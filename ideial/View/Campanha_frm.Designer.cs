namespace ideial.View
{
    partial class Campanha_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Campanha_frm));
            this.campanhaBG_pnl = new System.Windows.Forms.Panel();
            this.bottom_pnl = new System.Windows.Forms.Panel();
            this.adicionarIdeia_btn = new System.Windows.Forms.Button();
            this.camp_commentsNbr_lbl = new System.Windows.Forms.Label();
            this.comment_img = new System.Windows.Forms.PictureBox();
            this.ideiaConteudo_lbl = new System.Windows.Forms.Label();
            this.ideiaTitulo_lbl = new System.Windows.Forms.Label();
            this.top_pnl = new System.Windows.Forms.Panel();
            this.ideiasNbr_lbl = new System.Windows.Forms.Label();
            this.criadorCampanha_lbl = new System.Windows.Forms.Label();
            this.ideias_img = new System.Windows.Forms.PictureBox();
            this.criadorCampanhaPic_img = new System.Windows.Forms.PictureBox();
            this.campanhaBG_pnl.SuspendLayout();
            this.bottom_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comment_img)).BeginInit();
            this.top_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ideias_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criadorCampanhaPic_img)).BeginInit();
            this.SuspendLayout();
            // 
            // campanhaBG_pnl
            // 
            this.campanhaBG_pnl.BackColor = System.Drawing.SystemColors.Highlight;
            this.campanhaBG_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campanhaBG_pnl.Controls.Add(this.bottom_pnl);
            this.campanhaBG_pnl.Controls.Add(this.ideiaConteudo_lbl);
            this.campanhaBG_pnl.Controls.Add(this.ideiaTitulo_lbl);
            this.campanhaBG_pnl.Controls.Add(this.top_pnl);
            this.campanhaBG_pnl.Location = new System.Drawing.Point(2, -1);
            this.campanhaBG_pnl.Name = "campanhaBG_pnl";
            this.campanhaBG_pnl.Size = new System.Drawing.Size(483, 282);
            this.campanhaBG_pnl.TabIndex = 1;
            // 
            // bottom_pnl
            // 
            this.bottom_pnl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bottom_pnl.Controls.Add(this.adicionarIdeia_btn);
            this.bottom_pnl.Controls.Add(this.camp_commentsNbr_lbl);
            this.bottom_pnl.Controls.Add(this.comment_img);
            this.bottom_pnl.Location = new System.Drawing.Point(-1, 245);
            this.bottom_pnl.Name = "bottom_pnl";
            this.bottom_pnl.Size = new System.Drawing.Size(482, 36);
            this.bottom_pnl.TabIndex = 15;
            // 
            // adicionarIdeia_btn
            // 
            this.adicionarIdeia_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adicionarIdeia_btn.BackgroundImage")));
            this.adicionarIdeia_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adicionarIdeia_btn.FlatAppearance.BorderSize = 0;
            this.adicionarIdeia_btn.Location = new System.Drawing.Point(9, 4);
            this.adicionarIdeia_btn.Name = "adicionarIdeia_btn";
            this.adicionarIdeia_btn.Size = new System.Drawing.Size(29, 28);
            this.adicionarIdeia_btn.TabIndex = 8;
            this.adicionarIdeia_btn.UseVisualStyleBackColor = true;
            this.adicionarIdeia_btn.Click += new System.EventHandler(this.adicionarIdeia_btn_Click);
            // 
            // camp_commentsNbr_lbl
            // 
            this.camp_commentsNbr_lbl.AutoSize = true;
            this.camp_commentsNbr_lbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.camp_commentsNbr_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camp_commentsNbr_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.camp_commentsNbr_lbl.Location = new System.Drawing.Point(444, 10);
            this.camp_commentsNbr_lbl.Name = "camp_commentsNbr_lbl";
            this.camp_commentsNbr_lbl.Size = new System.Drawing.Size(16, 17);
            this.camp_commentsNbr_lbl.TabIndex = 15;
            this.camp_commentsNbr_lbl.Text = "0";
            // 
            // comment_img
            // 
            this.comment_img.Image = ((System.Drawing.Image)(resources.GetObject("comment_img.Image")));
            this.comment_img.Location = new System.Drawing.Point(408, 4);
            this.comment_img.Name = "comment_img";
            this.comment_img.Size = new System.Drawing.Size(30, 26);
            this.comment_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.comment_img.TabIndex = 0;
            this.comment_img.TabStop = false;
            // 
            // ideiaConteudo_lbl
            // 
            this.ideiaConteudo_lbl.AutoSize = true;
            this.ideiaConteudo_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.ideiaConteudo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ideiaConteudo_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ideiaConteudo_lbl.Location = new System.Drawing.Point(41, 97);
            this.ideiaConteudo_lbl.MaximumSize = new System.Drawing.Size(400, 140);
            this.ideiaConteudo_lbl.Name = "ideiaConteudo_lbl";
            this.ideiaConteudo_lbl.Size = new System.Drawing.Size(400, 136);
            this.ideiaConteudo_lbl.TabIndex = 13;
            this.ideiaConteudo_lbl.Text = resources.GetString("ideiaConteudo_lbl.Text");
            // 
            // ideiaTitulo_lbl
            // 
            this.ideiaTitulo_lbl.AutoSize = true;
            this.ideiaTitulo_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.ideiaTitulo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ideiaTitulo_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ideiaTitulo_lbl.Location = new System.Drawing.Point(41, 70);
            this.ideiaTitulo_lbl.Name = "ideiaTitulo_lbl";
            this.ideiaTitulo_lbl.Size = new System.Drawing.Size(158, 18);
            this.ideiaTitulo_lbl.TabIndex = 12;
            this.ideiaTitulo_lbl.Text = "Título da Campanha";
            // 
            // top_pnl
            // 
            this.top_pnl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.top_pnl.Controls.Add(this.ideiasNbr_lbl);
            this.top_pnl.Controls.Add(this.criadorCampanha_lbl);
            this.top_pnl.Controls.Add(this.ideias_img);
            this.top_pnl.Controls.Add(this.criadorCampanhaPic_img);
            this.top_pnl.Location = new System.Drawing.Point(-1, -1);
            this.top_pnl.Name = "top_pnl";
            this.top_pnl.Size = new System.Drawing.Size(482, 56);
            this.top_pnl.TabIndex = 1;
            // 
            // ideiasNbr_lbl
            // 
            this.ideiasNbr_lbl.AutoSize = true;
            this.ideiasNbr_lbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ideiasNbr_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ideiasNbr_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ideiasNbr_lbl.Location = new System.Drawing.Point(444, 19);
            this.ideiasNbr_lbl.Name = "ideiasNbr_lbl";
            this.ideiasNbr_lbl.Size = new System.Drawing.Size(16, 17);
            this.ideiasNbr_lbl.TabIndex = 14;
            this.ideiasNbr_lbl.Text = "0";
            // 
            // criadorCampanha_lbl
            // 
            this.criadorCampanha_lbl.AutoSize = true;
            this.criadorCampanha_lbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.criadorCampanha_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criadorCampanha_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.criadorCampanha_lbl.Location = new System.Drawing.Point(44, 20);
            this.criadorCampanha_lbl.Name = "criadorCampanha_lbl";
            this.criadorCampanha_lbl.Size = new System.Drawing.Size(96, 13);
            this.criadorCampanha_lbl.TabIndex = 8;
            this.criadorCampanha_lbl.Text = "Nome do Utilizador";
            // 
            // ideias_img
            // 
            this.ideias_img.Image = ((System.Drawing.Image)(resources.GetObject("ideias_img.Image")));
            this.ideias_img.Location = new System.Drawing.Point(412, 17);
            this.ideias_img.Name = "ideias_img";
            this.ideias_img.Size = new System.Drawing.Size(26, 22);
            this.ideias_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ideias_img.TabIndex = 13;
            this.ideias_img.TabStop = false;
            // 
            // criadorCampanhaPic_img
            // 
            this.criadorCampanhaPic_img.Cursor = System.Windows.Forms.Cursors.Default;
            this.criadorCampanhaPic_img.Image = ((System.Drawing.Image)(resources.GetObject("criadorCampanhaPic_img.Image")));
            this.criadorCampanhaPic_img.Location = new System.Drawing.Point(9, 8);
            this.criadorCampanhaPic_img.Name = "criadorCampanhaPic_img";
            this.criadorCampanhaPic_img.Size = new System.Drawing.Size(29, 38);
            this.criadorCampanhaPic_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.criadorCampanhaPic_img.TabIndex = 7;
            this.criadorCampanhaPic_img.TabStop = false;
            // 
            // Campanha_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 281);
            this.Controls.Add(this.campanhaBG_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Campanha_frm";
            this.Text = "Campanha";
            this.Load += new System.EventHandler(this.Campanha_Load);
            this.campanhaBG_pnl.ResumeLayout(false);
            this.campanhaBG_pnl.PerformLayout();
            this.bottom_pnl.ResumeLayout(false);
            this.bottom_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comment_img)).EndInit();
            this.top_pnl.ResumeLayout(false);
            this.top_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ideias_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criadorCampanhaPic_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel campanhaBG_pnl;
        private System.Windows.Forms.Panel bottom_pnl;
        private System.Windows.Forms.Label camp_commentsNbr_lbl;
        private System.Windows.Forms.PictureBox comment_img;
        private System.Windows.Forms.Label ideiaConteudo_lbl;
        private System.Windows.Forms.Label ideiaTitulo_lbl;
        private System.Windows.Forms.Panel top_pnl;
        private System.Windows.Forms.Label ideiasNbr_lbl;
        private System.Windows.Forms.Label criadorCampanha_lbl;
        private System.Windows.Forms.PictureBox ideias_img;
        private System.Windows.Forms.PictureBox criadorCampanhaPic_img;
        private System.Windows.Forms.Button adicionarIdeia_btn;
    }
}