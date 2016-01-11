namespace ideial.View
{
    partial class PerfilResumoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilResumoFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.numIdeias_lbl = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.idea_img = new System.Windows.Forms.PictureBox();
            this.rank_img = new System.Windows.Forms.PictureBox();
            this.tipoUtilizador_lbl = new System.Windows.Forms.Label();
            this.userPic_img = new System.Windows.Forms.PictureBox();
            this.userName_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idea_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rank_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPic_img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numIdeias_lbl);
            this.panel1.Controls.Add(this.score_lbl);
            this.panel1.Controls.Add(this.idea_img);
            this.panel1.Controls.Add(this.rank_img);
            this.panel1.Controls.Add(this.tipoUtilizador_lbl);
            this.panel1.Controls.Add(this.userPic_img);
            this.panel1.Controls.Add(this.userName_lbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 130);
            this.panel1.TabIndex = 0;
            // 
            // numIdeias_lbl
            // 
            this.numIdeias_lbl.AutoSize = true;
            this.numIdeias_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.numIdeias_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIdeias_lbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numIdeias_lbl.Location = new System.Drawing.Point(375, 80);
            this.numIdeias_lbl.Name = "numIdeias_lbl";
            this.numIdeias_lbl.Size = new System.Drawing.Size(20, 24);
            this.numIdeias_lbl.TabIndex = 22;
            this.numIdeias_lbl.Text = "0";
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.score_lbl.Location = new System.Drawing.Point(375, 30);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(20, 24);
            this.score_lbl.TabIndex = 21;
            this.score_lbl.Text = "0";
            // 
            // idea_img
            // 
            this.idea_img.Image = ((System.Drawing.Image)(resources.GetObject("idea_img.Image")));
            this.idea_img.Location = new System.Drawing.Point(313, 71);
            this.idea_img.Name = "idea_img";
            this.idea_img.Size = new System.Drawing.Size(31, 44);
            this.idea_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.idea_img.TabIndex = 20;
            this.idea_img.TabStop = false;
            // 
            // rank_img
            // 
            this.rank_img.Image = global::ideial.Properties.Resources.silverBadge1;
            this.rank_img.Location = new System.Drawing.Point(301, 20);
            this.rank_img.Name = "rank_img";
            this.rank_img.Size = new System.Drawing.Size(57, 45);
            this.rank_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rank_img.TabIndex = 18;
            this.rank_img.TabStop = false;
            // 
            // tipoUtilizador_lbl
            // 
            this.tipoUtilizador_lbl.AutoSize = true;
            this.tipoUtilizador_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.tipoUtilizador_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoUtilizador_lbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tipoUtilizador_lbl.Location = new System.Drawing.Point(112, 75);
            this.tipoUtilizador_lbl.Name = "tipoUtilizador_lbl";
            this.tipoUtilizador_lbl.Size = new System.Drawing.Size(109, 20);
            this.tipoUtilizador_lbl.TabIndex = 19;
            this.tipoUtilizador_lbl.Text = "Tipo Utilizador";
            // 
            // userPic_img
            // 
            this.userPic_img.Cursor = System.Windows.Forms.Cursors.Default;
            this.userPic_img.Image = ((System.Drawing.Image)(resources.GetObject("userPic_img.Image")));
            this.userPic_img.Location = new System.Drawing.Point(19, 20);
            this.userPic_img.Name = "userPic_img";
            this.userPic_img.Size = new System.Drawing.Size(77, 95);
            this.userPic_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPic_img.TabIndex = 17;
            this.userPic_img.TabStop = false;
            this.userPic_img.Click += new System.EventHandler(this.userPic_img_Click);
            // 
            // userName_lbl
            // 
            this.userName_lbl.AutoSize = true;
            this.userName_lbl.BackColor = System.Drawing.SystemColors.Highlight;
            this.userName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_lbl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userName_lbl.Location = new System.Drawing.Point(111, 39);
            this.userName_lbl.Name = "userName_lbl";
            this.userName_lbl.Size = new System.Drawing.Size(103, 26);
            this.userName_lbl.TabIndex = 16;
            this.userName_lbl.Text = "Utilizador";
            // 
            // PerfilResumoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 131);
            this.Controls.Add(this.panel1);
            this.Name = "PerfilResumoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "perfilResumo_frm";
            this.Load += new System.EventHandler(this.perfilResumo_frm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idea_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rank_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPic_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label numIdeias_lbl;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.PictureBox idea_img;
        private System.Windows.Forms.PictureBox rank_img;
        private System.Windows.Forms.Label tipoUtilizador_lbl;
        private System.Windows.Forms.PictureBox userPic_img;
        private System.Windows.Forms.Label userName_lbl;
    }
}