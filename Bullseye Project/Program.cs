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
                Console.WriteLine($"The Mouse Position of X is: {userX}, The Mouse Position of Y is: {userY}");

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

                // Frozen
                int BananaX =  xAxis - 1000;
                int BananaY = yAxis - 1000;

                // Ice Cold
                int OrangeX = xAxis - 800;
                int OrangeY = yAxis - 800;

                // Cold
                int KiwiX = xAxis - 401;
                int KiwiY = yAxis - 401;
                
                // Warm
                int AppleX = xAxis - 200;
                int AppleY = xAxis - 200;

                // Hot
                int StrawberryX = xAxis - 80;
                int StrawberryY = yAxis - 80;

                // On Fire
                int WatermelonX = xAxis - 40;
                int WatermelonY = yAxis - 40;

                // Hit
                int CantalopeX = xAxis - 5;
                int CantalopeY = yAxis - 5;
                



                // Insane
                if (userX == xAxis && userY == yAxis)
                {
                    Console.WriteLine("Your INSANE!");
                    Thread.Sleep(90000000);
                    
                }


                //

                if (BananaX <= userX && BananaY <= userY)
                {
                    Console.WriteLine("Your Frozen!");
                    //Thread.Sleep(5000);


                }

                //
                if (OrangeX <= userX && OrangeY <= userY)
                {
                    Console.WriteLine("Your Ice Cold!");

                }

                //
                if (KiwiX <= userX && KiwiY <= userY)
                {
                    Console.WriteLine("Your Cold!");
                }

                //
                if (AppleX <= userX && AppleY <= userY)
                {
                    Console.WriteLine("Your Warm!");
                }


                //
                if (StrawberryX <= userX && StrawberryY <= userY)
                {
                    Console.WriteLine("Your  Hot!");
                }

                if (WatermelonX <= userX && WatermelonY <= userY)
                {
                    Console.WriteLine("Your On Fire");
                }

                if (CantalopeX <= userX && CantalopeY <= userY)
                {
                    

                    Console.WriteLine("You Win!");
                    Console.WriteLine(myCount);
                    Thread.Sleep(10000000);
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