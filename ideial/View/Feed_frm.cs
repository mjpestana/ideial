using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ideial.Controller;

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
            PopulateFeed();
        }

        private void AddFormInPanel(Form con)
        {
            con.TopLevel = false;
            con.FormBorderStyle = FormBorderStyle.None;
            con.Location = new Point(10, feed_pnl.Controls.Count * 270);
            this.feed_pnl.Controls.Add(con);
            this.feed_pnl.Tag = con;
            con.Show();
        }

        private void PopulateFeed()
        {
            var listaIdeias = FeedControl.SelecionarIdeias();
            var listaCampanhas = FeedControl.SelecionarCampanhas();
            var listaFeed = FeedControl.GerarFeed(listaIdeias, listaCampanhas);
            
            for (int i = 0; i < listaFeed.Count; i++)
            {
                Form filho;
                
                if (listaFeed.Keys.ElementAt(i).Contains("ideia"))
                {
                    filho = new Ideia_frm(listaFeed.Values.ElementAt(i));
                }
                else
                {
                    filho = new Campanha_frm(listaFeed.Values.ElementAt(i));
                    
                }
                AddFormInPanel(filho);
            }
        }

        private void PopulateFeedIdeias()
        {
            var listaIdeias = FeedControl.SelecionarIdeias();

            for (int i = 0; i < listaIdeias.Count; i++)
            {
                Ideia_frm filho = new Ideia_frm(listaIdeias.Keys.ElementAt(i));
                filho.Name = filho.Name + i;
                AddFormInPanel(filho);
            }
        }

        private void PopulateFeedCampanhas()
        {
            var listaCampanhas = FeedControl.SelecionarCampanhas();

            for (int i = 0; i < listaCampanhas.Count; i++)
            {
                Campanha_frm filho = new Campanha_frm(listaCampanhas.Keys.ElementAt(i));
                filho.Name = filho.Name + i;
                AddFormInPanel(filho);
            }
        }
    }
}
