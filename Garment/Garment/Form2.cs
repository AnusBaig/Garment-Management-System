using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Garment
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            item1.BringToFront();
        }


        string path = Directory.GetCurrentDirectory();

        public static string userName;

        bool hide = false;
        private void MENU_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            item1.BringToFront();
        }

        private void ABOUT_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/apparel_mag?lang=en");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Al.Shopping.online/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            productUC1.BringToFront();
            productUC1.homePanel.BringToFront();
            ACCOUNT.BackColor = Color.FromArgb(235, 235, 235);
            ITEMS.BackColor = Color.FromArgb(235, 235, 235);
            PRODUCT.BackColor = Color.FromArgb(43, 43, 43);
            PRODUCT.ForeColor = Color.White;
            ITEMS.ForeColor = Color.Purple;
            ACCOUNT.ForeColor = Color.Purple;
        }

        private void ITEMS_Click(object sender, EventArgs e)
        {
            item1.BringToFront();

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
            
            info1.BringToFront();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            item1.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login.login == 0)
            {
                new Login().ShowDialog();
                this.Hide();
                //this.hide();//= false;
            }
            else if(Login.login == 58)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to logout", "Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    new Login().ShowDialog();
                    this.Hide();
                }
                if(result==DialogResult.No)
                {

                }
            }

            }

        private void Form2_VisibleChanged(object sender, EventArgs e)
        {
            if (Login.login == 58)
            {
                accountPicBox.ImageLocation = @"D:\LoginPics\"+userName+".jpg";
            }
            else
            {
                
                accountPicBox.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do you want to close?", "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
           
        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.Size.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Login.login == 0)
            {
                new Login().ShowDialog();
                this.Hide();
                //this.hide();//= false;
            }
            else if (Login.login == 58)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to logout", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    new Login().ShowDialog();
                    this.Hide();
                }
                if (result == DialogResult.No)
                {

                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
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
    }
}
