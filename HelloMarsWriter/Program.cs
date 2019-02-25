using SharedComponents;
using System;
using System.Reflection;

namespace HelloMarsWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWriter writer = new MyWriter();

            if (writer.IsHelloMarsString(Assembly.GetExecutingAssembly().FullName))
            {
                Console.WriteLine(writer.GetHelloMarsString());
            }
            else
            {
                Console.WriteLine(writer.GetHelloGenericWorldString());
            }
        }
    }
}
