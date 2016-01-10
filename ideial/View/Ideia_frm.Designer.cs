namespace ideial.View
{
    partial class Ideia_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ideia_frm));
            this.ideiasBG_pnl = new System.Windows.Forms.Panel();
            this.bottom_pnl = new System.Windows.Forms.Panel();
            this.commentsNbr_lbl = new System.Windows.Forms.Label();
            this.ideiaConteudo_lbl = new System.Windows.Forms.Label();
            this.ideiaTitulo_lbl = new System.Windows.Forms.Label();
            this.top_pnl = new System.Windows.Forms.Panel();
            this.scoresNbr_lbl = new System.Windows.Forms.Label();
            this.criadorIdeia_lbl = new System.Windows.Forms.Label();
            this.comentarios_pnl = new System.Windows.Forms.Panel();
            this.adicionarComentario_btn = new System.Windows.Forms.Button();
            this.comment_img = new System.Windows.Forms.PictureBox();
            this.ideiaScore_img = new System.Windows.Forms.PictureBox();
            this.criadorIdeiaPic_img = new System.Windows.Forms.PictureBox();
            this.ideiasBG_pnl.SuspendLayout();
            this.bottom_pnl.SuspendLayout();
            this.top_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comment_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ideiaScore_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criadorIdeiaPic_img)).BeginInit();
            this.SuspendLayout();
            // 
            // ideiasBG_pnl
            // 
            this.ideiasBG_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ideiasBG_pnl.Controls.Add(this.bottom_pnl);
            this.ideiasBG_pnl.Controls.Add(this.ideiaConteudo_lbl);
            this.ideiasBG_pnl.Controls.Add(this.ideiaTitulo_lbl);
            this.ideiasBG_pnl.Controls.Add(this.top_pnl);
            this.ideiasBG_pnl.Location = new System.Drawing.Point(0, 0);
            this.ideiasBG_pnl.Name = "ideiasBG_pnl";
            this.ideiasBG_pnl.Size = new System.Drawing.Size(443, 225);
            this.ideiasBG_pnl.TabIndex = 0;
            this.ideiasBG_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bottom_pnl
            // 
            this.bottom_pnl.BackColor = System.Drawing.SystemColors.Highlight;
            this.bottom_pnl.Controls.Add(this.adicionarComentario_btn);
            this.bottom_pnl.Controls.Add(this.commentsNbr_lbl);
            this.bottom_pnl.Controls.Add(this.comment_img);
            this.bottom_pnl.Location = new System.Drawing.Point(-1, 189);
            this.bottom_pnl.Name = "bottom_pnl";
            this.bottom_pnl.Size = new System.Drawing.Size(449, 36);
            this.bottom_pnl.TabIndex = 15;
            // 
            // commentsNbr_lbl
            // 
            this.commentsNbr_lbl.AutoSize = true;
            this.commentsNbr_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.commentsNbr_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsNbr_lbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.commentsNbr_lbl.Location = new System.Drawing.Point(414, 10);
            this.commentsNbr_lbl.Name = "commentsNbr_lbl";
            this.commentsNbr_lbl.Size = new System.Drawing.Size(16, 17);
            this.commentsNbr_lbl.TabIndex = 15;
            this.commentsNbr_lbl.Text = "0";
            // 
            // ideiaConteudo_lbl
            // 
            this.ideiaConteudo_lbl.AutoSize = true;
            this.ideiaConteudo_lbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ideiaConteudo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ideiaConteudo_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ideiaConteudo_lbl.Location = new System.Drawing.Point(41, 97);
            this.ideiaConteudo_lbl.MaximumSize = new System.Drawing.Size(375, 85);
            this.ideiaConteudo_lbl.Name = "ideiaConteudo_lbl";
            this.ideiaConteudo_lbl.Size = new System.Drawing.Size(365, 85);
            this.ideiaConteudo_lbl.TabIndex = 13;
            this.ideiaConteudo_lbl.Text = resources.GetString("ideiaConteudo_lbl.Text");
            this.ideiaConteudo_lbl.Click += new System.EventHandler(this.ideiaConteudo_lbl_Click);
            // 
            // ideiaTitulo_lbl
            // 
            this.ideiaTitulo_lbl.AutoSize = true;
            this.ideiaTitulo_lbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ideiaTitulo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ideiaTitulo_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ideiaTitulo_lbl.Location = new System.Drawing.Point(41, 70);
            this.ideiaTitulo_lbl.Name = "ideiaTitulo_lbl";
            this.ideiaTitulo_lbl.Size = new System.Drawing.Size(113, 18);
            this.ideiaTitulo_lbl.TabIndex = 12;
            this.ideiaTitulo_lbl.Text = "Título da Ideia";
            this.ideiaTitulo_lbl.Click += new System.EventHandler(this.criar_lbl_Click);
            // 
            // top_pnl
            // 
            this.top_pnl.BackColor = System.Drawing.SystemColors.Highlight;
            this.top_pnl.Controls.Add(this.scoresNbr_lbl);
            this.top_pnl.Controls.Add(this.criadorIdeia_lbl);
            this.top_pnl.Controls.Add(this.ideiaScore_img);
            this.top_pnl.Controls.Add(this.criadorIdeiaPic_img);
            this.top_pnl.Location = new System.Drawing.Point(-1, -1);
            this.top_pnl.Name = "top_pnl";
            this.top_pnl.Size = new System.Drawing.Size(449, 55);
            this.top_pnl.TabIndex = 1;
            // 
            // scoresNbr_lbl
            // 
            this.scoresNbr_lbl.AutoSize = true;
            this.scoresNbr_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.scoresNbr_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoresNbr_lbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.scoresNbr_lbl.Location = new System.Drawing.Point(414, 19);
            this.scoresNbr_lbl.Name = "scoresNbr_lbl";
            this.scoresNbr_lbl.Size = new System.Drawing.Size(16, 17);
            this.scoresNbr_lbl.TabIndex = 14;
            this.scoresNbr_lbl.Text = "0";
            // 
            // criadorIdeia_lbl
            // 
            this.criadorIdeia_lbl.AutoSize = true;
            this.criadorIdeia_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.criadorIdeia_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criadorIdeia_lbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.criadorIdeia_lbl.Location = new System.Drawing.Point(44, 20);
            this.criadorIdeia_lbl.Name = "criadorIdeia_lbl";
            this.criadorIdeia_lbl.Size = new System.Drawing.Size(96, 13);
            this.criadorIdeia_lbl.TabIndex = 8;
            this.criadorIdeia_lbl.Text = "Nome do Utilizador";
            // 
            // comentarios_pnl
            // 
            this.comentarios_pnl.AutoScroll = true;
            this.comentarios_pnl.Location = new System.Drawing.Point(0, 226);
            this.comentarios_pnl.Name = "comentarios_pnl";
            this.comentarios_pnl.Size = new System.Drawing.Size(443, 170);
            this.comentarios_pnl.TabIndex = 1;
            // 
            // adicionarComentario_btn
            // 
            this.adicionarComentario_btn.BackgroundImage = global::ideial.Properties.Resources.plusLight;
            this.adicionarComentario_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adicionarComentario_btn.FlatAppearance.BorderSize = 0;
            this.adicionarComentario_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionarComentario_btn.Location = new System.Drawing.Point(342, 3);
            this.adicionarComentario_btn.Name = "adicionarComentario_btn";
            this.adicionarComentario_btn.Size = new System.Drawing.Size(29, 28);
            this.adicionarComentario_btn.TabIndex = 15;
            this.adicionarComentario_btn.UseVisualStyleBackColor = true;
            this.adicionarComentario_btn.Click += new System.EventHandler(this.adicionarComentario_btn_Click);
            // 
            // comment_img
            // 
            this.comment_img.Image = ((System.Drawing.Image)(resources.GetObject("comment_img.Image")));
            this.comment_img.Location = new System.Drawing.Point(378, 4);
            this.comment_img.Name = "comment_img";
            this.comment_img.Size = new System.Drawing.Size(30, 26);
            this.comment_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.comment_img.TabIndex = 0;
            this.comment_img.TabStop = false;
            // 
            // ideiaScore_img
            // 
            this.ideiaScore_img.Image = ((System.Drawing.Image)(resources.GetObject("ideiaScore_img.Image")));
            this.ideiaScore_img.Location = new System.Drawing.Point(382, 16);
            this.ideiaScore_img.Name = "ideiaScore_img";
            this.ideiaScore_img.Size = new System.Drawing.Size(26, 22);
            this.ideiaScore_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ideiaScore_img.TabIndex = 13;
            this.ideiaScore_img.TabStop = false;
            this.ideiaScore_img.Click += new System.EventHandler(this.ideiaScore_img_Click);
            // 
            // criadorIdeiaPic_img
            // 
            this.criadorIdeiaPic_img.Cursor = System.Windows.Forms.Cursors.Default;
            this.criadorIdeiaPic_img.Image = ((System.Drawing.Image)(resources.GetObject("criadorIdeiaPic_img.Image")));
            this.criadorIdeiaPic_img.Location = new System.Drawing.Point(9, 8);
            this.criadorIdeiaPic_img.Name = "criadorIdeiaPic_img";
            this.criadorIdeiaPic_img.Size = new System.Drawing.Size(29, 38);
            this.criadorIdeiaPic_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.criadorIdeiaPic_img.TabIndex = 7;
            this.criadorIdeiaPic_img.TabStop = false;
            // 
            // Ideia_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 396);
            this.Controls.Add(this.comentarios_pnl);
            this.Controls.Add(this.ideiasBG_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ideia_frm";
            this.Text = "Ideias";
            this.Load += new System.EventHandler(this.Ideia_frm_Load);
            this.ideiasBG_pnl.ResumeLayout(false);
            this.ideiasBG_pnl.PerformLayout();
            this.bottom_pnl.ResumeLayout(false);
            this.bottom_pnl.PerformLayout();
            this.top_pnl.ResumeLayout(false);
            this.top_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comment_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ideiaScore_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criadorIdeiaPic_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ideiasBG_pnl;
        private System.Windows.Forms.Panel top_pnl;
        private System.Windows.Forms.PictureBox criadorIdeiaPic_img;
        private System.Windows.Forms.Label criadorIdeia_lbl;
        private System.Windows.Forms.Label scoresNbr_lbl;
        private System.Windows.Forms.PictureBox ideiaScore_img;
        private System.Windows.Forms.Label ideiaTitulo_lbl;
        private System.Windows.Forms.Label ideiaConteudo_lbl;
        private System.Windows.Forms.Panel bottom_pnl;
        private System.Windows.Forms.Label commentsNbr_lbl;
        private System.Windows.Forms.PictureBox comment_img;

        public Ideia_frm()
        {
        }

        private System.Windows.Forms.Panel comentarios_pnl;
        private System.Windows.Forms.Button adicionarComentario_btn;
    }
}