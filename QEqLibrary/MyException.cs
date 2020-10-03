using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using QEqLibrary;

namespace QEqLibrary
{
    /// <summary>
    /// Пользовательский класс для обработки исключений
    /// </summary>
    public class MyException : Exception
    {
        public static void IncorrectData()
        {
            throw new Exception("Коэффициенты могут быть только действительными числами");
        }
    }
}
