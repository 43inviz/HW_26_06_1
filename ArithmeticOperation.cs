using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_26_06_1
{
    /*Створіть додатки для виконання арифметичних операцій. Підтримувані операції:
        ■ Перевірка числа на парність;
        ■ Перевірка числа на непарність;
        ■ Перевірка на просте число;
        ■ Перевірка на число Фібоначчі.
    Обов’язково використовуйте делегат типу Predicate.*/
    internal class ArithmeticOperation
    {
        public ArithmeticOperation() { }

        public void ArithmStart(int x,Predicate<int> predicate) {
            foreach(var Predicate in predicate.GetInvocationList()) {
                Console.WriteLine($"{predicate.Method.Name}: {predicate.Invoke(x)}");
            }
        }

    }
}
