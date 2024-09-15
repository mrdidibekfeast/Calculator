namespace Calculator
{
    public partial class Form1 : Form
    {
        int firstNumber = 0;
        int secondNumber = 0;
        int answer = 0;

     
        public Form1()
        {
            InitializeComponent();
        }

        enum Operators
        {
            Plus,
            Minus,
            Multiply,
            Divide,
            None
            
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
            operatorBox.Text = " ";

            switch(operatorUsed)
            {
                case Operators.Plus:
                    answer = firstNumber + secondNumber;
                 
                    
                    break;
                case Operators.Minus:
                    answer = firstNumber - secondNumber;
                    
                   
                    break;
                case Operators.Multiply:
                    answer = firstNumber * secondNumber;
                   
                   
                    break;
                case Operators.Divide:
                    answer = firstNumber / secondNumber;
                    
                    break;
            }
            calculationsBox.Text = $"{answer}";
            operatorUsed = Operators.None;
            operatorBox.Text = " ";
        }

        private void button_Click(object sender, EventArgs e)
        {

            calculationsBox.Text += ((Control)sender).Tag;
        }
        private void operator_Click(object sender, EventArgs e)
        {
            

            Control realSender = (Control)sender;
            operatorUsed = (Operators)realSender.Tag!;

           

            firstNumber = int.Parse(calculationsBox.Text);
            calculationsBox.Text = "";

           

            switch (operatorUsed)
            {
                case Operators.Plus:
                    operatorBox.Text = "+";
                    break;
                case Operators.Minus:
                    operatorBox.Text = "-";
                    break;
                case Operators.Multiply:
                    operatorBox.Text = "X";
                    break;
                case Operators.Divide:
                    operatorBox.Text = "÷";
                    break;
            }
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
