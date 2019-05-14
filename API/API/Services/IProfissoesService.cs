using API_RESTFul_SMN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTFul_SMN.Services
{
    public interface IProfissoesService
    {
        Profissoes Create(Profissoes profissoes);
        Profissoes FindById(long id);
        List<Profissoes> FindAll();
        Profissoes Update(Profissoes profissoes);
        void Delete(long id);

    }
}
