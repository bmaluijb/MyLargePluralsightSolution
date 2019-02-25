using SharedComponents;
using System;
using System.Reflection;

namespace HelloEarthWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWriter writer = new MyWriter();

            if (writer.IsHelloEarthString(Assembly.GetExecutingAssembly().FullName))
            {
                Console.WriteLine(writer.GetHelloEarthString());
            }
            else
            {
                Console.WriteLine(writer.GetHelloGenericWorldString());
            }
        }
    }
}
