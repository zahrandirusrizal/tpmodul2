namespace TP_KPL_MOD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TombolSubmitNama_MouseClick(object sender, MouseEventArgs e)
        {
            this.label1.Text = "Halo " + this.TextBoxInput.Text;
        }
    }
}