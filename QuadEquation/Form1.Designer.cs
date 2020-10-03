namespace QuadEquation
{
    partial class Calculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Equation = new System.Windows.Forms.Label();
            this.Welcome_message = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.ABox = new System.Windows.Forms.TextBox();
            this.CBox = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.BBox = new System.Windows.Forms.TextBox();
            this.Decision = new System.Windows.Forms.Button();
            this.Formulas = new System.Windows.Forms.Label();
            this.Discriminant_Formul = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.Label();
            this.x2 = new System.Windows.Forms.Label();
            this.Welcome_message_2 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            this.D_Answer = new System.Windows.Forms.Label();
            this.Ans = new System.Windows.Forms.Label();
            this.Discriminant_Label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Exception = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Equation
            // 
            this.Equation.AutoSize = true;
            this.Equation.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equation.Location = new System.Drawing.Point(63, 129);
            this.Equation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Equation.Name = "Equation";
            this.Equation.Size = new System.Drawing.Size(182, 29);
            this.Equation.TabIndex = 0;
            this.Equation.Text = "a⋅x² + b⋅x + c = 0";
            // 
            // Welcome_message
            // 
            this.Welcome_message.AutoSize = true;
            this.Welcome_message.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_message.Location = new System.Drawing.Point(123, 28);
            this.Welcome_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Welcome_message.Name = "Welcome_message";
            this.Welcome_message.Size = new System.Drawing.Size(379, 26);
            this.Welcome_message.TabIndex = 1;
            this.Welcome_message.Text = "Пожалуйста, задайте коэффициенты a, b, c";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(61, 176);
            this.a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(43, 32);
            this.a.TabIndex = 2;
            this.a.Text = "a=";
            // 
            // ABox
            // 
            this.ABox.BackColor = System.Drawing.Color.White;
            this.ABox.Location = new System.Drawing.Point(103, 181);
            this.ABox.Margin = new System.Windows.Forms.Padding(4);
            this.ABox.Name = "ABox";
            this.ABox.Size = new System.Drawing.Size(72, 22);
            this.ABox.TabIndex = 1;
            this.ABox.Text = "0";
            this.ABox.TextChanged += new System.EventHandler(this.Box_TextChanged);
            // 
            // CBox
            // 
            this.CBox.BackColor = System.Drawing.Color.White;
            this.CBox.Location = new System.Drawing.Point(103, 283);
            this.CBox.Margin = new System.Windows.Forms.Padding(4);
            this.CBox.Name = "CBox";
            this.CBox.Size = new System.Drawing.Size(72, 22);
            this.CBox.TabIndex = 3;
            this.CBox.Text = "0";
            this.CBox.TextChanged += new System.EventHandler(this.Box_TextChanged);
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.Location = new System.Drawing.Point(61, 228);
            this.b.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(45, 32);
            this.b.TabIndex = 6;
            this.b.Text = "b=";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(61, 278);
            this.c.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(42, 32);
            this.c.TabIndex = 7;
            this.c.Text = "c=";
            // 
            // BBox
            // 
            this.BBox.BackColor = System.Drawing.Color.White;
            this.BBox.Location = new System.Drawing.Point(103, 233);
            this.BBox.Margin = new System.Windows.Forms.Padding(4);
            this.BBox.Name = "BBox";
            this.BBox.Size = new System.Drawing.Size(72, 22);
            this.BBox.TabIndex = 2;
            this.BBox.Text = "0";
            this.BBox.TextChanged += new System.EventHandler(this.Box_TextChanged);
            // 
            // Decision
            // 
            this.Decision.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Decision.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decision.Location = new System.Drawing.Point(68, 342);
            this.Decision.Margin = new System.Windows.Forms.Padding(4);
            this.Decision.Name = "Decision";
            this.Decision.Size = new System.Drawing.Size(203, 42);
            this.Decision.TabIndex = 4;
            this.Decision.Text = "Решить уравнение";
            this.Decision.UseVisualStyleBackColor = false;
            this.Decision.Click += new System.EventHandler(this.Decision_Click);
            // 
            // Formulas
            // 
            this.Formulas.AutoSize = true;
            this.Formulas.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formulas.Location = new System.Drawing.Point(399, 129);
            this.Formulas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Formulas.Name = "Formulas";
            this.Formulas.Size = new System.Drawing.Size(185, 26);
            this.Formulas.TabIndex = 9;
            this.Formulas.Text = "Полезные формулы:";
            // 
            // Discriminant_Formul
            // 
            this.Discriminant_Formul.AutoSize = true;
            this.Discriminant_Formul.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discriminant_Formul.Location = new System.Drawing.Point(475, 182);
            this.Discriminant_Formul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Discriminant_Formul.Name = "Discriminant_Formul";
            this.Discriminant_Formul.Size = new System.Drawing.Size(127, 26);
            this.Discriminant_Formul.TabIndex = 10;
            this.Discriminant_Formul.Text = "D = b² - 4⋅a⋅c";
            // 
            // x1
            // 
            this.x1.AutoSize = true;
            this.x1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1.Location = new System.Drawing.Point(417, 231);
            this.x1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(185, 26);
            this.x1.TabIndex = 11;
            this.x1.Text = "x₁ = (-b - √D) / (2⋅a)";
            // 
            // x2
            // 
            this.x2.AutoSize = true;
            this.x2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2.Location = new System.Drawing.Point(416, 282);
            this.x2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(186, 26);
            this.x2.TabIndex = 12;
            this.x2.Text = "x₂ = (-b +√D) / (2⋅a)";
            // 
            // Welcome_message_2
            // 
            this.Welcome_message_2.AutoSize = true;
            this.Welcome_message_2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_message_2.Location = new System.Drawing.Point(148, 54);
            this.Welcome_message_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Welcome_message_2.Name = "Welcome_message_2";
            this.Welcome_message_2.Size = new System.Drawing.Size(342, 26);
            this.Welcome_message_2.TabIndex = 13;
            this.Welcome_message_2.Text = "и нажмите кнопку \"Решить уравнение\"";
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer.Location = new System.Drawing.Point(61, 78);
            this.Answer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(90, 32);
            this.Answer.TabIndex = 14;
            this.Answer.Text = "Ответ:";
            // 
            // D_Answer
            // 
            this.D_Answer.AutoSize = true;
            this.D_Answer.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_Answer.Location = new System.Drawing.Point(61, 27);
            this.D_Answer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.D_Answer.Name = "D_Answer";
            this.D_Answer.Size = new System.Drawing.Size(62, 32);
            this.D_Answer.TabIndex = 15;
            this.D_Answer.Text = "D = ";
            // 
            // Ans
            // 
            this.Ans.AutoSize = true;
            this.Ans.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ans.Location = new System.Drawing.Point(153, 78);
            this.Ans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(25, 32);
            this.Ans.TabIndex = 16;
            this.Ans.Text = "-";
            // 
            // Discriminant_Label
            // 
            this.Discriminant_Label.AutoSize = true;
            this.Discriminant_Label.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discriminant_Label.Location = new System.Drawing.Point(116, 27);
            this.Discriminant_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Discriminant_Label.Name = "Discriminant_Label";
            this.Discriminant_Label.Size = new System.Drawing.Size(25, 32);
            this.Discriminant_Label.TabIndex = 17;
            this.Discriminant_Label.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.Welcome_message_2);
            this.groupBox1.Controls.Add(this.Welcome_message);
            this.groupBox1.Location = new System.Drawing.Point(-5, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(676, 105);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.Discriminant_Label);
            this.groupBox2.Controls.Add(this.Ans);
            this.groupBox2.Controls.Add(this.D_Answer);
            this.groupBox2.Controls.Add(this.Answer);
            this.groupBox2.Controls.Add(this.Exception);
            this.groupBox2.Location = new System.Drawing.Point(0, 391);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(671, 132);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // Exception
            // 
            this.Exception.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exception.Location = new System.Drawing.Point(323, 20);
            this.Exception.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exception.Name = "Exception";
            this.Exception.Size = new System.Drawing.Size(297, 86);
            this.Exception.TabIndex = 18;
            this.Exception.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(323, 94);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(13, 318);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(667, 521);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.Discriminant_Formul);
            this.Controls.Add(this.Formulas);
            this.Controls.Add(this.Decision);
            this.Controls.Add(this.CBox);
            this.Controls.Add(this.BBox);
            this.Controls.Add(this.ABox);
            this.Controls.Add(this.a);
            this.Controls.Add(this.Equation);
            this.Controls.Add(this.b);
            this.Controls.Add(this.c);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор квадратных уравнений";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Welcome_message;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox ABox;
        private System.Windows.Forms.TextBox CBox;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.TextBox BBox;
        private System.Windows.Forms.Button Decision;
        private System.Windows.Forms.Label Formulas;
        private System.Windows.Forms.Label Discriminant_Formul;
        private System.Windows.Forms.Label x1;
        private System.Windows.Forms.Label x2;
        private System.Windows.Forms.Label Welcome_message_2;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Label D_Answer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label Discriminant_Label;
        public System.Windows.Forms.Label Ans;
        public System.Windows.Forms.Label Equation;
        public System.Windows.Forms.Label Exception;
    }
}

