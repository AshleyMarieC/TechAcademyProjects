using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Exercise
{
    public class voidClass
    {
        public static void Method(int number4, int number2, out int result3, out int result2)
        {
            result3 = number4 * 10;
            result2 = number2;
        }
    }
}
