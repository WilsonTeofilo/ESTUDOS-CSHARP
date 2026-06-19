namespace ex004
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
            this.txtN1 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.Label();
            this.txtN3 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnClique = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(146, 354);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(123, 27);
            this.txtN1.TabIndex = 0;
            this.txtN1.Text = "label1";
            this.txtN1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtN1.Visible = false;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(336, 350);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(135, 34);
            this.txtN2.TabIndex = 1;
            this.txtN2.Text = "label2";
            this.txtN2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtN2.Visible = false;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(521, 350);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(134, 34);
            this.txtN3.TabIndex = 2;
            this.txtN3.Text = "label3";
            this.txtN3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtN3.Visible = false;
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(105, 79);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(155, 37);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "Digite um número:";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(310, 90);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(217, 20);
            this.txtNum.TabIndex = 4;
            // 
            // btnClique
            // 
            this.btnClique.Location = new System.Drawing.Point(355, 202);
            this.btnClique.Name = "btnClique";
            this.btnClique.Size = new System.Drawing.Size(136, 39);
            this.btnClique.TabIndex = 5;
            this.btnClique.Text = "Clique";
            this.btnClique.UseVisualStyleBackColor = true;
            this.btnClique.Click += new System.EventHandler(this.btnClique_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnClique;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClique);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtN1;
        private System.Windows.Forms.Label txtN2;
        private System.Windows.Forms.Label txtN3;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnClique;
    }
}

