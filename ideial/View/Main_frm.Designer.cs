namespace DISgrupo1.Ideial.View
{
    partial class Main_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_frm));
            this.campanhas_btn = new System.Windows.Forms.Button();
            this.userName_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sair_btn = new System.Windows.Forms.Button();
            this.numIdeias_lbl = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.idea_img = new System.Windows.Forms.PictureBox();
            this.star_img = new System.Windows.Forms.PictureBox();
            this.utilizadores_btn = new System.Windows.Forms.Button();
            this.favoritos_btn = new System.Windows.Forms.Button();
            this.ideias_btn = new System.Windows.Forms.Button();
            this.Cargo_lbl = new System.Windows.Forms.Label();
            this.userPic_img = new System.Windows.Forms.PictureBox();
            this.Subsc_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.criar_btn = new System.Windows.Forms.Button();
            this.criar_lbl = new System.Windows.Forms.Label();
            this.panel_conteudo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idea_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPic_img)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // campanhas_btn
            // 
            this.campanhas_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.campanhas_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.campanhas_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.campanhas_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.campanhas_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campanhas_btn.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.campanhas_btn.Location = new System.Drawing.Point(0, 216);
            this.campanhas_btn.Name = "campanhas_btn";
            this.campanhas_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.campanhas_btn.Size = new System.Drawing.Size(231, 38);
            this.campanhas_btn.TabIndex = 0;
            this.campanhas_btn.Text = "Campanhas";
            this.campanhas_btn.UseVisualStyleBackColor = false;
            // 
            // userName_lbl
            // 
            this.userName_lbl.AutoSize = true;
            this.userName_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.userName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_lbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userName_lbl.Location = new System.Drawing.Point(61, 23);
            this.userName_lbl.Name = "userName_lbl";
            this.userName_lbl.Size = new System.Drawing.Size(128, 17);
            this.userName_lbl.TabIndex = 3;
            this.userName_lbl.Text = "Nome do Utilizador";
            this.userName_lbl.Click += new System.EventHandler(this.userName_lbl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.sair_btn);
            this.panel1.Controls.Add(this.numIdeias_lbl);
            this.panel1.Controls.Add(this.score_lbl);
            this.panel1.Controls.Add(this.idea_img);
            this.panel1.Controls.Add(this.star_img);
            this.panel1.Controls.Add(this.utilizadores_btn);
            this.panel1.Controls.Add(this.favoritos_btn);
            this.panel1.Controls.Add(this.ideias_btn);
            this.panel1.Controls.Add(this.Cargo_lbl);
            this.panel1.Controls.Add(this.userPic_img);
            this.panel1.Controls.Add(this.Subsc_btn);
            this.panel1.Controls.Add(this.campanhas_btn);
            this.panel1.Controls.Add(this.userName_lbl);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 461);
            this.panel1.TabIndex = 5;
            // 
            // sair_btn
            // 
            this.sair_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.sair_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sair_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sair_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sair_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair_btn.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.sair_btn.Location = new System.Drawing.Point(0, 422);
            this.sair_btn.Name = "sair_btn";
            this.sair_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sair_btn.Size = new System.Drawing.Size(231, 38);
            this.sair_btn.TabIndex = 14;
            this.sair_btn.Text = "Sair";
            this.sair_btn.UseVisualStyleBackColor = false;
            this.sair_btn.Click += new System.EventHandler(this.sair_btn_Click);
            // 
            // numIdeias_lbl
            // 
            this.numIdeias_lbl.AutoSize = true;
            this.numIdeias_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.numIdeias_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIdeias_lbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numIdeias_lbl.Location = new System.Drawing.Point(128, 73);
            this.numIdeias_lbl.Name = "numIdeias_lbl";
            this.numIdeias_lbl.Size = new System.Drawing.Size(16, 17);
            this.numIdeias_lbl.TabIndex = 13;
            this.numIdeias_lbl.Text = "0";
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.score_lbl.Location = new System.Drawing.Point(43, 73);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(16, 17);
            this.score_lbl.TabIndex = 12;
            this.score_lbl.Text = "0";
            // 
            // idea_img
            // 
            this.idea_img.Image = ((System.Drawing.Image)(resources.GetObject("idea_img.Image")));
            this.idea_img.Location = new System.Drawing.Point(96, 71);
            this.idea_img.Name = "idea_img";
            this.idea_img.Size = new System.Drawing.Size(26, 22);
            this.idea_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.idea_img.TabIndex = 11;
            this.idea_img.TabStop = false;
            // 
            // star_img
            // 
            this.star_img.Image = ((System.Drawing.Image)(resources.GetObject("star_img.Image")));
            this.star_img.Location = new System.Drawing.Point(11, 71);
            this.star_img.Name = "star_img";
            this.star_img.Size = new System.Drawing.Size(26, 22);
            this.star_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star_img.TabIndex = 7;
            this.star_img.TabStop = false;
            // 
            // utilizadores_btn
            // 
            this.utilizadores_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.utilizadores_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.utilizadores_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.utilizadores_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.utilizadores_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilizadores_btn.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.utilizadores_btn.Location = new System.Drawing.Point(0, 380);
            this.utilizadores_btn.Name = "utilizadores_btn";
            this.utilizadores_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.utilizadores_btn.Size = new System.Drawing.Size(231, 38);
            this.utilizadores_btn.TabIndex = 10;
            this.utilizadores_btn.Text = "Utilizadores";
            this.utilizadores_btn.UseVisualStyleBackColor = false;
            this.utilizadores_btn.Click += new System.EventHandler(this.utilizadores_btn_Click);
            // 
            // favoritos_btn
            // 
            this.favoritos_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.favoritos_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.favoritos_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.favoritos_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favoritos_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favoritos_btn.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.favoritos_btn.Location = new System.Drawing.Point(0, 298);
            this.favoritos_btn.Name = "favoritos_btn";
            this.favoritos_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.favoritos_btn.Size = new System.Drawing.Size(231, 38);
            this.favoritos_btn.TabIndex = 9;
            this.favoritos_btn.Text = "Favoritos";
            this.favoritos_btn.UseVisualStyleBackColor = false;
            // 
            // ideias_btn
            // 
            this.ideias_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.ideias_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ideias_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ideias_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ideias_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ideias_btn.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ideias_btn.Location = new System.Drawing.Point(0, 257);
            this.ideias_btn.Name = "ideias_btn";
            this.ideias_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ideias_btn.Size = new System.Drawing.Size(231, 38);
            this.ideias_btn.TabIndex = 8;
            this.ideias_btn.Text = "Ideias";
            this.ideias_btn.UseVisualStyleBackColor = false;
            this.ideias_btn.Click += new System.EventHandler(this.ideias_btn_Click);
            // 
            // Cargo_lbl
            // 
            this.Cargo_lbl.AutoSize = true;
            this.Cargo_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.Cargo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cargo_lbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Cargo_lbl.Location = new System.Drawing.Point(61, 41);
            this.Cargo_lbl.Name = "Cargo_lbl";
            this.Cargo_lbl.Size = new System.Drawing.Size(35, 13);
            this.Cargo_lbl.TabIndex = 7;
            this.Cargo_lbl.Text = "Cargo";
            // 
            // userPic_img
            // 
            this.userPic_img.Cursor = System.Windows.Forms.Cursors.Default;
            this.userPic_img.Image = ((System.Drawing.Image)(resources.GetObject("userPic_img.Image")));
            this.userPic_img.Location = new System.Drawing.Point(11, 12);
            this.userPic_img.Name = "userPic_img";
            this.userPic_img.Size = new System.Drawing.Size(44, 53);
            this.userPic_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPic_img.TabIndex = 6;
            this.userPic_img.TabStop = false;
            // 
            // Subsc_btn
            // 
            this.Subsc_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Subsc_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Subsc_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Subsc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subsc_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subsc_btn.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Subsc_btn.Location = new System.Drawing.Point(0, 338);
            this.Subsc_btn.Name = "Subsc_btn";
            this.Subsc_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Subsc_btn.Size = new System.Drawing.Size(231, 38);
            this.Subsc_btn.TabIndex = 4;
            this.Subsc_btn.Text = "Subscrições";
            this.Subsc_btn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.criar_btn);
            this.panel2.Controls.Add(this.criar_lbl);
            this.panel2.Location = new System.Drawing.Point(1, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 111);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(21, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Criar Campanha";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(162, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 42);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // criar_btn
            // 
            this.criar_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("criar_btn.BackgroundImage")));
            this.criar_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.criar_btn.FlatAppearance.BorderSize = 0;
            this.criar_btn.Location = new System.Drawing.Point(162, 12);
            this.criar_btn.Name = "criar_btn";
            this.criar_btn.Size = new System.Drawing.Size(42, 42);
            this.criar_btn.TabIndex = 7;
            this.criar_btn.UseVisualStyleBackColor = true;
            // 
            // criar_lbl
            // 
            this.criar_lbl.AutoSize = true;
            this.criar_lbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.criar_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criar_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.criar_lbl.Location = new System.Drawing.Point(66, 23);
            this.criar_lbl.Name = "criar_lbl";
            this.criar_lbl.Size = new System.Drawing.Size(85, 18);
            this.criar_lbl.TabIndex = 11;
            this.criar_lbl.Text = "Criar Ideia";
            // 
            // panel_conteudo
            // 
            this.panel_conteudo.Location = new System.Drawing.Point(254, 0);
            this.panel_conteudo.Name = "panel_conteudo";
            this.panel_conteudo.Size = new System.Drawing.Size(530, 460);
            this.panel_conteudo.TabIndex = 7;
            // 
            // Main_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel_conteudo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ideial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_frm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idea_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPic_img)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button campanhas_btn;
        private System.Windows.Forms.Label userName_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Subsc_btn;
        private System.Windows.Forms.Label Cargo_lbl;
        private System.Windows.Forms.PictureBox userPic_img;
        private System.Windows.Forms.Button ideias_btn;
        private System.Windows.Forms.Button favoritos_btn;
        private System.Windows.Forms.Button utilizadores_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label criar_lbl;
        private System.Windows.Forms.Button criar_btn;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.PictureBox idea_img;
        private System.Windows.Forms.PictureBox star_img;
        private System.Windows.Forms.Label numIdeias_lbl;
        private System.Windows.Forms.Panel panel_conteudo;
        private System.Windows.Forms.Button sair_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

