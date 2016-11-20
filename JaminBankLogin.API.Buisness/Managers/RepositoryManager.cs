using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaminBankLogin.API.Data.Interfaces;

namespace JaminBankLogin.API.Buisness.Managers
{
    internal abstract class RepositoryManager<repoType> where repoType : IRepository
    {
        public readonly repoType _repository;         

        public RepositoryManager(repoType repo)
        {
            if (repo == null) throw new ArgumentNullException("Repository");
            _repository = repo;
        }
    }
}
