namespace Banco_Consulta
{
    partial class Transferencia
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
            this.txtConta1 = new System.Windows.Forms.TextBox();
            this.txtConta2 = new System.Windows.Forms.TextBox();
            this.lblNome1 = new System.Windows.Forms.Label();
            this.lblSaldo1 = new System.Windows.Forms.Label();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.lblSaldo2 = new System.Windows.Forms.Label();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnTransf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banco_Consulta.Properties.Resources.img_347030;
            this.pictureBox1.Location = new System.Drawing.Point(246, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtConta1
            // 
            this.txtConta1.Location = new System.Drawing.Point(36, 31);
            this.txtConta1.Name = "txtConta1";
            this.txtConta1.Size = new System.Drawing.Size(100, 20);
            this.txtConta1.TabIndex = 1;
            this.txtConta1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConta1_KeyPress);
            // 
            // txtConta2
            // 
            this.txtConta2.Location = new System.Drawing.Point(485, 31);
            this.txtConta2.Name = "txtConta2";
            this.txtConta2.Size = new System.Drawing.Size(100, 20);
            this.txtConta2.TabIndex = 2;
            this.txtConta2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConta2_KeyPress);
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Location = new System.Drawing.Point(36, 69);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(35, 13);
            this.lblNome1.TabIndex = 3;
            this.lblNome1.Text = "label1";
            // 
            // lblSaldo1
            // 
            this.lblSaldo1.AutoSize = true;
            this.lblSaldo1.Location = new System.Drawing.Point(36, 98);
            this.lblSaldo1.Name = "lblSaldo1";
            this.lblSaldo1.Size = new System.Drawing.Size(35, 13);
            this.lblSaldo1.TabIndex = 4;
            this.lblSaldo1.Text = "label1";
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Location = new System.Drawing.Point(482, 69);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(35, 13);
            this.lblNome2.TabIndex = 5;
            this.lblNome2.Text = "label1";
            // 
            // lblSaldo2
            // 
            this.lblSaldo2.AutoSize = true;
            this.lblSaldo2.Location = new System.Drawing.Point(482, 98);
            this.lblSaldo2.Name = "lblSaldo2";
            this.lblSaldo2.Size = new System.Drawing.Size(35, 13);
            this.lblSaldo2.TabIndex = 6;
            this.lblSaldo2.Text = "label1";
            // 
            // btnC1
            // 
            this.btnC1.Location = new System.Drawing.Point(45, 76);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(75, 23);
            this.btnC1.TabIndex = 7;
            this.btnC1.Text = "Confirmar";
            this.btnC1.UseVisualStyleBackColor = true;
            this.btnC1.Click += new System.EventHandler(this.btnC1_Click);
            // 
            // btnC2
            // 
            this.btnC2.Location = new System.Drawing.Point(494, 76);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(75, 23);
            this.btnC2.TabIndex = 8;
            this.btnC2.Text = "Confirmar";
            this.btnC2.UseVisualStyleBackColor = true;
            this.btnC2.Click += new System.EventHandler(this.btnC2_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(257, 136);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 9;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // btnTransf
            // 
            this.btnTransf.Location = new System.Drawing.Point(249, 175);
            this.btnTransf.Name = "btnTransf";
            this.btnTransf.Size = new System.Drawing.Size(115, 36);
            this.btnTransf.TabIndex = 10;
            this.btnTransf.Text = "Transferir";
            this.btnTransf.UseVisualStyleBackColor = true;
            this.btnTransf.Click += new System.EventHandler(this.btnTransf_Click);
            // 
            // Transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 236);
            this.Controls.Add(this.btnTransf);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnC2);
            this.Controls.Add(this.btnC1);
            this.Controls.Add(this.lblSaldo2);
            this.Controls.Add(this.lblNome2);
            this.Controls.Add(this.lblSaldo1);
            this.Controls.Add(this.lblNome1);
            this.Controls.Add(this.txtConta2);
            this.Controls.Add(this.txtConta1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Transferencia";
            this.Text = "Transferencia";
            this.Load += new System.EventHandler(this.Transferencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtConta1;
        private System.Windows.Forms.TextBox txtConta2;
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.Label lblSaldo1;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.Label lblSaldo2;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnTransf;
    }
}