using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace QEqLibrary
{
    public class QuadDecision
    {
        /// <summary>
        /// Конструктор без параметров. Задаёт всем коэффициентам значение 0
        /// </summary>
        public QuadDecision()
        {
            A = 0;
            B = 0;
            C = 0;
        }

        /// <summary>
        /// Конструктор, принимающий числа
        /// </summary>
        /// <param name="coef1"> Коэффициент А </param>
        /// <param name="coef2"> Коэффициент В </param>
        /// <param name="coef3"> Коэффициент С </param>
        public QuadDecision(double coef1, double coef2, double coef3)
        {
            A = coef1;
            B = coef2;
            C = coef3;
        }

        /// <summary>
        /// Массив, показывающий, являются ли коэффициенты типом double
        /// </summary>
        private bool[] p = new bool[3];

        /// <summary>
        /// Конструктор, принимающий строки
        /// </summary>
        /// <param name="coef1"> Коэффициент А </param>
        /// <param name="coef2"> Коэффициент В </param>
        /// <param name="coef3"> Коэффициент С </param>
        public QuadDecision(string coef1, string coef2, string coef3)
        {
            try
            {
                AString = coef1;
                BString = coef2;
                CString = coef3;
            }
            catch
            {
                MyException.IncorrectData();
            }
        }

        /// <summary>
        /// Свойство для коэффициента А
        /// </summary>
        public double A { get; set; }

        /// <summary>
        /// Свойство для коэффициента A строкового типа
        /// </summary>
        public string AString
        {
            get
            {
                return A.ToString();
            }
            set
            {
                p[0] = double.TryParse(value, out double a);
                A = a;
            }
        }

        /// <summary>
        /// Свойство для коэффициента В
        /// </summary>
        public double B { get; set; }

        /// <summary>
        /// Свойство для коэффициента B строкового типа
        /// </summary>
        public string BString
        {
            get
            {
                return B.ToString();
            }
            set
            {
                p[1] = double.TryParse(value, out double b);
                B = b;
            }
        }

        /// <summary>
        /// Свойство для коэффициента С
        /// </summary>
        public double C { get; set; }

        /// <summary>
        /// Свойство для коэффициента C строкового типа
        /// </summary>
        public string CString
        {
            get
            {
                return C.ToString();
            }
            set
            {
                p[2] = double.TryParse(value, out double c);
                C = c;
            }
        }

        /// <summary>
        /// Свойство. Если уравнение квадратное, считает дискриминант. Иначе возвращает NaN;
        /// </summary>
        public double Discriminant
        {
            get
            {
                if (A != 0)
                {
                    return B * B - 4 * A * C;
                }
                return double.NaN;
            }
        }
        /// <summary>
        /// Массив, который хранит ответ
        /// </summary>
        private double[] ans = new double[3];

        /// <summary>
        /// [0] 2, если два корня. 1, если один корень. 12, если два одинаковых корня. 
        /// 0, если решений нет. -1, если любое число; -2, если действительных корней нет.
        /// [1] Первый корень уравнения;
        /// [2] Второй корень уравнения.
        /// </summary>
        public double[] Answer
        {
            get
            {
                Decision();
                return ans;
            }
        }

        /// <summary>
        /// [0] true, если коэффициент A является типом double;
        /// [1] true, если коэффициент B является типом double;
        /// [2] true, если коэффициент C является типом double.
        /// </summary>
        public bool[] Parse
        {
            get
            {
                return p;
            }
        }

        /// <summary>
        /// Решает уравнение
        /// </summary>
        private void Decision()
        {
            if (A != 0)
            {
                ans[0] = 2;
                Quadratic_Equation();
            }
            else
            {
                ans[0] = 1;
                Not_Quadratic_Equation();
            }
        }

        /// <summary>
        /// Решает квадратное уравнение
        /// </summary>
        private void Quadratic_Equation()
        {
            if (B == 0 && C == 0)
            {
                ans[0] = 12;
                ans[1] = 0;
                ans[2] = 0;
            }
            else
            {
                if (Discriminant < 0)
                {
                    ans[0] = -2;
                    ans[1] = double.NaN;
                    ans[2] = double.NaN;
                }
                else
                {
                    if (Discriminant == 0)
                    {
                        ans[0] = 1;
                        ans[1] = Math.Round(-B / (2 * A), 3);
                        ans[2] = double.NaN;
                    }
                    else
                    {
                        double Sd = Math.Sqrt(Discriminant);
                        ans[1] = Math.Round((-B - Sd) / (2 * A), 3);
                        ans[2] = Math.Round((-B + Sd) / (2 * A), 3);
                    }
                }
            }
        }

        /// <summary>
        /// Решает линейное кравнение
        /// </summary>
        public void Not_Quadratic_Equation()
        {
            if (B == 0)
            {
                if (C == 0)
                {
                    ans[0] = -1;
                }
                else
                {
                    ans[0] = 0;
                }
                ans[1] = double.NaN;
                ans[2] = double.NaN;
            }
            else
            {
                ans[1] = Math.Round(-C / B, 3);
                ans[2] = double.NaN;
            }
        }

    }
}
