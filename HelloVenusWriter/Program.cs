using SharedComponents;
using System;
using System.Reflection;

namespace HelloVenusWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWriter writer = new MyWriter();

            if (writer.IsHelloVenusString(Assembly.GetExecutingAssembly().FullName))
            {
                Console.WriteLine(writer.GetHelloVenusString());
            }
            else
            {
                Console.WriteLine(writer.GetHelloGenericWorldString());
            }
        }
    }
}
