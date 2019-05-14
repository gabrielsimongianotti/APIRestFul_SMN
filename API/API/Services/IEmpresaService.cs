using API_RESTFul_SMN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTFul_SMN.Services
{
    public interface IEmpresaService
    {
        Empresa Create(Empresa empresa);
        Empresa FindById(long id);
        List<Empresa> FindAll();
        Empresa Update(Empresa empresa);
        void Delete(long id);

    }
}
