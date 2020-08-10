namespace Inventário_e_dinheiro_RPG
{
    partial class Armas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TemMunicao2 = new System.Windows.Forms.CheckBox();
            this.TemMunicao1 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Arma2Img = new System.Windows.Forms.PictureBox();
            this.Arma1Img = new System.Windows.Forms.PictureBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.BTNArma1 = new System.Windows.Forms.Button();
            this.BTNArma2 = new System.Windows.Forms.Button();
            this.Ammo1 = new System.Windows.Forms.TextBox();
            this.Ammo2 = new System.Windows.Forms.TextBox();
            this.AmmoBox1 = new System.Windows.Forms.TextBox();
            this.AmmoBox2 = new System.Windows.Forms.TextBox();
            this.BotaoDeSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Arma2Img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arma1Img)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Arma 2";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Arma 1";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TemMunicao2
            // 
            this.TemMunicao2.AutoSize = true;
            this.TemMunicao2.Location = new System.Drawing.Point(429, 15);
            this.TemMunicao2.Name = "TemMunicao2";
            this.TemMunicao2.Size = new System.Drawing.Size(88, 17);
            this.TemMunicao2.TabIndex = 2;
            this.TemMunicao2.Text = "Usa munição";
            this.TemMunicao2.UseVisualStyleBackColor = true;
            this.TemMunicao2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TemMunicao1
            // 
            this.TemMunicao1.AutoSize = true;
            this.TemMunicao1.Location = new System.Drawing.Point(173, 16);
            this.TemMunicao1.Name = "TemMunicao1";
            this.TemMunicao1.Size = new System.Drawing.Size(88, 17);
            this.TemMunicao1.TabIndex = 2;
            this.TemMunicao1.Text = "Usa munição";
            this.TemMunicao1.UseVisualStyleBackColor = true;
            this.TemMunicao1.CheckedChanged += new System.EventHandler(this.TemMunicao1_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 237);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 150);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(268, 238);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 149);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(13, 211);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 13);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Atributos Adicionais:";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox6.Location = new System.Drawing.Point(268, 212);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 13);
            this.textBox6.TabIndex = 4;
            this.textBox6.Text = "Atributos Adicionais:";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Arma2Img
            // 
            this.Arma2Img.Location = new System.Drawing.Point(268, 36);
            this.Arma2Img.Name = "Arma2Img";
            this.Arma2Img.Size = new System.Drawing.Size(227, 166);
            this.Arma2Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Arma2Img.TabIndex = 5;
            this.Arma2Img.TabStop = false;
            this.Arma2Img.Click += new System.EventHandler(this.Arma1Img_Click);
            // 
            // Arma1Img
            // 
            this.Arma1Img.Location = new System.Drawing.Point(12, 36);
            this.Arma1Img.Name = "Arma1Img";
            this.Arma1Img.Size = new System.Drawing.Size(227, 167);
            this.Arma1Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Arma1Img.TabIndex = 5;
            this.Arma1Img.TabStop = false;
            this.Arma1Img.Click += new System.EventHandler(this.Arma2Img_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // BTNArma1
            // 
            this.BTNArma1.Location = new System.Drawing.Point(107, 12);
            this.BTNArma1.Name = "BTNArma1";
            this.BTNArma1.Size = new System.Drawing.Size(60, 19);
            this.BTNArma1.TabIndex = 6;
            this.BTNArma1.Text = "Add IMG";
            this.BTNArma1.UseVisualStyleBackColor = true;
            this.BTNArma1.Click += new System.EventHandler(this.BTNArma1_Click_1);
            // 
            // BTNArma2
            // 
            this.BTNArma2.Location = new System.Drawing.Point(363, 12);
            this.BTNArma2.Name = "BTNArma2";
            this.BTNArma2.Size = new System.Drawing.Size(60, 19);
            this.BTNArma2.TabIndex = 6;
            this.BTNArma2.Text = "Add IMG";
            this.BTNArma2.UseVisualStyleBackColor = true;
            this.BTNArma2.Click += new System.EventHandler(this.BTNArma2_Click_1);
            // 
            // Ammo1
            // 
            this.Ammo1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ammo1.Location = new System.Drawing.Point(165, 238);
            this.Ammo1.Name = "Ammo1";
            this.Ammo1.ReadOnly = true;
            this.Ammo1.Size = new System.Drawing.Size(38, 13);
            this.Ammo1.TabIndex = 7;
            this.Ammo1.Text = "Ammo:";
            this.Ammo1.Visible = false;
            // 
            // Ammo2
            // 
            this.Ammo2.BackColor = System.Drawing.SystemColors.Control;
            this.Ammo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ammo2.Location = new System.Drawing.Point(429, 238);
            this.Ammo2.Name = "Ammo2";
            this.Ammo2.ReadOnly = true;
            this.Ammo2.Size = new System.Drawing.Size(41, 13);
            this.Ammo2.TabIndex = 7;
            this.Ammo2.Text = "Ammo:";
            this.Ammo2.Visible = false;
            // 
            // AmmoBox1
            // 
            this.AmmoBox1.BackColor = System.Drawing.SystemColors.Control;
            this.AmmoBox1.Location = new System.Drawing.Point(164, 264);
            this.AmmoBox1.Name = "AmmoBox1";
            this.AmmoBox1.Size = new System.Drawing.Size(52, 20);
            this.AmmoBox1.TabIndex = 8;
            this.AmmoBox1.Visible = false;
            // 
            // AmmoBox2
            // 
            this.AmmoBox2.BackColor = System.Drawing.SystemColors.Control;
            this.AmmoBox2.Location = new System.Drawing.Point(429, 264);
            this.AmmoBox2.Name = "AmmoBox2";
            this.AmmoBox2.Size = new System.Drawing.Size(52, 20);
            this.AmmoBox2.TabIndex = 8;
            this.AmmoBox2.Visible = false;
            // 
            // BotaoDeSalvar
            // 
            this.BotaoDeSalvar.Location = new System.Drawing.Point(510, 343);
            this.BotaoDeSalvar.Name = "BotaoDeSalvar";
            this.BotaoDeSalvar.Size = new System.Drawing.Size(92, 59);
            this.BotaoDeSalvar.TabIndex = 9;
            this.BotaoDeSalvar.Text = "Salvar";
            this.BotaoDeSalvar.UseVisualStyleBackColor = true;
            this.BotaoDeSalvar.Click += new System.EventHandler(this.BotaoDeSalvar_Click);
            // 
            // Armas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 405);
            this.Controls.Add(this.BotaoDeSalvar);
            this.Controls.Add(this.AmmoBox2);
            this.Controls.Add(this.AmmoBox1);
            this.Controls.Add(this.Ammo2);
            this.Controls.Add(this.Ammo1);
            this.Controls.Add(this.BTNArma2);
            this.Controls.Add(this.BTNArma1);
            this.Controls.Add(this.Arma1Img);
            this.Controls.Add(this.Arma2Img);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.TemMunicao1);
            this.Controls.Add(this.TemMunicao2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Armas";
            this.Text = "Armas";
            this.Load += new System.EventHandler(this.Armas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Arma2Img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arma1Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox TemMunicao2;
        private System.Windows.Forms.CheckBox TemMunicao1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox Arma2Img;
        private System.Windows.Forms.PictureBox Arma1Img;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button BTNArma1;
        private System.Windows.Forms.Button BTNArma2;
        private System.Windows.Forms.TextBox Ammo1;
        private System.Windows.Forms.TextBox Ammo2;
        private System.Windows.Forms.TextBox AmmoBox1;
        private System.Windows.Forms.TextBox AmmoBox2;
        private System.Windows.Forms.Button BotaoDeSalvar;
    }
}

