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
    public partial class AdminForm : Form
    {
        mssql2303722Entities tempRecipesDB = new mssql2303722Entities();

        Recipe currentSelectedRecipe;

        Recipe templRecipe;

        List<Ingredient> addedIngredients = new List<Ingredient>();
        List<Ingredient> deletedIngredients = new List<Ingredient>();


        public AdminForm()
        {
            InitializeComponent();

            RecipesLV.Clear();

            RecipeInfo_GroupBox.Hide();

            // SET RECIPE LIST
            IQueryable<Recipe> matchedRecipes = from r in Program.RecipesDB.Recipes select r;

            if (matchedRecipes.Count() > 0)
            {
                foreach (Recipe recipe in matchedRecipes)
                {
                    RecipesLV.Items.Add(recipe.Name);
                }
            }

            IQueryable<Ingredient> allIngredients = from i in Program.RecipesDB.Ingredients select i;
            foreach (var item in allIngredients)
            {
                ingredientsList_CB.Items.Add(item.Name);
            }

        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.loginWin.Show();
        }

        private void matchedRecipesLV_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //RecipeInfo_GroupBox.Show();
            //shoppingList_GroupBox.Show();
            //leaveComment_BTN.Show();
            RecipeInfo_GroupBox.Show();

            addedIngredients = null;
            deletedIngredients = null;


            if (RecipesLV.SelectedItems.Count > 0)
            {
                //Ingredients_LV.Items.Clear();
                //comments_LV.Items.Clear();
                //shoppingList_LV.Items.Clear();

                // Change group box name for selected recipe name
                string recipeName = RecipesLV.SelectedItems[0].Text;

                Recipe selectedRecipe = Program.RecipesDB.Recipes.Where(r => r.Name == recipeName).FirstOrDefault();
                currentSelectedRecipe = selectedRecipe;

                if (selectedRecipe != null)
                {
                    templRecipe = selectedRecipe;

                    recipeName_TB.Text = selectedRecipe.Name;

                    cuisine_CB.Text = selectedRecipe.Cuisine;

                    prepTime_NUM.Value = selectedRecipe.PreparationTime.Value;

                    // SET UP INGREDIENTS
                    Ingredients_LV.Items.Clear();
                    foreach (var ingredient in selectedRecipe.Ingredients)
                    {
                        var item = Ingredients_LV.Items.Add(ingredient.Name);
                        item.SubItems.Add(ingredient.NutritionalInfo);
                        item.SubItems[0].Font = new Font("Arial", 10, FontStyle.Bold);

                    }

                }

                //Ingredient matchedIngredients = Program.RecipesDB.Ingredients.Where(ingr => ingr.Name.Contains("tom")).FirstOrDefault();
                // MessageBox.Show("" + selectedRecipe.Ingredients.Contains(matchedIngredients));

            }

        }

        private void addIngr_BTN_Click(object sender, EventArgs e)
        {
            if (ingredientsList_CB.SelectedItem == null) { return; }

            Ingredient selectedIngredient = Program.RecipesDB.Ingredients.Where(i => i.Name == ingredientsList_CB.SelectedItem.ToString()).FirstOrDefault();
            //addedIngredients.Add(selectedIngredient);

            currentSelectedRecipe.Ingredients.Add(selectedIngredient);


            Ingredients_LV.Items.Clear();
            foreach (var ingredient in currentSelectedRecipe.Ingredients)
            {
                var item = Ingredients_LV.Items.Add(ingredient.Name);
                item.SubItems.Add(ingredient.NutritionalInfo);
                item.SubItems[0].Font = new Font("Arial", 10, FontStyle.Bold);
            }

        }

        private void save_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                Program.RecipesDB.SaveChanges();
                MessageBox.Show("Changes saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // SET RECIPE LIST
            RecipesLV.Items.Clear();
            IQueryable<Recipe> matchedRecipes = from r in Program.RecipesDB.Recipes select r;

            if (matchedRecipes.Count() > 0)
            {
                foreach (Recipe recipe in matchedRecipes)
                {
                    RecipesLV.Items.Add(recipe.Name);
                }
            }
        }

        private void DeleteItem_BTN_Click(object sender, EventArgs e)
        {
            if(Ingredients_LV.SelectedItems.Count > 0)
            {
                string nameOfIngredientToDelete = Ingredients_LV.SelectedItems[0].Text;
                Ingredient ingredientToDelete = Program.RecipesDB.Ingredients.Where(i => i.Name.Equals(nameOfIngredientToDelete)).FirstOrDefault();

                if(ingredientToDelete != null)
                {
                    //deletedIngredients.Add(ingredientToDelete);
                    currentSelectedRecipe.Ingredients.Remove(ingredientToDelete);
                }

                Ingredients_LV.Items.Clear();
                foreach (var ingredient in currentSelectedRecipe.Ingredients)
                {
                    var item = Ingredients_LV.Items.Add(ingredient.Name);
                    item.SubItems.Add(ingredient.NutritionalInfo);
                    item.SubItems[0].Font = new Font("Arial", 10, FontStyle.Bold);
                }

            }
        }

        private void cancel_BTN_Click(object sender, EventArgs e)
        {
            Program.RecipesDB = tempRecipesDB;

            RecipeInfo_GroupBox.Hide();
        }

        private void deleteRecipe_BTN_Click(object sender, EventArgs e)
        {
            if (currentSelectedRecipe != null)
            {

                DialogResult dialogResult = MessageBox.Show("Do you really want to delete the recipe permanently?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Program.RecipesDB.Recipes.Attach(currentSelectedRecipe);
                    Program.RecipesDB.Recipes.Remove(currentSelectedRecipe);

                    try
                    {
                        Program.RecipesDB.SaveChanges();
                        MessageBox.Show("Recipe has been deleted");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    RecipesLV.Items.Clear();
                    IQueryable<Recipe> matchedRecipes = from r in Program.RecipesDB.Recipes select r;

                    if (matchedRecipes.Count() > 0)
                    {
                        foreach (Recipe recipe in matchedRecipes)
                        {
                            RecipesLV.Items.Add(recipe.Name);
                        }
                    }

                    RecipeInfo_GroupBox.Hide();

                }
            }
        }

        private void addRecipe_BTN_Click(object sender, EventArgs e)
        {
            AddNewRecipe addNewRecipeForm = new AddNewRecipe();
            addNewRecipeForm.ShowDialog();

            RecipesLV.Items.Clear();
            IQueryable<Recipe> matchedRecipes = from r in Program.RecipesDB.Recipes select r;

            if (matchedRecipes.Count() > 0)
            {
                foreach (Recipe recipe in matchedRecipes)
                {
                    RecipesLV.Items.Add(recipe.Name);
                }
            }

            //RecipeInfo_GroupBox.Hide();

        }

        private void recipeName_TB_TextChanged(object sender, EventArgs e)
        {
            currentSelectedRecipe.Name = recipeName_TB.Text;
        }

        private void cuisine_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSelectedRecipe.Cuisine = cuisine_CB.Text;
        }

        private void prepTime_NUM_ValueChanged(object sender, EventArgs e)
        {
            currentSelectedRecipe.PreparationTime = (int)prepTime_NUM.Value;
        }

        private void quit_BTN_Click(object sender, EventArgs e)
        {
            Program.loginWin.Show();

            this.Close();
        }
    }
}
