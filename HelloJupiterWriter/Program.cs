using SharedComponents;
using System;
using System.Reflection;

namespace HelloJupiterWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWriter writer = new MyWriter();

            if (writer.IsHelloJupiterString(Assembly.GetExecutingAssembly().FullName))
            {
                Console.WriteLine(writer.GetHelloJupiterString());
            }
            else
            {
                Console.WriteLine(writer.GetHelloGenericWorldString());
            }
        }
    }
}
