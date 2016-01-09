namespace ideial.View
{
    partial class ListaCampanhas_frm
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
            this.camp_lv = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // camp_lv
            // 
            this.camp_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.camp_lv.FullRowSelect = true;
            this.camp_lv.Location = new System.Drawing.Point(12, 22);
            this.camp_lv.Name = "camp_lv";
            this.camp_lv.Size = new System.Drawing.Size(454, 324);
            this.camp_lv.TabIndex = 2;
            this.camp_lv.UseCompatibleStateImageBehavior = false;
            this.camp_lv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            this.columnHeader4.Width = 446;
            // 
            // ListaCampanhas_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 358);
            this.Controls.Add(this.camp_lv);
            this.Name = "ListaCampanhas_frm";
            this.Text = "Campanhas";
            this.Load += new System.EventHandler(this.ListaCampanhas_frm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView camp_lv;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}