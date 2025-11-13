using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace M17A_Prototipo_2025_26_12T
{
    /// <summary>
    /// Responsável por criar a bd, e executar comandos na bd
    /// </summary>
    public class BaseDados
    {
        string NomeBD;
        string Strligacao;
        string CaminhoBD;
        SqlConnection ligacaoSQL;
        public BaseDados(string NomeBD) 
        {
            this.NomeBD = NomeBD;
            //ler a string de ligação
            Strligacao=ConfigurationManager.ConnectionStrings["sql"].ToString();
            CaminhoBD = Utils.PastaPrograma("M17A_Biblioteca_12T");
            CaminhoBD += @"\" + NomeBD + ".mdf";
            //verificar se bd existe no sistema de ficheiros
            if (System.IO.File.Exists(CaminhoBD)==false)
            {
                CriaBD();
            }
            ligacaoSQL = new SqlConnection(Strligacao);
            ligacaoSQL.Open();
            ligacaoSQL.ChangeDatabase(this.NomeBD);
        }
        /// <summary>
        /// Verifica se a BD existe no catálogo e cria a bd e as tabelas
        /// </summary>
        void CriaBD()
        {
            SqlConnection ligacaoSQL = new SqlConnection(Strligacao);
            ligacaoSQL.Open();
            //verificar se existe no catálogo do sql server
            string sql = $@"IF EXISTS(SELECT * FROM master.SYS.databases
                            WHERE name='{this.NomeBD}')
                           BEGIN
                                USE [master];
                                EXEC sp_detach_db {this.NomeBD}
                           END";
            SqlCommand comando= new SqlCommand(sql,ligacaoSQL);
            comando.ExecuteNonQuery();
            //Criar a bd
            sql = $"CREATE DATABASE {this.NomeBD} ON PRIMARY (NAME={this.NomeBD},FILENAME='{this.CaminhoBD}')";
            //github.com/alunosnet/m17a_prototipo_2025_26_12t
            comando = new SqlCommand(sql, ligacaoSQL);
            comando.ExecuteNonQuery();
            //ativar a base de dados criada
            ligacaoSQL.ChangeDatabase(this.NomeBD);
            //criar a tabela livros
            //Livros(nlivro,titulo,autor,isbn,ano,data_aquisicao,preco,capa,estado)
            sql = @"CREATE TABLE Livros(
                nlivro int identity primary key,
                titulo varchar(50) not null,
                autor varchar(100),
                isbn varchar(13),
                ano int check (ano > 0),
                data_aquisicao date default getdate(),
                preco money check (preco>=0),
                capa varchar(500),
                estado bit default 1
                )";
            //TODO: faltam as tabelas leitores e empréstimos
            comando = new SqlCommand (sql, ligacaoSQL);
            comando.ExecuteNonQuery();
            comando.Dispose();
        }
        public void ExecutarSQL(string sql,List<SqlParameter> parametros=null)
        {
            SqlCommand comando = new SqlCommand(sql, ligacaoSQL);
            if (parametros!=null)
                comando.Parameters.AddRange(parametros.ToArray());

            comando.ExecuteNonQuery();
            comando.Dispose();
        }
        public DataTable DevolveSQL(string sql,List<SqlParameter> parametros = null)
        {
            SqlCommand comando = new SqlCommand(sql, ligacaoSQL);
            if (parametros != null)
                comando.Parameters.AddRange(parametros.ToArray());
            SqlDataReader dados = comando.ExecuteReader();
            DataTable registos = new DataTable();
            registos.Load(dados);
            comando.Dispose();
            dados.Close();
            return registos;
        }
    }
}
