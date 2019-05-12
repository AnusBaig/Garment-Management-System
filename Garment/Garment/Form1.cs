using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool hide=false;
        private void menuBtn_Click(object sender, EventArgs e)
        {
            if(hide)
            {
                movingPanel.Visible = true;
                hide = false;
            }
            else
            {
                movingPanel.Visible = false;
                hide = true;
            }
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            productUC1.BringToFront();
            productUC1.homePanel.BringToFront();

            accountBtn.BackColor = Color.FromArgb(235, 235, 235);
            dealsBtn.BackColor = Color.FromArgb(235, 235, 235);
            productBtn.BackColor = Color.FromArgb(43, 43, 43);
            productBtn.ForeColor = Color.White;
            dealsBtn.ForeColor = Color.Purple;
            accountBtn.ForeColor = Color.Purple;
        }

        private void dealsBtn_Click(object sender, EventArgs e)
        {
            item1.BringToFront();
            accountBtn.BackColor = Color.FromArgb(235, 235, 235);
            dealsBtn.BackColor = Color.FromArgb(43, 43, 43);
            productBtn.BackColor = Color.FromArgb(235, 235, 235);
            productBtn.ForeColor = Color.Purple;
            dealsBtn.ForeColor = Color.White;
            accountBtn.ForeColor = Color.Purple;
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            productBtn.BackColor = Color.FromArgb(235, 235, 235);
            productBtn.ForeColor = Color.Purple;
            dealsBtn.BackColor = Color.FromArgb(235, 235, 235);
            dealsBtn.ForeColor = Color.Purple;
            accountBtn.BackColor = Color.FromArgb(43,43,43);
            accountBtn.ForeColor = Color.White;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //home1.BringToFront();

            productBtn.BackColor = Color.FromArgb(235, 235, 235);
            productBtn.ForeColor = Color.Purple;
            dealsBtn.BackColor = Color.FromArgb(235, 235, 235);
            dealsBtn.ForeColor = Color.Purple;
            accountBtn.BackColor = Color.FromArgb(235, 235, 235);
            accountBtn.ForeColor = Color.Purple;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            item2.BringToFront();
           // home1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (hide)
            {
                SIDE.Visible = true;
                hide = false;
            }
            else
            {
                SIDE.Visible = false;
                hide = true;
            }
        }

        private void PRODUCT_Click(object sender, EventArgs e)
        {
            productUC2.BringToFront();

            ACCOUNT.BackColor = Color.FromArgb(235, 235, 235);
            ITEMS.BackColor = Color.FromArgb(235, 235, 235);
            PRODUCT.BackColor = Color.FromArgb(43, 43, 43);
            PRODUCT.ForeColor = Color.White;
            ITEMS.ForeColor = Color.Purple;
            ACCOUNT.ForeColor = Color.Purple;
        }

        private void ITEMS_Click(object sender, EventArgs e)
        {
            item2.BringToFront();

            ACCOUNT.BackColor = Color.FromArgb(235, 235, 235);
            ITEMS.BackColor = Color.FromArgb(43, 43, 43);
            PRODUCT.BackColor = Color.FromArgb(235, 235, 235);
            PRODUCT.ForeColor = Color.Purple;
            ITEMS.ForeColor = Color.White;
            ACCOUNT.ForeColor = Color.Purple;

        }

        private void ACCOUNT_Click(object sender, EventArgs e)
        {
            ACCOUNT.BackColor = Color.FromArgb(43, 43, 43);
            ITEMS.BackColor = Color.FromArgb(235, 235, 235);
            PRODUCT.BackColor = Color.FromArgb(235, 235, 235);
            PRODUCT.ForeColor = Color.Purple;
            ITEMS.ForeColor = Color.Purple;
            ACCOUNT.ForeColor = Color.White;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
             System.Diagnostics.Process.Start("https://www.facebook.com/Al.Shopping.online/");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/apparel_mag?lang=en");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SIDE_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
