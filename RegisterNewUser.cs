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
    public partial class RegisterNewUser : Form
    {
        public RegisterNewUser()
        {
            InitializeComponent();
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            Program.loginWin.Show();

            this.Close();  
        }

        private void registerBTN_Click(object sender, EventArgs e)
        {
            IQueryable<UserProfile> users = from u in Program.RecipesDB.UserProfiles select u;

            bool userExists = false;
            foreach (UserProfile user in users) 
            {
                if(user.Username == usernameTB.Text) { userExists = true; break; }
            }

            if (usernameTB.Text != null && !userExists)
            {
                if (pwdTB.Text != null && pwdTB.Text == repeatPwdTB.Text)
                {
                    UserProfile newUser = new UserProfile();
                    newUser.Username = usernameTB.Text;
                    newUser.Password = pwdTB.Text;

                    newUser.DietaryPreferences = prefCB.SelectedIndex >= 0 ? prefCB.SelectedItem.ToString() : "Omnivore";
                    newUser.Allergies = allergiesCB.SelectedIndex >= 0 ? allergiesCB.SelectedItem.ToString() : "None";

                    Program.RecipesDB.UserProfiles.Add(newUser);

                    try
                    {
                        Program.RecipesDB.SaveChanges();
                        MessageBox.Show(newUser.Username + " user successful registered");

                        Program.loginWin.Show();

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else 
                {
                    MessageBox.Show("Password mismatch!");
                }
            }
            else 
            {
                MessageBox.Show("User with this nickname already exists!");
            }
        }

        private void RegisterNewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.loginWin.Show();
        }
    }
}
