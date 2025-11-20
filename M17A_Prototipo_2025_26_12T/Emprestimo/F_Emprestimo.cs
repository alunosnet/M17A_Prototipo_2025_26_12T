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
                novo.estado = bool.Parse(dr["estado"].ToString());
                //só listar o livro se não está emprestado
                if (novo.estado==true)
                    cb_livro.Items.Add(novo);
            }
        }
        /// <summary>
        /// Preencher a cb dos leitores
        /// </summary>
        void PreencheCBLeitores()
        {
            cb_leitor.Items.Clear();
            Leitor.Leitor l = new Leitor.Leitor(bd);
            DataTable dados = l.Listar();
            foreach(DataRow dr in dados.Rows)
            {
                Leitor.Leitor novo = new Leitor.Leitor(bd);
                novo.nleitor = int.Parse(dr["nleitor"].ToString());
                novo.nome = dr["nome"].ToString();
                novo.estado = bool.Parse(dr["estado"].ToString());
                if (novo.estado == true)
                    cb_leitor.Items.Add(novo);
            }
        }
        private void bt_emprestar_Click(object sender, EventArgs ev)
        {
            //Livro selecionado
            if (cb_leitor.SelectedIndex==-1 || cb_livro.SelectedIndex == -1)
            {
                MessageBox.Show("Tem de escolher um livro e um leitor");
                return;
            }
            Leitor.Leitor leitor_escolhido = cb_leitor.SelectedItem as Leitor.Leitor;
            Livro.Livro livro_escolhido = cb_livro.SelectedItem as Livro.Livro;
            Emprestimo e = new Emprestimo(bd);
            e.nlivro = livro_escolhido.nlivro;
            e.nleitor = leitor_escolhido.nleitor;
            e.RegistarEmprestimo();
            PreencheCBLivros();

        }
    }
}
