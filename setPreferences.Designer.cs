
namespace CourseworkApp
{
    partial class setPreferences
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
            this.prefCB = new System.Windows.Forms.ComboBox();
            this.allergiesCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.welcome_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prefCB
            // 
            this.prefCB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefCB.FormattingEnabled = true;
            this.prefCB.Items.AddRange(new object[] {
            "Vegetarian",
            "Vegan",
            "Omnivore",
            "Pescatarian"});
            this.prefCB.Location = new System.Drawing.Point(190, 87);
            this.prefCB.Margin = new System.Windows.Forms.Padding(2);
            this.prefCB.Name = "prefCB";
            this.prefCB.Size = new System.Drawing.Size(194, 29);
            this.prefCB.TabIndex = 15;
            // 
            // allergiesCB
            // 
            this.allergiesCB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allergiesCB.FormattingEnabled = true;
            this.allergiesCB.Items.AddRange(new object[] {
            "None",
            "Nuts",
            "Dairy",
            "Shellfish",
            "Gluten",
            "Soy",
            "Eggs",
            "Lactose"});
            this.allergiesCB.Location = new System.Drawing.Point(190, 120);
            this.allergiesCB.Margin = new System.Windows.Forms.Padding(2);
            this.allergiesCB.Name = "allergiesCB";
            this.allergiesCB.Size = new System.Drawing.Size(194, 29);
            this.allergiesCB.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Dietary preferences";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Allergies";
            // 
            // saveBTN
            // 
            this.saveBTN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBTN.Location = new System.Drawing.Point(309, 195);
            this.saveBTN.Margin = new System.Windows.Forms.Padding(2);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(75, 24);
            this.saveBTN.TabIndex = 21;
            this.saveBTN.Text = "Save";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.registerBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBTN.Location = new System.Drawing.Point(36, 195);
            this.cancelBTN.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(75, 24);
            this.cancelBTN.TabIndex = 20;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // welcome_text
            // 
            this.welcome_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcome_text.AutoSize = true;
            this.welcome_text.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_text.Location = new System.Drawing.Point(84, 23);
            this.welcome_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcome_text.Name = "welcome_text";
            this.welcome_text.Size = new System.Drawing.Size(267, 32);
            this.welcome_text.TabIndex = 22;
            this.welcome_text.Text = "SET PREFERENCES";
            // 
            // setPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 245);
            this.Controls.Add(this.welcome_text);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.allergiesCB);
            this.Controls.Add(this.prefCB);
            this.Name = "setPreferences";
            this.Text = "setPreferences";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox prefCB;
        private System.Windows.Forms.ComboBox allergiesCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.Label welcome_text;
    }
}