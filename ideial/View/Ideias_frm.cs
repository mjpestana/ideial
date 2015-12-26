using System;
using System.Drawing;
using System.Windows.Forms;

namespace ideial.View
{
    public partial class Ideias_frm : Form
    {
        readonly Bitmap _starSelected = Properties.Resources.star;
        readonly Bitmap _starDeselected = Properties.Resources.inactiveStar;

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
