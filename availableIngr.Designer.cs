namespace CourseworkApp
{
    partial class availableIngr
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
            this.availableIngr_GroupBox = new System.Windows.Forms.GroupBox();
            this.AvailableIngredients_LV = new System.Windows.Forms.ListView();
            this.ingredientsList_CB = new System.Windows.Forms.ComboBox();
            this.addIngr_BTN = new System.Windows.Forms.Button();
            this.DeleteItem_BTN = new System.Windows.Forms.Button();
            this.save_BTN = new System.Windows.Forms.Button();
            this.availableIngr_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // availableIngr_GroupBox
            // 
            this.availableIngr_GroupBox.Controls.Add(this.AvailableIngredients_LV);
            this.availableIngr_GroupBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableIngr_GroupBox.Location = new System.Drawing.Point(5, 47);
            this.availableIngr_GroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.availableIngr_GroupBox.Name = "availableIngr_GroupBox";
            this.availableIngr_GroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.availableIngr_GroupBox.Size = new System.Drawing.Size(311, 236);
            this.availableIngr_GroupBox.TabIndex = 7;
            this.availableIngr_GroupBox.TabStop = false;
            this.availableIngr_GroupBox.Text = "Available Ingredients";
            // 
            // AvailableIngredients_LV
            // 
            this.AvailableIngredients_LV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AvailableIngredients_LV.HideSelection = false;
            this.AvailableIngredients_LV.Location = new System.Drawing.Point(7, 34);
            this.AvailableIngredients_LV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AvailableIngredients_LV.Name = "AvailableIngredients_LV";
            this.AvailableIngredients_LV.Size = new System.Drawing.Size(298, 196);
            this.AvailableIngredients_LV.TabIndex = 0;
            this.AvailableIngredients_LV.UseCompatibleStateImageBehavior = false;
            this.AvailableIngredients_LV.View = System.Windows.Forms.View.Tile;
            this.AvailableIngredients_LV.SelectedIndexChanged += new System.EventHandler(this.AvailableIngredients_LV_SelectedIndexChanged);
            // 
            // ingredientsList_CB
            // 
            this.ingredientsList_CB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsList_CB.FormattingEnabled = true;
            this.ingredientsList_CB.Location = new System.Drawing.Point(12, 12);
            this.ingredientsList_CB.Name = "ingredientsList_CB";
            this.ingredientsList_CB.Size = new System.Drawing.Size(223, 30);
            this.ingredientsList_CB.TabIndex = 8;
            // 
            // addIngr_BTN
            // 
            this.addIngr_BTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIngr_BTN.Location = new System.Drawing.Point(241, 10);
            this.addIngr_BTN.Name = "addIngr_BTN";
            this.addIngr_BTN.Size = new System.Drawing.Size(75, 33);
            this.addIngr_BTN.TabIndex = 9;
            this.addIngr_BTN.Text = "Add";
            this.addIngr_BTN.UseVisualStyleBackColor = true;
            this.addIngr_BTN.Click += new System.EventHandler(this.addIngr_BTN_Click);
            // 
            // DeleteItem_BTN
            // 
            this.DeleteItem_BTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteItem_BTN.Location = new System.Drawing.Point(5, 288);
            this.DeleteItem_BTN.Name = "DeleteItem_BTN";
            this.DeleteItem_BTN.Size = new System.Drawing.Size(208, 33);
            this.DeleteItem_BTN.TabIndex = 10;
            this.DeleteItem_BTN.Text = "Delete selected item";
            this.DeleteItem_BTN.UseVisualStyleBackColor = true;
            this.DeleteItem_BTN.Click += new System.EventHandler(this.DeleteItem_BTN_Click);
            // 
            // save_BTN
            // 
            this.save_BTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_BTN.Location = new System.Drawing.Point(241, 288);
            this.save_BTN.Name = "save_BTN";
            this.save_BTN.Size = new System.Drawing.Size(75, 33);
            this.save_BTN.TabIndex = 11;
            this.save_BTN.Text = "Save";
            this.save_BTN.UseVisualStyleBackColor = true;
            this.save_BTN.Click += new System.EventHandler(this.save_BTN_Click);
            // 
            // availableIngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 333);
            this.Controls.Add(this.save_BTN);
            this.Controls.Add(this.DeleteItem_BTN);
            this.Controls.Add(this.addIngr_BTN);
            this.Controls.Add(this.ingredientsList_CB);
            this.Controls.Add(this.availableIngr_GroupBox);
            this.Name = "availableIngr";
            this.Text = "availableIngr";
            this.availableIngr_GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox availableIngr_GroupBox;
        private System.Windows.Forms.ListView AvailableIngredients_LV;
        private System.Windows.Forms.ComboBox ingredientsList_CB;
        private System.Windows.Forms.Button addIngr_BTN;
        private System.Windows.Forms.Button DeleteItem_BTN;
        private System.Windows.Forms.Button save_BTN;
    }
}