using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ideial.View
{
    public partial class Feed_frm : Form
    {
        public Feed_frm()
        {
            InitializeComponent();
        }

        private void Feed_frm_Load(object sender, EventArgs e)
        {
            
            for (int i = 1; i < 5; i++)
            {
                Ideia_frm filho = new Ideia_frm(i);
                filho.Name = filho.Name + i;
                AddFormInPanel(filho);
                Console.WriteLine("form name: " + filho.Name);
            }
        }

        private void AddFormInPanel(Form con)
        {
            con.TopLevel = false;
            con.FormBorderStyle = FormBorderStyle.None;
            //con.Dock = DockStyle.Top;
            con.Location = new Point(10, feed_pnl.Controls.Count * 270);
            this.feed_pnl.Controls.Add(con);
            this.feed_pnl.Tag = con;
            con.Show();
        }

        
    }
}
