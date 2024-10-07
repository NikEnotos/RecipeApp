using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseworkApp
{
    public partial class Home : Form
    {
        UserProfile currentUser = Program.RecipesDB.UserProfiles.Where(u => u.UserID == Program.userIndex).FirstOrDefault();

        Recipe currentSelectedRecipe;

        public static string comment = string.Empty;
        public static decimal commentScore = 0.0M;

        Image spagettiIMG, curryIMG, pizzaIMG;
        
        
        

        public Home()
        {
            if (currentUser != null)
            {
                string[] s = { "\\bin" };
                string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0];

                spagettiIMG = Image.FromFile(path + "\\_Pictures_\\spagetti.png");
                curryIMG = Image.FromFile(path + "\\_Pictures_\\curry.png");
                pizzaIMG = Image.FromFile(path + "\\_Pictures_\\pizza.png");

                InitializeComponent();

                RecipeInfo_GroupBox.Hide();
                shoppingList_GroupBox.Hide();
                matchedRecipesLV.Items.Clear();
                leaveComment_BTN.Hide();
                recommends_LV.Items.Clear();
                availableIngr_GroupBox.Hide();

                IQueryable<Recipe> AllRecipes = from r in Program.RecipesDB.Recipes select r;
                foreach (var recipe in AllRecipes)
                {
                    recalculateRecipeAverageRating(recipe);
                }

                setRecommends();

            }
        }

        private void recalculateRecipeAverageRating(Recipe recipe)
        {
            if (recipe.UserRatingsReviews.Count > 0)
            {
                decimal? sum = 0;

                foreach (var review in recipe.UserRatingsReviews)
                {
                    sum = sum + review.Rating;
                }

                recipe.AverageRating = sum / recipe.UserRatingsReviews.Count;
            }

        }

        // SEARCH
        private void searchBTN_Click(object sender, EventArgs e)
        {
            RecipeInfo_GroupBox.Hide();
            shoppingList_GroupBox.Hide();
            matchedRecipesLV.Items.Clear();
            leaveComment_BTN.Hide();

            setSearchList();

        }




        // SELECT RECIPE
        private void matchedRecipesLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecipeInfo_GroupBox.Show();
            shoppingList_GroupBox.Show();
            leaveComment_BTN.Show();

            if (matchedRecipesLV.SelectedItems.Count > 0)
            {
                Ingredients_LV.Items.Clear();
                comments_LV.Items.Clear();
                shoppingList_LV.Items.Clear();

                // Change group box name for selected recipe name
                string recipeName = RecipeInfo_GroupBox.Text = matchedRecipesLV.SelectedItems[0].Text;

                Recipe selectedRecipe = Program.RecipesDB.Recipes.Where(r => r.Name == recipeName).FirstOrDefault();
                currentSelectedRecipe = selectedRecipe;

                if (selectedRecipe != null)
                {
                    recipeCuisine_Lable.Text = "Cuisine: " + selectedRecipe.Cuisine;

                    preparationTime_Lable.Text = "Preparation time: " + selectedRecipe.PreparationTime.ToString() + " min";

                    // SET UP INGREDIENTS
                    foreach (var ingredient in selectedRecipe.Ingredients)
                    {
                        var item = Ingredients_LV.Items.Add(ingredient.Name);
                        item.SubItems.Add(ingredient.NutritionalInfo);
                        item.SubItems[0].Font = new Font("Arial", 10, FontStyle.Bold);

                    }

                    // SET UP COMMENTS
                    foreach (var comment in selectedRecipe.UserRatingsReviews)
                    {
                        var item = comments_LV.Items.Add(comment.UserProfile.Username + " (" + comment.Rating.ToString() + ")");
                        item.SubItems.Add(comment.Review);
                        item.SubItems[0].Font = new Font("Arial", 10, FontStyle.Bold);

                    }

                    if (selectedRecipe.UserProfiles.Contains(currentUser))
                    {
                        addToFavorits_BTN.Text = "Remove from Favorites";
                    }
                    else
                    {
                        addToFavorits_BTN.Text = "Add to Favorites";
                    }

                    // CREATE SHOPPING LIST
                    foreach (var item in currentSelectedRecipe.Ingredients)
                    {
                        if (!Program.availableIngredients.Contains(item))
                        {
                            shoppingList_LV.Items.Add(item.Name);
                        }
                    }

                    // SET PICTURE
                    switch (currentSelectedRecipe.Name)
                    {
                        case "Spaghetti Bolognese":
                            recipeIMG.Image = spagettiIMG;
                            break;

                        case "Chicken Curry":
                            recipeIMG.Image = curryIMG;
                            break;

                        case "Pizza Margherita":
                            recipeIMG.Image = pizzaIMG;
                            break;
                        default:
                            recipeIMG.Image = null;
                            break;

                    }

                }

                //Ingredient matchedIngredients = Program.RecipesDB.Ingredients.Where(ingr => ingr.Name.Contains("tom")).FirstOrDefault();
                // MessageBox.Show("" + selectedRecipe.Ingredients.Contains(matchedIngredients));

            }



        }

        private void favoritRecipesBTN_Click(object sender, EventArgs e)
        {
            RecipeInfo_GroupBox.Hide();
            shoppingList_GroupBox.Hide();
            leaveComment_BTN.Hide();

            matchedRecipesLV.Items.Clear();

            List<Recipe> favoriteRecipes = Program.RecipesDB.Recipes.ToList().Where(r => r.UserProfiles.Contains(currentUser)).ToList();

            if (favoriteRecipes != null)
            {
                foreach (Recipe recipe in favoriteRecipes)
                {
                    var item = matchedRecipesLV.Items.Add(recipe.Name);

                    if (recipe.AverageRating != null)
                    {
                        item.SubItems.Add("AverageRating: " + recipe.AverageRating.ToString()[0] +
                        recipe.AverageRating.ToString()[1] +
                        recipe.AverageRating.ToString()[2] +
                        recipe.AverageRating.ToString()[3]);
                    }
                }
            }

        }

        private void setPrefBTN_Click(object sender, EventArgs e)
        {
            setPreferences setPreferencesForm = new setPreferences();

            setPreferencesForm.ShowDialog();

            setRecommends();
        }

        private void addToFavorits_BTN_Click(object sender, EventArgs e)
        {
            if (currentSelectedRecipe != null)
            {

                if (currentSelectedRecipe.UserProfiles.Contains(currentUser))
                {
                    addToFavorits_BTN.Text = "Add to Favorites";
                    currentSelectedRecipe.UserProfiles.Remove(currentUser);
                }
                else
                {
                    addToFavorits_BTN.Text = "Remove from Favorites";
                    currentSelectedRecipe.UserProfiles.Add(currentUser);
                }

                try
                {
                    Program.RecipesDB.SaveChanges();
                    //MessageBox.Show("Saved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.loginWin.Close();
        }

        private void addIngredients_Click(object sender, EventArgs e)
        {
            availableIngr setAvailableIngr = new availableIngr();

            setAvailableIngr.ShowDialog();

            AvailableIngredients_LV.Items.Clear();
            if (Program.availableIngredients.Count > 0)
            {
                availableIngr_GroupBox.Show();
                foreach (var item in Program.availableIngredients)
                {
                    AvailableIngredients_LV.Items.Add(item.Name);
                }
            }
            else 
            {
                availableIngr_GroupBox.Hide();
            }

            shoppingList_LV.Items.Clear();
            if (currentSelectedRecipe != null)
            {
                foreach (var item in currentSelectedRecipe.Ingredients)
                {
                    if (!Program.availableIngredients.Contains(item))
                    {
                        shoppingList_LV.Items.Add(item.Name);
                    }
                }
            }

            setRecommends();
        }

        private void leaveComment_BTN_Click(object sender, EventArgs e)
        {
            leaveComment leaveComment = new leaveComment();
            leaveComment.ShowDialog();


            if (commentScore > 0)
            {
                UserRatingsReview reviewFromCurrentuser = Program.RecipesDB.UserRatingsReviews.Where(u => u.UserID == Program.userIndex && u.RecipeID == currentSelectedRecipe.RecipeID).FirstOrDefault();

                UserRatingsReview userRatingsReview = new UserRatingsReview();

                userRatingsReview.UserID = currentUser.UserID;
                userRatingsReview.RecipeID = currentSelectedRecipe.RecipeID;
                userRatingsReview.Rating = commentScore;
                userRatingsReview.Review = comment;

                if (reviewFromCurrentuser == null)
                {
                    Program.RecipesDB.UserRatingsReviews.Add(userRatingsReview);
                }
                else
                {
                    Program.RecipesDB.UserRatingsReviews.Remove(reviewFromCurrentuser);
                    Program.RecipesDB.UserRatingsReviews.Add(userRatingsReview);
                }

                try
                {
                    Program.RecipesDB.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                comment = string.Empty;
                commentScore = 0.0M;

                comments_LV.Items.Clear();
                foreach (var comment in currentSelectedRecipe.UserRatingsReviews)
                {
                    var item = comments_LV.Items.Add(comment.UserProfile.Username + " (" + comment.Rating.ToString() + ")");
                    item.SubItems.Add(comment.Review);
                    item.SubItems[0].Font = new Font("Arial", 10, FontStyle.Bold);

                }

                recalculateRecipeAverageRating(currentSelectedRecipe);

                // SEARCH REFRESH
                setSearchList();
                setRecommends();

            }

        }

        private void setRecommends()
        {
            recommends_LV.Items.Clear();

            // SET 3 RECOMMENDER RECIPES BASED ON PREFERENCES
            IQueryable<Recipe> apropriateRecipes = from r in Program.RecipesDB.Recipes select r;
            if (apropriateRecipes.Count() > 0)
            {
               
                foreach (var recipe in apropriateRecipes)
                {
                    if (recommends_LV.Items.Count == 3) break;

                    bool isApropriate;
                    switch (currentUser.DietaryPreferences) 
                    {
                        case "Vegetarian":
                            isApropriate = true;
                            foreach (var ingr in recipe.Ingredients)
                            {
                                if (ingr.Name == "Chicken Breast" || ingr.Name == "Ground Beef")
                                {
                                    isApropriate = false;
                                    break;
                                }
                            }
                            if (isApropriate)
                            {
                                var item1 = recommends_LV.Items.Add(recipe.Name);

                                if (recipe.AverageRating != null)
                                {
                                    item1.SubItems.Add("AverageRating: " + recipe.AverageRating.ToString()[0] +
                                        recipe.AverageRating.ToString()[1] +
                                        recipe.AverageRating.ToString()[2] +
                                        recipe.AverageRating.ToString()[3]);
                                }
                            }
                            break;

                        case "Vegan":
                            isApropriate = true;
                            foreach (var ingr in recipe.Ingredients)
                            {
                                if (ingr.Name == "Chicken Breast" || ingr.Name == "Ground Beef" || ingr.Name == "Mozzarella Cheese" || ingr.Name == "Tofu")
                                {
                                    isApropriate = false;
                                    break;
                                }
                            }
                            if (isApropriate)
                            {
                                var item2 = recommends_LV.Items.Add(recipe.Name);

                                if (recipe.AverageRating != null)
                                {
                                    item2.SubItems.Add("AverageRating: " + recipe.AverageRating.ToString()[0] +
                                        recipe.AverageRating.ToString()[1] +
                                        recipe.AverageRating.ToString()[2] +
                                        recipe.AverageRating.ToString()[3]);
                                }
                            }
                            break;

                        case "Omnivore":

                                var item3 = recommends_LV.Items.Add(recipe.Name);

                                if (recipe.AverageRating != null)
                                {
                                    item3.SubItems.Add("AverageRating: " + recipe.AverageRating.ToString()[0] +
                                        recipe.AverageRating.ToString()[1] +
                                        recipe.AverageRating.ToString()[2] +
                                        recipe.AverageRating.ToString()[3]);
                                }
                                break;

                        case "Pescatarian":
                            isApropriate = true;
                            foreach (var ingr in recipe.Ingredients)
                            {
                                if (ingr.Name == "Chicken Breast" || ingr.Name == "Ground Beef")
                                {
                                    isApropriate = false;
                                    break;
                                }
                            }
                            if (isApropriate)
                            {
                                var item4 = recommends_LV.Items.Add(recipe.Name);

                                if (recipe.AverageRating != null)
                                {
                                    item4.SubItems.Add("AverageRating: " + recipe.AverageRating.ToString()[0] +
                                        recipe.AverageRating.ToString()[1] +
                                        recipe.AverageRating.ToString()[2] +
                                        recipe.AverageRating.ToString()[3]);
                                }
                            }
                            break;

                        default:

                            var item5 = recommends_LV.Items.Add(recipe.Name);

                            if (recipe.AverageRating != null)
                            {
                                item5.SubItems.Add("AverageRating: " + recipe.AverageRating.ToString()[0] +
                                    recipe.AverageRating.ToString()[1] +
                                    recipe.AverageRating.ToString()[2] +
                                    recipe.AverageRating.ToString()[3]);
                            }
                            break;

                    }
                }
            }



            // SET RECOMMENDER RECIPES BASED ON AVAILABLE INGREDIENTS
            IQueryable<Ingredient> allIngredients = from ingr in Program.RecipesDB.Ingredients select ingr;
            if (allIngredients.Count() > 0)
            {

                List<Ingredient> availableIngredients = new List<Ingredient>();

                foreach (Ingredient ingredient in allIngredients)
                {

                    foreach (var ingr in AvailableIngredients_LV.Items)
                    {
                        if (ingr.ToString().Contains(ingredient.Name))
                        {
                            availableIngredients.Add(ingredient);
                        }
                    }
                }

                foreach (var ingr in availableIngredients)
                {
                    List<Recipe> matchedRecipesbyIngredient = Program.RecipesDB.Recipes.ToList().Where(r => r.Ingredients.Contains(ingr)).ToList();

                    if (matchedRecipesbyIngredient != null)
                    {
                        foreach (Recipe recipe in matchedRecipesbyIngredient)
                        {

                            bool isContain = false;
                            foreach (var item in recommends_LV.Items)
                            {
                                if (item.ToString().Contains(recipe.Name))
                                {
                                    isContain = true;
                                    break;
                                }
                            }

                            if (!isContain)
                            {
                                var item = recommends_LV.Items.Add(recipe.Name);

                                if (recipe.AverageRating != null)
                                {
                                    item.SubItems.Add("AverageRating: " + recipe.AverageRating.ToString()[0] +
                                        recipe.AverageRating.ToString()[1] +
                                        recipe.AverageRating.ToString()[2] +
                                        recipe.AverageRating.ToString()[3]);
                                }
                            }
                        }
                    }
                }

            }


        }


        private void setSearchList()
        {
            matchedRecipesLV.Items.Clear();

            // SEARCH FOR RECIPE NAME OR CUISINE
            IQueryable<Recipe> matchedRecipes = from r in Program.RecipesDB.Recipes where r.Name.Contains(searchTB.Text) || r.Cuisine.Contains(searchTB.Text) select r;

            if (matchedRecipes.Count() > 0)
            {
                foreach (Recipe recipe in matchedRecipes)
                {
                    var item = matchedRecipesLV.Items.Add(recipe.Name);

                    if (recipe.AverageRating != null)
                    {
                        item.SubItems.Add("AverageRating: " + recipe.AverageRating.ToString()[0] +
                        recipe.AverageRating.ToString()[1] +
                        recipe.AverageRating.ToString()[2] +
                        recipe.AverageRating.ToString()[3]);
                    }

                }
            }


            // SEARCH FOR RECIPE INGREDIENTS
            IQueryable<Ingredient> matchedIngredients = from ingr in Program.RecipesDB.Ingredients where ingr.Name.Contains(searchTB.Text) select ingr;
            if (matchedIngredients.Count() > 0)
            {
                foreach (Ingredient ingredient in matchedIngredients)
                {

                    List<Recipe> matchedRecipesbyIngredient = Program.RecipesDB.Recipes.ToList().Where(r => r.Ingredients.Contains(ingredient)).ToList();

                    if (matchedRecipesbyIngredient != null)
                    {
                        foreach (Recipe recipe in matchedRecipesbyIngredient)
                        {
                            bool isContain = false;
                            foreach (var item in matchedRecipesLV.Items)
                            {
                                if (item.ToString().Contains(recipe.Name))
                                {
                                    isContain = true;
                                    break;
                                }
                            }

                            if (!isContain)
                            {
                                var item = matchedRecipesLV.Items.Add(recipe.Name);

                                if (recipe.AverageRating != null)
                                {
                                    item.SubItems.Add("AverageRating: " + recipe.AverageRating.ToString()[0] +
                                        recipe.AverageRating.ToString()[1] +
                                        recipe.AverageRating.ToString()[2] +
                                        recipe.AverageRating.ToString()[3]);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void recommends_LV_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecipeInfo_GroupBox.Show();
            shoppingList_GroupBox.Show();
            leaveComment_BTN.Show();

            if (recommends_LV.SelectedItems.Count > 0)
            {
                Ingredients_LV.Items.Clear();
                comments_LV.Items.Clear();
                shoppingList_LV.Items.Clear();

                // Change group box name for selected recipe name
                string recipeName = RecipeInfo_GroupBox.Text = recommends_LV.SelectedItems[0].Text;

                Recipe selectedRecipe = Program.RecipesDB.Recipes.Where(r => r.Name == recipeName).FirstOrDefault();
                currentSelectedRecipe = selectedRecipe;

                if (selectedRecipe != null)
                {
                    recipeCuisine_Lable.Text = "Cuisine: " + selectedRecipe.Cuisine;

                    preparationTime_Lable.Text = "Preparation time: " + selectedRecipe.PreparationTime.ToString() + " min";

                    // SET UP INGREDIENTS
                    foreach (var ingredient in selectedRecipe.Ingredients)
                    {
                        var item = Ingredients_LV.Items.Add(ingredient.Name);
                        item.SubItems.Add(ingredient.NutritionalInfo);
                        item.SubItems[0].Font = new Font("Arial", 10, FontStyle.Bold);

                    }

                    // SET UP COMMENTS
                    foreach (var comment in selectedRecipe.UserRatingsReviews)
                    {
                        var item = comments_LV.Items.Add(comment.UserProfile.Username + " (" + comment.Rating.ToString() + ")");
                        item.SubItems.Add(comment.Review);
                        item.SubItems[0].Font = new Font("Arial", 10, FontStyle.Bold);

                    }
                    
                    if (selectedRecipe.UserProfiles.Contains(currentUser))
                    {
                        addToFavorits_BTN.Text = "Remove from Favorites";
                    }
                    else
                    {
                        addToFavorits_BTN.Text = "Add to Favorites";
                    }

                    // CREATE SHOPPING LIST
                    foreach (var item in currentSelectedRecipe.Ingredients)
                    {
                        if (!Program.availableIngredients.Contains(item))
                        {
                            shoppingList_LV.Items.Add(item.Name);
                        }
                    }

                    // SET PICTURE
                    switch (currentSelectedRecipe.Name)
                    {
                        case "Spaghetti Bolognese":
                            recipeIMG.Image = spagettiIMG;
                            break;

                        case "Chicken Curry":
                            recipeIMG.Image = curryIMG;
                            break;

                        case "Pizza Margherita":
                            recipeIMG.Image = pizzaIMG;
                            break;
                        default:
                            recipeIMG.Image = null;
                            break;

                    }
                }
            }



        }
    }
}
