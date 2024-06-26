using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_26_06_1
{

    public delegate void MathMethods(int x, int y);
    internal class MathOperation
    {
       
        public MathOperation() { }

        public void MethodsON(int x, int y,MathMethods methods) {
            methods.Invoke(x, y);
        }

    }
}
