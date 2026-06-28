namespace Calculator
{
    public partial class FrmCalculator : Form
    {
        double firstNumber;          // Guarda el primer número que ingresa el usuario
        double secondNumber;         // Guarda el segundo número que ingresa el usuario
        string @operator = "";       // Guarda el operador seleccionado (+, -, *, /, %, ^)
        bool shouldClearScreen = false;  // Controla si la pantalla debe limpiarse al escribir el siguiente número


        // El constructor se ejecuta automáticamente cuando se crea el formulario.
        // Aquí se inicializan todos los componentes visuales (botones, caja de texto, etc.)
        // Esto lo hace el método InitializeComponent(), generado automáticamente por Visual Studio.
        public FrmCalculator()
        {
            InitializeComponent();
        }

        // Estos métodos se ejecutan cuando el usuario hace clic en un botón de número (0-9).
        // Si shouldClearScreen está en true (porque venimos de un resultado), se limpia la pantalla
        // antes de escribir el nuevo número. Luego se agrega el dígito al final del texto actual.
        // shouldClearScreen se pone en false para que el siguiente dígito se agregue normalmente.
        #region numbersButtons
        private void Btn0_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            TxtScreen.Text = TxtScreen.Text + "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            TxtScreen.Text = TxtScreen.Text + "1";

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            TxtScreen.Text = TxtScreen.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            TxtScreen.Text = TxtScreen.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            TxtScreen.Text = TxtScreen.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            TxtScreen.Text = TxtScreen.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            TxtScreen.Text = TxtScreen.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            TxtScreen.Text = TxtScreen.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            TxtScreen.Text = TxtScreen.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            TxtScreen.Text = TxtScreen.Text + "9";
        }
        #endregion

        // Si el texto en pantalla aún NO contiene un punto (.), lo agrega.
        // El signo "!" delante de la condición la niega: "si NO contiene punto".
        // Esto evita que el usuario ponga dos puntos decimales en el mismo número (ej: 5.4.3).
        private void BtnDot_Click(object sender, EventArgs e)
        {
            if (shouldClearScreen)
            {
                TxtScreen.Clear();
                shouldClearScreen = false;
            }

            if (!TxtScreen.Text.Contains('.'))
            {
                TxtScreen.Text = TxtScreen.Text + ".";
            }
        }


        // Al hacer clic en un operador (+, -, *, /, %, ^):
        // 1. Guardamos el símbolo del operador en la variable @operator
        // 2. Convertimos el texto de la pantalla a número (double) y lo guardamos en firstNumber
        // 3. Limpiamos la pantalla para que el usuario ingrese el segundo número
        #region OperationsButtons
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

        private void BtnPow_Click(object sender, EventArgs e)
        {
            @operator = "^";
            firstNumber = double.Parse(TxtScreen.Text);
            TxtScreen.Clear();
        }
        #endregion

        // Limpia la pantalla y reinicia todas las variables para empezar una operación nueva desde cero.
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtScreen.Clear();
            firstNumber = 0;
            secondNumber = 0;
            @operator = "";
            shouldClearScreen = false;
        }

        // Este método se ejecuta cuando el usuario hace clic en "=".
        // 1. Toma el texto de la pantalla, lo convierte a número (double) y lo guarda en secondNumber
        // 2. Evalúa con un switch qué operación se va a realizar, según el valor de @operator
        //    (switch es como varios if pero más ordenado)
        // 3. Llama al método correspondiente de la clase Calculator y guarda el resultado
        // 4. Convierte el resultado a texto y lo muestra en la pantalla
        // 5. Al final, activa shouldClearScreen para que el próximo número se escriba en pantalla limpia
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

                case "^":
                    result = Calculator.Pow((firstNumber), (secondNumber));
                    TxtScreen.Text = result.ToString();
                    break;
            }

            shouldClearScreen = true;
        }
    }
}
