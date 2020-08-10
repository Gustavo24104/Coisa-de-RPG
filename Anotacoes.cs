using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inventário_e_dinheiro_RPG
{
    public partial class Anotacoes : Form
    {
        public Anotacoes()
        {
            InitializeComponent();
        }

        private void anotator_TextChanged(object sender, EventArgs e)
        {

        }

        private void Anotacoes_Load(object sender, EventArgs e)
        {
            //Chama o meme de carregar.
            Carregar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Chama o meme de saas
            Saas();
        }

        //Salva as anotações
        void Saas()
        {
            Properties.Settings.Default.Anotations = textBox1.Text;

            //Escreve no arquivo
            Properties.Settings.Default.Save();

            //Aquela msg que deu certo que salvou
            MessageBox.Show("salvei.", "peloamordedeusmematapfvacabacommeusofrimento, oqueeavidasofrer?seéassim,naoqueroficarvivo.", MessageBoxButtons.YesNo);
        }


        //Carrega as anotações
        void Carregar()
        {
            textBox1.Text = Properties.Settings.Default.Anotations;
        }
    }
}
