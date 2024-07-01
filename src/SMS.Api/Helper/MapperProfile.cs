using AutoMapper;

namespace SMS.Api.Helper
{
    internal class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // Create Map BETWEEN Entitie Parent and Model Parent
            CreateMap<Infrastructure.Entities.Parent, Core.Models.Parent>();
            CreateMap<Core.Models.Parent, Infrastructure.Entities.Parent>();
            // Create Map BETWEEN Model Parent and (Response,Request)DTO
            CreateMap<Core.Models.Parent, Core.Response.ParentResponse>();
            CreateMap<Core.Request.ParentRequest, Core.Models.Parent>();





        }
    }
}
