namespace ideial.View
{
    partial class Comentario_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comentario_frm));
            this.top_pnl = new System.Windows.Forms.Panel();
            this.criadorComentario_lbl = new System.Windows.Forms.Label();
            this.criadorComentarioPic_img = new System.Windows.Forms.PictureBox();
            this.comentarioConteudo_lbl = new System.Windows.Forms.Label();
            this.top_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.criadorComentarioPic_img)).BeginInit();
            this.SuspendLayout();
            // 
            // top_pnl
            // 
            this.top_pnl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.top_pnl.Controls.Add(this.criadorComentario_lbl);
            this.top_pnl.Controls.Add(this.criadorComentarioPic_img);
            this.top_pnl.Location = new System.Drawing.Point(0, 0);
            this.top_pnl.Name = "top_pnl";
            this.top_pnl.Size = new System.Drawing.Size(443, 48);
            this.top_pnl.TabIndex = 2;
            // 
            // criadorComentario_lbl
            // 
            this.criadorComentario_lbl.AutoSize = true;
            this.criadorComentario_lbl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.criadorComentario_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criadorComentario_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.criadorComentario_lbl.Location = new System.Drawing.Point(44, 17);
            this.criadorComentario_lbl.Name = "criadorComentario_lbl";
            this.criadorComentario_lbl.Size = new System.Drawing.Size(96, 13);
            this.criadorComentario_lbl.TabIndex = 8;
            this.criadorComentario_lbl.Text = "Nome do Utilizador";
            // 
            // criadorComentarioPic_img
            // 
            this.criadorComentarioPic_img.Cursor = System.Windows.Forms.Cursors.Default;
            this.criadorComentarioPic_img.Image = ((System.Drawing.Image)(resources.GetObject("criadorComentarioPic_img.Image")));
            this.criadorComentarioPic_img.Location = new System.Drawing.Point(9, 5);
            this.criadorComentarioPic_img.Name = "criadorComentarioPic_img";
            this.criadorComentarioPic_img.Size = new System.Drawing.Size(29, 38);
            this.criadorComentarioPic_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.criadorComentarioPic_img.TabIndex = 7;
            this.criadorComentarioPic_img.TabStop = false;
            // 
            // comentarioConteudo_lbl
            // 
            this.comentarioConteudo_lbl.AutoSize = true;
            this.comentarioConteudo_lbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comentarioConteudo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comentarioConteudo_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.comentarioConteudo_lbl.Location = new System.Drawing.Point(29, 62);
            this.comentarioConteudo_lbl.MaximumSize = new System.Drawing.Size(385, 60);
            this.comentarioConteudo_lbl.Name = "comentarioConteudo_lbl";
            this.comentarioConteudo_lbl.Size = new System.Drawing.Size(380, 60);
            this.comentarioConteudo_lbl.TabIndex = 14;
            this.comentarioConteudo_lbl.Text = resources.GetString("comentarioConteudo_lbl.Text");
            // 
            // Comentario_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 131);
            this.Controls.Add(this.comentarioConteudo_lbl);
            this.Controls.Add(this.top_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Comentario_frm";
            this.Text = "Comentario_frm";
            this.Load += new System.EventHandler(this.Comentario_frm_Load);
            this.top_pnl.ResumeLayout(false);
            this.top_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.criadorComentarioPic_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top_pnl;
        private System.Windows.Forms.Label criadorComentario_lbl;
        private System.Windows.Forms.PictureBox criadorComentarioPic_img;
        private System.Windows.Forms.Label comentarioConteudo_lbl;
    }
}