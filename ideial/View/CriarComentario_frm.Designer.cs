namespace ideial.View
{
    partial class CriarComentario_frm
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
            this.conteudo_txt = new System.Windows.Forms.TextBox();
            this.insira_lbl = new System.Windows.Forms.Label();
            this.submeterComentario_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conteudo_txt
            // 
            this.conteudo_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conteudo_txt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.conteudo_txt.Location = new System.Drawing.Point(12, 50);
            this.conteudo_txt.Multiline = true;
            this.conteudo_txt.Name = "conteudo_txt";
            this.conteudo_txt.Size = new System.Drawing.Size(403, 66);
            this.conteudo_txt.TabIndex = 17;
            // 
            // insira_lbl
            // 
            this.insira_lbl.AutoSize = true;
            this.insira_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insira_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.insira_lbl.Location = new System.Drawing.Point(12, 18);
            this.insira_lbl.Name = "insira_lbl";
            this.insira_lbl.Size = new System.Drawing.Size(182, 20);
            this.insira_lbl.TabIndex = 18;
            this.insira_lbl.Text = "Insira o seu comentário: ";
            // 
            // submeterComentario_btn
            // 
            this.submeterComentario_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.submeterComentario_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submeterComentario_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submeterComentario_btn.Location = new System.Drawing.Point(223, 123);
            this.submeterComentario_btn.Name = "submeterComentario_btn";
            this.submeterComentario_btn.Size = new System.Drawing.Size(192, 38);
            this.submeterComentario_btn.TabIndex = 22;
            this.submeterComentario_btn.Text = "Submeter Comentário";
            this.submeterComentario_btn.UseVisualStyleBackColor = false;
            this.submeterComentario_btn.Click += new System.EventHandler(this.submeterComentario_btn_Click);
            // 
            // CriarComentario_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 171);
            this.Controls.Add(this.submeterComentario_btn);
            this.Controls.Add(this.insira_lbl);
            this.Controls.Add(this.conteudo_txt);
            this.Name = "CriarComentario_frm";
            this.Text = "Criar Comentario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox conteudo_txt;
        private System.Windows.Forms.Label insira_lbl;
        private System.Windows.Forms.Button submeterComentario_btn;
    }
}