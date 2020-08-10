using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Inventário_e_dinheiro_RPG.Properties;
using System.Security;

namespace Inventário_e_dinheiro_RPG
{
    public partial class Inventario : Form
    {
        public int dinDin;
        public int cristais;
        public int valor;
        
        

        public Inventario()
        {
            //não sei
            InitializeComponent();
        }


        //Quando essa janela abre
        private void Inventario_Load(object sender, EventArgs e)
        {
            //Chama o metódo de carregar as coisas salvas.
            Carregar();
        }

        private void AddIMG_Click(object sender, EventArgs e)
        {
            
        }

        private void Itens_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDinheiro_Click(object sender, EventArgs e)
        {
            //Adiciona o dinheiro
            dinDin += valor;
            //Concerta a text box
            DinheiroNTextBox.Text = dinDin.ToString();
            
        }

        private void SubDinheiro_Click(object sender, EventArgs e)
        {
            //Se a subtração nao der 0, subtrai o dinheiro
            if(dinDin - valor >= 0)
            {
                dinDin -= valor;
                //Concerta a text box
                DinheiroNTextBox.Text = dinDin.ToString();
            }
            else
            {
                //Mostra a mensagem de sem dinheiro.
                semGrana("dinheiro");
            }
        }

        //Mesma coisa que faz com o dinheiro, mas agora, com os cristais.
        private void AddCristal_Click(object sender, EventArgs e)
        {
            cristais += valor;
            CristaisNTextBox.Text = cristais.ToString();
        }

        //Veja acima.
        private void SubCristal_Click(object sender, EventArgs e)
        {
            if (cristais - valor >= 0)
            {
                cristais -= valor;
                CristaisNTextBox.Text = cristais.ToString();
            }
            else
            {
                semGrana("cristais");
            }
        }

        private void CristaisNTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DinheiroNTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Quando o valor do coisa de número muda
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //Arredonda e converte de decimal pra int.
            valor = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
        }

        private void semGrana(string Moeda)
        {
            //Msg de sem dinheiro.
            MessageBox.Show("Você não tem " + Moeda + " o suficiente!", "vc eh pobrer kkkk", MessageBoxButtons.OK);
        }

        private void AbridorDeArma_Click(object sender, EventArgs e)
        {
            //Abre o menu das armas
            var m = new Armas();
            m.Show();
        }

        //Quando o botão de salvar for clicado...
        private void Salvador_Click(object sender, EventArgs e)
        {
            //Chama o metódo pra salvar.
            Salvar();
        }

        public void Salvar()
        {
            //Salva os itens, esse deve ser o pior códio que já escrevi meu Deus do céu.
            Settings.Default.Item1 = Item1.Text;
            Settings.Default.Item2 = Item2.Text;
            Settings.Default.Item3 = Item3.Text;
            Settings.Default.Item4 = Item4.Text;
            Settings.Default.Item5 = Item5.Text;
            Settings.Default.Item6 = Item6.Text;
            Settings.Default.Item7 = Item7.Text;
            Settings.Default.Item8 = Item8.Text;
            Settings.Default.Item9 = Item9.Text;
            Settings.Default.Item10 = Item10.Text;
            Settings.Default.Item11 = Item11.Text;
            Settings.Default.Item12 = Item12.Text;
            Settings.Default.Item13 = Item13.Text;

            //Salva as magias, parte 2 do pior código que já escrevi.
            Settings.Default.Magia1 = Magia1.Text;
            Settings.Default.Magia2 = Magia2.Text;
            Settings.Default.Magia3 = Magia3.Text;
            Settings.Default.Magia4 = Magia4.Text;
            Settings.Default.Magia5 = Magia5.Text;
            Settings.Default.Magia6 = Magia6.Text;
            Settings.Default.Magia7 = Magia7.Text;

            //Salva as magias negras, parte 3 do pior código que já escrevi.
            Settings.Default.MagiaN1 = MagiaN1.Text;
            Settings.Default.MagiaN2 = MagiaN2.Text;
            Settings.Default.MagiaN3 = MagiaN3.Text;
            Settings.Default.MagiaN4 = MagiaN4.Text;
            Settings.Default.MagiaN5 = MagiaN5.Text;

            //Salva os cristais e dinheiro, já sabe o que eu acho desse código.
            Settings.Default.Cristais = cristais;
            Settings.Default.Dinheiro = dinDin;

            //Escreve as mudanças pra salvar de verdade.
            Settings.Default.Save();

            //Mensagem falando que salvou.
            MessageBox.Show("Salvo!", "Eis que eu que eu salvo S.A.M QUANDO A 10/10 TENTE NÃO RIR MELHORES MEMES", MessageBoxButtons.OK);

        }

        public void Carregar()
        {
            //Carrega os itens, outro código bosta.
            Item1.Text = Settings.Default.Item1;
            Item2.Text = Settings.Default.Item2;
            Item3.Text = Settings.Default.Item3;
            Item4.Text = Settings.Default.Item4;
            Item5.Text = Settings.Default.Item5;
            Item6.Text = Settings.Default.Item6;
            Item7.Text = Settings.Default.Item7;
            Item8.Text = Settings.Default.Item8;
            Item9.Text = Settings.Default.Item9;
            Item10.Text = Settings.Default.Item10;
            Item11.Text = Settings.Default.Item11;
            Item12.Text = Settings.Default.Item12;
            Item13.Text = Settings.Default.Item13;

            //Carrega as magias. Uma merda.
            Magia1.Text = Settings.Default.Magia1;
            Magia2.Text = Settings.Default.Magia2;
            Magia3.Text = Settings.Default.Magia3;
            Magia4.Text = Settings.Default.Magia4;
            Magia5.Text = Settings.Default.Magia5;
            Magia6.Text = Settings.Default.Magia6;
            Magia7.Text = Settings.Default.Magia7;

            //Carrega as magias negras, mais uma merda mds
            MagiaN1.Text = Settings.Default.MagiaN1;
            MagiaN2.Text = Settings.Default.MagiaN2;
            MagiaN3.Text = Settings.Default.MagiaN3;
            MagiaN4.Text = Settings.Default.MagiaN4;
            MagiaN5.Text = Settings.Default.MagiaN5;

            //Carrega os Dinheiros, horrível
            cristais = Settings.Default.Cristais;
            dinDin = Settings.Default.Dinheiro;

            //Faz o dinheiro e cristais aparecer, basicamente.
            DinheiroNTextBox.Text = dinDin.ToString();
            CristaisNTextBox.Text = cristais.ToString();
        }


        //Quando o btn for clicado.
        private void Notas_Click(object sender, EventArgs e)
        {
            //Carrega o coisa de anotações.
            var a = new Anotacoes();
            a.Show();
        }
    }
}
