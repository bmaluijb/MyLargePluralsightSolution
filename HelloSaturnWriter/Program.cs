using SharedComponents;
using System;
using System.Reflection;

namespace HelloSaturnWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWriter writer = new MyWriter();

            if (writer.IsHelloSaturnString(Assembly.GetExecutingAssembly().FullName))
            {
                Console.WriteLine(writer.GetHelloSaturnString());
            }
            else
            {
                Console.WriteLine(writer.GetHelloGenericWorldString());
            }
        }
    }
}
