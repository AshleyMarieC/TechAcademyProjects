using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide
{
    public class divMethod
    {
        public static void Method(int number1, out int result1)
        {
            result1 = number1 / 2;
        }
    }

    public class outMethod //Declare a class to be static.
    {
        public void OutExample(out int number) //Create a method with output parameters.
        {
            number = 125;
        }
        public void OutExample(out string number) //Overload a method.
        {
            number = "Fourty Four";
        }
    }

    static public class classStatic
    {
        public struct MyStruct
        {
            public static int num4 = 4;
        }
           
    }

}
