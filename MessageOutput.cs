using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW_26_06_1
{
    public delegate void MessageMethods(string text);
    internal class MessageOutput
    {
        /*Створіть додаток, який відображає текстове повідомлення. Використовуйте механізми делегатів. Делегат має
        повертати void та приймати один параметр типу string
        (текст повідомлення). Для тестування додатка створіть
        різні методи виклику через делегат.*/

        public MessageOutput () { }
        
        public void DelegateON(string text,MessageMethods method )
        {
            method.Invoke(text);
        }

       



        
    }
}
