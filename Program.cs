using System;

namespace CS_133_Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intergerArray = new int[11, 11];

            intergerArray[0, 0] = 1;
            intergerArray[1, 0] = 2;
            intergerArray[2, 0] = 3;
            intergerArray[3, 0] = 4;
            intergerArray[4, 0] = 5;
            intergerArray[5, 0] = 6;
            intergerArray[6, 0] = 7;
            intergerArray[7, 0] = 8;
            intergerArray[8, 0] = 9;
            intergerArray[9, 0] = 10;



            for (int Y = 1; Y < 11; Y++)
            {
                for (int X = 1; X < 11; X++)
                {
                    Console.Write((X * Y) + " ");
                }

                Console.WriteLine("");

            } }
    }
}
