using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17A_Prototipo_2025_26_12T.Leitor
{
    public class Leitor
    {
        public int nleitor {  get; set; }
        public string nome { get; set; }
        public bool estado { get; set; }
        BaseDados bd;
        public Leitor(BaseDados bd)
        {
            this.bd = bd;
        }
        public DataTable Listar()
        {
            return bd.DevolveSQL("SELECT * FROM Leitores ORDER BY nome");
        }
        //TODO: adicionar as funcionalidades restantes
        public override string ToString()
        {
            return this.nome;
        }
    }
}
