using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using SMS.Core.Interfaces.Repositories;
using SMS.Core.Interfaces.Services;
using SMS.Core.Models;
using SMS.Core.Request;
using SMS.Core.Response;

namespace SMS.Core.Services
{
    public class ParentService : IParentService
    {
        private readonly IRepositoryWrapper repositoryWrapper;
        private readonly IMapper mapper;
        public ParentService(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            this.repositoryWrapper = repositoryWrapper ?? throw new ArgumentNullException(nameof(repositoryWrapper));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<ParentResponse> Add(ParentRequest requestDTO)
        {
            var parent = mapper.Map<Parent>(requestDTO);
            var parentResponse = await this.repositoryWrapper.ParentRepository.CreateAsync(parent);
            await this.repositoryWrapper.SaveAsync();
            var result = mapper.Map<ParentResponse>(parentResponse);
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            var result = await this.repositoryWrapper.ParentRepository.DeleteAsync(id);
            await this.repositoryWrapper.SaveAsync();
            return result;
        }

        public async Task<IEnumerable<ParentResponse>> GetAll()
        {
            var parent = await this.repositoryWrapper.ParentRepository.GetAllAsync();
            var result = mapper.Map<IEnumerable<ParentResponse>>(parent);
            return result;
        }

        public async Task<ParentResponse?> GetById(int id)
        {
            var parent = await this.repositoryWrapper.ParentRepository.GetById(id);
            if (parent is null) return null;
            var result = mapper.Map<ParentResponse>(parent);
            return result;
        }

        public async Task<ParentResponse?> Update(int id, ParentRequest requestDTO)
        {
            var parent = mapper.Map<Parent>(requestDTO);
            var parentResponse = await this.repositoryWrapper.ParentRepository.UpdateAsync(id, parent);
            if (parentResponse is not null)
            {
                await this.repositoryWrapper.SaveAsync();
                return mapper.Map<ParentResponse>(parentResponse);
            }
            return null;
        }

        public async Task<ParentResponse?> UpdatePatch(int id, JsonPatchDocument<Parent> request)
        {
            var parentResponse = await this.repositoryWrapper.ParentRepository.UpdatePatchAsync(id, request);
            if (parentResponse is not null)
            {
                await this.repositoryWrapper.SaveAsync();
                return mapper.Map<ParentResponse>(parentResponse);
            }
            return null;
        }
    }
}
