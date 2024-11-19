using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_6._2
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnResultrectsolid_Click(object sender, EventArgs e)
        {
            double C = double.Parse(txbLength.Text);
            double D = double.Parse(txbWidth.Text);
            double H = double.Parse(txbHeight.Text);
            ISolid rectSolid = new RectSolid(C, D, H);
            double rectVolume = rectSolid.GetVolume();
            txbVolume.Text = rectVolume.ToString("0.00");
        }

        private void btnResultcube_Click(object sender, EventArgs e)
        {
            double A = double.Parse(txbRiblength.Text);
            ISolid cube = new Cube(A);
            double cubeVolume = cube.GetVolume();
            txbVolumecube.Text = cubeVolume.ToString("0.00");
        }

        private void btnResetrectsolid_Click(object sender, EventArgs e)
        {
            txbLength.Text = string.Empty; // Поле довжини
            txbWidth.Text = string.Empty;  // Поле ширини
            txbHeight.Text = string.Empty; // Поле висоти
            txbVolume.Text = string.Empty;
        }

        private void btnResetcube_Click(object sender, EventArgs e)
        {
            txbRiblength.Text = string.Empty; // Поле довжини ребра
            txbVolumecube.Text = string.Empty;
        }
    }
}
