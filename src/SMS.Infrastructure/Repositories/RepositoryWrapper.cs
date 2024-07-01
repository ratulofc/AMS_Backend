using AutoMapper;
using SMS.Core.Interfaces.Repositories;
using SMS.Infrastructure.Context;

namespace SMS.Infrastructure.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly SMSDBContext smsDBContext;
        public IParentRepository ParentRepository { get; set; }

        public RepositoryWrapper(SMSDBContext smsDBContext, IMapper mapper)
        {
            this.smsDBContext = smsDBContext;
            ParentRepository = new ParentRepository(smsDBContext, mapper);
        }

        public async Task<int> SaveAsync()
        {
            return await smsDBContext.SaveChangesAsync();
        }
    }
}
