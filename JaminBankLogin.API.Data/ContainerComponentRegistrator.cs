using Funq;
using JaminBankLogin.API.Data.Factories;
using JaminBankLogin.API.Data.Interfaces;
using JaminBankLogin.API.Data.Repositories;
using ServiceStack.Configuration;

namespace JaminBankLogin.API.Data
{
    public class ContainerComponentRegistrator
    {
        public static void RegisterComponents(Container container)
        {
            var settings = new AppSettings();
            container.Register<IUnitOfWorkFactory>(c => new UnitOfWorkFactory(settings.GetString("ConnStringDb1"), true));
            container.RegisterAutoWiredAs<PersonRepository, IPersonRepository>();

        }
    }
}
