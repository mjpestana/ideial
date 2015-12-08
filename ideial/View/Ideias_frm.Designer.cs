namespace DISgrupo1.Ideial.View
{
    partial class Ideias_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ideias_frm));
            this.ideiasBG_pnl = new System.Windows.Forms.Panel();
            this.top_pnl = new System.Windows.Forms.Panel();
            this.userPic_img = new System.Windows.Forms.PictureBox();
            this.userName_lbl = new System.Windows.Forms.Label();
            this.scoresNbr_lbl = new System.Windows.Forms.Label();
            this.star5_img = new System.Windows.Forms.PictureBox();
            this.ideiaTitulo_lbl = new System.Windows.Forms.Label();
            this.ideiaConteudo_lbl = new System.Windows.Forms.Label();
            this.bottom_pnl = new System.Windows.Forms.Panel();
            this.comment_img = new System.Windows.Forms.PictureBox();
            this.commentsNbr_lbl = new System.Windows.Forms.Label();
            this.star4_img = new System.Windows.Forms.PictureBox();
            this.star3_img = new System.Windows.Forms.PictureBox();
            this.star2_img = new System.Windows.Forms.PictureBox();
            this.star1_img = new System.Windows.Forms.PictureBox();
            this.subscription_img = new System.Windows.Forms.PictureBox();
            this.subscriptionsNbr_lbl = new System.Windows.Forms.Label();
            this.ideiasBG_pnl.SuspendLayout();
            this.top_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPic_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star5_img)).BeginInit();
            this.bottom_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comment_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscription_img)).BeginInit();
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
            this.ideiasBG_pnl.Size = new System.Drawing.Size(474, 282);
            this.ideiasBG_pnl.TabIndex = 0;
            this.ideiasBG_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // top_pnl
            // 
            this.top_pnl.BackColor = System.Drawing.SystemColors.Highlight;
            this.top_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.top_pnl.Controls.Add(this.star1_img);
            this.top_pnl.Controls.Add(this.star2_img);
            this.top_pnl.Controls.Add(this.star3_img);
            this.top_pnl.Controls.Add(this.star4_img);
            this.top_pnl.Controls.Add(this.scoresNbr_lbl);
            this.top_pnl.Controls.Add(this.userName_lbl);
            this.top_pnl.Controls.Add(this.star5_img);
            this.top_pnl.Controls.Add(this.userPic_img);
            this.top_pnl.Location = new System.Drawing.Point(-1, -1);
            this.top_pnl.Name = "top_pnl";
            this.top_pnl.Size = new System.Drawing.Size(474, 55);
            this.top_pnl.TabIndex = 1;
            // 
            // userPic_img
            // 
            this.userPic_img.Cursor = System.Windows.Forms.Cursors.Default;
            this.userPic_img.Image = ((System.Drawing.Image)(resources.GetObject("userPic_img.Image")));
            this.userPic_img.Location = new System.Drawing.Point(9, 8);
            this.userPic_img.Name = "userPic_img";
            this.userPic_img.Size = new System.Drawing.Size(29, 38);
            this.userPic_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPic_img.TabIndex = 7;
            this.userPic_img.TabStop = false;
            // 
            // userName_lbl
            // 
            this.userName_lbl.AutoSize = true;
            this.userName_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.userName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_lbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userName_lbl.Location = new System.Drawing.Point(44, 20);
            this.userName_lbl.Name = "userName_lbl";
            this.userName_lbl.Size = new System.Drawing.Size(96, 13);
            this.userName_lbl.TabIndex = 8;
            this.userName_lbl.Text = "Nome do Utilizador";
            // 
            // scoresNbr_lbl
            // 
            this.scoresNbr_lbl.AutoSize = true;
            this.scoresNbr_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.scoresNbr_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoresNbr_lbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.scoresNbr_lbl.Location = new System.Drawing.Point(444, 19);
            this.scoresNbr_lbl.Name = "scoresNbr_lbl";
            this.scoresNbr_lbl.Size = new System.Drawing.Size(16, 17);
            this.scoresNbr_lbl.TabIndex = 14;
            this.scoresNbr_lbl.Text = "0";
            // 
            // star5_img
            // 
            this.star5_img.Image = ((System.Drawing.Image)(resources.GetObject("star5_img.Image")));
            this.star5_img.Location = new System.Drawing.Point(412, 17);
            this.star5_img.Name = "star5_img";
            this.star5_img.Size = new System.Drawing.Size(26, 22);
            this.star5_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star5_img.TabIndex = 13;
            this.star5_img.TabStop = false;
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
            // ideiaConteudo_lbl
            // 
            this.ideiaConteudo_lbl.AutoSize = true;
            this.ideiaConteudo_lbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ideiaConteudo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ideiaConteudo_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ideiaConteudo_lbl.Location = new System.Drawing.Point(41, 97);
            this.ideiaConteudo_lbl.MaximumSize = new System.Drawing.Size(400, 140);
            this.ideiaConteudo_lbl.Name = "ideiaConteudo_lbl";
            this.ideiaConteudo_lbl.Size = new System.Drawing.Size(400, 136);
            this.ideiaConteudo_lbl.TabIndex = 13;
            this.ideiaConteudo_lbl.Text = resources.GetString("ideiaConteudo_lbl.Text");
            this.ideiaConteudo_lbl.Click += new System.EventHandler(this.ideiaConteudo_lbl_Click);
            // 
            // bottom_pnl
            // 
            this.bottom_pnl.BackColor = System.Drawing.SystemColors.Highlight;
            this.bottom_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottom_pnl.Controls.Add(this.subscriptionsNbr_lbl);
            this.bottom_pnl.Controls.Add(this.subscription_img);
            this.bottom_pnl.Controls.Add(this.commentsNbr_lbl);
            this.bottom_pnl.Controls.Add(this.comment_img);
            this.bottom_pnl.Location = new System.Drawing.Point(-1, 244);
            this.bottom_pnl.Name = "bottom_pnl";
            this.bottom_pnl.Size = new System.Drawing.Size(474, 36);
            this.bottom_pnl.TabIndex = 15;
            // 
            // comment_img
            // 
            this.comment_img.Image = ((System.Drawing.Image)(resources.GetObject("comment_img.Image")));
            this.comment_img.Location = new System.Drawing.Point(408, 5);
            this.comment_img.Name = "comment_img";
            this.comment_img.Size = new System.Drawing.Size(30, 26);
            this.comment_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.comment_img.TabIndex = 0;
            this.comment_img.TabStop = false;
            // 
            // commentsNbr_lbl
            // 
            this.commentsNbr_lbl.AutoSize = true;
            this.commentsNbr_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.commentsNbr_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsNbr_lbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.commentsNbr_lbl.Location = new System.Drawing.Point(444, 9);
            this.commentsNbr_lbl.Name = "commentsNbr_lbl";
            this.commentsNbr_lbl.Size = new System.Drawing.Size(16, 17);
            this.commentsNbr_lbl.TabIndex = 15;
            this.commentsNbr_lbl.Text = "0";
            // 
            // star4_img
            // 
            this.star4_img.Image = ((System.Drawing.Image)(resources.GetObject("star4_img.Image")));
            this.star4_img.Location = new System.Drawing.Point(380, 17);
            this.star4_img.Name = "star4_img";
            this.star4_img.Size = new System.Drawing.Size(26, 22);
            this.star4_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star4_img.TabIndex = 15;
            this.star4_img.TabStop = false;
            // 
            // star3_img
            // 
            this.star3_img.Image = ((System.Drawing.Image)(resources.GetObject("star3_img.Image")));
            this.star3_img.Location = new System.Drawing.Point(348, 17);
            this.star3_img.Name = "star3_img";
            this.star3_img.Size = new System.Drawing.Size(26, 22);
            this.star3_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star3_img.TabIndex = 16;
            this.star3_img.TabStop = false;
            // 
            // star2_img
            // 
            this.star2_img.Image = ((System.Drawing.Image)(resources.GetObject("star2_img.Image")));
            this.star2_img.Location = new System.Drawing.Point(316, 17);
            this.star2_img.Name = "star2_img";
            this.star2_img.Size = new System.Drawing.Size(26, 22);
            this.star2_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star2_img.TabIndex = 17;
            this.star2_img.TabStop = false;
            // 
            // star1_img
            // 
            this.star1_img.Image = ((System.Drawing.Image)(resources.GetObject("star1_img.Image")));
            this.star1_img.Location = new System.Drawing.Point(284, 17);
            this.star1_img.Name = "star1_img";
            this.star1_img.Size = new System.Drawing.Size(26, 22);
            this.star1_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star1_img.TabIndex = 18;
            this.star1_img.TabStop = false;
            // 
            // subscription_img
            // 
            this.subscription_img.Image = ((System.Drawing.Image)(resources.GetObject("subscription_img.Image")));
            this.subscription_img.Location = new System.Drawing.Point(11, 3);
            this.subscription_img.Name = "subscription_img";
            this.subscription_img.Size = new System.Drawing.Size(30, 26);
            this.subscription_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.subscription_img.TabIndex = 16;
            this.subscription_img.TabStop = false;
            // 
            // subscriptionsNbr_lbl
            // 
            this.subscriptionsNbr_lbl.AutoSize = true;
            this.subscriptionsNbr_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.subscriptionsNbr_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriptionsNbr_lbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.subscriptionsNbr_lbl.Location = new System.Drawing.Point(47, 9);
            this.subscriptionsNbr_lbl.Name = "subscriptionsNbr_lbl";
            this.subscriptionsNbr_lbl.Size = new System.Drawing.Size(16, 17);
            this.subscriptionsNbr_lbl.TabIndex = 17;
            this.subscriptionsNbr_lbl.Text = "0";
            // 
            // Ideias_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(474, 281);
            this.Controls.Add(this.ideiasBG_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ideias_frm";
            this.Text = "Ideias";
            this.ideiasBG_pnl.ResumeLayout(false);
            this.ideiasBG_pnl.PerformLayout();
            this.top_pnl.ResumeLayout(false);
            this.top_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPic_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star5_img)).EndInit();
            this.bottom_pnl.ResumeLayout(false);
            this.bottom_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comment_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscription_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ideiasBG_pnl;
        private System.Windows.Forms.Panel top_pnl;
        private System.Windows.Forms.PictureBox userPic_img;
        private System.Windows.Forms.Label userName_lbl;
        private System.Windows.Forms.Label scoresNbr_lbl;
        private System.Windows.Forms.PictureBox star5_img;
        private System.Windows.Forms.Label ideiaTitulo_lbl;
        private System.Windows.Forms.Label ideiaConteudo_lbl;
        private System.Windows.Forms.Panel bottom_pnl;
        private System.Windows.Forms.Label commentsNbr_lbl;
        private System.Windows.Forms.PictureBox comment_img;
        private System.Windows.Forms.PictureBox star1_img;
        private System.Windows.Forms.PictureBox star2_img;
        private System.Windows.Forms.PictureBox star3_img;
        private System.Windows.Forms.PictureBox star4_img;
        private System.Windows.Forms.Label subscriptionsNbr_lbl;
        private System.Windows.Forms.PictureBox subscription_img;
    }
}