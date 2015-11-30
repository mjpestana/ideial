namespace ideial.View
{
    partial class Utilizador_C
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
            this.filho = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filho
            // 
            this.filho.AutoSize = true;
            this.filho.Location = new System.Drawing.Point(12, 9);
            this.filho.Name = "filho";
            this.filho.Size = new System.Drawing.Size(26, 13);
            this.filho.TabIndex = 0;
            this.filho.Text = "filho";
            this.filho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Utilizador_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.filho);
            this.Name = "Utilizador_C";
            this.Text = "Utilizador_C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filho;
    }
}