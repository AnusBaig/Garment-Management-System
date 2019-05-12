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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            passwordtxt.PasswordChar = '*';
            btnback.Visible = false;
        }
        public static int check = 0;
        public static int login = 0;

        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (userNametxt.Text.ToUpper() == "Anus Baig".ToUpper() && passwordtxt.Text.ToUpper() == "softwaredeveloper".ToUpper())
            {
                Form2.userName = "anus baig";
                login = 58;
                userPicbox.ImageLocation = @"D:\LoginPics\anus baig.jpg";

                DialogResult result = MessageBox.Show("You have successfully logged into your account", "Correct Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                   
                    
                new Form2().Show();
                this.Hide();
                
                 
            }
            else if (userNametxt.Text.ToUpper() == "Abdullah Sohail".ToUpper() && passwordtxt.Text.ToUpper() == "softwaredeveloper".ToUpper())
            {
                Form2.userName = "abdullah sohail";
                login = 58;
                userPicbox.ImageLocation = @"D:\LoginPics\abdullah sohail.jpg";
                DialogResult result = MessageBox.Show("You have successfully logged into your account", "Correct Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(result==DialogResult.OK)
                    

                new Form2().Show();
                this.Hide();
                
              
            }
            else
            {
                MessageBox.Show("You cannot logged into this account", "InCorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                login = 0;
            }
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (userNametxt.Text == "" && check == 58)
                lbluserName.Visible = true;

            if (passwordtxt.Text == "" && check == 58)
                lblpassword.Visible = true;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (login == 58)
            {
                new Form2().Show();
                this.Hide();
            }
        }

        private void exitloginbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do you want to close?", "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
        }

        private void usernameDeleteBtn_Click(object sender, EventArgs e)
        {
            userNametxt.Clear();
            lbluserName.Visible = false;
        }

        private void passwordDeleteBtn_Click(object sender, EventArgs e)
        {
            passwordtxt.Clear();
            lblpassword.Visible = false;
        }

        private void lbluserName_Click(object sender, EventArgs e)
        {
            lbluserName.Visible = false;
        }

        private void lblpassword_Click(object sender, EventArgs e)
        {
            lblpassword.Visible = false;
        }

        private void lblpassword_MouseMove(object sender, MouseEventArgs e)
        {
            if (passwordtxt.Text == "")
            {
                lblpassword.Visible = false;
                check = 58;
            }

            else
                lblpassword.Visible = true;
        }

        private void lbluserName_MouseMove(object sender, MouseEventArgs e)
        {
            if (userNametxt.Text == "")
            {
                lbluserName.Visible = false;
                check = 58;
            }

            else
                lbluserName.Visible = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (login == 58)
            {
                btnback.Enabled = true;
            }
            else
                btnback.Enabled = false;
        }

        private void userNametxt_TextChanged(object sender, EventArgs e)
        {
            if (userNametxt.Text == "")
            {

                lbluserName.Visible = true;
            }
            else
            {

                lbluserName.Visible = false;
            }       
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordtxt.Text == "")
            {
                lblpassword.Visible = true;
            }
            else
            {
                lblpassword.Visible = false;
            }
        }

        bool showpassword = false;
        private void showPasswordpictureBox_Click(object sender, EventArgs e)
        {
            if (!showpassword)
            {
                passwordtxt.PasswordChar = '\0';
                passwordtxt.ForeColor = Color.Red;
                showpassword = true;
            }

            else
            {
                passwordtxt.PasswordChar = '*';
                passwordtxt.ForeColor = Color.White;
                showpassword = false;
            }
        }
    }
}
