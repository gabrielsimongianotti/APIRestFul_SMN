using API_RESTFul_SMN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTFul_SMN.Services
{
    public interface IDependentesService
    {
        Dependentes Create(Dependentes dependentes);
        Dependentes FindById(long id);
        List<Dependentes> FindAll();
        Dependentes Update(Dependentes dependentes);
        void Delete(long id);

    }
}
