namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public void RellenarGrilla()
        {
            dataGridView3.DataSource = null;

        }
    }
}
