using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferEqualsEx
{
    /*
        경우에 따라 참조 상등 비교를 강제해야 할 수도 있다.
         */

    class Widget { }

    class Test
    {
        static void Main(string[] args)
        {
            Widget w1 = new Widget();
            Widget w2 = new Widget();
            Console.WriteLine(object.ReferenceEquals(w1, w2));  // False

        }
    }
}
