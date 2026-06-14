namespace Calculator
{
    public partial class FrmCalculator : Form
    {
        double firstNumber;
        double secondNumber;
        string @operator = "";
        bool shouldClearScreen = false;

        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            TxtScreen.Text += "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            TxtScreen.Text += "1";

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            TxtScreen.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            TxtScreen.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            TxtScreen.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen) {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }
            
            TxtScreen.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            TxtScreen.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            TxtScreen.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            TxtScreen.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            TxtScreen.Text += "9";
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            if (!TxtScreen.Text.Contains('.'))
            {
                TxtScreen.Text += ".";
            }
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(TxtScreen.Text);

            double result;

            switch (@operator)
            {
                case "/":
                    result = Calculator.Divide((firstNumber), (secondNumber));
                    TxtScreen.Text = result.ToString();
                    break;

                case "-":
                    result = Calculator.Subtract((firstNumber), (secondNumber));
                    TxtScreen.Text = result.ToString();
                    break;

                case "*":
                    result = Calculator.Multiply((firstNumber), (secondNumber));
                    TxtScreen.Text = result.ToString();
                    break;

                case "%":
                    result = Calculator.CalculatePercentage((firstNumber), (secondNumber));
                    TxtScreen.Text = result.ToString();
                    break;

                case "+":
                    result = Calculator.Add((firstNumber), (secondNumber));
                    TxtScreen.Text = result.ToString();
                    break;
            }

            shouldClearScreen = true;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            @operator = "+";
            firstNumber = double.Parse(TxtScreen.Text);
            TxtScreen.Clear();
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            @operator = "-";
            firstNumber = double.Parse(TxtScreen.Text);
            TxtScreen.Clear();
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            @operator = "*";
            firstNumber = double.Parse(TxtScreen.Text);
            TxtScreen.Clear();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            @operator = "/";
            firstNumber = double.Parse(TxtScreen.Text);
            TxtScreen.Clear();
        }

        private void BtnPercentage_Click(object sender, EventArgs e)
        {
            @operator = "%";
            firstNumber = double.Parse(TxtScreen.Text);
            TxtScreen.Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtScreen.Clear();
            firstNumber = 0;
            secondNumber = 0;
            @operator = "";
            shouldClearScreen = false;
        }
    }
}
