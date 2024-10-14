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
        bool opHasBeenUsed = false;
        bool divideByZero = false;



        private void Form1_Load(object sender, EventArgs e)
        {
            plusButton.Tag = Operators.Plus;
            minusButton.Tag = Operators.Minus;
            multiplyButton.Tag = Operators.Multiply;
            divideButton.Tag = Operators.Divide;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(calculationsBox.Text, out int calculationsBoxNumber2))
            {
                secondNumber = calculationsBoxNumber2;
            }

            calculationsBox.Text = "";
            operatorBox.Text = "";

            switch (operatorUsed)
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

                    if (secondNumber != 0)
                    {
                        answer = firstNumber / secondNumber;
                    }
                    else
                    {
                        divideByZero = true;
                    }

                    break;
            }
            if (divideByZero == false)
            {
                calculationsBox.Text = $"{answer}";
            }
            else
            {
                calculationsBox.Text = "Cannot divide by zero";
            }

            operatorUsed = Operators.None;
            operatorBox.Text = " ";
            opHasBeenUsed = false;
            firstNumberDisplay.Text = "";

        }

        private void Button_Click(object sender, EventArgs e)
        {

            calculationsBox.Text += ((Control)sender).Tag;

            if (divideByZero)
            {
                calculationsBox.Text = "";
                divideByZero = false;
            }
        }
        private void Operator_Click(object sender, EventArgs e)
        {

            if (opHasBeenUsed)
            {
                if (int.TryParse(calculationsBox.Text, out int calculationsBoxNumber3))
                {
                    secondNumber = calculationsBoxNumber3;
                }
                else
                {
                    calculationsBox.Text = "You can't do that";
                }
                switch (operatorUsed)
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
                        if (secondNumber != 0)
                        {
                            answer = firstNumber / secondNumber;
                        }
                        else
                        {
                            calculationsBox.Text = "You can't do that";
                        }
                        break;
                }
                calculationsBox.Text = $"{answer}";
                operatorUsed = Operators.None;
                operatorBox.Text = "";
            }

            Control realSender = (Control)sender;
            operatorUsed = (Operators)realSender.Tag!;

            //fix divide by zero

            if (int.TryParse(calculationsBox.Text, out int calculationBoxNumber))
            {
                firstNumber = calculationBoxNumber;
                firstNumberDisplay.Text = firstNumber.ToString();
                calculationsBox.Text = "";
            }
            else
            {
                calculationsBox.Text = "You can't do that";
            }


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


            opHasBeenUsed = true;
        }



        private void ClearButton_Click(object sender, EventArgs e)
        {
            calculationsBox.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            char[] numbersInCalc = calculationsBox.Text.ToCharArray();
            //numbersInCalc[numbersInCalc.Length - 1] 

            if (numbersInCalc.Length != 0)
            {
                char[] newNumbersinCalc = new char[numbersInCalc.Length - 1];

                for (int i = 0; i < newNumbersinCalc.Length; i++)
                {
                    newNumbersinCalc[i] = numbersInCalc[i];
                }
                calculationsBox.Text = new string(newNumbersinCalc);
            }

        }

        private void NegativeButton_Click(object sender, EventArgs e)
        {
            if (calculationsBox.Text != "")
            {
                int toNegative = int.Parse(calculationsBox.Text);
                calculationsBox.Text = (toNegative * -1).ToString();
            }

        }
    }
}
