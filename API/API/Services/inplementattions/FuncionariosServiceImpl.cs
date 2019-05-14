using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_RESTFul_SMN.Model;

namespace API_RESTFul_SMN.Services.inplementattions
{
    public class FuncionariosServiceImpl : IFuncionariosService
    {
        public Funcionarios Create(Funcionarios funcionarios)
        {
            return funcionarios;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Funcionarios> FindAll()
        {
            throw new NotImplementedException();
        }

        public Funcionarios FindById(long id)
        {
            throw new NotImplementedException();
        }

        public Funcionarios Update(Funcionarios funcionarios)
        {
            throw new NotImplementedException();
        }
    }
}
