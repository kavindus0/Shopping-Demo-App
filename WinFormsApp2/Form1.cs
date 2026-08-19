namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Form2 detailform = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grocerryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 grocerry = new Form2();
            grocerry.Show();
        }

        private void homewareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 homeware = new Form3();
            homeware.Show();
        }

        private void pharmacyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 pharmacy = new Form4();
            pharmacy.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCat.Items.Add("Beverages");
            cmbCat.Items.Add("Daily Products");
            cmbCat.Items.Add("Vegitables");
            cmbCat.Items.Add("Fruits");
            cmbCat.Items.Add("Meat");

            cmbCat.SelectedIndex = 0;
        }

        private void cmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSelect.Items.Clear();

            string selectedCat = cmbCat.SelectedItem.ToString();

            detailform.setCategory(selectedCat);

            switch (selectedCat)
            {
                case "Beverage":
                    cmbSelect.Items.Add("chocolate Drink");
                    cmbSelect.Items.Add("chocolate Drink");
                    cmbSelect.Items.Add("chocolate Drink");
                    cmbSelect.Items.Add("chocolate Drink");
                    cmbSelect.Items.Add("chocolate Drink");
                    break;
                case "Diary Product":
                    cmbSelect.Items.Add("chocolate Drink");
                    cmbSelect.Items.Add("chocolate Drink");
                    cmbSelect.Items.Add("chocolate Drink");
                    cmbSelect.Items.Add("chocolate Drink");
                    cmbSelect.Items.Add("chocolate Drink");
                    break;
                case "Meat":
                    cmbSelect.Items.Add("chocolate Drink");
                    cmbSelect.Items.Add("chocolate Drink");
                    cmbSelect.Items.Add("chocolate Drink");
                    cmbSelect.Items.Add("chocolate Drink");
                    cmbSelect.Items.Add("chocolate Drink");
                    break;
                case "Default":
                    cmbSelect.Items.Add("chocolate Drink");
                    cmbSelect.Items.Add("chocolate Drink");
                    cmbSelect.Items.Add("chocolate Drink");
                    cmbSelect.Items.Add("chocolate Drink");
                    cmbSelect.Items.Add("chocolate Drink");
                    break;
            }
            cmbSelect.SelectedIndex = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            detailform.setID(textBox1.Text);
            detailform.setName(textBox2.Text);
            detailform.setContact(textBox3.Text);
            detailform.setAdress(textBox4.Text);
            detailform.setEmail(textBox5.Text);

            detailform.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            detailform.setID(textBox1.Text);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            detailform.setName(textBox2.Text);

        }
    }