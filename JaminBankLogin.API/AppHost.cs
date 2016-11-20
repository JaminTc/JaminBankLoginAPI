using Funq;
using JaminBankLogin.API.ServiceDefinition;
using JaminBankLogin.API.ServiceDefinition.Mappers;
using ServiceStack;

namespace JaminBankLogin.API
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base(APIInfo.Name, APIInfo.Assembly) { }

        public override void Configure(Container container)
        {
            ContainerManager.Register(container);
            SetConfig(new HostConfig { HandlerFactoryPath = "JaminBankLogin" });
            AutoMapperConfiguration.Configure();
        }
    }
}