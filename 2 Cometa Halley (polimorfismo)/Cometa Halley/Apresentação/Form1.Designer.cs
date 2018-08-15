namespace Cometa_Halley
{
    partial class Form1
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
            this.lblAno = new System.Windows.Forms.Label();
            this.txbAno = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblPriscillaRizzardo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(44, 22);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(72, 13);
            this.lblAno.TabIndex = 0;
            this.lblAno.Text = "Informe o ano";
            // 
            // txbAno
            // 
            this.txbAno.Location = new System.Drawing.Point(47, 49);
            this.txbAno.Name = "txbAno";
            this.txbAno.Size = new System.Drawing.Size(106, 20);
            this.txbAno.TabIndex = 1;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(12, 130);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(52, 13);
            this.lblResposta.TabIndex = 2;
            this.lblResposta.Text = "Resposta";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(58, 84);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblPriscillaRizzardo
            // 
            this.lblPriscillaRizzardo.AutoSize = true;
            this.lblPriscillaRizzardo.Location = new System.Drawing.Point(69, 212);
            this.lblPriscillaRizzardo.Name = "lblPriscillaRizzardo";
            this.lblPriscillaRizzardo.Size = new System.Drawing.Size(129, 13);
            this.lblPriscillaRizzardo.TabIndex = 4;
            this.lblPriscillaRizzardo.Text = "made by Priscilla Rizzardo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(210, 234);
            this.Controls.Add(this.lblPriscillaRizzardo);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.txbAno);
            this.Controls.Add(this.lblAno);
            this.Name = "Form1";
            this.Text = "Cometa Halley";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txbAno;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblPriscillaRizzardo;
    }
}

