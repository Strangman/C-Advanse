using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public delegate void MyDelegate();
    class StaticMethod
    {
        
        public static void CallDelegate(MyDelegate myDelegate)
        {
            myDelegate();
        }
    }
}
