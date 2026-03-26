namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private string _expression = "";
        private bool _isNewCalculation = true;
        private readonly List<string> _history = [];

        public Form1()
        {
            InitializeComponent();
        }

        private void AppendNumber(string number)
        {
            if (_isNewCalculation)
            {
                _expression = number;
                _isNewCalculation = false;
            }
            else
            {
                _expression += number;
            }
            Ctext.Text = _expression;
        }

        private void SetOperator(string op)
        {
            if (_isNewCalculation && _expression.Length > 0)
                _isNewCalculation = false;

            if (_expression.Length > 0)
                _expression += " " + op + " ";

            Ctext.Text = _expression;
        }

        private void AppendBracket(string bracket)
        {
            if (_isNewCalculation)
            {
                _expression = bracket;
                _isNewCalculation = false;
            }
            else
            {
                _expression += bracket;
            }
            Ctext.Text = _expression;
        }

        #region Expression Parser

        private static void SkipSpaces(string expr, ref int pos)
        {
            while (pos < expr.Length && expr[pos] == ' ') pos++;
        }

        private static double ParseAddSub(string expr, ref int pos)
        {
            double result = ParseMulDiv(expr, ref pos);
            while (pos < expr.Length)
            {
                SkipSpaces(expr, ref pos);
                if (pos >= expr.Length) break;
                if (expr[pos] == '+') { pos++; result += ParseMulDiv(expr, ref pos); }
                else if (expr[pos] == '-') { pos++; result -= ParseMulDiv(expr, ref pos); }
                else break;
            }
            return result;
        }

        private static double ParseMulDiv(string expr, ref int pos)
        {
            double result = ParseFactor(expr, ref pos);
            while (pos < expr.Length)
            {
                SkipSpaces(expr, ref pos);
                if (pos >= expr.Length) break;
                if (expr[pos] == '*') { pos++; result *= ParseFactor(expr, ref pos); }
                else if (expr[pos] == '/')
                {
                    pos++;
                    double d = ParseFactor(expr, ref pos);
                    result = d != 0 ? result / d : double.NaN;
                }
                else break;
            }
            return result;
        }

        private static double ParseFactor(string expr, ref int pos)
        {
            SkipSpaces(expr, ref pos);
            if (pos < expr.Length && expr[pos] == '-') { pos++; return -ParseFactor(expr, ref pos); }
            if (pos < expr.Length && expr[pos] == '+') { pos++; return ParseFactor(expr, ref pos); }

            double value;

            if (pos < expr.Length && (expr[pos] == '(' || expr[pos] == '{'))
            {
                char close = expr[pos] == '(' ? ')' : '}';
                pos++;
                value = ParseAddSub(expr, ref pos);
                SkipSpaces(expr, ref pos);
                if (pos < expr.Length && expr[pos] == close) pos++;
            }
            else
            {
                SkipSpaces(expr, ref pos);
                int start = pos;
                while (pos < expr.Length && (char.IsDigit(expr[pos]) || expr[pos] == '.'))
                    pos++;
                value = start < pos ? double.Parse(expr[start..pos]) : 0;
            }

            // 생략된 곱셈: 2(3+4), (2+3)(4+5), 3{2+1} 등
            SkipSpaces(expr, ref pos);
            while (pos < expr.Length && (expr[pos] == '(' || expr[pos] == '{'))
            {
                value *= ParseFactor(expr, ref pos);
            }

            return value;
        }

        #endregion

        private void Calculate()
        {
            if (string.IsNullOrWhiteSpace(_expression)) return;
            try
            {
                string normalized = _expression
                    .Replace("×", "*")
                    .Replace("÷", "/");
                int pos = 0;
                double result = ParseAddSub(normalized, ref pos);

                string fullExpr = _expression + " = " + result;
                _history.Add(fullExpr);
                Ctext.Text = fullExpr;
                Rtext.Text = result.ToString();
                _expression = result.ToString();
                _isNewCalculation = true;
            }
            catch
            {
                Rtext.Text = "Error";
            }
        }

        // CE
        private void CE_Click(object sender, EventArgs e)
        {
            _expression = "";
            _isNewCalculation = true;
            Ctext.Text = "";
        }

        // C
        private void C_Click(object sender, EventArgs e)
        {
            _history.Add("--- C (초기화) ---");
            _expression = "";
            _isNewCalculation = true;
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
            if (_expression.Length > 0)
            {
                _expression = _expression.TrimEnd();
                _expression = _expression[..^1].TrimEnd();
                _isNewCalculation = _expression.Length == 0;
                Ctext.Text = _expression;
            }
        }

        // ( 
        private void 괄호1_Click(object sender, EventArgs e) => AppendBracket("(");

        // )
        private void 괄호2_Click(object sender, EventArgs e) => AppendBracket(")");

        // {
        private void 대괄1_Click(object sender, EventArgs e) => AppendBracket("{");

        // }
        private void 대괄2_Click(object sender, EventArgs e) => AppendBracket("}");

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
            if (string.IsNullOrEmpty(_expression)) return;
            if (_expression.StartsWith("(-") && _expression.EndsWith(")"))
                _expression = _expression[2..^1];
            else
                _expression = "(-" + _expression + ")";
            Ctext.Text = _expression;
        }

        // 0
        private void b0_Click(object sender, EventArgs e) => AppendNumber("0");

        // .
        private void dot_Click(object sender, EventArgs e)
        {
            if (_isNewCalculation)
            {
                _expression = "0.";
                _isNewCalculation = false;
            }
            else
            {
                _expression += ".";
            }
            Ctext.Text = _expression;
        }

        // =
        private void e_Click(object sender, EventArgs e) => Calculate();

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0 when e.Shift: AppendBracket(")"); break;
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
                case Keys.D9 when e.Shift: AppendBracket("("); break;
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
                { what, b0, dot, this.e },
                { 괄호1, 괄호2, 대괄1, 대괄2 }
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
