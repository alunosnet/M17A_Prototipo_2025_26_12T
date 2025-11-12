using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace M17A_Prototipo_2025_26_12T
{
    /// <summary>
    /// Responsável por criar a bd, e executar comandos na bd
    /// </summary>
    internal class BaseDados
    {
        string NomeBD;
        string Strligacao;
        string CaminhoBD;
        public BaseDados(string NomeBD) 
        {
            this.NomeBD = NomeBD;
            //ler a string de ligação
            Strligacao=ConfigurationManager.ConnectionStrings["sql"].ToString();
            CaminhoBD = Utils.PastaPrograma("M17A_Biblioteca_12T");
            CaminhoBD += @"\" + NomeBD + ".mdf";
            //verificar se bd exist
            if (System.IO.File.Exists(CaminhoBD)==false)
            {
                CriaBD();
            }
        }
        /// <summary>
        /// Verifica se a BD existe no catálogo e cria a bd e as tabelas
        /// </summary>
        void CriaBD()
        {
            SqlConnection ligacaoSQL = new SqlConnection(Strligacao);
            ligacaoSQL.Open();
            string sql = $@"IF EXISTS(SELECT * FROM master.SYS.databases
                            WHERE name='{this.NomeBD}')
                           BEGIN
                                USE [master];
                                EXEC sp_detach_db {this.NomeBD}
                           END";
            SqlCommand comando= new SqlCommand(sql,ligacaoSQL);
            comando.ExecuteNonQuery();
        }
    }
}
