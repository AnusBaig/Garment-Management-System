using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garment
{
    public partial class Info : UserControl
    {
        public static AccInfo[] accinfo = new AccInfo[2];
        public Info()
        {
            InitializeComponent();
            accinfo[0] = new AccInfo();
            accinfo[0].email = "anusbaig08@gmail.com";
            accinfo[0].age = 19;
            accinfo[0].phnumber = "03343854480";

            accinfo[1] = new AccInfo();
            accinfo[1].email = "abdullahsohailofficial123@gmail.com";
            accinfo[1].age = 19;
            accinfo[1].phnumber = "03135311092";
        }
       
        
        
        private void Infopanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void getInfobtn_Click(object sender, EventArgs e)
        {
            if(Form2.userName.ToUpper()=="ANUS BAIG")
            {
                InfoAgedatalbl.Text = accinfo[0].age.ToString();
                InfoEmaildatalbl.Text = accinfo[0].email;
                InfoPHnumberdatalbl.Text = accinfo[0].phnumber;
                InfoNamelbl.Text = Form2.userName.ToUpper();
                InfoPicBox.ImageLocation = @"D:\LoginPics\anus baig.jpg";
            }
            else if(Form2.userName.ToUpper()=="ABDULLAH SOHAIL")
            {
                InfoAgedatalbl.Text = accinfo[1].age.ToString();
                InfoEmaildatalbl.Text = accinfo[1].email;
                InfoPHnumberdatalbl.Text = accinfo[1].phnumber;
                InfoNamelbl.Text = Form2.userName.ToUpper();
                InfoPicBox.ImageLocation = @"D:\LoginPics\abdullah sohail.jpg";
            }
            else
            {
                MessageBox.Show("Not logged in with any account");
            }
        }
    }
}
