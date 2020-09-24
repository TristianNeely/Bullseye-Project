using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            int PointLocation = rnd.Next(1080 * 1920);
            //int xAxis = 1080;
            //int yAxis = 1920;
            Console.WriteLine(PointLocation);
            Console.ReadLine();



        }


    }
}

