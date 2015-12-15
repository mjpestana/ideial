using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISgrupo1.Ideial.View
{
    public partial class Ideias_frm : Form
    {
        readonly Bitmap _starSelected = ideial.Properties.Resources.star;
        readonly Bitmap _starDeselected = ideial.Properties.Resources.inactiveStar;

        public Ideias_frm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void criar_lbl_Click(object sender, EventArgs e)
        {

        }

        private void ideiaConteudo_lbl_Click(object sender, EventArgs e)
        {

        }

        private void ideiaScore_img_Click(object sender, EventArgs e)
        {
            var tempImage = ideiaScore_img.Image;
            ideiaScore_img.Image = tempImage == _starSelected ? _starDeselected : _starSelected;
        }
    }
}
