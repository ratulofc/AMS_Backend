using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using SMS.Infrastructure.Context;
using SMS.Core.Interfaces.Repositories;

namespace SMS.Infrastructure.Repositories
{
    public abstract class BaseRepository<TModel, TEntity> : IBaseRepository<TModel> where TModel : class where TEntity : class
    {
        private readonly SMSDBContext smsDBContext;
        private readonly DbSet<TEntity> dbSet;
        private readonly IMapper mapper;
        public BaseRepository(SMSDBContext smsDBContext, IMapper mapper)
        {
            this.smsDBContext = smsDBContext ?? throw new ArgumentNullException(nameof(smsDBContext));
            this.dbSet = this.smsDBContext.Set<TEntity>();
            this.mapper = mapper;
        }

        public async Task<TModel> CreateAsync(TModel model)
        {
            var entity = mapper.Map<TEntity>(model);
            var result = await dbSet.AddAsync(entity);
            return mapper.Map<TModel>(result.Entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await dbSet.FindAsync(id);
            if (entity is null) return await Task.FromResult(false);
            dbSet.Remove(entity);
            return await Task.FromResult(true);
        }

        public async Task<IEnumerable<TModel>> GetAllAsync(params string[] navsToInclude)
        {
            IQueryable<TEntity> query = dbSet;
            if (navsToInclude.Length > 0)
            {
                foreach (var nav in navsToInclude)
                {
                    query = query.Include(nav);
                }
            }
            var entities = await query.ToListAsync();
            var result = mapper.Map<IEnumerable<TModel>>(entities);
            return result;
        }

        public async Task<TModel?> GetById(int id)
        {
            var entity = await dbSet.FindAsync(id);
            return entity == null ? null : mapper.Map<TModel>(entity);
        }

        public async Task<TModel?> UpdateAsync(int id, TModel model)
        {
            var entity = await dbSet.FindAsync(id);
            if (entity is not null)
            {
                mapper.Map(model, entity);
                return mapper.Map<TModel>(entity);
            }
            return null;
        }

        public async Task<TModel?> UpdatePatchAsync(int id, JsonPatchDocument<TModel> patchDocument)
        {
            var entity = await dbSet.FindAsync(id);
            if (entity is not null)
            {
                var model = mapper.Map<TModel>(entity);
                patchDocument.ApplyTo(model);
                mapper.Map(model, entity);
                return mapper.Map<TModel>(entity);
            }
            return null;
        }
    }
}
