using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTFul_SMN.Model
{
    public class Funcionarios
    {
        public long? Id { get; set; }
        public string Nome { get; set; }
        public long? IdEstadoCivil { get; set; }
        public long? Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public long? IdProfissao { get; set; }
        public string Telefone { get; set; }
        public long? IdEmpresa { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteração { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

    }
}
