namespace Banco_Consulta
{
    partial class CriarConta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Criar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDataDeNascimento = new System.Windows.Forms.Label();
            this.nmcDia = new System.Windows.Forms.NumericUpDown();
            this.nmcMes = new System.Windows.Forms.NumericUpDown();
            this.nmcAno = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblAlertaRG = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlerta = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCepAlerta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkEspecial = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdAdE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNumeroDaCoonta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmcDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Criar
            // 
            this.Criar.Location = new System.Drawing.Point(138, 353);
            this.Criar.Name = "Criar";
            this.Criar.Size = new System.Drawing.Size(134, 51);
            this.Criar.TabIndex = 0;
            this.Criar.Text = "Confirmar";
            this.Criar.UseVisualStyleBackColor = true;
            this.Criar.Click += new System.EventHandler(this.Criar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(71, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(314, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(28, 75);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblDataDeNascimento
            // 
            this.lblDataDeNascimento.AutoSize = true;
            this.lblDataDeNascimento.Location = new System.Drawing.Point(28, 118);
            this.lblDataDeNascimento.Name = "lblDataDeNascimento";
            this.lblDataDeNascimento.Size = new System.Drawing.Size(104, 13);
            this.lblDataDeNascimento.TabIndex = 4;
            this.lblDataDeNascimento.Text = "Data de Nascimento";
            // 
            // nmcDia
            // 
            this.nmcDia.Location = new System.Drawing.Point(138, 116);
            this.nmcDia.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nmcDia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmcDia.Name = "nmcDia";
            this.nmcDia.Size = new System.Drawing.Size(34, 20);
            this.nmcDia.TabIndex = 5;
            this.nmcDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmcDia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmcMes
            // 
            this.nmcMes.Location = new System.Drawing.Point(189, 116);
            this.nmcMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nmcMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmcMes.Name = "nmcMes";
            this.nmcMes.Size = new System.Drawing.Size(34, 20);
            this.nmcMes.TabIndex = 6;
            this.nmcMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmcMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmcAno
            // 
            this.nmcAno.Location = new System.Drawing.Point(240, 116);
            this.nmcAno.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.nmcAno.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nmcAno.Name = "nmcAno";
            this.nmcAno.Size = new System.Drawing.Size(48, 20);
            this.nmcAno.TabIndex = 7;
            this.nmcAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmcAno.Value = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "RG";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(68, 190);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(314, 20);
            this.txtRG.TabIndex = 10;
            this.txtRG.TextChanged += new System.EventHandler(this.txtRG_TextChanged);
            this.txtRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRG_KeyPress);
            // 
            // lblAlertaRG
            // 
            this.lblAlertaRG.AutoSize = true;
            this.lblAlertaRG.Location = new System.Drawing.Point(392, 195);
            this.lblAlertaRG.Name = "lblAlertaRG";
            this.lblAlertaRG.Size = new System.Drawing.Size(0, 13);
            this.lblAlertaRG.TabIndex = 12;
            this.lblAlertaRG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "CEP";
            // 
            // txtAlerta
            // 
            this.txtAlerta.Location = new System.Drawing.Point(68, 238);
            this.txtAlerta.Name = "txtAlerta";
            this.txtAlerta.Size = new System.Drawing.Size(314, 20);
            this.txtAlerta.TabIndex = 13;
            this.txtAlerta.TextChanged += new System.EventHandler(this.txtAlerta_TextChanged);
            this.txtAlerta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlerta_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banco_Consulta.Properties.Resources._0c6d2d_7f1209e30451419e874b47d4991a7c86_mv2;
            this.pictureBox1.Location = new System.Drawing.Point(31, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Banco_Consulta.Properties.Resources.logo__1_;
            this.pictureBox2.Location = new System.Drawing.Point(97, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // lblCepAlerta
            // 
            this.lblCepAlerta.AutoSize = true;
            this.lblCepAlerta.Location = new System.Drawing.Point(392, 242);
            this.lblCepAlerta.Name = "lblCepAlerta";
            this.lblCepAlerta.Size = new System.Drawing.Size(0, 13);
            this.lblCepAlerta.TabIndex = 17;
            this.lblCepAlerta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Especial";
            // 
            // chkEspecial
            // 
            this.chkEspecial.AutoSize = true;
            this.chkEspecial.Location = new System.Drawing.Point(82, 284);
            this.chkEspecial.Name = "chkEspecial";
            this.chkEspecial.Size = new System.Drawing.Size(15, 14);
            this.chkEspecial.TabIndex = 20;
            this.chkEspecial.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Idade";
            // 
            // txtIdAdE
            // 
            this.txtIdAdE.Location = new System.Drawing.Point(68, 151);
            this.txtIdAdE.Name = "txtIdAdE";
            this.txtIdAdE.Size = new System.Drawing.Size(29, 20);
            this.txtIdAdE.TabIndex = 22;
            this.txtIdAdE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdAdE_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Número da conta: ";
            // 
            // lblNumeroDaCoonta
            // 
            this.lblNumeroDaCoonta.AutoSize = true;
            this.lblNumeroDaCoonta.Location = new System.Drawing.Point(119, 319);
            this.lblNumeroDaCoonta.Name = "lblNumeroDaCoonta";
            this.lblNumeroDaCoonta.Size = new System.Drawing.Size(0, 13);
            this.lblNumeroDaCoonta.TabIndex = 24;
            // 
            // CriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(415, 416);
            this.Controls.Add(this.lblNumeroDaCoonta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdAdE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkEspecial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCepAlerta);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlerta);
            this.Controls.Add(this.lblAlertaRG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmcAno);
            this.Controls.Add(this.nmcMes);
            this.Controls.Add(this.nmcDia);
            this.Controls.Add(this.lblDataDeNascimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Criar);
            this.Name = "CriarConta";
            this.Text = "CriarConta";
            this.Load += new System.EventHandler(this.CriarConta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmcDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Criar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDataDeNascimento;
        private System.Windows.Forms.NumericUpDown nmcDia;
        private System.Windows.Forms.NumericUpDown nmcMes;
        private System.Windows.Forms.NumericUpDown nmcAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lblAlertaRG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlerta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCepAlerta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkEspecial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdAdE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNumeroDaCoonta;
    }
}