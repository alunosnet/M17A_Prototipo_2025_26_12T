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
        public F_Livro(BaseDados bd)
        {
            InitializeComponent();
            this.bd = bd;
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
            Livro novo = new Livro();
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
            //limpar o formulário
            //atualizar a lista dos livros da datagridview
            //feedback ao user
        }
    }
}
