namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private double _firstValue;
        private string _operator = "";
        private bool _isNewInput = true;
        private string _currentInput = "0";

        public Form1()
        {
            InitializeComponent();
        }

        

private void AppendNumber(string number)
        {
            if (_isNewInput)
            {
                _currentInput = number;
                _isNewInput = false;
            }
            else
            {
                if (_currentInput == "0")
                    _currentInput = number;
                else
                    _currentInput += number;
            }
            RefreshDisplay();
        }

        private void RefreshDisplay()
        {
            if (_operator != "")
                textBox1.Text = _firstValue + " " + _operator + " " + _currentInput;
            else
                textBox1.Text = _currentInput;
        }

        private double Evaluate(double first, string op, double second)
        {
            return op switch
            {
                "+" => first + second,
                "-" => first - second,
                "×" => first * second,
                "÷" => second != 0 ? first / second : double.NaN,
                _ => second
            };
        }

        private void SetOperator(string op)
        {
            if (!_isNewInput && _operator != "")
            {
                double secondValue = double.Parse(_currentInput);
                double result = Evaluate(_firstValue, _operator, secondValue);
                textBox2.Text = result.ToString();
                _firstValue = result;
            }
            else
            {
                _firstValue = double.Parse(_currentInput);
            }
            _operator = op;
            _currentInput = "";
            _isNewInput = true;
            textBox1.Text = _firstValue + " " + _operator;
        }

        private void Calculate()
        {
            if (_operator == "" || _isNewInput) return;

            double secondValue = double.Parse(_currentInput);
            double result = Evaluate(_firstValue, _operator, secondValue);

            textBox1.Text = _firstValue + " " + _operator + " " + secondValue;
            textBox2.Text = result.ToString();
            _firstValue = result;
            _currentInput = result.ToString();
            _operator = "";
            _isNewInput = true;
        }

        // CE
        private void button1_Click(object sender, EventArgs e)
        {
            _currentInput = "0";
            _isNewInput = true;
            RefreshDisplay();
        }

        // C
        private void button2_Click(object sender, EventArgs e)
        {
            _firstValue = 0;
            _operator = "";
            _currentInput = "0";
            _isNewInput = true;
            textBox1.Text = "0";
            textBox2.Text = "";
        }

        // del
        private void button3_Click(object sender, EventArgs e)
        {
            if (!_isNewInput && _currentInput.Length > 0)
            {
                _currentInput = _currentInput[..^1];
                if (_currentInput.Length == 0 || _currentInput == "-")
                {
                    _currentInput = "0";
                    _isNewInput = true;
                }
                RefreshDisplay();
            }
        }

        // /
        private void button4_Click(object sender, EventArgs e) => SetOperator("÷");

        // 7
        private void button5_Click(object sender, EventArgs e) => AppendNumber("7");

        // 8
        private void button6_Click(object sender, EventArgs e) => AppendNumber("8");

        // 9
        private void button7_Click(object sender, EventArgs e) => AppendNumber("9");

        // X (multiply)
        private void button8_Click(object sender, EventArgs e) => SetOperator("×");

        // 4
        private void button9_Click(object sender, EventArgs e) => AppendNumber("4");

        // 5
        private void button10_Click(object sender, EventArgs e) => AppendNumber("5");

        // 6
        private void button11_Click(object sender, EventArgs e) => AppendNumber("6");

        // -
        private void button12_Click(object sender, EventArgs e) => SetOperator("-");

        // 1
        private void button13_Click(object sender, EventArgs e) => AppendNumber("1");

        // 2
        private void button14_Click(object sender, EventArgs e) => AppendNumber("2");

        // 3
        private void button15_Click(object sender, EventArgs e) => AppendNumber("3");

        // +
        private void button16_Click(object sender, EventArgs e) => SetOperator("+");

        // +/-
        private void button17_Click(object sender, EventArgs e)
        {
            if (double.TryParse(_currentInput, out double value))
            {
                _currentInput = (-value).ToString();
                RefreshDisplay();
            }
        }

        // 0
        private void button18_Click(object sender, EventArgs e) => AppendNumber("0");

        // .
        private void button19_Click(object sender, EventArgs e)
        {
            if (_isNewInput)
            {
                _currentInput = "0.";
                _isNewInput = false;
            }
            else if (!_currentInput.Contains('.'))
            {
                _currentInput += ".";
            }
            RefreshDisplay();
        }

        // =
        private void button20_Click(object sender, EventArgs e) => Calculate();

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0 or Keys.NumPad0: AppendNumber("0"); break;
                case Keys.D1 or Keys.NumPad1: AppendNumber("1"); break;
                case Keys.D2 or Keys.NumPad2: AppendNumber("2"); break;
                case Keys.D3 or Keys.NumPad3: AppendNumber("3"); break;
                case Keys.D4 or Keys.NumPad4: AppendNumber("4"); break;
                case Keys.D5 or Keys.NumPad5: AppendNumber("5"); break;
                case Keys.D6 or Keys.NumPad6: AppendNumber("6"); break;
                case Keys.D7 or Keys.NumPad7: AppendNumber("7"); break;
                case Keys.D8 or Keys.NumPad8: AppendNumber("8"); break;
                case Keys.D9 or Keys.NumPad9: AppendNumber("9"); break;
                case Keys.Add or Keys.Oemplus when e.Shift: SetOperator("+"); break;
                case Keys.Subtract or Keys.OemMinus: SetOperator("-"); break;
                case Keys.Multiply: SetOperator("×"); break;
                case Keys.Divide or Keys.Oem2: SetOperator("÷"); break;
                case Keys.Enter: Calculate(); break;
                case Keys.Back: button3_Click(sender, e); break;
                case Keys.Escape: button2_Click(sender, e); break;
                case Keys.Delete: button1_Click(sender, e); break;
                case Keys.Decimal or Keys.OemPeriod: button19_Click(sender, e); break;
            }
            e.SuppressKeyPress = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
