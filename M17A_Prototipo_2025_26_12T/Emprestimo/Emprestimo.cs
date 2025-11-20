using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17A_Prototipo_2025_26_12T.Emprestimo
{
    public class Emprestimo
    {
        public int nlivro { get; set; }
        public int nleitor { get; set; }
        BaseDados bd;
        public Emprestimo(BaseDados bd)
        {
            this.bd = bd;
        }
        public void RegistarEmprestimo()
        {
            //insert tabela emprestimos
            string SQL = "INSERT INTO Emprestimos(nleitor,nlivro) VALUES (@nleitor,@nlivro)";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter(){
                     ParameterName = "@nleitor",
                    SqlDbType = SqlDbType.Int,
                    Value = this.nleitor,
                },
                new SqlParameter(){
                     ParameterName = "@nlivro",
                    SqlDbType = SqlDbType.Int,
                    Value = this.nlivro,
                }
            };
            bd.ExecutarSQL(SQL, parametros);
            //update tabela livros
            SQL = "UPDATE Livros Set estado = 0 WHERE nlivro=@nlivro";
            parametros = new List<SqlParameter>()
            {
                new SqlParameter(){
                     ParameterName = "@nlivro",
                    SqlDbType = SqlDbType.Int,
                    Value = this.nlivro,
                }
            };
            bd.ExecutarSQL(SQL, parametros);

        }
    }
}
