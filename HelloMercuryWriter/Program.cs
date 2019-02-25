using SharedComponents;
using System;
using System.Reflection;

namespace HelloMercuryWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWriter writer = new MyWriter();

            if (writer.IsHelloMercuryString(Assembly.GetExecutingAssembly().FullName))
            {
                Console.WriteLine(writer.GetHelloMercuryString());
            }
            else
            {
                Console.WriteLine(writer.GetHelloGenericWorldString());
            }
        }
    }
}
