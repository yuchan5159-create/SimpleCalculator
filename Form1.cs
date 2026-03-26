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
                "%" => first / 100.0 * second,
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

        // %
        private void button4_Click(object sender, EventArgs e) => SetOperator("%");

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

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
