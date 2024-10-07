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
    public partial class availableIngr : Form
    {
        public availableIngr()
        {
            InitializeComponent();

            DeleteItem_BTN.Hide();

            IQueryable<Ingredient> allIngredients = from i in Program.RecipesDB.Ingredients select i;
            foreach (var item in allIngredients)
            {
                ingredientsList_CB.Items.Add(item.Name);
            }

            refreshAvailableIngredientsList();
        }

        private void addIngr_BTN_Click(object sender, EventArgs e)
        {
            if(ingredientsList_CB.SelectedItem == null) { return; }

            Ingredient selectedIngredient = Program.RecipesDB.Ingredients.Where(i => i.Name == ingredientsList_CB.SelectedItem.ToString()).FirstOrDefault();
            
            Program.availableIngredients.Add(selectedIngredient);

            refreshAvailableIngredientsList();


        }

        private void refreshAvailableIngredientsList()
        {
            AvailableIngredients_LV.Clear();

            foreach (var item in Program.availableIngredients)
            {
                AvailableIngredients_LV.Items.Add(item.Name);
            }
        }

        private void AvailableIngredients_LV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AvailableIngredients_LV.SelectedItems.Count > 0)
            {
                DeleteItem_BTN.Show();
            }
            else
            {
                DeleteItem_BTN.Hide();
            }
        }

        private void DeleteItem_BTN_Click(object sender, EventArgs e)
        {
            if (AvailableIngredients_LV.SelectedItems[0] != null)
            {
                foreach (var item in Program.availableIngredients)
                {
                    if (item.Name == AvailableIngredients_LV.SelectedItems[0].Text)
                    {
                        Program.availableIngredients.Remove(item);
                        break;
                    }
                    
                }

                refreshAvailableIngredientsList();

                //AvailableIngredients_LV.SelectedItems.Clear();
            }
        }

        private void save_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
