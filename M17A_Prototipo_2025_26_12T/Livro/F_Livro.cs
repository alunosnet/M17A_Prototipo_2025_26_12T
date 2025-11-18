using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M17A_Prototipo_2025_26_12T.Livro
{
    public partial class F_Livro : Form
    {
        string ficheiro_capa="";
        BaseDados bd;
        int nlivro_escolhido=0;
        public F_Livro(BaseDados bd)
        {
            InitializeComponent();
            this.bd = bd;
            ListarLivros();
        }
        /// <summary>
        /// Botão para procurar a imagem que vai ser a capa do livro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_procurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ficheiro = new OpenFileDialog();
            ficheiro.Filter = "Imagens |*.jpg;*.png;*.bmp | Todos os ficheiros |*.*";
            ficheiro.InitialDirectory = "c:\\";
            ficheiro.Multiselect = false;
            if (ficheiro.ShowDialog() == DialogResult.OK)
            {
                string temp = ficheiro.FileName;
                if (System.IO.File.Exists(temp))
                {
                    pb_capa.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb_capa.Image = Image.FromFile(temp);
                    ficheiro_capa = temp;
                }
            }
        }
        /// <summary>
        /// Botão para criar um objeto do tipo livro, validar e guardar os dados na bd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_guardar_Click(object sender, EventArgs e)
        {
            //criar um objeto do tipo livro
            Livro novo = new Livro(bd);
            //preencher o objeto com os dados do form
            novo.titulo = tb_titulo.Text;
            novo.isbn = tb_isbn.Text;
            novo.ano = int.Parse(tb_ano.Text);
            novo.autor= tb_autor.Text;
            novo.data_aquisicao = dtp_data.Value;
            novo.preco = Decimal.Parse(tb_preco.Text);
            novo.estado = true;
            novo.capa = Utils.PastaPrograma("M17A_Biblioteca_12T") + @"\" + novo.isbn;
            //validar os dados
            List<string> erros = novo.Validar();
            if (erros.Count>0)
            {
                //mostrar os erros
                string mensagem = "";
                foreach (string erro in erros)
                    mensagem += erro + "; " ;
                lb_feedback.Text = mensagem;
                lb_feedback.ForeColor= Color.Red;
                return;
            }
            //se não existirem erros guardar na bd
            novo.Adicionar();
            //copiar a imagem da capa para a pasta do programa
            if (ficheiro_capa!="")
            {
                if (System.IO.File.Exists(ficheiro_capa)==true)
                {
                    System.IO.File.Copy(ficheiro_capa, novo.capa);
                }
            }
            //limpar o formulário
            LimparForm();
            //atualizar a lista dos livros da datagridview
            ListarLivros();
            //feedback ao user
            lb_feedback.Text = "Livro guardado com sucesso.";
            lb_feedback.ForeColor = Color.Black;
        }
        //Atualizar a lista dos livros na datagridview
        private void ListarLivros()
        {
            //configurar a dgv_livros
            dgv_livros.AllowUserToAddRows = false;
            dgv_livros.AllowUserToDeleteRows = false;
            dgv_livros.MultiSelect= false;
            dgv_livros.ReadOnly = true;
            dgv_livros.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            Livro l = new Livro(bd);
            dgv_livros.DataSource = l.Listar();
        }
        //Limpar os controlos do formulário
        private void LimparForm()
        {
            tb_ano.Text = "0";
            tb_autor.Text = "";
            tb_isbn.Text = "";
            tb_titulo.Text = "";
            tb_preco.Text = "0";
            pb_capa.Image = null;
            ficheiro_capa = "";
            dtp_data.Value = DateTime.Now;
        }
        private void dgv_livros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //guardar o nlivro selecionado
            int linha = dgv_livros.CurrentCell.RowIndex;
            if (linha < 0)
                return;
            nlivro_escolhido = int.Parse(dgv_livros.Rows[linha].Cells[0].Value.ToString());
        }

        private void F_Livro_Load(object sender, EventArgs e)
        {

        }
        //Apaga o livro escolhido
        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            EliminarLivro();
        }
        //Apaga o livro escolhido (click ou menu contexto)
        private void EliminarLivro()
        {
            if (nlivro_escolhido == 0)
            {
                MessageBox.Show("Tem de selecionar um livro primeiro.");
                return;
            }
            if (MessageBox.Show("Tem a certeza que pretende eliminar o livro selecionado?",
                "Confirmar",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Livro apagar = new Livro(bd);
                apagar.nlivro = nlivro_escolhido;
                apagar.Apagar();
                nlivro_escolhido = 0;
                ListarLivros();
            }
        }
    }
}
