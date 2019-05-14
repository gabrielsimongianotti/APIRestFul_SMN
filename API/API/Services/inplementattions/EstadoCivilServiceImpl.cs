using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_RESTFul_SMN.Model;
using API_RESTFul_SMN.Model.Context;

namespace API_RESTFul_SMN.Services.inplementattions
{
    public class EstadoCivilServiceImpl : IEstadoCivilService
    {
        private SQLContext _context;

        public EstadoCivilServiceImpl(SQLContext context)
        {
            _context = context;
        }
        public EstadoCivil Create(EstadoCivil estadoCivil)
        {
            try
            {
                _context.Add(estadoCivil);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return estadoCivil;
        }

        public void Delete(long id)
        {
            var result = _context.estadoCivil.SingleOrDefault(p => p.Id.Equals(id));
            try
            {
                if (result != null) _context.estadoCivil.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EstadoCivil> FindAll()
        {
            return _context.estadoCivil.ToList();
        }

        public EstadoCivil FindById(long id)
        {
            return _context.estadoCivil.SingleOrDefault(p => p.Id.Equals(id));
        }

        public EstadoCivil Update(EstadoCivil estadoCivil)
        {
            if (!Exist(estadoCivil.Id)) return new EstadoCivil();
            var result = _context.estadoCivil.SingleOrDefault(p => p.Id.Equals(estadoCivil.Id));
            try
            {
                _context.Entry(estadoCivil).CurrentValues.SetValues(estadoCivil);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return estadoCivil;
        }
        private bool Exist(long? id)
        {
            return _context.estadoCivil.Any(p => p.Id.Equals(id));
        }
    }
}
