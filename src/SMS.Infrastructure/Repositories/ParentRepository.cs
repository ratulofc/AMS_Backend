using AutoMapper;
using SMS.Core.Interfaces.Repositories;
using SMS.Infrastructure.Context;

namespace SMS.Infrastructure.Repositories
{
    public class ParentRepository : BaseRepository<Core.Models.Parent, Entities.Parent>, IParentRepository
    {
        public ParentRepository(SMSDBContext smsDBContext, IMapper mapper) : base(smsDBContext, mapper) { }
    }
}
