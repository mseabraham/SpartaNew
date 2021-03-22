using System;

namespace Sesssion1App
{
    class Program
    {
        static void Main(string[] args)
        {
            Session2();
        }

        static void Session1()
        {
 
             
            Console.WriteLine("Hello, command line demo");
            sbyte v1 = Convert.ToSByte("11111111", 2);
            sbyte v2 = Convert.ToSByte("10000000", 2);
            Console.WriteLine(v2 + v1);
            sbyte v3 = Convert.ToSByte("01111111", 2);
            Console.WriteLine(v3);

           
            ushort s = ushort.MaxValue-1;
            s++;

            decimal sum = 0;
            for(int i = 0; i<1000; i++)
            {
               // sum += 1 / 3.0;
            }

            Console.WriteLine("1/2 added 1000 times " + sum);
            Console.WriteLine("1/3 multiplied by 1000 times " + 1/3.0 * 1000);

            char initial = 'M';
            int mCode = initial;
            Console.WriteLine(mCode);
            Console.WriteLine((char)mCode);


            //char space = "m";
            //char clear = (char)space;
           // Console.WriteLine(clear);
            
        }

        static void Session2()
        {
            /*
            int x = 5;
            int y = 5;*/

            //int z = x++ + ++y;

            /*
            var x = 5;
            var n = (double)5;
            var o = -x;
            var p = +x;
            var r = true;
            var s = !r;
            s = !!r;
            */

            /*
            var res = 0.5 / 0.2;
            var res1 = 5 / 2;
            res = 5.0 / 2;
            res1 = 5 / 3;
            res = 5 % 3;
            */

            /*
            const int NUM_ROWS = 6;
            const int NUM_COLS = 10;

            int spriteNo = 0;

            //GameLoop
            for (int i = 0; i < 60; i++)
            {
                ++spriteNo;
                spriteNo = spriteNo % (NUM_ROWS * NUM_COLS);
                
                int row = spriteNo / NUM_COLS;
                int col = spriteNo % NUM_COLS;
            }
            */

            bool isWearingParachute = false;
            bool jump()
            {
                return true;
            }

            //no short cut person will jump to satisfy statement
            var safe = isWearingParachute & jump();
            //short cut will not run jump() becuase isWearingParachute is false;
            safe = isWearingParachute && jump();



            int a = 5, b = 3, c = 4;
            Console.WriteLine(c += +a+++ ++b);
        }
    }
}
