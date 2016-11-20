using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaminBankLogin.API.DomainModel;

namespace JaminBankLogin.API.Data.Interfaces
{
    public interface IPersonRepository : IRepository
    {
        Person GetPerson(Person person);
    }
}
