using SharedComponents;
using System;

namespace ConsoleApp1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            MyWriter writer = new MyWriter();
   

            DateTime earthTime = DateTime.Now;
            double earthPrintTime = earthTime.AddSeconds(-2).Second;
            var earthPrintTimeAfternoon = earthPrintTime + 12;

            var firstEarthTime = writer.GetHelloVenusString();
            var firstEarthTimeSplit = firstEarthTime.Split('\n');
    
        }
    }
}
