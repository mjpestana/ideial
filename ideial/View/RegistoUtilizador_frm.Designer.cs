namespace DISgrupo1.Ideial.View
{
    partial class RegistoUtilizador_frm
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
            this.utilizador_panel = new System.Windows.Forms.Panel();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.nome_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.userName_txt = new System.Windows.Forms.TextBox();
            this.tipoUtilizador_cmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.funcionario_panel = new System.Windows.Forms.Panel();
            this.fornecedor_panel = new System.Windows.Forms.Panel();
            this.empresa_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.departamento_cmb = new System.Windows.Forms.ComboBox();
            this.cargo_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.registarUtilizador_btn = new System.Windows.Forms.Button();
            this.utilizador_panel.SuspendLayout();
            this.funcionario_panel.SuspendLayout();
            this.fornecedor_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // utilizador_panel
            // 
            this.utilizador_panel.Controls.Add(this.email_txt);
            this.utilizador_panel.Controls.Add(this.nome_txt);
            this.utilizador_panel.Controls.Add(this.password_txt);
            this.utilizador_panel.Controls.Add(this.userName_txt);
            this.utilizador_panel.Controls.Add(this.tipoUtilizador_cmb);
            this.utilizador_panel.Controls.Add(this.label5);
            this.utilizador_panel.Controls.Add(this.label4);
            this.utilizador_panel.Controls.Add(this.label3);
            this.utilizador_panel.Controls.Add(this.label2);
            this.utilizador_panel.Controls.Add(this.label1);
            this.utilizador_panel.Location = new System.Drawing.Point(1, 3);
            this.utilizador_panel.Name = "utilizador_panel";
            this.utilizador_panel.Size = new System.Drawing.Size(480, 170);
            this.utilizador_panel.TabIndex = 0;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(155, 105);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(250, 20);
            this.email_txt.TabIndex = 3;
            // 
            // nome_txt
            // 
            this.nome_txt.Location = new System.Drawing.Point(155, 75);
            this.nome_txt.Name = "nome_txt";
            this.nome_txt.Size = new System.Drawing.Size(250, 20);
            this.nome_txt.TabIndex = 2;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(155, 45);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(121, 20);
            this.password_txt.TabIndex = 1;
            // 
            // userName_txt
            // 
            this.userName_txt.Location = new System.Drawing.Point(155, 15);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.Size = new System.Drawing.Size(121, 20);
            this.userName_txt.TabIndex = 0;
            // 
            // tipoUtilizador_cmb
            // 
            this.tipoUtilizador_cmb.FormattingEnabled = true;
            this.tipoUtilizador_cmb.Location = new System.Drawing.Point(155, 134);
            this.tipoUtilizador_cmb.Name = "tipoUtilizador_cmb";
            this.tipoUtilizador_cmb.Size = new System.Drawing.Size(121, 21);
            this.tipoUtilizador_cmb.TabIndex = 4;
            this.tipoUtilizador_cmb.SelectedIndexChanged += new System.EventHandler(this.tipoUtilizador_cmb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tipo Utilizador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Palavra-passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Utilizador";
            // 
            // funcionario_panel
            // 
            this.funcionario_panel.Controls.Add(this.fornecedor_panel);
            this.funcionario_panel.Controls.Add(this.departamento_cmb);
            this.funcionario_panel.Controls.Add(this.cargo_txt);
            this.funcionario_panel.Controls.Add(this.label7);
            this.funcionario_panel.Controls.Add(this.label6);
            this.funcionario_panel.Location = new System.Drawing.Point(0, 179);
            this.funcionario_panel.Name = "funcionario_panel";
            this.funcionario_panel.Size = new System.Drawing.Size(480, 80);
            this.funcionario_panel.TabIndex = 1;
            // 
            // fornecedor_panel
            // 
            this.fornecedor_panel.Controls.Add(this.empresa_txt);
            this.fornecedor_panel.Controls.Add(this.label8);
            this.fornecedor_panel.Location = new System.Drawing.Point(0, 0);
            this.fornecedor_panel.Name = "fornecedor_panel";
            this.fornecedor_panel.Size = new System.Drawing.Size(480, 80);
            this.fornecedor_panel.TabIndex = 3;
            // 
            // empresa_txt
            // 
            this.empresa_txt.Location = new System.Drawing.Point(77, 27);
            this.empresa_txt.Name = "empresa_txt";
            this.empresa_txt.Size = new System.Drawing.Size(100, 20);
            this.empresa_txt.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Empresa";
            // 
            // departamento_cmb
            // 
            this.departamento_cmb.FormattingEnabled = true;
            this.departamento_cmb.Location = new System.Drawing.Point(156, 8);
            this.departamento_cmb.Name = "departamento_cmb";
            this.departamento_cmb.Size = new System.Drawing.Size(121, 21);
            this.departamento_cmb.TabIndex = 3;
            // 
            // cargo_txt
            // 
            this.cargo_txt.Location = new System.Drawing.Point(156, 41);
            this.cargo_txt.Name = "cargo_txt";
            this.cargo_txt.Size = new System.Drawing.Size(121, 20);
            this.cargo_txt.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cargo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Departamento";
            // 
            // registarUtilizador_btn
            // 
            this.registarUtilizador_btn.Location = new System.Drawing.Point(202, 293);
            this.registarUtilizador_btn.Name = "registarUtilizador_btn";
            this.registarUtilizador_btn.Size = new System.Drawing.Size(75, 23);
            this.registarUtilizador_btn.TabIndex = 2;
            this.registarUtilizador_btn.Text = "Registar";
            this.registarUtilizador_btn.UseVisualStyleBackColor = true;
            this.registarUtilizador_btn.Click += new System.EventHandler(this.registarUtilizador_btn_Click);
            // 
            // RegistoUtilizador_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.registarUtilizador_btn);
            this.Controls.Add(this.funcionario_panel);
            this.Controls.Add(this.utilizador_panel);
            this.Name = "RegistoUtilizador_frm";
            this.Text = "Registo Utilizador";
            this.utilizador_panel.ResumeLayout(false);
            this.utilizador_panel.PerformLayout();
            this.funcionario_panel.ResumeLayout(false);
            this.funcionario_panel.PerformLayout();
            this.fornecedor_panel.ResumeLayout(false);
            this.fornecedor_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel utilizador_panel;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox nome_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox userName_txt;
        private System.Windows.Forms.ComboBox tipoUtilizador_cmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel funcionario_panel;
        private System.Windows.Forms.ComboBox departamento_cmb;
        private System.Windows.Forms.TextBox cargo_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button registarUtilizador_btn;
        private System.Windows.Forms.Panel fornecedor_panel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox empresa_txt;
    }
}