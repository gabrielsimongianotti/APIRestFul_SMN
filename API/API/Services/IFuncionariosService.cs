using API_RESTFul_SMN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTFul_SMN.Services
{
    public interface IFuncionariosService
    {
        Funcionarios Create(Funcionarios funcionarios);
        Funcionarios FindById(long id);
        List<Funcionarios> FindAll();
        Funcionarios Update(Funcionarios funcionarios);
        void Delete(long id);

    }
}
