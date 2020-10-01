using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Threading;

namespace Bullseye
{
    class Program
    {

        static void Main(string[] args)
        {


            /* RandomPos()*/
           
            MousePos();
        }


        public static void MousePos()
        {
            Random rnd = new Random();
            int xAxis = rnd.Next(0, 1920);
            int yAxis = rnd.Next(0, 1080);
            Console.WriteLine($"The xAxis Cordinate is: {xAxis} / The yAxis Cordinate is:  {yAxis}");
            int myCount = 0;

            while (true)
            {
                Thread.Sleep(100);
                int userX = Cursor.Position.X;
                int userY = Cursor.Position.Y;
                Console.WriteLine($"The Mouse Position of X is: {userX}, The Mouse Position of X is: {userY}");

                Console.WriteLine($"The xAxis Cordinate is: {xAxis} / The yAxis Cordinate is:  {yAxis}");
                /* Random rnd = new Random();
                 int xAxis = rnd.Next(0, 1920);
                 int yAxis = rnd.Next(0, 1080);

                 Console.WriteLine($"The Random xAxis Cordinate is: {xAxis} / The Random yAxis Cordinate is:  {yAxis}");
                */
                if (myCount <= 100)
                {
                    Thread.Sleep(1000);
                    ++myCount;
                    Console.WriteLine($"Number of seconds: {myCount}");
                    
                }
                else
                {
                    Console.WriteLine("For the love of god. Stop me.");
                    MousePos();
                    Console.Clear();
                }
                 if (userX == xAxis && userY == yAxis)
                {
                    Console.WriteLine("Got It!!");
                    return;
                }

                

            }





        }

        //public static void RandomPos()
        //{
        //    Random rnd = new Random();
        //    int xAxis = rnd.Next(0, 1920);
        //    int yAxis = rnd.Next(0, 1080);




        //    Console.WriteLine($"The xAxis Cordinate is: {xAxis} / The yAxis Cordinate is:  {yAxis}");
        //    //Console.WriteLine(yAxis);
        //    Console.ReadLine();
        //}



































    }
}
