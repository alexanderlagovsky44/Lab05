using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QEqLibrary;

namespace QuadEquation
{
    public partial class Calculator : Form
    {
        QuadDecision equation;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            equation = new QuadDecision();
        }

        private void Decision_Click(object sender, EventArgs e)
        {
            if (equation.Parse[0] && equation.Parse[1] && equation.Parse[2])
            {
                double[] ans = equation.Answer;
                if (ans[0] == 12)
                {
                    Ans.Text = "x₁ = x₂ = " + ans[1];
                }
                if (ans[0] == 2)
                {
                    Ans.Text = "x₁ = " + ans[1] + ", x₂ = " + ans[2];
                }
                if (ans[0] == 1)
                {
                    Ans.Text = "x = " + ans[1];
                }
                if (ans[0] == 0)
                {
                    Ans.Text = "Решений нет";
                }
                if (ans[0] == -1)
                {
                    Ans.Text = "x - любое число";
                }
                if (ans[0] == -2)
                {
                    Ans.Text = "Действительных корней нет";
                }
                if (equation.A != 0)
                {
                    Discriminant_Label.Text = equation.Discriminant.ToString();
                }
                else
                {
                    Discriminant_Label.Text = "-";
                }
            }
        }


        /// <summary>
        /// Обработчик для всех TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Box_TextChanged(object sender, EventArgs e)
        {
            try
            {
                equation.AString = ABox.Text;
                equation.BString = BBox.Text;
                equation.CString = CBox.Text;
                ColorAndException();
            }
            catch (Exception er)
            {
                Exception.Text = er.Message;
            }
        }


        /// <summary>
        /// Задаёт цвет для фона TextBox и показывает ошибку, если введён некорректный текст
        /// </summary>
        /// <param name="sender">Объект. В данном случае TextBox</param>
        private void ColorAndException()
        {
            Color(ABox, equation.Parse[0]);
            Color(BBox, equation.Parse[1]);
            Color(CBox, equation.Parse[2]);

            if (!equation.Parse[0] || !equation.Parse[1] || !equation.Parse[2])
            {
                MyException.IncorrectData();
            }
            else
            {
                Exception.Text = "";
            }

        }

        /// <summary>
        /// Задаёт цвет для фона TextBox
        /// </summary>
        /// <param name="sender"> Объект(TextBox) </param>
        /// <param name="f"> Если true, красный цвет. Если false, белый цвет</param>
        private void Color(object sender, bool f)
        {
            if (f)
            {
                (sender as TextBox).BackColor = System.Drawing.Color.White;
            }
            else
            {
                (sender as TextBox).BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            }
        }
    }
}

