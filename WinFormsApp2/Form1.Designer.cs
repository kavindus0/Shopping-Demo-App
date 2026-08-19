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
            newToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            myChoiceProductsToolStripMenuItem = new ToolStripMenuItem();
            grocerryToolStripMenuItem = new ToolStripMenuItem();
            homewareToolStripMenuItem = new ToolStripMenuItem();
            pharmacyToolStripMenuItem = new ToolStripMenuItem();
            idlabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            cmbCat = new ComboBox();
            cmbSelect = new ComboBox();
            button1 = new Button();
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
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(122, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(122, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // myChoiceProductsToolStripMenuItem
            // 
            myChoiceProductsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grocerryToolStripMenuItem, homewareToolStripMenuItem, pharmacyToolStripMenuItem });
            myChoiceProductsToolStripMenuItem.Name = "myChoiceProductsToolStripMenuItem";
            myChoiceProductsToolStripMenuItem.Size = new Size(149, 24);
            myChoiceProductsToolStripMenuItem.Text = "MyChoice Products";
            // 
            // grocerryToolStripMenuItem
            // 
            grocerryToolStripMenuItem.Name = "grocerryToolStripMenuItem";
            grocerryToolStripMenuItem.Size = new Size(165, 26);
            grocerryToolStripMenuItem.Text = "Grocerry";
            grocerryToolStripMenuItem.Click += grocerryToolStripMenuItem_Click;
            // 
            // homewareToolStripMenuItem
            // 
            homewareToolStripMenuItem.Name = "homewareToolStripMenuItem";
            homewareToolStripMenuItem.Size = new Size(165, 26);
            homewareToolStripMenuItem.Text = "Homeware";
            homewareToolStripMenuItem.Click += homewareToolStripMenuItem_Click;
            // 
            // pharmacyToolStripMenuItem
            // 
            pharmacyToolStripMenuItem.Name = "pharmacyToolStripMenuItem";
            pharmacyToolStripMenuItem.Size = new Size(165, 26);
            pharmacyToolStripMenuItem.Text = "Pharmacy";
            pharmacyToolStripMenuItem.Click += pharmacyToolStripMenuItem_Click;
            // 
            // idlabel
            // 
            idlabel.AutoSize = true;
            idlabel.Location = new Point(63, 73);
            idlabel.Name = "idlabel";
            idlabel.Size = new Size(24, 20);
            idlabel.TabIndex = 1;
            idlabel.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 124);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 171);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 3;
            label3.Text = "Contact No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 224);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 4;
            label4.Text = "Adress";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 273);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 5;
            label1.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 341);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 6;
            label5.Text = "Select Catagory";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 388);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 7;
            label6.Text = "Select Item";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(208, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(355, 27);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(208, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(355, 27);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(208, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(355, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(208, 224);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(355, 27);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(208, 273);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(355, 27);
            textBox5.TabIndex = 12;
            // 
            // cmbCat
            // 
            cmbCat.FormattingEnabled = true;
            cmbCat.Location = new Point(210, 335);
            cmbCat.Name = "cmbCat";
            cmbCat.Size = new Size(355, 28);
            cmbCat.TabIndex = 13;
            cmbCat.SelectedIndexChanged += cmbCat_SelectedIndexChanged;
            // 
            // cmbSelect
            // 
            cmbSelect.FormattingEnabled = true;
            cmbSelect.Location = new Point(208, 385);
            cmbSelect.Name = "cmbSelect";
            cmbSelect.Size = new Size(355, 28);
            cmbSelect.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(617, 315);
            button1.Name = "button1";
            button1.Size = new Size(137, 102);
            button1.TabIndex = 15;
            button1.Text = "Add to Cart";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(cmbSelect);
            Controls.Add(cmbCat);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(idlabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
        private Label idlabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox cmbCat;
        private ComboBox cmbSelect;
        private Button button1;
    }
}
