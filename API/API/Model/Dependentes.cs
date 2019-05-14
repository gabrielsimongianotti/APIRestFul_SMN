using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTFul_SMN.Model
{
    public class Dependentes
    {
        public long? Id { get; set; }
        public string Nome { get; set; }
        public long? IdFuncionario { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteração { get; set; }
        public string Cnf { get; set; }
        public DateTime DataNascimento { get; set; }
        public long? IdParentesco { get; set; }
    }
}
