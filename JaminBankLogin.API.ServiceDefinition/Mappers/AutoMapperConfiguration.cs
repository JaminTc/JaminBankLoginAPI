using AutoMapper;
using dm = JaminBankLogin.API.DomainModel;
using sm = JaminBankLogin.API.ServiceModel.Dtos;


namespace JaminBankLogin.API.ServiceDefinition.Mappers
{
    public class AutoMapperConfiguration
    {
        public static IMapper Configure() 
        {
            var mapperConfig = new MapperConfiguration(
                cfg => cfg.AddProfile<PersonMapper>()
            );
            return mapperConfig.CreateMapper();
        }
    }
}
