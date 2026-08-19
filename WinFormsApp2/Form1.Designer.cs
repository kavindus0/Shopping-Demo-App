namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            myChoiceProductsToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            grocerryToolStripMenuItem = new ToolStripMenuItem();
            homewareToolStripMenuItem = new ToolStripMenuItem();
            pharmacyToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, myChoiceProductsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // myChoiceProductsToolStripMenuItem
            // 
            myChoiceProductsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grocerryToolStripMenuItem, homewareToolStripMenuItem, pharmacyToolStripMenuItem });
            myChoiceProductsToolStripMenuItem.Name = "myChoiceProductsToolStripMenuItem";
            myChoiceProductsToolStripMenuItem.Size = new Size(149, 24);
            myChoiceProductsToolStripMenuItem.Text = "MyChoice Products";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(224, 26);
            newToolStripMenuItem.Text = "New";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // grocerryToolStripMenuItem
            // 
            grocerryToolStripMenuItem.Name = "grocerryToolStripMenuItem";
            grocerryToolStripMenuItem.Size = new Size(224, 26);
            grocerryToolStripMenuItem.Text = "Grocerry";
            // 
            // homewareToolStripMenuItem
            // 
            homewareToolStripMenuItem.Name = "homewareToolStripMenuItem";
            homewareToolStripMenuItem.Size = new Size(224, 26);
            homewareToolStripMenuItem.Text = "Homeware";
            // 
            // pharmacyToolStripMenuItem
            // 
            pharmacyToolStripMenuItem.Name = "pharmacyToolStripMenuItem";
            pharmacyToolStripMenuItem.Size = new Size(224, 26);
            pharmacyToolStripMenuItem.Text = "Pharmacy";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem myChoiceProductsToolStripMenuItem;
        private ToolStripMenuItem grocerryToolStripMenuItem;
        private ToolStripMenuItem homewareToolStripMenuItem;
        private ToolStripMenuItem pharmacyToolStripMenuItem;
    }
}
