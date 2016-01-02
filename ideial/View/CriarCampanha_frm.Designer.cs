namespace ideial.View
{
    partial class CriarCampanha_frm
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
            this.descricao_txt = new System.Windows.Forms.TextBox();
            this.nome_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.data_lbl = new System.Windows.Forms.Label();
            this.nomeUtilizador_lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.criarCampanha_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descricao_txt
            // 
            this.descricao_txt.Location = new System.Drawing.Point(152, 55);
            this.descricao_txt.Multiline = true;
            this.descricao_txt.Name = "descricao_txt";
            this.descricao_txt.Size = new System.Drawing.Size(234, 101);
            this.descricao_txt.TabIndex = 16;
            // 
            // nome_txt
            // 
            this.nome_txt.Location = new System.Drawing.Point(152, 23);
            this.nome_txt.Name = "nome_txt";
            this.nome_txt.Size = new System.Drawing.Size(234, 20);
            this.nome_txt.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            // 
            // data_lbl
            // 
            this.data_lbl.AutoSize = true;
            this.data_lbl.Location = new System.Drawing.Point(149, 203);
            this.data_lbl.Name = "data_lbl";
            this.data_lbl.Size = new System.Drawing.Size(30, 13);
            this.data_lbl.TabIndex = 20;
            this.data_lbl.Text = "Data";
            // 
            // nomeUtilizador_lbl
            // 
            this.nomeUtilizador_lbl.AutoSize = true;
            this.nomeUtilizador_lbl.Location = new System.Drawing.Point(149, 176);
            this.nomeUtilizador_lbl.Name = "nomeUtilizador_lbl";
            this.nomeUtilizador_lbl.Size = new System.Drawing.Size(81, 13);
            this.nomeUtilizador_lbl.TabIndex = 19;
            this.nomeUtilizador_lbl.Text = "Nome Utilizador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Utilizador";
            // 
            // criarCampanha_btn
            // 
            this.criarCampanha_btn.Location = new System.Drawing.Point(204, 269);
            this.criarCampanha_btn.Name = "criarCampanha_btn";
            this.criarCampanha_btn.Size = new System.Drawing.Size(102, 23);
            this.criarCampanha_btn.TabIndex = 21;
            this.criarCampanha_btn.Text = "Criar Campanha";
            this.criarCampanha_btn.UseVisualStyleBackColor = true;
            this.criarCampanha_btn.Click += new System.EventHandler(this.criarCampanha_btn_Click);
            // 
            // CriarCampanha_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 358);
            this.Controls.Add(this.criarCampanha_btn);
            this.Controls.Add(this.data_lbl);
            this.Controls.Add(this.nomeUtilizador_lbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.descricao_txt);
            this.Controls.Add(this.nome_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CriarCampanha_frm";
            this.Text = "Criar Campanha";
            this.Load += new System.EventHandler(this.CriarCampanha_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descricao_txt;
        private System.Windows.Forms.TextBox nome_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label data_lbl;
        private System.Windows.Forms.Label nomeUtilizador_lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button criarCampanha_btn;
    }
}