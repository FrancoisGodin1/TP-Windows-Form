namespace tpFentreMereFille
{
    partial class Ffille
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
            this.lbFfille = new System.Windows.Forms.Label();
            this.btnChanger = new System.Windows.Forms.Button();
            this.btnMamere = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbFfille
            // 
            this.lbFfille.AutoSize = true;
            this.lbFfille.Location = new System.Drawing.Point(11, 87);
            this.lbFfille.Name = "lbFfille";
            this.lbFfille.Size = new System.Drawing.Size(98, 13);
            this.lbFfille.TabIndex = 0;
            this.lbFfille.Text = "je change de nom :";
            // 
            // btnChanger
            // 
            this.btnChanger.Location = new System.Drawing.Point(222, 84);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(75, 23);
            this.btnChanger.TabIndex = 1;
            this.btnChanger.Text = "Changer";
            this.btnChanger.UseVisualStyleBackColor = true;
            // 
            // btnMamere
            // 
            this.btnMamere.Location = new System.Drawing.Point(34, 160);
            this.btnMamere.Name = "btnMamere";
            this.btnMamere.Size = new System.Drawing.Size(75, 23);
            this.btnMamere.TabIndex = 2;
            this.btnMamere.Text = "Ma Mere";
            this.btnMamere.UseVisualStyleBackColor = true;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(115, 84);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(74, 20);
            this.tbNom.TabIndex = 3;
            // 
            // Ffille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 262);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.btnMamere);
            this.Controls.Add(this.btnChanger);
            this.Controls.Add(this.lbFfille);
            this.Name = "Ffille";
            this.Text = "Ffille";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFfille;
        private System.Windows.Forms.Button btnChanger;
        private System.Windows.Forms.Button btnMamere;
        private System.Windows.Forms.TextBox tbNom;
    }
}