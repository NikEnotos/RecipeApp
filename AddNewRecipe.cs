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
    public partial class AddNewRecipe : Form
    {

        static List<Ingredient> ingredients = new List<Ingredient>();
        public AddNewRecipe()
        {
            InitializeComponent();

            IQueryable<Ingredient> allIngredients = from i in Program.RecipesDB.Ingredients select i;
            foreach (var item in allIngredients)
            {
                ingredientsList_CB.Items.Add(item.Name);
            }
        }

        private void cancel_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addIngr_BTN_Click(object sender, EventArgs e)
        {
            if (ingredientsList_CB.SelectedItem == null) { return; }

            Ingredient selectedIngredient = Program.RecipesDB.Ingredients.Where(i => i.Name == ingredientsList_CB.SelectedItem.ToString()).FirstOrDefault();

            ingredients.Add(selectedIngredient);

            Ingredients_LV.Items.Clear();
            foreach (var ingredient in ingredients)
            {
                var item = Ingredients_LV.Items.Add(ingredient.Name);
                item.SubItems.Add(ingredient.NutritionalInfo);
                item.SubItems[0].Font = new Font("Arial", 10, FontStyle.Bold);
            }

        
        }

        private void DeleteItem_BTN_Click(object sender, EventArgs e)
        {
            if (Ingredients_LV.SelectedItems.Count > 0)
            {
                string nameOfIngredientToDelete = Ingredients_LV.SelectedItems[0].Text;
                Ingredient ingredientToDelete = Program.RecipesDB.Ingredients.Where(i => i.Name.Equals(nameOfIngredientToDelete)).FirstOrDefault();

                if (ingredientToDelete != null)
                {
                    ingredients.Remove(ingredientToDelete);


                    Ingredients_LV.Items.Clear();
                    foreach (var ingredient in ingredients)
                    {
                        var item = Ingredients_LV.Items.Add(ingredient.Name);
                        item.SubItems.Add(ingredient.NutritionalInfo);
                        item.SubItems[0].Font = new Font("Arial", 10, FontStyle.Bold);
                    }
                }

            }
        }

        private void add_BTN_Click(object sender, EventArgs e)
        {


            if (recipeName_TB.Text == string.Empty || cuisine_CB.SelectedIndex < 0 || prepTime_NUM.Value <= 0 || ingredients.Count <= 0)
            { 
                MessageBox.Show("Provide all required information!");
            }
            else
            {
                Recipe newRecipe = new Recipe();

                newRecipe.Ingredients = ingredients;
                newRecipe.Cuisine = cuisine_CB.Text;
                newRecipe.Name = recipeName_TB.Text;
                newRecipe.PreparationTime = (int)prepTime_NUM.Value;

                Program.RecipesDB.Recipes.Add(newRecipe);

                try
                {
                    Program.RecipesDB.SaveChanges();
                    MessageBox.Show("Recipe added!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                this.Close();
            }
        }
    }
}
