using API_RESTFul_SMN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTFul_SMN.Services
{
    public interface IParentescoService
    {
        Parentesco Create(Parentesco parentesco);
        Parentesco FindById(long id);
        List<Parentesco> FindAll();
        Parentesco Update(Parentesco parentesco);
        void Delete(long id);

    }
}
