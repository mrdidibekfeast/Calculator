namespace Calculator
{
    public partial class Form1 : Form
    {
        int firstNumber = 0;
        int secondNumber = 0;
        int answer = 0;

        Button currentButton;
        public Form1()
        {
            InitializeComponent();
        }

        enum Operators
        {
            Plus,
            Minus,
            Multiply,
            Divide
            
        }

        Operators operatorUsed;
        private void Form1_Load(object sender, EventArgs e)
        {
            plusButton.Tag = Operators.Plus;
            minusButton.Tag = Operators.Minus;
            multiplyButton.Tag = Operators.Multiply;
            divideButton.Tag = Operators.Divide;
            
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            secondNumber = int.Parse(calculationsBox.Text);
            calculationsBox.Text = " ";

            switch(operatorUsed)
            {
                case Operators.Plus:
                    
                    break;
                case Operators.Minus:

                    break;
                case Operators.Multiply:

                    break;
                case Operators.Divide:

                    break;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {

            calculationsBox.Text += ((Control)sender).Tag;
        }
        private void operator_Click(object sender, EventArgs e)
        {
            Control realSender = (Control)sender;
            Operators currentOp = (Operators)realSender.Tag!;

           

            firstNumber = int.Parse(calculationsBox.Text);
            calculationsBox.Text = " ";

            operatorUsed = currentOp;
        }

        private void calculationsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            
            
            // taG FOR MY Operators is a string so when I press the operator i can check the string to see if it matches up and then i can use that operatore to add or whatevrer
        }
    }
}
