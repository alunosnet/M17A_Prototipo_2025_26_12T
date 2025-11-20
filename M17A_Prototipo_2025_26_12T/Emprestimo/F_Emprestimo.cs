using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M17A_Prototipo_2025_26_12T.Livro;
namespace M17A_Prototipo_2025_26_12T.Emprestimo
{
    public partial class F_Emprestimo : Form
    {
        BaseDados bd;
        public F_Emprestimo(BaseDados bd)
        {
            InitializeComponent();
            this.bd = bd;
            PreencheCBLeitores();
            PreencheCBLivros();
        }
        /// <summary>
        /// Preencher a cb dos livros
        /// </summary>
        void PreencheCBLivros()
        {
            cb_livro.Items.Clear();
            Livro.Livro l = new Livro.Livro(bd);
            DataTable dados = l.Listar();
            foreach (DataRow dr in dados.Rows)
            {
                Livro.Livro novo = new Livro.Livro(bd);
                novo.nlivro = int.Parse(dr["nlivro"].ToString());
                novo.titulo = dr["titulo"].ToString();
                cb_livro.Items.Add(novo);
            }
        }
        /// <summary>
        /// Preencher a cb dos leitores
        /// </summary>
        void PreencheCBLeitores()
        {

        }
        private void bt_emprestar_Click(object sender, EventArgs e)
        {

        }
    }
}
