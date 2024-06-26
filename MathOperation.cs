using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_26_06_1
{
    /*Створіть додаток для виконання арифметичних операцій. Підтримувані операції:
    ■ Додавання двох чисел;
    ■ Віднімання двох чисел;
    ■ Множення двох чисел.
    Код програми обов’язково має використати механізм
    делегатів*/
    public delegate void MathMethods(int x, int y);
    internal class MathOperation
    {
       
        public MathOperation() { }

        public void MethodsON(int x, int y,MathMethods methods) {
            methods.Invoke(x, y);
        }

    }
}
