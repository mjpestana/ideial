using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ideial.Model.Entity;
using ideial.Controller;
using System.Diagnostics;
using ideial.Model.DAO;

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
            cheia_ideias();
            cheia_campanhas();
        }

        public void cheia_ideias() {

           DataTable Idea_Dt =   FeedController.Ideia_DataTable();

            for (int i = 0; i < Idea_Dt.Rows.Count; i++)
            {

                ListViewItem lvi = new ListViewItem(Idea_Dt.Rows[i]["ID"].ToString());
                lvi.SubItems.Add(Idea_Dt.Rows[i]["titulo"].ToString());
                ideias_lv.Items.Add(lvi);
                
              }
          }

        public void cheia_campanhas()
        {

            DataTable Camp_Dt = FeedController.Camp_DataTable();

            for (int i = 0; i < Camp_Dt.Rows.Count; i++)
            {

                ListViewItem lvc = new ListViewItem(Camp_Dt.Rows[i]["ID"].ToString());
                lvc.SubItems.Add(Camp_Dt.Rows[i]["nome"].ToString());
                camp_lv.Items.Add(lvc);

            }
        }

        private void ideias_lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = ideias_lv.SelectedItems[0].SubItems[0].Text;

            Ideia_frm form = new Ideia_frm(Convert.ToInt16(ID)); 
            form.Show();

        }

        private void camp_lv_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string ID = camp_lv.SelectedItems[0].SubItems[0].Text;



            Campanha_frm form = new Campanha_frm(Convert.ToInt16(ID));
            form.Show();
        }
    }
}
