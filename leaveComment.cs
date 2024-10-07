using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseworkApp
{
    public partial class leaveComment : Form
    {
 
        Image selectedStar;
        Image defaultStar;
        decimal score = 0.0M;

        public leaveComment()
        {
            InitializeComponent();

            string[] s = { "\\bin" };
            string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0];

            selectedStar = Image.FromFile(path + "\\_Pictures_\\selectedStarBTN.png");
            defaultStar = Image.FromFile(path + "\\_Pictures_\\whiteStarBTN.png");
        }

        private void star1_Click(object sender, EventArgs e)
        {
            star1.Image = selectedStar;
            score = 1.00M;

            star2.Image = defaultStar;
            star3.Image = defaultStar;
            star4.Image = defaultStar;
            star5.Image = defaultStar;
        }

        private void star2_Click(object sender, EventArgs e)
        {
            star1.Image = selectedStar;
            star2.Image = selectedStar;
            score = 2.00M;

            star3.Image = defaultStar;
            star4.Image = defaultStar;
            star5.Image = defaultStar;
        }

        private void star3_Click(object sender, EventArgs e)
        {
            star1.Image = selectedStar;
            star2.Image = selectedStar;
            star3.Image = selectedStar;
            score = 3.00M;

            star4.Image = defaultStar;
            star5.Image = defaultStar;
        }

        private void star4_Click(object sender, EventArgs e)
        {
            star1.Image = selectedStar;
            star2.Image = selectedStar;
            star3.Image = selectedStar;
            star4.Image = selectedStar;
            score = 4.00M;

            star5.Image = defaultStar;
        }

        private void star5_Click(object sender, EventArgs e)
        {
            star1.Image = selectedStar;
            star2.Image = selectedStar;
            star3.Image = selectedStar;
            star4.Image = selectedStar;
            star5.Image = selectedStar;
            score = 5.00M;
        }

        private void cacel_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_BTN_Click(object sender, EventArgs e)
        {
            UserProfile currentUser = Program.RecipesDB.UserProfiles.Where(u => u.UserID == Program.userIndex).FirstOrDefault();

            if (currentUser != null && score > 0)
            {
                Home.comment = comment_RTB.Text;
                Home.commentScore = score;

                this.Close();
            }

        }
    }
}
