using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17A_Prototipo_2025_26_12T.Livro
{
    internal class Livro : IItem
    {
        public int nlivro { get; set; }
        public string titulo { get; set; }
        public string autor {  get; set; }
        public string isbn { get; set; }
        public int ano { get; set; }
        public DateTime data_aquisicao { get; set; }
        public Decimal preco { get; set; }
        public string capa {  get; set; }
        public bool estado { get; set; }
        BaseDados bd;
        public Livro(BaseDados bd)
        {
            this.bd = bd;
        }
        public void Adicionar()
        {
            string sql = @"INSERT INTO Livros(titulo,autor,isbn,ano,data_aquisicao,preco,capa)
                            VALUES (@titulo,@autor,@isbn,@ano,@data_aquisicao,@preco,@capa)";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName ="@titulo",               //nome do parametro
                    SqlDbType = System.Data.SqlDbType.VarChar,      //tipo de dados na bd
                    Value=this.titulo                           //valor do parametro
                },
                new SqlParameter()
                {
                    ParameterName ="@autor",               //nome do parametro
                    SqlDbType = System.Data.SqlDbType.VarChar,      //tipo de dados na bd
                    Value=this.autor                           //valor do parametro
                },
                new SqlParameter()
                {
                    ParameterName ="@isbn",               //nome do parametro
                    SqlDbType = System.Data.SqlDbType.VarChar,      //tipo de dados na bd
                    Value=this.isbn                           //valor do parametro
                },
                new SqlParameter()
                {
                    ParameterName ="@ano",               //nome do parametro
                    SqlDbType = System.Data.SqlDbType.Int,      //tipo de dados na bd
                    Value=this.ano                           //valor do parametro
                },
                new SqlParameter()
                {
                    ParameterName ="@data_aquisicao",               //nome do parametro
                    SqlDbType = System.Data.SqlDbType.Date,      //tipo de dados na bd
                    Value=this.data_aquisicao                           //valor do parametro
                },
                new SqlParameter()
                {
                    ParameterName ="@preco",               //nome do parametro
                    SqlDbType = System.Data.SqlDbType.Money,      //tipo de dados na bd
                    Value=this.preco                           //valor do parametro
                },
                new SqlParameter()
                {
                    ParameterName ="@capa",               //nome do parametro
                    SqlDbType = System.Data.SqlDbType.VarChar,      //tipo de dados na bd
                    Value=this.capa                           //valor do parametro
                },
            };
            //executar comando
            bd.ExecutarSQL(sql, parametros);
        }

        public void Apagar()
        {
            //Isto é seguro porque o nlivro é um inteiro. Não é possível
            //fazer SQL Injection num inteiro
            bd.ExecutarSQL("DELETE FROM LIVROS WHERE nlivro="+nlivro);
        }

        public void Editar()
        {
            string sql = @"UPDATE Livros SET titulo=@titulo,autor=@autor,
                            isbn=@isbn,ano=@ano,data_aquisicao=@data_aquisicao,
                            preco=@preco,capa=@capa
                            WHERE nlivro=@nlivro";
            List<SqlParameter> parametros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName ="@titulo",               //nome do parametro
                    SqlDbType = System.Data.SqlDbType.VarChar,      //tipo de dados na bd
                    Value=this.titulo                           //valor do parametro
                },
                new SqlParameter()
                {
                    ParameterName ="@autor",               //nome do parametro
                    SqlDbType = System.Data.SqlDbType.VarChar,      //tipo de dados na bd
                    Value=this.autor                           //valor do parametro
                },
                new SqlParameter()
                {
                    ParameterName ="@isbn",               //nome do parametro
                    SqlDbType = System.Data.SqlDbType.VarChar,      //tipo de dados na bd
                    Value=this.isbn                           //valor do parametro
                },
                new SqlParameter()
                {
                    ParameterName ="@ano",               //nome do parametro
                    SqlDbType = System.Data.SqlDbType.Int,      //tipo de dados na bd
                    Value=this.ano                           //valor do parametro
                },
                new SqlParameter()
                {
                    ParameterName ="@data_aquisicao",               //nome do parametro
                    SqlDbType = System.Data.SqlDbType.Date,      //tipo de dados na bd
                    Value=this.data_aquisicao                           //valor do parametro
                },
                new SqlParameter()
                {
                    ParameterName ="@preco",               //nome do parametro
                    SqlDbType = System.Data.SqlDbType.Money,      //tipo de dados na bd
                    Value=this.preco                           //valor do parametro
                },
                new SqlParameter()
                {
                    ParameterName ="@capa",               //nome do parametro
                    SqlDbType = System.Data.SqlDbType.VarChar,      //tipo de dados na bd
                    Value=this.capa                           //valor do parametro
                },
                new SqlParameter()
                {
                    ParameterName ="@nlivro",               //nome do parametro
                    SqlDbType = System.Data.SqlDbType.Int,      //tipo de dados na bd
                    Value=this.nlivro                           //valor do parametro
                },
            };
            //executar comando
            bd.ExecutarSQL(sql, parametros);

        }

        public List<string> Validar()
        {
            List<string> erros = new List<string>();
            //validar o título
            if (String.IsNullOrEmpty(titulo) || titulo.Length < 3)
            {
                erros.Add("O título deve ter pelo menos 3 letras.");
            }
            //validar autor
            if (String.IsNullOrEmpty(autor) || autor.Length < 3)
            {
                erros.Add("O autor do livro deve ter pelo menos 3 letras.");
            }
            //validar ano
            if (ano<0 || ano > DateTime.Now.Year)
            {
                erros.Add("O ano de publicação do livro deve ser maior que zero e menor ou igual ao ano atual.");
            }
            //validar isbn
            if (isbn.Length!=13)
            {
                erros.Add("O ISBN do livro deve ter 13 números.");
            }
            return erros;
        }
        //Devolve um datatable com todos os registos da tabela livros
        public DataTable Listar()
        {
            return bd.DevolveSQL("SELECT nlivro,titulo,autor,isbn,estado FROM Livros ORDER BY titulo");
        }
        /// <summary>
        /// Pesquisa um livro com base no nlivro e preenche o objeto com os dados da bd
        /// </summary>
        public void Procurar()
        {
            string sql = "SELECT * FROM Livros WHERE nlivro=" + nlivro;
            DataTable dados = bd.DevolveSQL(sql);
            if (dados!=null && dados.Rows.Count>0)
            {
                DataRow linha = dados.Rows[0];
                this.titulo = linha["titulo"].ToString();
                this.isbn = linha["isbn"].ToString();
                this.preco = Decimal.Parse(linha["preco"].ToString());
                this.autor = linha["autor"].ToString();
                this.capa = linha["capa"].ToString();
                this.data_aquisicao = DateTime.Parse(linha["data_aquisicao"].ToString());
                this.ano = int.Parse(linha["ano"].ToString());
                this.estado = bool.Parse(linha["estado"].ToString());
            }
            //TODO: o que fazer caso o livro não seja encontrado?
        }
        public DataTable Procurar(string campo,string texto_pesquisar)
        {
            string sql = "SELECT nlivro,titulo,autor,isbn FROM Livros WHERE ";
            sql += campo + " LIKE @pesquisa";
            List<SqlParameter> pararmetros = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@pesquisa",
                    SqlDbType = SqlDbType.VarChar,
                    Value = "%" + texto_pesquisar + "%",
                }
            };
            return bd.DevolveSQL(sql, pararmetros);
        }
        public override string ToString()
        {
            return this.titulo;
        }
    }
}
