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
        private bool _byDate = true;
        private bool _withId;

        public Feed_frm(int tipo)
        {
            InitializeComponent();
            _tipoFeed = tipo;
            _withId = false;
        }

        public Feed_frm(int tipo, int id)
        {
            InitializeComponent();
            _tipoFeed = tipo;
            Id = id;
            _withId = true;
        }

        private void Feed_frm_Load(object sender, EventArgs e)
        {
            LoadForm();
            
        }

        private void AddFormInPanel(Form con)
        {
            con.TopLevel = false;
            con.FormBorderStyle = FormBorderStyle.None;
            var height = 270;

            if (con.Name == "PerfilResumoFrm")
                height = 170;

            con.Location = new Point(20, feed_pnl.Controls.Count * height);
            this.feed_pnl.Controls.Add(con);
            this.feed_pnl.Tag = con;
            con.Show();
        }

        private void PopulateFeed()
        {
            ordenar_pnl.Visible = false;
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

        private void PopulateFeedIdeias(int id)
        {
            ordenar_pnl.Visible = true;
            var listaIdeias = FeedControl.SelecionarIdeiasUtiliz(id);
            
            for (int i = 0; i < listaIdeias.Count; i++)
            {
                Ideia_frm filho = new Ideia_frm(listaIdeias.Keys.ElementAt(i), false);
                AddFormInPanel(filho);
            }
        }

        private void PopulateFeedCampanhas()
        {
            ordenar_pnl.Visible = false;
            var listaCampanhas = FeedControl.SelecionarCampanhasUtiliz();

            for (int i = 0; i < listaCampanhas.Count; i++)
            {
                Campanha_frm filho = new Campanha_frm(listaCampanhas.Keys.ElementAt(i));
                AddFormInPanel(filho);
            }
        }

        public void PopulateFeedIdeiasDaCampanha(int idCamp)
        {
            ordenar_pnl.Visible = true;
            var listaIdeias = FeedControl.SelecionarIdeiasDaCampanha(idCamp);

            for (int i = 0; i < listaIdeias.Count; i++)
            {
                Ideia_frm filho = new Ideia_frm(listaIdeias[i], false);
                AddFormInPanel(filho);
            }
        }

        public void PopulateFeedUtilizadores()
        {
            ordenar_pnl.Visible = false;
            var listaUtilizadores = FeedControl.SelecionarTodosUtilizadores();

            for (int i = 0; i < listaUtilizadores.Count; i++)
            {
                PerfilResumoFrm filho = new PerfilResumoFrm(listaUtilizadores[i]);
                AddFormInPanel(filho);
            }
        }

        private void ordenarData_btn_Click(object sender, EventArgs e)
        {
            _byDate = true;
            //LoadForm();
        }

        private void ordenarPop_btn_Click(object sender, EventArgs e)
        {
            _byDate = false;
            //LoadForm();
        }

        private void LoadForm()
        {
            switch (_tipoFeed)
            {
                case 0:
                    PopulateFeed();
                    break;
                case 1:
                    PopulateFeedIdeias(Id);
                    break;
                case 2:
                    PopulateFeedCampanhas();
                    break;
                case 3:
                    PopulateFeedIdeiasDaCampanha(Id);
                    break;
                case 4:
                    PopulateFeedUtilizadores();
                    break;
            }
        }
    }
}
