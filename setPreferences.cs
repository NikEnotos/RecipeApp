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
    public partial class setPreferences : Form
    {
        public setPreferences()
        {
            InitializeComponent();
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerBTN_Click(object sender, EventArgs e)
        {
            UserProfile currentUser = Program.RecipesDB.UserProfiles.Where(u => u.UserID == Program.userIndex).FirstOrDefault();

            currentUser.DietaryPreferences = prefCB.SelectedIndex >= 0 ? prefCB.SelectedItem.ToString() : "Omnivore";
            currentUser.Allergies = allergiesCB.SelectedIndex >= 0 ? allergiesCB.SelectedItem.ToString() : "None";

            try
            {
                Program.RecipesDB.SaveChanges();
                //MessageBox.Show(currentUser.Username + " user`s preferences changed successfuly");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
