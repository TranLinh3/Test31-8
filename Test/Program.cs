using System;

namespace Test
{
    public class Program
    {
       public static void Main()
        {
            double Radius = 38.64;
            double Height = 22.48;
            double BaseArea = Radius * Radius * Math.PI;
            double LateralArea = 2 * Math.PI * Radius * Height;
            double TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            double Volume = Math.PI * Radius * Radius * Height;
            Console.WriteLine("Radius: 38.64 , Height: 22.48");

            Console.WriteLine("Base :" + BaseArea );
            Console.WriteLine("Lateral :" + LateralArea);
            Console.WriteLine("Total:" + TotalArea);
            Console.WriteLine("Volume :" + Volume);
            Console.ReadKey();


        }
    }
}
