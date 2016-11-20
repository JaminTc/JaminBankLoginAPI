using Funq;

using JaminBankLogin.API.Buisness.Managers;
using JaminBankLogin.API.Buisness.Interfaces;

namespace JaminBankLogin.API.Buisness
{
    public class ContainerComponentRegistrator
    {
        public static void RegisterComponents(Container container)
        {
            Data.ContainerComponentRegistrator.RegisterComponents(container);
            container.RegisterAutoWiredAs<PersonManager, IPersonManager>();
        }
    }
}
