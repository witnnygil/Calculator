namespace Calculator
{
    public partial class FrmCalculator : Form
    {
        double firstNumber;
        double secondNumber;
        string @operator = "";
        bool shouldClearScreen = false;


        // El contructor es lo primero que se hace cuando se instancia una clase
        // En este caso se inicializan los componentes del formulario, es decir los controles
        // Esto lo hace de manera automática el lenguaje
        public FrmCalculator()
        {
            InitializeComponent();
        }

        // Estos son los métodos que estan asociados al evento click de cada botón 
        // If, esto lo que hace es que verifica si debería limpiar la pantalla cuando agregamos un #, para permitir agregar el próx #
        // ShouldClearScreem = false, porque no quiero que muestre el 1er # que agregué
        // TxtScreen.Text += lo que hace es que muestra el contenido del TxtS + el #
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

        // If (!TxtScreen.Text.Contains('.')), esto me pregunta si el TxtS no contiene un ".", si no lo contiene el lo agrega,
        // en caso de que sí, no hace nada
        // Nota: el simbolo de exclamacion (!) delante de la operacion la niega es decir, en lugar de contiene, es NO contiene
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


        // Operaciones de los botones, son supuestos a ser clickeados luego de colocar el 1er # 
        // se asigna el simbolo del operador,
        // se asigna a la variable firstNumber la conversión del texto en la pantalla, a double, (todo en la pantalla es un string)
        // Luego se limpia la pantalla para dejarlo lista para colocar el 2do #
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

        // clear básicamente limpia la pantalla y restablece las variables utlizadas para poder inicar una operación desde cero
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtScreen.Clear();
            firstNumber = 0;
            secondNumber = 0;
            @operator = "";
            shouldClearScreen = false;
        }

        // Este se ejecuta cuando se hace click (evento click) sobre el boton de igual
        // se asigna a la variable SeconN la conversión del texto en la pantalla, a double, (todo en la pantalla es un string)
        // se declara la varible de result para que almacene el resultado
        // Switch, evalua la operación que se realiza (nos evita realizar muchos if),
        // Dependiendo la operación que se haya seleccionado, llama al método correspondiente en la clase Calculator y lo asigna a la var result
        // TxtScreen.Text = result.ToString();, convierte el resultado en un string otra vez, y lo asigna al TxtS
        // break termina la evaluacion
        // Al final se indica que debe limpiar la pantalla en la variable shouldClearScreen, para que el prox # que se le click sepa que debe limpiar
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
