namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private double _firstValue;
        private string _operator = "";
        private bool _isNewInput = true;
        private string _currentInput = "0";
        private readonly List<string> _history = [];

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
                Ctext.Text = _firstValue + " " + _operator + " " + _currentInput;
            else
                Ctext.Text = _currentInput;
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
                Rtext.Text = result.ToString();
                _firstValue = result;
            }
            else
            {
                _firstValue = double.Parse(_currentInput);
            }
            _operator = op;
            _currentInput = "";
            _isNewInput = true;
            Ctext.Text = _firstValue + " " + _operator;
        }

        private void Calculate()
        {
            if (_operator == "" || _isNewInput) return;

            double secondValue = double.Parse(_currentInput);
            double result = Evaluate(_firstValue, _operator, secondValue);

            string expression = _firstValue + " " + _operator + " " + secondValue + " = " + result;
            _history.Add(expression);
            Ctext.Text = expression;
            Rtext.Text = result.ToString();
            _firstValue = result;
            _currentInput = result.ToString();
            _operator = "";
            _isNewInput = true;
        }

        
 // CE
        private void CE_Click(object sender, EventArgs e)
        {
            _currentInput = "";
            _isNewInput = true;
            RefreshDisplay();
        }

       
  // C
        private void C_Click(object sender, EventArgs e)
        {
            _history.Add("--- C (초기화) ---");
            _firstValue = 0;
            _operator = "";
            _currentInput = "";
            _isNewInput = true;
            Ctext.Text = "";
            Rtext.Text = "";
        }

        // History
        private void history_Click(object sender, EventArgs e)
        {
            if (_history.Count == 0)
            {
                MessageBox.Show("기록이 없습니다.", "History");
                return;
            }
            string historyText = string.Join(Environment.NewLine, _history);
            MessageBox.Show(historyText, "History");
        }

        
 // del
        private void del_Click(object sender, EventArgs e)
        {
            if (!_isNewInput && _currentInput.Length > 0)
            {
                _currentInput = _currentInput[..^1];
                if (_currentInput.Length == 0 || _currentInput == "-")
                {
                    _currentInput = "";
                }
                RefreshDisplay();
            }
            else if (_operator != "")
            {
                _operator = "";
                _currentInput = _firstValue.ToString();
                _firstValue = 0;
                _isNewInput = false;
                RefreshDisplay();
            }
            else if (_isNewInput && _currentInput.Length > 0)
            {
                _currentInput = _currentInput[..^1];
                if (_currentInput.Length == 0 || _currentInput == "-")
                {
                    _currentInput = "";
                }
                _isNewInput = false;
                RefreshDisplay();
            }
        }

      
  // /
        private void 나누기_Click(object sender, EventArgs e) => SetOperator("÷");

        // 7
        private void b7_Click(object sender, EventArgs e) => AppendNumber("7");

        // 8
        private void b8_Click(object sender, EventArgs e) => AppendNumber("8");

        // 9
        private void b9_Click(object sender, EventArgs e) => AppendNumber("9");

       
 // X (multiply)
        private void X_Click(object sender, EventArgs e) => SetOperator("×");

        // 4
        private void b4_Click(object sender, EventArgs e) => AppendNumber("4");

        // 5
        private void b5_Click(object sender, EventArgs e) => AppendNumber("5");

        // 6
        private void b6_Click(object sender, EventArgs e) => AppendNumber("6");

       
 // -
        private void 빼기_Click(object sender, EventArgs e) => SetOperator("-");

        // 1
        private void b1_Click(object sender, EventArgs e) => AppendNumber("1");

        // 2
        private void b2_Click(object sender, EventArgs e) => AppendNumber("2");

        // 3
        private void b3_Click(object sender, EventArgs e) => AppendNumber("3");

        // +
        private void 더하기_Click(object sender, EventArgs e) => SetOperator("+");

        // +/-
        private void what_Click(object sender, EventArgs e)
        {
            if (double.TryParse(_currentInput, out double value))
            {
                _currentInput = (-value).ToString();
                RefreshDisplay();
            }
        }

        // 0
        private void b0_Click(object sender, EventArgs e) => AppendNumber("0");

        // .
        private void dot_Click(object sender, EventArgs e)
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
        private void e_Click(object sender, EventArgs e) => Calculate();

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
                case Keys.D8 when e.Shift: SetOperator("×"); break;
                case Keys.D8 or Keys.NumPad8: AppendNumber("8"); break;
                case Keys.D9 or Keys.NumPad9: AppendNumber("9"); break;
                case Keys.Add or Keys.Oemplus when e.Shift: SetOperator("+"); break;
                case Keys.Subtract or Keys.OemMinus: SetOperator("-"); break;
                case Keys.Multiply: SetOperator("×"); break;
                case Keys.Divide or Keys.Oem2: SetOperator("÷"); break;
                case Keys.Enter: Calculate(); break;
                case Keys.Back: del_Click(sender, e); break;
                case Keys.Escape: C_Click(sender, e); break;
                case Keys.Delete: CE_Click(sender, e); break;
                case Keys.Decimal or Keys.OemPeriod: dot_Click(sender, e); break;
            }
            e.SuppressKeyPress = true;
        }

        private void MakeCircular(Button btn)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ctext.Text = "";

            int btnSize = 100;
            int startX = 64;
            int startY = 210;
            int gap = 10;
            int step = btnSize + gap;

            Button[,] grid =
            {
                { CE, C, del, 나누기 },
                { b7, b8, b9, X },
                { b4, b5, b6, 빼기 },
                { b1, b2, b3, 더하기 },
                { what, b0, dot, this.e }
            };

            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    Button btn = grid[row, col];
                    btn.Size = new Size(btnSize, btnSize);
                    btn.Location = new Point(startX + col * step, startY + row * step);
                    MakeCircular(btn);
                }
            }
        }
    }
}
