namespace exercicios
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
            this.txtMeu = new System.Windows.Forms.Label();
            this.txtBrasil = new System.Windows.Forms.Label();
            this.txtBrasileiro = new System.Windows.Forms.Label();
            this.btnClicka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMeu
            // 
            this.txtMeu.Location = new System.Drawing.Point(141, 78);
            this.txtMeu.Name = "txtMeu";
            this.txtMeu.Size = new System.Drawing.Size(147, 43);
            this.txtMeu.TabIndex = 0;
            this.txtMeu.Text = "msg";
            this.txtMeu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtMeu.Visible = false;
            this.txtMeu.Click += new System.EventHandler(this.txtMeu_Click);
            // 
            // txtBrasil
            // 
            this.txtBrasil.Location = new System.Drawing.Point(307, 81);
            this.txtBrasil.Name = "txtBrasil";
            this.txtBrasil.Size = new System.Drawing.Size(139, 36);
            this.txtBrasil.TabIndex = 1;
            this.txtBrasil.Text = "label2";
            this.txtBrasil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtBrasil.Visible = false;
            this.txtBrasil.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBrasileiro
            // 
            this.txtBrasileiro.Location = new System.Drawing.Point(452, 78);
            this.txtBrasileiro.Name = "txtBrasileiro";
            this.txtBrasileiro.Size = new System.Drawing.Size(157, 43);
            this.txtBrasileiro.TabIndex = 2;
            this.txtBrasileiro.Text = "label3";
            this.txtBrasileiro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtBrasileiro.Visible = false;
            this.txtBrasileiro.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnClicka
            // 
            this.btnClicka.AllowDrop = true;
            this.btnClicka.Location = new System.Drawing.Point(343, 306);
            this.btnClicka.Name = "btnClicka";
            this.btnClicka.Size = new System.Drawing.Size(75, 23);
            this.btnClicka.TabIndex = 3;
            this.btnClicka.Text = "INICIAR!";
            this.btnClicka.UseVisualStyleBackColor = true;
            this.btnClicka.Click += new System.EventHandler(this.btnClicka_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnClicka;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClicka);
            this.Controls.Add(this.txtBrasileiro);
            this.Controls.Add(this.txtBrasil);
            this.Controls.Add(this.txtMeu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtMeu;
        private System.Windows.Forms.Label txtBrasil;
        private System.Windows.Forms.Label txtBrasileiro;
        private System.Windows.Forms.Button btnClicka;
    }
}

