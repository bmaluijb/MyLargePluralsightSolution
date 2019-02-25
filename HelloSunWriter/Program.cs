using SharedComponents;
using System;
using System.Reflection;

namespace HelloSunWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWriter writer = new MyWriter();

            if (writer.IsHelloSunString(Assembly.GetExecutingAssembly().FullName))
            {
                Console.WriteLine(writer.GetHelloSunString());
            }
            else
            {
                Console.WriteLine(writer.GetHelloGenericWorldString());
            }
        }
    }
}
