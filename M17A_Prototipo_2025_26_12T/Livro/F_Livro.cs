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
        public F_Livro()
        {
            InitializeComponent();
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

        }
    }
}
