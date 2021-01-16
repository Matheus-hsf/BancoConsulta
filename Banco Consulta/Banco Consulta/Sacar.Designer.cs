namespace Banco_Consulta
{
    partial class Sacar
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtNConta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSacar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtValorASerRetirado = new System.Windows.Forms.TextBox();
            this.lblValorAhSacar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Banco_Consulta.Properties.Resources.save_money_512;
            this.pictureBox2.Location = new System.Drawing.Point(12, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banco_Consulta.Properties.Resources.logo__1_;
            this.pictureBox1.Location = new System.Drawing.Point(130, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(155, 209);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(116, 43);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtNConta
            // 
            this.txtNConta.Location = new System.Drawing.Point(163, 157);
            this.txtNConta.Name = "txtNConta";
            this.txtNConta.Size = new System.Drawing.Size(100, 20);
            this.txtNConta.TabIndex = 3;
            this.txtNConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNConta_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informe o número da conta";
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(155, 258);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(116, 35);
            this.btnSacar.TabIndex = 5;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(151, 92);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(25, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "aaa";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(151, 114);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(35, 13);
            this.lblSaldo.TabIndex = 7;
            this.lblSaldo.Text = "label2";
            // 
            // txtValorASerRetirado
            // 
            this.txtValorASerRetirado.Location = new System.Drawing.Point(163, 184);
            this.txtValorASerRetirado.Name = "txtValorASerRetirado";
            this.txtValorASerRetirado.Size = new System.Drawing.Size(100, 20);
            this.txtValorASerRetirado.TabIndex = 8;
            this.txtValorASerRetirado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorASerRetirado_KeyPress);
            // 
            // lblValorAhSacar
            // 
            this.lblValorAhSacar.AutoSize = true;
            this.lblValorAhSacar.Location = new System.Drawing.Point(163, 165);
            this.lblValorAhSacar.Name = "lblValorAhSacar";
            this.lblValorAhSacar.Size = new System.Drawing.Size(35, 13);
            this.lblValorAhSacar.TabIndex = 9;
            this.lblValorAhSacar.Text = "label2";
            // 
            // Sacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(415, 305);
            this.Controls.Add(this.lblValorAhSacar);
            this.Controls.Add(this.txtValorASerRetirado);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNConta);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Sacar";
            this.Text = "Sacar";
            this.Load += new System.EventHandler(this.Sacar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtNConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtValorASerRetirado;
        private System.Windows.Forms.Label lblValorAhSacar;
    }
}