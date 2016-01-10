namespace ideial.View
{
    partial class CriarIdeia_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarIdeia_frm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nomeCampanha_lbl = new System.Windows.Forms.Label();
            this.nomeUtilizador_lbl = new System.Windows.Forms.Label();
            this.data_lbl = new System.Windows.Forms.Label();
            this.estadoIdeia_cmb = new System.Windows.Forms.ComboBox();
            this.titulo_txt = new System.Windows.Forms.TextBox();
            this.descricao_txt = new System.Windows.Forms.TextBox();
            this.tags_txt = new System.Windows.Forms.TextBox();
            this.criarIdeia_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(74, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(46, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(82, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tags";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(5, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado da Ideia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(39, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Campanha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(51, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Utilizador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(77, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data";
            // 
            // nomeCampanha_lbl
            // 
            this.nomeCampanha_lbl.AutoSize = true;
            this.nomeCampanha_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCampanha_lbl.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nomeCampanha_lbl.Location = new System.Drawing.Point(155, 228);
            this.nomeCampanha_lbl.MaximumSize = new System.Drawing.Size(266, 40);
            this.nomeCampanha_lbl.Name = "nomeCampanha_lbl";
            this.nomeCampanha_lbl.Size = new System.Drawing.Size(218, 40);
            this.nomeCampanha_lbl.TabIndex = 7;
            this.nomeCampanha_lbl.Text = "A Ideia não está associada a nenhuma Campanha";
            this.nomeCampanha_lbl.Click += new System.EventHandler(this.nomeCampanha_lbl_Click);
            // 
            // nomeUtilizador_lbl
            // 
            this.nomeUtilizador_lbl.AutoSize = true;
            this.nomeUtilizador_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeUtilizador_lbl.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nomeUtilizador_lbl.Location = new System.Drawing.Point(155, 285);
            this.nomeUtilizador_lbl.Name = "nomeUtilizador_lbl";
            this.nomeUtilizador_lbl.Size = new System.Drawing.Size(121, 20);
            this.nomeUtilizador_lbl.TabIndex = 8;
            this.nomeUtilizador_lbl.Text = "Nome Utilizador";
            // 
            // data_lbl
            // 
            this.data_lbl.AutoSize = true;
            this.data_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_lbl.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.data_lbl.Location = new System.Drawing.Point(155, 327);
            this.data_lbl.Name = "data_lbl";
            this.data_lbl.Size = new System.Drawing.Size(44, 20);
            this.data_lbl.TabIndex = 9;
            this.data_lbl.Text = "Data";
            // 
            // estadoIdeia_cmb
            // 
            this.estadoIdeia_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoIdeia_cmb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.estadoIdeia_cmb.FormattingEnabled = true;
            this.estadoIdeia_cmb.Location = new System.Drawing.Point(155, 186);
            this.estadoIdeia_cmb.Name = "estadoIdeia_cmb";
            this.estadoIdeia_cmb.Size = new System.Drawing.Size(121, 28);
            this.estadoIdeia_cmb.TabIndex = 10;
            // 
            // titulo_txt
            // 
            this.titulo_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_txt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.titulo_txt.Location = new System.Drawing.Point(155, 19);
            this.titulo_txt.Name = "titulo_txt";
            this.titulo_txt.Size = new System.Drawing.Size(266, 26);
            this.titulo_txt.TabIndex = 11;
            // 
            // descricao_txt
            // 
            this.descricao_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao_txt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.descricao_txt.Location = new System.Drawing.Point(155, 59);
            this.descricao_txt.Multiline = true;
            this.descricao_txt.Name = "descricao_txt";
            this.descricao_txt.Size = new System.Drawing.Size(266, 73);
            this.descricao_txt.TabIndex = 12;
            // 
            // tags_txt
            // 
            this.tags_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tags_txt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tags_txt.Location = new System.Drawing.Point(155, 144);
            this.tags_txt.Name = "tags_txt";
            this.tags_txt.Size = new System.Drawing.Size(266, 26);
            this.tags_txt.TabIndex = 13;
            // 
            // criarIdeia_btn
            // 
            this.criarIdeia_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.criarIdeia_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criarIdeia_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.criarIdeia_btn.Location = new System.Drawing.Point(170, 375);
            this.criarIdeia_btn.Name = "criarIdeia_btn";
            this.criarIdeia_btn.Size = new System.Drawing.Size(160, 38);
            this.criarIdeia_btn.TabIndex = 14;
            this.criarIdeia_btn.Text = "Criar Ideia";
            this.criarIdeia_btn.UseVisualStyleBackColor = false;
            this.criarIdeia_btn.Click += new System.EventHandler(this.criarIdeia_btn_Click);
            // 
            // CriarIdeia_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.criarIdeia_btn);
            this.Controls.Add(this.tags_txt);
            this.Controls.Add(this.descricao_txt);
            this.Controls.Add(this.titulo_txt);
            this.Controls.Add(this.estadoIdeia_cmb);
            this.Controls.Add(this.data_lbl);
            this.Controls.Add(this.nomeUtilizador_lbl);
            this.Controls.Add(this.nomeCampanha_lbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CriarIdeia_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Criar Ideia";
            this.Load += new System.EventHandler(this.CriarIdeia_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label nomeCampanha_lbl;
        private System.Windows.Forms.Label nomeUtilizador_lbl;
        private System.Windows.Forms.Label data_lbl;
        private System.Windows.Forms.ComboBox estadoIdeia_cmb;
        private System.Windows.Forms.TextBox titulo_txt;
        private System.Windows.Forms.TextBox descricao_txt;
        private System.Windows.Forms.TextBox tags_txt;
        private System.Windows.Forms.Button criarIdeia_btn;
    }
}