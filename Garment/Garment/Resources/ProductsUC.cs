using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garment.Resources
{
    public partial class ProductsUC : UserControl
    {
        public ProductsUC()
        {
            InitializeComponent();
        }

        private void productsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mensFashionpicBox_Click(object sender, EventArgs e)
        {
            productsPanel.Visible = false;
            menFashionpanel.Visible = true;
            womensFashionPanel.Visible = false;
            menFashionpanel.BringToFront();
        }

        private void womensFashionpicBox_Click(object sender, EventArgs e)
        {
            productsPanel.Visible = false;
            menFashionpanel.Visible = false;
            womensFashionPanel.Visible = true;
            womensFashionPanel.BringToFront();
        }
    }
}
