using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_RESTFul_SMN.Model;

namespace API_RESTFul_SMN.Services.inplementattions
{
    public class EmpresaServiceImpl : IEmpresaService
    {
        public Empresa Create(Empresa empresa)
        {
            return empresa;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Empresa> FindAll()
        {
            throw new NotImplementedException();
        }

        public Empresa FindById(long id)
        {
            throw new NotImplementedException();
        }

        public Empresa Update(Empresa empresa)
        {
            throw new NotImplementedException();
        }
    }
}
