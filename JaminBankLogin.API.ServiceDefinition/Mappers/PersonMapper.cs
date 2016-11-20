using AutoMapper;
using dm = JaminBankLogin.API.DomainModel;
using sm = JaminBankLogin.API.ServiceModel.Dtos;

namespace JaminBankLogin.API.ServiceDefinition.Mappers
{
    internal class PersonMapper : Profile
    {
        public PersonMapper()
        {
            CreateMap<dm.Person, sm.Person>();
            CreateMap<sm.Person, dm.Person>();
        }
    }
}
