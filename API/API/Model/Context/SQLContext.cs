using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API_RESTFul_SMN.Model.Context
{
    public class SQLContext : DbContext
    {
        public SQLContext()
        {

        }
        public SQLContext(DbContextOptions<SQLContext> options) : base(options) { }

        public DbSet<EstadoCivil> estadoCivil { get; set; }
       // public string select() {
           // SqlConnection minhaConexao =
           // new SqlConnection(@"data source=LAPTOP-KK1SN8IA\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=webAPIok");
           // minhaConexao.Open();
           // string strQuerySelect = "select * from parentesco;";
           // SqlCommand cmd =new SqlCommand(strQuerySelect,minhaConexao);
           // SqlDataReader dados = cmd.ExecuteReader();
           // string retorno = "";
           // while (dados.Read())
           // {
                
               // retorno += string.Format(dados["id"],dados["parente"]);
           // }
           // return retorno;
       // }
        

    }
}
