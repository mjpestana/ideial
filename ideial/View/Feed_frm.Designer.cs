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
            this.SuspendLayout();
            // 
            // feed_pnl
            // 
            this.feed_pnl.AutoScroll = true;
            this.feed_pnl.Location = new System.Drawing.Point(21, 12);
            this.feed_pnl.Name = "feed_pnl";
            this.feed_pnl.Size = new System.Drawing.Size(519, 394);
            this.feed_pnl.TabIndex = 0;
            // 
            // Feed_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(542, 405);
            this.Controls.Add(this.feed_pnl);
            this.Name = "Feed_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Feed";
            this.Load += new System.EventHandler(this.Feed_frm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel feed_pnl;
    }
}