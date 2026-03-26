namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private double _firstValue;
        private string _operator = "";
        private bool _isNewInput = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void AppendNumber(string number)
        {
            if (_isNewInput)
            {
                textBox1.Text = number;
                _isNewInput = false;
            }
            else
            {
                textBox1.Text += number;
            }
        }

        private void SetOperator(string op)
        {
            if (!_isNewInput)
            {
                Calculate();
            }
            _firstValue = double.Parse(textBox1.Text);
            _operator = op;
            textBox2.Text = _firstValue + " " + _operator;
            _isNewInput = true;
        }

        private void Calculate()
        {
            if (_operator == "" || _isNewInput) return;

            double secondValue = double.Parse(textBox1.Text);
            double result = _operator switch
            {
                "+" => _firstValue + secondValue,
                "-" => _firstValue - secondValue,
                "×" => _firstValue * secondValue,
                "%" => _firstValue / 100.0 * secondValue,
                _ => secondValue
            };

            textBox1.Text = result.ToString();
            textBox2.Text = "";
            _operator = "";
            _isNewInput = true;
        }

        // CE
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            _isNewInput = true;
        }

        // C
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            _firstValue = 0;
            _operator = "";
            _isNewInput = true;
        }

        // del
        private void button3_Click(object sender, EventArgs e)
        {
            if (!_isNewInput && textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text[..^1];
                if (textBox1.Text.Length == 0 || textBox1.Text == "-")
                {
                    textBox1.Text = "0";
                    _isNewInput = true;
                }
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
            if (double.TryParse(textBox1.Text, out double value))
            {
                textBox1.Text = (-value).ToString();
            }
        }

        // 0
        private void button18_Click(object sender, EventArgs e) => AppendNumber("0");

        // .
        private void button19_Click(object sender, EventArgs e)
        {
            if (_isNewInput)
            {
                textBox1.Text = "0.";
                _isNewInput = false;
            }
            else if (!textBox1.Text.Contains('.'))
            {
                textBox1.Text += ".";
            }
        }

        // =
        private void button20_Click(object sender, EventArgs e) => Calculate();

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
