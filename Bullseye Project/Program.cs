﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Threading;
using System.IO;



namespace Bullseye
{
    class Program
    {
        static public string documentPath = @"C:/Users/neely_tristian/Desktop/Bullseye Project(UPDATED)/Bullseye Project/Bullseye Project/myData.txt";
        static void Main(string[] args)
        {


            /* RandomPos()*/
            
            normalDifficulty();

        }

        public static void EasyDif()
        {

        }
        public static void normalDifficulty()
        {

            // Random Pos
            Random rnd = new Random();
            int xAxis = rnd.Next(0, 1920);
            int yAxis = rnd.Next(0, 1080);
            Console.WriteLine($"The xAxis Cordinate is: {xAxis} / The yAxis Cordinate is:  {yAxis}");
            int myCount = 0;



            while (true)
            {
                Thread.Sleep(100);

                // Mouse Pos
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
                    Console.WriteLine($"Your time was: {myCount}");

                }
                else
                {
                    Console.WriteLine("For the love of god. Stop me.");
                    normalDifficulty();
                    Console.Clear();
                }
                if (userX == xAxis && userY == yAxis)
                {
                    Console.WriteLine("Got It!!");
                    return;
                }

                // Frozen
                int BananaX = xAxis - 1000;
                int BananaY = yAxis - 1000;

                // Ice Cold
                int OrangeX = xAxis - 800;
                int OrangeY = yAxis - 800;

                // Cold
                int KiwiX = xAxis - 401;
                int KiwiY = yAxis - 401;

                // Warm
                int AppleX = xAxis - 200;
                int AppleY = yAxis - 200;

                // Spicyyyyyyy
                int pepperX = xAxis - 140;
                int pepperY = yAxis - 140;

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
                    Console.WriteLine("--------------------");




                }

                //
                if (OrangeX <= userX && OrangeY <= userY)
                {
                    Console.WriteLine("Your Ice Cold!");
                    Console.WriteLine("--------------------");


                }

                //
                if (KiwiX <= userX && KiwiY <= userY)
                {
                    Console.WriteLine("Your Cold!");
                    Console.WriteLine("--------------------");

                }

                //
                if (AppleX <= userX && AppleY <= userY)
                {
                    Console.WriteLine("Your Warm!");
                    Console.WriteLine("--------------------");
                }


                // 

                if (pepperX <= userX && pepperY <= userY)
                {
                    Console.WriteLine("Your  Spicyyyyyyyyy!");
                    Console.WriteLine("--------------------");
                }


                //
                if (StrawberryX <= userX && StrawberryY <= userY)
                {
                    Console.WriteLine("Your  Hot!");
                    Console.WriteLine("--------------------");
                }

                if (WatermelonX <= userX && WatermelonY <= userY)
                {
                    Console.WriteLine("Your On Fire");
                    Console.WriteLine("--------------------");
                }

                if (CantalopeX <= userX && CantalopeY <= userY)
                {
                


                    Console.WriteLine("You Win!");
                    Console.WriteLine(myCount);
                    Console.WriteLine("--------------------");

                    Console.WriteLine("Do you want to play again: Yes / No");
                    string result = Console.ReadLine();
                    Console.WriteLine(result);

                    if (result == "Yes" || result == "y")
                    {
                        normalDifficulty();
                    }
                    else if (result == "No" || result == "n")
                    {
                        Console.WriteLine("Hope you had fun");
                        Console.WriteLine("Press Any Button To Exit");
                        Console.ReadKey();
                        Console.Clear();
                        Console.ReadLine();
                        Thread.Sleep(10000000);
                    }



                   

                    
                }

                

            }
        }
        // Easy Difficulty
       
      

    }
}