using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05
{
    class NonStaticClass
    {
        public static void StaticMethod(Action action)
        {
            action();
        }
    }
}
