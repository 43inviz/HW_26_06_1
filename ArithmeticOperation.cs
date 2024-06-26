using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_26_06_1
{
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
