using API_RESTFul_SMN.Model;

using System.Collections.Generic;


namespace API_RESTFul_SMN.Services
{
    public interface IEstadoCivilService
    {
        EstadoCivil Create(EstadoCivil estadoCivil);
        EstadoCivil FindById(long id);
        List<EstadoCivil> FindAll();
        EstadoCivil Update(EstadoCivil estadoCivil);
        void Delete(long id);

    }
}
