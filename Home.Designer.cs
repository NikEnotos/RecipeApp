using System.Windows.Forms;

namespace CourseworkApp
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("asdasd");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("asdqwe123");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("asdasd");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("asdqwe123");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.searchTB = new System.Windows.Forms.TextBox();
            this.matchedRecipesLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchBTN = new System.Windows.Forms.Button();
            this.setPrefBTN = new System.Windows.Forms.Button();
            this.addIngredients = new System.Windows.Forms.Button();
            this.RecipeInfo_GroupBox = new System.Windows.Forms.GroupBox();
            this.recipeIMG = new System.Windows.Forms.PictureBox();
            this.Comments_GroupBox = new System.Windows.Forms.GroupBox();
            this.comments_LV = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.leaveComment_BTN = new System.Windows.Forms.Button();
            this.addToFavorits_BTN = new System.Windows.Forms.Button();
            this.preparationTime_Lable = new System.Windows.Forms.Label();
            this.recipeCuisine_Lable = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ingredients_LV = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.availableIngr_GroupBox = new System.Windows.Forms.GroupBox();
            this.AvailableIngredients_LV = new System.Windows.Forms.ListView();
            this.shoppingList_GroupBox = new System.Windows.Forms.GroupBox();
            this.shoppingList_LV = new System.Windows.Forms.ListView();
            this.favoritRecipesBTN = new System.Windows.Forms.Button();
            this.recomendations_GB = new System.Windows.Forms.GroupBox();
            this.recommends_LV = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RecipeInfo_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeIMG)).BeginInit();
            this.Comments_GroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.availableIngr_GroupBox.SuspendLayout();
            this.shoppingList_GroupBox.SuspendLayout();
            this.recomendations_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.Location = new System.Drawing.Point(12, 12);
            this.searchTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(399, 39);
            this.searchTB.TabIndex = 0;
            // 
            // matchedRecipesLV
            // 
            this.matchedRecipesLV.BackColor = System.Drawing.SystemColors.Window;
            this.matchedRecipesLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.matchedRecipesLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchedRecipesLV.HideSelection = false;
            listViewItem2.ToolTipText = "qeqwe";
            this.matchedRecipesLV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.matchedRecipesLV.Location = new System.Drawing.Point(12, 66);
            this.matchedRecipesLV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.matchedRecipesLV.Name = "matchedRecipesLV";
            this.matchedRecipesLV.Size = new System.Drawing.Size(519, 336);
            this.matchedRecipesLV.TabIndex = 1;
            this.matchedRecipesLV.UseCompatibleStateImageBehavior = false;
            this.matchedRecipesLV.View = System.Windows.Forms.View.Tile;
            this.matchedRecipesLV.SelectedIndexChanged += new System.EventHandler(this.matchedRecipesLV_SelectedIndexChanged);
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.Color.Transparent;
            this.searchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.searchBTN.Location = new System.Drawing.Point(416, 12);
            this.searchBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(115, 39);
            this.searchBTN.TabIndex = 2;
            this.searchBTN.Text = "Search";
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // setPrefBTN
            // 
            this.setPrefBTN.BackColor = System.Drawing.Color.Transparent;
            this.setPrefBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setPrefBTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPrefBTN.Location = new System.Drawing.Point(1171, 12);
            this.setPrefBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setPrefBTN.Name = "setPrefBTN";
            this.setPrefBTN.Size = new System.Drawing.Size(197, 39);
            this.setPrefBTN.TabIndex = 3;
            this.setPrefBTN.Text = "Set preferences";
            this.setPrefBTN.UseVisualStyleBackColor = false;
            this.setPrefBTN.Click += new System.EventHandler(this.setPrefBTN_Click);
            // 
            // addIngredients
            // 
            this.addIngredients.BackColor = System.Drawing.Color.Transparent;
            this.addIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addIngredients.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIngredients.Location = new System.Drawing.Point(864, 12);
            this.addIngredients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addIngredients.Name = "addIngredients";
            this.addIngredients.Size = new System.Drawing.Size(300, 39);
            this.addIngredients.TabIndex = 4;
            this.addIngredients.Text = "Set available ingredients";
            this.addIngredients.UseVisualStyleBackColor = false;
            this.addIngredients.Click += new System.EventHandler(this.addIngredients_Click);
            // 
            // RecipeInfo_GroupBox
            // 
            this.RecipeInfo_GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.RecipeInfo_GroupBox.Controls.Add(this.recipeIMG);
            this.RecipeInfo_GroupBox.Controls.Add(this.Comments_GroupBox);
            this.RecipeInfo_GroupBox.Controls.Add(this.addToFavorits_BTN);
            this.RecipeInfo_GroupBox.Controls.Add(this.preparationTime_Lable);
            this.RecipeInfo_GroupBox.Controls.Add(this.recipeCuisine_Lable);
            this.RecipeInfo_GroupBox.Controls.Add(this.groupBox1);
            this.RecipeInfo_GroupBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeInfo_GroupBox.Location = new System.Drawing.Point(547, 66);
            this.RecipeInfo_GroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecipeInfo_GroupBox.Name = "RecipeInfo_GroupBox";
            this.RecipeInfo_GroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecipeInfo_GroupBox.Size = new System.Drawing.Size(556, 646);
            this.RecipeInfo_GroupBox.TabIndex = 5;
            this.RecipeInfo_GroupBox.TabStop = false;
            this.RecipeInfo_GroupBox.Text = "Recipe Information ";
            // 
            // recipeIMG
            // 
            this.recipeIMG.Location = new System.Drawing.Point(377, 443);
            this.recipeIMG.Name = "recipeIMG";
            this.recipeIMG.Size = new System.Drawing.Size(170, 170);
            this.recipeIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.recipeIMG.TabIndex = 5;
            this.recipeIMG.TabStop = false;
            // 
            // Comments_GroupBox
            // 
            this.Comments_GroupBox.Controls.Add(this.comments_LV);
            this.Comments_GroupBox.Controls.Add(this.leaveComment_BTN);
            this.Comments_GroupBox.Location = new System.Drawing.Point(6, 409);
            this.Comments_GroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Comments_GroupBox.Name = "Comments_GroupBox";
            this.Comments_GroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Comments_GroupBox.Size = new System.Drawing.Size(365, 231);
            this.Comments_GroupBox.TabIndex = 2;
            this.Comments_GroupBox.TabStop = false;
            this.Comments_GroupBox.Text = "Comments";
            // 
            // comments_LV
            // 
            this.comments_LV.BackColor = System.Drawing.SystemColors.Menu;
            this.comments_LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.comments_LV.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comments_LV.HideSelection = false;
            this.comments_LV.Location = new System.Drawing.Point(5, 34);
            this.comments_LV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comments_LV.Name = "comments_LV";
            this.comments_LV.Size = new System.Drawing.Size(352, 149);
            this.comments_LV.TabIndex = 1;
            this.comments_LV.UseCompatibleStateImageBehavior = false;
            this.comments_LV.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Width = 210;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "3";
            this.columnHeader7.Width = 277;
            // 
            // leaveComment_BTN
            // 
            this.leaveComment_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.leaveComment_BTN.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveComment_BTN.Location = new System.Drawing.Point(131, 187);
            this.leaveComment_BTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leaveComment_BTN.Name = "leaveComment_BTN";
            this.leaveComment_BTN.Size = new System.Drawing.Size(226, 37);
            this.leaveComment_BTN.TabIndex = 5;
            this.leaveComment_BTN.Text = "Leave a comment";
            this.leaveComment_BTN.UseVisualStyleBackColor = true;
            this.leaveComment_BTN.Click += new System.EventHandler(this.leaveComment_BTN_Click);
            // 
            // addToFavorits_BTN
            // 
            this.addToFavorits_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addToFavorits_BTN.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToFavorits_BTN.Location = new System.Drawing.Point(402, 42);
            this.addToFavorits_BTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addToFavorits_BTN.Name = "addToFavorits_BTN";
            this.addToFavorits_BTN.Size = new System.Drawing.Size(132, 52);
            this.addToFavorits_BTN.TabIndex = 4;
            this.addToFavorits_BTN.Text = "Remove from Favorites";
            this.addToFavorits_BTN.UseVisualStyleBackColor = true;
            this.addToFavorits_BTN.Click += new System.EventHandler(this.addToFavorits_BTN_Click);
            // 
            // preparationTime_Lable
            // 
            this.preparationTime_Lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.preparationTime_Lable.AutoSize = true;
            this.preparationTime_Lable.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preparationTime_Lable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.preparationTime_Lable.Location = new System.Drawing.Point(21, 82);
            this.preparationTime_Lable.Name = "preparationTime_Lable";
            this.preparationTime_Lable.Size = new System.Drawing.Size(341, 37);
            this.preparationTime_Lable.TabIndex = 3;
            this.preparationTime_Lable.Text = "Preparation time: 23 min";
            // 
            // recipeCuisine_Lable
            // 
            this.recipeCuisine_Lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.recipeCuisine_Lable.AutoSize = true;
            this.recipeCuisine_Lable.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeCuisine_Lable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.recipeCuisine_Lable.Location = new System.Drawing.Point(21, 42);
            this.recipeCuisine_Lable.Name = "recipeCuisine_Lable";
            this.recipeCuisine_Lable.Size = new System.Drawing.Size(165, 32);
            this.recipeCuisine_Lable.TabIndex = 2;
            this.recipeCuisine_Lable.Text = "Recipe name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Ingredients_LV);
            this.groupBox1.Location = new System.Drawing.Point(6, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(544, 274);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredients";
            // 
            // Ingredients_LV
            // 
            this.Ingredients_LV.BackColor = System.Drawing.SystemColors.Menu;
            this.Ingredients_LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.Ingredients_LV.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingredients_LV.HideSelection = false;
            this.Ingredients_LV.Location = new System.Drawing.Point(5, 34);
            this.Ingredients_LV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ingredients_LV.Name = "Ingredients_LV";
            this.Ingredients_LV.Size = new System.Drawing.Size(532, 234);
            this.Ingredients_LV.TabIndex = 1;
            this.Ingredients_LV.UseCompatibleStateImageBehavior = false;
            this.Ingredients_LV.View = System.Windows.Forms.View.Tile;
            // 
            // availableIngr_GroupBox
            // 
            this.availableIngr_GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.availableIngr_GroupBox.Controls.Add(this.AvailableIngredients_LV);
            this.availableIngr_GroupBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableIngr_GroupBox.Location = new System.Drawing.Point(1117, 66);
            this.availableIngr_GroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.availableIngr_GroupBox.Name = "availableIngr_GroupBox";
            this.availableIngr_GroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.availableIngr_GroupBox.Size = new System.Drawing.Size(251, 336);
            this.availableIngr_GroupBox.TabIndex = 6;
            this.availableIngr_GroupBox.TabStop = false;
            this.availableIngr_GroupBox.Text = "Available Ingredients";
            // 
            // AvailableIngredients_LV
            // 
            this.AvailableIngredients_LV.BackColor = System.Drawing.SystemColors.Menu;
            this.AvailableIngredients_LV.HideSelection = false;
            this.AvailableIngredients_LV.Location = new System.Drawing.Point(7, 34);
            this.AvailableIngredients_LV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AvailableIngredients_LV.Name = "AvailableIngredients_LV";
            this.AvailableIngredients_LV.Size = new System.Drawing.Size(237, 295);
            this.AvailableIngredients_LV.TabIndex = 0;
            this.AvailableIngredients_LV.UseCompatibleStateImageBehavior = false;
            this.AvailableIngredients_LV.View = System.Windows.Forms.View.Tile;
            // 
            // shoppingList_GroupBox
            // 
            this.shoppingList_GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.shoppingList_GroupBox.Controls.Add(this.shoppingList_LV);
            this.shoppingList_GroupBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingList_GroupBox.Location = new System.Drawing.Point(1117, 407);
            this.shoppingList_GroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shoppingList_GroupBox.Name = "shoppingList_GroupBox";
            this.shoppingList_GroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shoppingList_GroupBox.Size = new System.Drawing.Size(251, 305);
            this.shoppingList_GroupBox.TabIndex = 7;
            this.shoppingList_GroupBox.TabStop = false;
            this.shoppingList_GroupBox.Text = "Shopping List";
            // 
            // shoppingList_LV
            // 
            this.shoppingList_LV.BackColor = System.Drawing.SystemColors.Menu;
            this.shoppingList_LV.HideSelection = false;
            this.shoppingList_LV.Location = new System.Drawing.Point(7, 33);
            this.shoppingList_LV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shoppingList_LV.Name = "shoppingList_LV";
            this.shoppingList_LV.Size = new System.Drawing.Size(237, 266);
            this.shoppingList_LV.TabIndex = 1;
            this.shoppingList_LV.UseCompatibleStateImageBehavior = false;
            this.shoppingList_LV.View = System.Windows.Forms.View.Tile;
            // 
            // favoritRecipesBTN
            // 
            this.favoritRecipesBTN.BackColor = System.Drawing.Color.Transparent;
            this.favoritRecipesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.favoritRecipesBTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favoritRecipesBTN.Location = new System.Drawing.Point(692, 12);
            this.favoritRecipesBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.favoritRecipesBTN.Name = "favoritRecipesBTN";
            this.favoritRecipesBTN.Size = new System.Drawing.Size(165, 39);
            this.favoritRecipesBTN.TabIndex = 8;
            this.favoritRecipesBTN.Text = "My Favorites";
            this.favoritRecipesBTN.UseVisualStyleBackColor = false;
            this.favoritRecipesBTN.Click += new System.EventHandler(this.favoritRecipesBTN_Click);
            // 
            // recomendations_GB
            // 
            this.recomendations_GB.BackColor = System.Drawing.Color.Transparent;
            this.recomendations_GB.Controls.Add(this.recommends_LV);
            this.recomendations_GB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recomendations_GB.Location = new System.Drawing.Point(12, 407);
            this.recomendations_GB.Name = "recomendations_GB";
            this.recomendations_GB.Size = new System.Drawing.Size(519, 306);
            this.recomendations_GB.TabIndex = 9;
            this.recomendations_GB.TabStop = false;
            this.recomendations_GB.Text = "Recommendations";
            // 
            // recommends_LV
            // 
            this.recommends_LV.BackColor = System.Drawing.SystemColors.Window;
            this.recommends_LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9});
            this.recommends_LV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommends_LV.HideSelection = false;
            listViewItem4.ToolTipText = "qeqwe";
            this.recommends_LV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.recommends_LV.Location = new System.Drawing.Point(6, 40);
            this.recommends_LV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recommends_LV.Name = "recommends_LV";
            this.recommends_LV.Size = new System.Drawing.Size(507, 259);
            this.recommends_LV.TabIndex = 10;
            this.recommends_LV.UseCompatibleStateImageBehavior = false;
            this.recommends_LV.View = System.Windows.Forms.View.Tile;
            this.recommends_LV.SelectedIndexChanged += new System.EventHandler(this.recommends_LV_SelectedIndexChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1387, 724);
            this.Controls.Add(this.recomendations_GB);
            this.Controls.Add(this.favoritRecipesBTN);
            this.Controls.Add(this.shoppingList_GroupBox);
            this.Controls.Add(this.availableIngr_GroupBox);
            this.Controls.Add(this.RecipeInfo_GroupBox);
            this.Controls.Add(this.addIngredients);
            this.Controls.Add(this.setPrefBTN);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.matchedRecipesLV);
            this.Controls.Add(this.searchTB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.RecipeInfo_GroupBox.ResumeLayout(false);
            this.RecipeInfo_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeIMG)).EndInit();
            this.Comments_GroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.availableIngr_GroupBox.ResumeLayout(false);
            this.shoppingList_GroupBox.ResumeLayout(false);
            this.recomendations_GB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.ListView matchedRecipesLV;
        private System.Windows.Forms.Button searchBTN;
        private Button setPrefBTN;
        private Button addIngredients;
        private GroupBox RecipeInfo_GroupBox;
        private GroupBox availableIngr_GroupBox;
        private GroupBox shoppingList_GroupBox;
        private ListView AvailableIngredients_LV;
        private ListView shoppingList_LV;
        private Button favoritRecipesBTN;
        private GroupBox groupBox1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label recipeCuisine_Lable;
        private Button addToFavorits_BTN;
        private Label preparationTime_Lable;
        private GroupBox Comments_GroupBox;
        private ListView comments_LV;
        private ListView Ingredients_LV;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button leaveComment_BTN;
        public ColumnHeader columnHeader7;
        private GroupBox recomendations_GB;
        private ListView recommends_LV;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private PictureBox recipeIMG;
    }
}