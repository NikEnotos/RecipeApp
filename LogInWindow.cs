using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseworkApp
{
    public partial class LogInWindow : Form
    {
        public LogInWindow()
        {
            InitializeComponent();
            adminPwd_TB.Hide();
            adminLoginBTN.Hide();

            adminPwd_TB.UseSystemPasswordChar = true;
            pwdTB.UseSystemPasswordChar = true;
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            UserProfile currentuser = Program.RecipesDB.UserProfiles.Where(user => user.Username == usernameTB.Text && user.Password == pwdTB.Text).FirstOrDefault();

            if (currentuser != null)
            {
                Program.userIndex = currentuser.UserID;

                Program.homeForm = new Home();
                Program.homeForm.Show();
    
                this.Hide();

                //MessageBox.Show("UserID = " + Program.userIndex);
            }
            else 
            {
                MessageBox.Show("Wrong username or password!");
            }

        }

        private void registerBTN_Click(object sender, EventArgs e)
        {
            RegisterNewUser registerNewUserform = new RegisterNewUser();
            registerNewUserform.Show();

            this.Hide();

            //this.FormClosing
        }

        private void adminBTN_Click(object sender, EventArgs e)
        {
            adminPwd_TB.Show();
            adminLoginBTN.Show();
        }

        private void adminLoginBTN_Click(object sender, EventArgs e)
        {
            if (adminPwd_TB.Text == Program.AdminPWD)
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();  
                this.Hide();
            }
        }

    }
}
