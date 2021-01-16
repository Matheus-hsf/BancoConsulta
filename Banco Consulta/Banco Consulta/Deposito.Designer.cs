namespace Banco_Consulta
{
    partial class Deposito
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNCONTA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVlrDeposito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblNNome = new System.Windows.Forms.Label();
            this.lblNSaldo = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banco_Consulta.Properties.Resources._0c6d2d_7f1209e30451419e874b47d4991a7c86_mv2;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número da conta";
            // 
            // txtNCONTA
            // 
            this.txtNCONTA.Location = new System.Drawing.Point(137, 124);
            this.txtNCONTA.Name = "txtNCONTA";
            this.txtNCONTA.Size = new System.Drawing.Size(100, 20);
            this.txtNCONTA.TabIndex = 2;
            this.txtNCONTA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNCONTA_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor a ser depositado";
            // 
            // txtVlrDeposito
            // 
            this.txtVlrDeposito.Location = new System.Drawing.Point(137, 170);
            this.txtVlrDeposito.Name = "txtVlrDeposito";
            this.txtVlrDeposito.Size = new System.Drawing.Size(100, 20);
            this.txtVlrDeposito.TabIndex = 4;
            this.txtVlrDeposito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVlrDeposito_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "-------------------------------------";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(300, 136);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(118, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "-------------------------------------";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(300, 152);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(118, 13);
            this.lblSaldo.TabIndex = 7;
            this.lblSaldo.Text = "-------------------------------------";
            // 
            // lblNNome
            // 
            this.lblNNome.AutoSize = true;
            this.lblNNome.Location = new System.Drawing.Point(301, 219);
            this.lblNNome.Name = "lblNNome";
            this.lblNNome.Size = new System.Drawing.Size(118, 13);
            this.lblNNome.TabIndex = 8;
            this.lblNNome.Text = "-------------------------------------";
            // 
            // lblNSaldo
            // 
            this.lblNSaldo.AutoSize = true;
            this.lblNSaldo.Location = new System.Drawing.Point(301, 241);
            this.lblNSaldo.Name = "lblNSaldo";
            this.lblNSaldo.Size = new System.Drawing.Size(118, 13);
            this.lblNSaldo.TabIndex = 9;
            this.lblNSaldo.Text = "-------------------------------------";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(67, 224);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(146, 30);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(67, 224);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(146, 30);
            this.btnDepositar.TabIndex = 11;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Banco_Consulta.Properties.Resources.cofrinho_300x300;
            this.pictureBox2.Location = new System.Drawing.Point(361, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(478, 288);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblNSaldo);
            this.Controls.Add(this.lblNNome);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVlrDeposito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNCONTA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Deposito";
            this.Text = "Deposito";
            this.Load += new System.EventHandler(this.Deposito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNCONTA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVlrDeposito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblNNome;
        private System.Windows.Forms.Label lblNSaldo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}