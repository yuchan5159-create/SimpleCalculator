namespace SimpleCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Ctext = new TextBox();
            Rtext = new TextBox();
            CE = new Button();
            C = new Button();
            del = new Button();
            나누기 = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            X = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            빼기 = new Button();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            더하기 = new Button();
            what = new Button();
            b0 = new Button();
            dot = new Button();
            e = new Button();
            name = new Label();
            history = new Button();
            SuspendLayout();
            // 
            // Ctext
            // 
            Ctext.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ctext.Location = new Point(64, 86);
            Ctext.Name = "Ctext";
            Ctext.Size = new Size(467, 31);
            Ctext.TabIndex = 0;
            // 
            // Rtext
            // 
            Rtext.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rtext.Location = new Point(64, 132);
            Rtext.Name = "Rtext";
            Rtext.Size = new Size(467, 57);
            Rtext.TabIndex = 1;
            // 
            // CE
            // 
            CE.BackColor = Color.LightGray;
            CE.Font = new Font("Segoe UI", 10.8F);
            CE.ForeColor = Color.DarkGreen;
            CE.Location = new Point(64, 210);
            CE.Name = "CE";
            CE.Size = new Size(134, 51);
            CE.TabIndex = 2;
            CE.Text = "ＣＥ";
            CE.UseVisualStyleBackColor = false;
            CE.Click += CE_Click;
            // 
            // C
            // 
            C.BackColor = Color.LightGray;
            C.Font = new Font("Segoe UI", 10.8F);
            C.ForeColor = Color.DarkGreen;
            C.Location = new Point(174, 210);
            C.Name = "C";
            C.Size = new Size(134, 51);
            C.TabIndex = 3;
            C.Text = "Ｃ";
            C.UseVisualStyleBackColor = false;
            C.Click += C_Click;
            // 
            // del
            // 
            del.BackColor = Color.LightGray;
            del.Font = new Font("Segoe UI", 10.8F);
            del.ForeColor = Color.DarkGreen;
            del.Location = new Point(284, 210);
            del.Name = "del";
            del.Size = new Size(134, 51);
            del.TabIndex = 4;
            del.Text = "ｄｅｌ";
            del.UseVisualStyleBackColor = false;
            del.Click += del_Click;
            // 
            // 나누기
            // 
            나누기.BackColor = Color.Orange;
            나누기.Font = new Font("Segoe UI", 10.8F);
            나누기.ForeColor = Color.SteelBlue;
            나누기.Location = new Point(397, 210);
            나누기.Name = "나누기";
            나누기.Size = new Size(134, 51);
            나누기.TabIndex = 5;
            나누기.Text = "/";
            나누기.UseVisualStyleBackColor = false;
            나누기.Click += 나누기_Click;
            // 
            // b7
            // 
            b7.BackColor = SystemColors.ControlDarkDark;
            b7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            b7.ForeColor = Color.Brown;
            b7.Location = new Point(64, 255);
            b7.Name = "b7";
            b7.Size = new Size(134, 51);
            b7.TabIndex = 6;
            b7.Text = "７";
            b7.UseVisualStyleBackColor = false;
            b7.Click += b7_Click;
            // 
            // b8
            // 
            b8.BackColor = SystemColors.ControlDarkDark;
            b8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            b8.ForeColor = Color.Brown;
            b8.Location = new Point(174, 255);
            b8.Name = "b8";
            b8.Size = new Size(134, 51);
            b8.TabIndex = 7;
            b8.Text = "８";
            b8.UseVisualStyleBackColor = false;
            b8.Click += b8_Click;
            // 
            // b9
            // 
            b9.BackColor = SystemColors.ControlDarkDark;
            b9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            b9.ForeColor = Color.Brown;
            b9.Location = new Point(284, 255);
            b9.Name = "b9";
            b9.Size = new Size(134, 51);
            b9.TabIndex = 8;
            b9.Text = "９";
            b9.UseVisualStyleBackColor = false;
            b9.Click += b9_Click;
            // 
            // X
            // 
            X.BackColor = Color.Orange;
            X.Font = new Font("Segoe UI", 10.8F);
            X.ForeColor = Color.SteelBlue;
            X.Location = new Point(397, 255);
            X.Name = "X";
            X.Size = new Size(134, 51);
            X.TabIndex = 9;
            X.Text = "Ｘ";
            X.UseVisualStyleBackColor = false;
            X.Click += X_Click;
            // 
            // b4
            // 
            b4.BackColor = SystemColors.ControlDarkDark;
            b4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            b4.ForeColor = Color.Brown;
            b4.Location = new Point(64, 302);
            b4.Name = "b4";
            b4.Size = new Size(134, 51);
            b4.TabIndex = 10;
            b4.Text = "４";
            b4.UseVisualStyleBackColor = false;
            b4.Click += b4_Click;
            // 
            // b5
            // 
            b5.BackColor = SystemColors.ControlDarkDark;
            b5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            b5.ForeColor = Color.Brown;
            b5.Location = new Point(174, 302);
            b5.Name = "b5";
            b5.Size = new Size(134, 51);
            b5.TabIndex = 11;
            b5.Text = "５";
            b5.UseVisualStyleBackColor = false;
            b5.Click += b5_Click;
            // 
            // b6
            // 
            b6.BackColor = SystemColors.ControlDarkDark;
            b6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            b6.ForeColor = Color.Brown;
            b6.Location = new Point(284, 302);
            b6.Name = "b6";
            b6.Size = new Size(134, 51);
            b6.TabIndex = 12;
            b6.Text = "６";
            b6.UseVisualStyleBackColor = false;
            b6.Click += b6_Click;
            // 
            // 빼기
            // 
            빼기.BackColor = Color.Orange;
            빼기.Font = new Font("Segoe UI", 10.8F);
            빼기.ForeColor = Color.SteelBlue;
            빼기.Location = new Point(397, 302);
            빼기.Name = "빼기";
            빼기.Size = new Size(134, 51);
            빼기.TabIndex = 13;
            빼기.Text = "－";
            빼기.UseVisualStyleBackColor = false;
            빼기.Click += 빼기_Click;
            // 
            // b1
            // 
            b1.BackColor = SystemColors.ControlDarkDark;
            b1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            b1.ForeColor = Color.Brown;
            b1.Location = new Point(64, 351);
            b1.Name = "b1";
            b1.Size = new Size(134, 51);
            b1.TabIndex = 14;
            b1.Text = "１";
            b1.UseVisualStyleBackColor = false;
            b1.Click += b1_Click;
            // 
            // b2
            // 
            b2.BackColor = SystemColors.ControlDarkDark;
            b2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            b2.ForeColor = Color.Brown;
            b2.Location = new Point(174, 351);
            b2.Name = "b2";
            b2.Size = new Size(134, 51);
            b2.TabIndex = 15;
            b2.Text = "２";
            b2.UseVisualStyleBackColor = false;
            b2.Click += b2_Click;
            // 
            // b3
            // 
            b3.BackColor = SystemColors.ControlDarkDark;
            b3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            b3.ForeColor = Color.Brown;
            b3.Location = new Point(284, 351);
            b3.Name = "b3";
            b3.Size = new Size(134, 51);
            b3.TabIndex = 16;
            b3.Text = "３";
            b3.UseVisualStyleBackColor = false;
            b3.Click += b3_Click;
            // 
            // 더하기
            // 
            더하기.BackColor = Color.Orange;
            더하기.Font = new Font("Segoe UI", 10.8F);
            더하기.ForeColor = Color.SteelBlue;
            더하기.Location = new Point(397, 351);
            더하기.Name = "더하기";
            더하기.Size = new Size(134, 51);
            더하기.TabIndex = 17;
            더하기.Text = "＋";
            더하기.UseVisualStyleBackColor = false;
            더하기.Click += 더하기_Click;
            // 
            // what
            // 
            what.BackColor = Color.Orange;
            what.Font = new Font("Segoe UI", 10.8F);
            what.Location = new Point(64, 398);
            what.Name = "what";
            what.Size = new Size(134, 51);
            what.TabIndex = 18;
            what.Text = "＋／－";
            what.UseVisualStyleBackColor = false;
            what.Click += what_Click;
            // 
            // b0
            // 
            b0.BackColor = SystemColors.ControlDarkDark;
            b0.Font = new Font("Segoe UI", 10.8F);
            b0.ForeColor = Color.Brown;
            b0.Location = new Point(174, 398);
            b0.Name = "b0";
            b0.Size = new Size(134, 51);
            b0.TabIndex = 19;
            b0.Text = "０";
            b0.UseVisualStyleBackColor = false;
            b0.Click += b0_Click;
            // 
            // dot
            // 
            dot.BackColor = Color.Orange;
            dot.Font = new Font("Segoe UI", 10.8F);
            dot.Location = new Point(284, 398);
            dot.Name = "dot";
            dot.Size = new Size(134, 51);
            dot.TabIndex = 20;
            dot.Text = "．";
            dot.UseVisualStyleBackColor = false;
            dot.Click += dot_Click;
            // 
            // e
            // 
            e.BackColor = Color.Orange;
            e.Font = new Font("Segoe UI", 10.8F);
            e.ForeColor = Color.SteelBlue;
            e.Location = new Point(397, 398);
            e.Name = "e";
            e.Size = new Size(134, 51);
            e.TabIndex = 21;
            e.Text = "＝";
            e.UseVisualStyleBackColor = false;
            e.Click += e_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            name.ForeColor = Color.Transparent;
            name.Location = new Point(29, 21);
            name.Name = "name";
            name.Size = new Size(614, 44);
            name.TabIndex = 22;
            name.Text = "Ｓｉｍｐｌｅ　Ｃａｌｃｕｌａｔｏｒ";
            // 
            // history
            // 
            history.Location = new Point(549, 88);
            history.Name = "history";
            history.Size = new Size(94, 29);
            history.TabIndex = 23;
            history.Text = "history";
            history.UseVisualStyleBackColor = true;
            history.Click += history_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(655, 559);
            Controls.Add(history);
            Controls.Add(name);
            Controls.Add(e);
            Controls.Add(dot);
            Controls.Add(b0);
            Controls.Add(what);
            Controls.Add(더하기);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(빼기);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(X);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(나누기);
            Controls.Add(del);
            Controls.Add(C);
            Controls.Add(CE);
            Controls.Add(Rtext);
            Controls.Add(Ctext);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Ctext;
        private TextBox Rtext;
        private Button CE;
        private Button C;
        private Button del;
        private Button 나누기;
        private Button b7;
        private Button b8;
        private Button b9;
        private Button X;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button 빼기;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button 더하기;
        private Button what;
        private Button b0;
        private Button dot;
        private Button e;
        private Label name;
        private Button history;
    }
}
