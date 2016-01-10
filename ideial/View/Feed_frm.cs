using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ideial.Controller;
using ideial.Model.Entity;

namespace ideial.View
{
    public partial class Feed_frm : Form
    {
        private readonly int _tipoFeed;
        public int Id { get; set; }

        public Feed_frm(int tipo)
        {
            InitializeComponent();
            _tipoFeed = tipo;
        }

        public Feed_frm(int tipo, int id)
        {
            InitializeComponent();
            _tipoFeed = tipo;
            Id = id;
            
        }

        private void Feed_frm_Load(object sender, EventArgs e)
        {
            switch (_tipoFeed)
            {
                case 0:
                    PopulateFeed();
                    break;
                case 1:
                    PopulateFeedIdeias();
                    break;
                case 2:
                    PopulateFeedCampanhas();
                    break;
                case 3:
                    PopulateFeedIdeiasDaCampanha(Id);
                    break;
            }
        }

        private void AddFormInPanel(Form con)
        {
            con.TopLevel = false;
            con.FormBorderStyle = FormBorderStyle.None;
            con.Location = new Point(20, feed_pnl.Controls.Count * 270);
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
                    filho = new Ideia_frm(listaFeed.Values.ElementAt(i), false);
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
            var listaIdeias = FeedControl.SelecionarIdeiasUtiliz();

            for (int i = 0; i < listaIdeias.Count; i++)
            {
                Ideia_frm filho = new Ideia_frm(listaIdeias.Keys.ElementAt(i), false);
                AddFormInPanel(filho);
            }
        }

        private void PopulateFeedCampanhas()
        {
            var listaCampanhas = FeedControl.SelecionarCampanhasUtiliz();

            for (int i = 0; i < listaCampanhas.Count; i++)
            {
                Campanha_frm filho = new Campanha_frm(listaCampanhas.Keys.ElementAt(i));
                AddFormInPanel(filho);
            }
        }

        public void PopulateFeedIdeiasDaCampanha(int idCamp)
        {
            var listaIdeias = FeedControl.SelecionarIdeiasDaCampanha(idCamp);
            
            for (int i = 0; i < listaIdeias.Count; i++)
            {
                Ideia_frm filho = new Ideia_frm(listaIdeias[i], false);
                AddFormInPanel(filho);
            }
        }
    }
}
