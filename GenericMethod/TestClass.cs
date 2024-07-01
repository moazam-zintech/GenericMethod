using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    public static class TestClass
    {
  
        public static void Test<T>(T Name)
        {
            Console.WriteLine(Name);
        }
    }
}
