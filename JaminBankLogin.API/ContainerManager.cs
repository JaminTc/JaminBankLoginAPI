using Funq;
using ServiceStack.Validation;

namespace JaminBankLogin.API
{
    public static class ContainerManager
    {
        public static void Register(Container container)
        {
            //container.RegisterValidators(ReuseScope.Container, typeof(APIValidat))
            JaminBankLogin.API.Buisness.ContainerComponentRegistrator.RegisterComponents(container);
        }
    }
}