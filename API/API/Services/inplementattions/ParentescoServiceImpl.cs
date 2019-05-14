using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_RESTFul_SMN.Model;

namespace API_RESTFul_SMN.Services.inplementattions
{
    public class ParentescoServiceImpl : IParentescoService
    {
        public Parentesco Create(Parentesco parentesco)
        {
            return parentesco;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Parentesco> FindAll()
        {
            throw new NotImplementedException();
        }

        public Parentesco FindById(long id)
        {
            throw new NotImplementedException();
        }

        public Parentesco Update(Parentesco parentesco)
        {
            throw new NotImplementedException();
        }
    }
}
