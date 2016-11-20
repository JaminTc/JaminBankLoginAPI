using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaminBankLogin.API.Buisness.Interfaces;
using JaminBankLogin.API.Data.Interfaces;
using JaminBankLogin.API.DomainModel;

namespace JaminBankLogin.API.Buisness.Managers
{
    internal class PersonManager : RepositoryManager<IPersonRepository>, IPersonManager
    {
        public PersonManager(IPersonRepository repo) : base(repo) { }

        public Person GetPerson(Person person)
        {
            return _repository.GetPerson(person);
        }
    }
}
