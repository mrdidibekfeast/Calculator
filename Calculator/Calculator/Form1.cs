namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           




        }

        private void EqualButton_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {

            calculationsBox.Text += ((Control)sender).Tag;

            //calculationsBox.Text += "0";
        }

        private void calculationsBox_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
