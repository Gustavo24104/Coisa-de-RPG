using Inventário_e_dinheiro_RPG.Properties;
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
    public partial class Armas : Form
    {
        public Armas()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Basicamente, checa se a checkBox tá marcada, se tiver, ele coloca os coisa de munição.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (TemMunicao2.Checked == true)
            {
                Ammo2.Visible = true;
                AmmoBox2.Visible = true;
            }
            if (TemMunicao2.Checked == false)
            {
                Ammo2.Visible = false;
                AmmoBox2.Visible = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Arma1Img_Click(object sender, EventArgs e)
        {
        }

        private void Arma2Img_Click(object sender, EventArgs e)
        {
        }

        private void BTNArma1_Click(object sender, EventArgs e)
        {

        }

        private void BTNArma2_Click(object sender, EventArgs e)
        {

        }

        private void BTNArma2_Click_1(object sender, EventArgs e)
        {
            //Carrega uma imagem que o usuario escolhe.
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                Arma2Img.Load(openFileDialog2.FileName);
            }
        }

        private void BTNArma1_Click_1(object sender, EventArgs e)
        {
            //Mesma coisa que lá em cima, mas a caixa é diferente.
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Arma1Img.Load(openFileDialog1.FileName);
            }
        }

        //Basicamente, checa se a checkBox tá marcada, se tiver, ele coloca os coisa de munição.
        private void TemMunicao1_CheckedChanged(object sender, EventArgs e)
        {
            if(TemMunicao1.Checked == true)
            {
                Ammo1.Visible = true;
                AmmoBox1.Visible = true;
            }
            if (TemMunicao1.Checked == false)
            {
                Ammo1.Visible = false;
                AmmoBox1.Visible = false;
            }
        }

        //Quando essa janela abrir.
        private void Armas_Load(object sender, EventArgs e)
        {
            //Chama o metódo de carregar
            Carregar();
        }


        //Carrega as coisa, aprende a ler porra, mds, agora tem que ficar comentando qualquer coisinha vai tomar no cu
        void Carregar()
        {
            textBox2.Text = Settings.Default.NomeArma1;
            textBox1.Text = Settings.Default.NomeArma2;
            textBox3.Text = Settings.Default.AtributoArma1;
            textBox4.Text = Settings.Default.AtributoArma2;
            AmmoBox1.Text = Settings.Default.Ammo1;
            AmmoBox2.Text = Settings.Default.Ammo2;


        }




        //Metódo pra salvar. O nome é óbvio, sabe ler não caralho?
        void Save()
        {
            Settings.Default.NomeArma1 = textBox2.Text;
            Settings.Default.NomeArma2 = textBox1.Text;
            Settings.Default.AtributoArma1 = textBox3.Text;
            Settings.Default.AtributoArma2 = textBox4.Text;
            Settings.Default.Ammo1 = AmmoBox1.Text;
            Settings.Default.Ammo2 = AmmoBox2.Text;

            //Escreve as mudanças pro arquivo.
            Settings.Default.Save();

            //Mensagem que salvou.
            MessageBox.Show("Eis que eu salvo kakaakkakaakak", "Suas armas são uma bosta", MessageBoxButtons.OK);
        }

        private void BotaoDeSalvar_Click(object sender, EventArgs e)
        {
            //Chama o metódo de salvar.
            Save();
        }
    }
}
