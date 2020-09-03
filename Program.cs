using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //Full Name - Demo.Program
    class Program /*Reference Type */
    {

        static void Main()
        {
            System.Console.WriteLine("C# Sample Demo App");
            Calculator obj = new Calculator();
            var method=obj.GetType().GetMethod("Add",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            object result=method.Invoke(obj, new Object[] { 10, 20 });
            Console.WriteLine(result);
        }
    }
}
