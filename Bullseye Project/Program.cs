using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Bullseye
{
    class Program


    {
        static void Main(string[] args)
        {

            Dot();
        }


        public static void Dot()
        {
            Random rnd = new Random();
            int xAxis = rnd.Next(0, 1920);
            int yAxis = rnd.Next(0, 1080);
            



            Console.WriteLine($"The xAxis Cordinate is: {xAxis} / The yAxis Cordinate is:  {yAxis}");
            //Console.WriteLine(yAxis);
            Console.ReadLine();

        }

        public struct MousePoint
        {
            
        }
      
            


































































    }
}
