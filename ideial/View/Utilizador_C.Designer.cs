namespace ideial.View
{
    partial class Utilizador_C
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
            this.Nome_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.Nombe_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.registo_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nome_txt
            // 
            this.Nome_txt.Location = new System.Drawing.Point(131, 31);
            this.Nome_txt.Name = "Nome_txt";
            this.Nome_txt.Size = new System.Drawing.Size(100, 20);
            this.Nome_txt.TabIndex = 0;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(131, 57);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(100, 20);
            this.email_txt.TabIndex = 1;
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(131, 83);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(100, 20);
            this.username_txt.TabIndex = 2;
            // 
            // Nombe_lbl
            // 
            this.Nombe_lbl.AutoSize = true;
            this.Nombe_lbl.Location = new System.Drawing.Point(49, 37);
            this.Nombe_lbl.Name = "Nombe_lbl";
            this.Nombe_lbl.Size = new System.Drawing.Size(35, 13);
            this.Nombe_lbl.TabIndex = 3;
            this.Nombe_lbl.Text = "Nome";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Location = new System.Drawing.Point(52, 63);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(36, 13);
            this.email_lbl.TabIndex = 4;
            this.email_lbl.Text = "E-Mail";
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(52, 89);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(53, 13);
            this.username_lbl.TabIndex = 5;
            this.username_lbl.Text = "username";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(52, 116);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(68, 13);
            this.password_lbl.TabIndex = 6;
            this.password_lbl.Text = "password_lbl";
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(131, 110);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(100, 20);
            this.password_txt.TabIndex = 7;
            // 
            // registo_btn
            // 
            this.registo_btn.Location = new System.Drawing.Point(155, 164);
            this.registo_btn.Name = "registo_btn";
            this.registo_btn.Size = new System.Drawing.Size(75, 23);
            this.registo_btn.TabIndex = 8;
            this.registo_btn.Text = "Registo";
            this.registo_btn.UseVisualStyleBackColor = true;
            this.registo_btn.Click += new System.EventHandler(this.registo_btn_Click);
            // 
            // Utilizador_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.registo_btn);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.Nombe_lbl);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.Nome_txt);
            this.Name = "Utilizador_C";
            this.Text = "Utilizador_C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nome_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label Nombe_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button registo_btn;
    }
}