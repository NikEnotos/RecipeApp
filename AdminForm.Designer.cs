﻿namespace CourseworkApp
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.RecipesLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RecipeInfo_GroupBox = new System.Windows.Forms.GroupBox();
            this.deleteRecipe_BTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.recipeName_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prepTime_NUM = new System.Windows.Forms.NumericUpDown();
            this.ingredientsList_CB = new System.Windows.Forms.ComboBox();
            this.cuisine_CB = new System.Windows.Forms.ComboBox();
            this.cancel_BTN = new System.Windows.Forms.Button();
            this.save_BTN = new System.Windows.Forms.Button();
            this.preparationTime_Lable = new System.Windows.Forms.Label();
            this.recipeCuisine_Lable = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteItem_BTN = new System.Windows.Forms.Button();
            this.addIngr_BTN = new System.Windows.Forms.Button();
            this.Ingredients_LV = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addRecipe_BTN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.quit_BTN = new System.Windows.Forms.Button();
            this.RecipeInfo_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prepTime_NUM)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecipesLV
            // 
            this.RecipesLV.BackColor = System.Drawing.SystemColors.Menu;
            this.RecipesLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.RecipesLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipesLV.HideSelection = false;
            listViewItem2.ToolTipText = "qeqwe";
            this.RecipesLV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.RecipesLV.Location = new System.Drawing.Point(6, 47);
            this.RecipesLV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecipesLV.Name = "RecipesLV";
            this.RecipesLV.Size = new System.Drawing.Size(444, 618);
            this.RecipesLV.TabIndex = 2;
            this.RecipesLV.UseCompatibleStateImageBehavior = false;
            this.RecipesLV.View = System.Windows.Forms.View.Tile;
            this.RecipesLV.SelectedIndexChanged += new System.EventHandler(this.matchedRecipesLV_SelectedIndexChanged_1);
            // 
            // RecipeInfo_GroupBox
            // 
            this.RecipeInfo_GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.RecipeInfo_GroupBox.Controls.Add(this.deleteRecipe_BTN);
            this.RecipeInfo_GroupBox.Controls.Add(this.label2);
            this.RecipeInfo_GroupBox.Controls.Add(this.recipeName_TB);
            this.RecipeInfo_GroupBox.Controls.Add(this.label1);
            this.RecipeInfo_GroupBox.Controls.Add(this.prepTime_NUM);
            this.RecipeInfo_GroupBox.Controls.Add(this.ingredientsList_CB);
            this.RecipeInfo_GroupBox.Controls.Add(this.cuisine_CB);
            this.RecipeInfo_GroupBox.Controls.Add(this.cancel_BTN);
            this.RecipeInfo_GroupBox.Controls.Add(this.save_BTN);
            this.RecipeInfo_GroupBox.Controls.Add(this.preparationTime_Lable);
            this.RecipeInfo_GroupBox.Controls.Add(this.recipeCuisine_Lable);
            this.RecipeInfo_GroupBox.Controls.Add(this.groupBox1);
            this.RecipeInfo_GroupBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeInfo_GroupBox.Location = new System.Drawing.Point(474, 11);
            this.RecipeInfo_GroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecipeInfo_GroupBox.Name = "RecipeInfo_GroupBox";
            this.RecipeInfo_GroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecipeInfo_GroupBox.Size = new System.Drawing.Size(556, 740);
            this.RecipeInfo_GroupBox.TabIndex = 6;
            this.RecipeInfo_GroupBox.TabStop = false;
            this.RecipeInfo_GroupBox.Text = "Recipe Information ";
            // 
            // deleteRecipe_BTN
            // 
            this.deleteRecipe_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteRecipe_BTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRecipe_BTN.Location = new System.Drawing.Point(139, 684);
            this.deleteRecipe_BTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteRecipe_BTN.Name = "deleteRecipe_BTN";
            this.deleteRecipe_BTN.Size = new System.Drawing.Size(274, 42);
            this.deleteRecipe_BTN.TabIndex = 17;
            this.deleteRecipe_BTN.Text = "Delete selected Recipe";
            this.deleteRecipe_BTN.UseVisualStyleBackColor = true;
            this.deleteRecipe_BTN.Click += new System.EventHandler(this.deleteRecipe_BTN_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(365, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "min";
            // 
            // recipeName_TB
            // 
            this.recipeName_TB.Location = new System.Drawing.Point(243, 48);
            this.recipeName_TB.Name = "recipeName_TB";
            this.recipeName_TB.Size = new System.Drawing.Size(300, 42);
            this.recipeName_TB.TabIndex = 13;
            this.recipeName_TB.TextChanged += new System.EventHandler(this.recipeName_TB_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Recipe name: ";
            // 
            // prepTime_NUM
            // 
            this.prepTime_NUM.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prepTime_NUM.Location = new System.Drawing.Point(284, 141);
            this.prepTime_NUM.Name = "prepTime_NUM";
            this.prepTime_NUM.Size = new System.Drawing.Size(75, 39);
            this.prepTime_NUM.TabIndex = 11;
            this.prepTime_NUM.ValueChanged += new System.EventHandler(this.prepTime_NUM_ValueChanged);
            // 
            // ingredientsList_CB
            // 
            this.ingredientsList_CB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsList_CB.FormattingEnabled = true;
            this.ingredientsList_CB.Location = new System.Drawing.Point(12, 221);
            this.ingredientsList_CB.Name = "ingredientsList_CB";
            this.ingredientsList_CB.Size = new System.Drawing.Size(298, 34);
            this.ingredientsList_CB.TabIndex = 10;
            // 
            // cuisine_CB
            // 
            this.cuisine_CB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuisine_CB.FormattingEnabled = true;
            this.cuisine_CB.Items.AddRange(new object[] {
            "Italian",
            "Chinese",
            "Indian",
            "American",
            "Japanese",
            "Mexican",
            "Thai",
            "Dessert",
            "Mediterranean"});
            this.cuisine_CB.Location = new System.Drawing.Point(149, 100);
            this.cuisine_CB.Name = "cuisine_CB";
            this.cuisine_CB.Size = new System.Drawing.Size(201, 33);
            this.cuisine_CB.TabIndex = 9;
            this.cuisine_CB.SelectedIndexChanged += new System.EventHandler(this.cuisine_CB_SelectedIndexChanged);
            // 
            // cancel_BTN
            // 
            this.cancel_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_BTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_BTN.Location = new System.Drawing.Point(12, 684);
            this.cancel_BTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_BTN.Name = "cancel_BTN";
            this.cancel_BTN.Size = new System.Drawing.Size(121, 42);
            this.cancel_BTN.TabIndex = 7;
            this.cancel_BTN.Text = "Cancel";
            this.cancel_BTN.UseVisualStyleBackColor = true;
            this.cancel_BTN.Click += new System.EventHandler(this.cancel_BTN_Click);
            // 
            // save_BTN
            // 
            this.save_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_BTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_BTN.Location = new System.Drawing.Point(419, 684);
            this.save_BTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_BTN.Name = "save_BTN";
            this.save_BTN.Size = new System.Drawing.Size(124, 42);
            this.save_BTN.TabIndex = 4;
            this.save_BTN.Text = "Save";
            this.save_BTN.UseVisualStyleBackColor = true;
            this.save_BTN.Click += new System.EventHandler(this.save_BTN_Click);
            // 
            // preparationTime_Lable
            // 
            this.preparationTime_Lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.preparationTime_Lable.AutoSize = true;
            this.preparationTime_Lable.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preparationTime_Lable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.preparationTime_Lable.Location = new System.Drawing.Point(21, 144);
            this.preparationTime_Lable.Name = "preparationTime_Lable";
            this.preparationTime_Lable.Size = new System.Drawing.Size(257, 37);
            this.preparationTime_Lable.TabIndex = 3;
            this.preparationTime_Lable.Text = "Preparation time:  ";
            // 
            // recipeCuisine_Lable
            // 
            this.recipeCuisine_Lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.recipeCuisine_Lable.AutoSize = true;
            this.recipeCuisine_Lable.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeCuisine_Lable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.recipeCuisine_Lable.Location = new System.Drawing.Point(22, 101);
            this.recipeCuisine_Lable.Name = "recipeCuisine_Lable";
            this.recipeCuisine_Lable.Size = new System.Drawing.Size(121, 32);
            this.recipeCuisine_Lable.TabIndex = 2;
            this.recipeCuisine_Lable.Text = "Cuisine: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteItem_BTN);
            this.groupBox1.Controls.Add(this.addIngr_BTN);
            this.groupBox1.Controls.Add(this.Ingredients_LV);
            this.groupBox1.Location = new System.Drawing.Point(6, 183);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(544, 491);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredients";
            // 
            // DeleteItem_BTN
            // 
            this.DeleteItem_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteItem_BTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteItem_BTN.Location = new System.Drawing.Point(421, 38);
            this.DeleteItem_BTN.Name = "DeleteItem_BTN";
            this.DeleteItem_BTN.Size = new System.Drawing.Size(116, 33);
            this.DeleteItem_BTN.TabIndex = 12;
            this.DeleteItem_BTN.Text = "Delete";
            this.DeleteItem_BTN.UseVisualStyleBackColor = true;
            this.DeleteItem_BTN.Click += new System.EventHandler(this.DeleteItem_BTN_Click);
            // 
            // addIngr_BTN
            // 
            this.addIngr_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addIngr_BTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIngr_BTN.Location = new System.Drawing.Point(310, 38);
            this.addIngr_BTN.Name = "addIngr_BTN";
            this.addIngr_BTN.Size = new System.Drawing.Size(75, 33);
            this.addIngr_BTN.TabIndex = 11;
            this.addIngr_BTN.Text = "Add";
            this.addIngr_BTN.UseVisualStyleBackColor = true;
            this.addIngr_BTN.Click += new System.EventHandler(this.addIngr_BTN_Click);
            // 
            // Ingredients_LV
            // 
            this.Ingredients_LV.BackColor = System.Drawing.SystemColors.Menu;
            this.Ingredients_LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.Ingredients_LV.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingredients_LV.HideSelection = false;
            this.Ingredients_LV.Location = new System.Drawing.Point(6, 77);
            this.Ingredients_LV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ingredients_LV.Name = "Ingredients_LV";
            this.Ingredients_LV.Size = new System.Drawing.Size(532, 406);
            this.Ingredients_LV.TabIndex = 1;
            this.Ingredients_LV.UseCompatibleStateImageBehavior = false;
            this.Ingredients_LV.View = System.Windows.Forms.View.Tile;
            // 
            // addRecipe_BTN
            // 
            this.addRecipe_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addRecipe_BTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecipe_BTN.Location = new System.Drawing.Point(214, 683);
            this.addRecipe_BTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addRecipe_BTN.Name = "addRecipe_BTN";
            this.addRecipe_BTN.Size = new System.Drawing.Size(210, 42);
            this.addRecipe_BTN.TabIndex = 16;
            this.addRecipe_BTN.Text = "Add Recipe";
            this.addRecipe_BTN.UseVisualStyleBackColor = true;
            this.addRecipe_BTN.Click += new System.EventHandler(this.addRecipe_BTN_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.quit_BTN);
            this.groupBox2.Controls.Add(this.RecipesLV);
            this.groupBox2.Controls.Add(this.addRecipe_BTN);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 738);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recipes Leist";
            // 
            // quit_BTN
            // 
            this.quit_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quit_BTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_BTN.Location = new System.Drawing.Point(32, 683);
            this.quit_BTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quit_BTN.Name = "quit_BTN";
            this.quit_BTN.Size = new System.Drawing.Size(142, 42);
            this.quit_BTN.TabIndex = 17;
            this.quit_BTN.Text = "Quit";
            this.quit_BTN.UseVisualStyleBackColor = true;
            this.quit_BTN.Click += new System.EventHandler(this.quit_BTN_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 764);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.RecipeInfo_GroupBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.RecipeInfo_GroupBox.ResumeLayout(false);
            this.RecipeInfo_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prepTime_NUM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView RecipesLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox RecipeInfo_GroupBox;
        private System.Windows.Forms.Button save_BTN;
        private System.Windows.Forms.Label preparationTime_Lable;
        private System.Windows.Forms.Label recipeCuisine_Lable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView Ingredients_LV;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button cancel_BTN;
        private System.Windows.Forms.ComboBox cuisine_CB;
        private System.Windows.Forms.Button addIngr_BTN;
        private System.Windows.Forms.ComboBox ingredientsList_CB;
        private System.Windows.Forms.Button DeleteItem_BTN;
        private System.Windows.Forms.TextBox recipeName_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown prepTime_NUM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addRecipe_BTN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteRecipe_BTN;
        private System.Windows.Forms.Button quit_BTN;
    }
}