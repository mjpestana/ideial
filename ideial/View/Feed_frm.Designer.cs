namespace ideial.View
{
    partial class Feed_frm
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
            this.feed_pnl = new System.Windows.Forms.Panel();
            this.ordenarData_btn = new System.Windows.Forms.Button();
            this.ordenarPop_btn = new System.Windows.Forms.Button();
            this.ordenar_pnl = new System.Windows.Forms.Panel();
            this.ordenar_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // feed_pnl
            // 
            this.feed_pnl.AutoScroll = true;
            this.feed_pnl.Location = new System.Drawing.Point(35, 12);
            this.feed_pnl.Name = "feed_pnl";
            this.feed_pnl.Size = new System.Drawing.Size(505, 394);
            this.feed_pnl.TabIndex = 0;
            // 
            // ordenarData_btn
            // 
            this.ordenarData_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.ordenarData_btn.BackgroundImage = global::ideial.Properties.Resources.calendar;
            this.ordenarData_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ordenarData_btn.FlatAppearance.BorderSize = 0;
            this.ordenarData_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordenarData_btn.Location = new System.Drawing.Point(3, 10);
            this.ordenarData_btn.Name = "ordenarData_btn";
            this.ordenarData_btn.Size = new System.Drawing.Size(29, 28);
            this.ordenarData_btn.TabIndex = 10;
            this.ordenarData_btn.UseVisualStyleBackColor = false;
            this.ordenarData_btn.Click += new System.EventHandler(this.ordenarData_btn_Click);
            // 
            // ordenarPop_btn
            // 
            this.ordenarPop_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.ordenarPop_btn.BackgroundImage = global::ideial.Properties.Resources.trophee;
            this.ordenarPop_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ordenarPop_btn.FlatAppearance.BorderSize = 0;
            this.ordenarPop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordenarPop_btn.Location = new System.Drawing.Point(3, 54);
            this.ordenarPop_btn.Name = "ordenarPop_btn";
            this.ordenarPop_btn.Size = new System.Drawing.Size(29, 28);
            this.ordenarPop_btn.TabIndex = 11;
            this.ordenarPop_btn.UseVisualStyleBackColor = false;
            this.ordenarPop_btn.Click += new System.EventHandler(this.ordenarPop_btn_Click);
            // 
            // ordenar_pnl
            // 
            this.ordenar_pnl.BackColor = System.Drawing.SystemColors.Highlight;
            this.ordenar_pnl.Controls.Add(this.ordenarPop_btn);
            this.ordenar_pnl.Controls.Add(this.ordenarData_btn);
            this.ordenar_pnl.Location = new System.Drawing.Point(7, 12);
            this.ordenar_pnl.Name = "ordenar_pnl";
            this.ordenar_pnl.Size = new System.Drawing.Size(36, 94);
            this.ordenar_pnl.TabIndex = 1;
            // 
            // Feed_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(542, 405);
            this.Controls.Add(this.ordenar_pnl);
            this.Controls.Add(this.feed_pnl);
            this.Name = "Feed_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Feed";
            this.Load += new System.EventHandler(this.Feed_frm_Load);
            this.ordenar_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel feed_pnl;
        private System.Windows.Forms.Button ordenarData_btn;
        private System.Windows.Forms.Button ordenarPop_btn;
        private System.Windows.Forms.Panel ordenar_pnl;
    }
}