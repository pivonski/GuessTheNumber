using System;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] array2D = new int[2, 3];

            //array2D[0, 0] = 1;
            //array2D[1, 2] = 9;

            //Console.WriteLine(array2D[0, 0]);
            //Console.WriteLine(array2D[1, 2]);


            //Console.WriteLine();




            //int[][] array = new int[3][];
            //array[0] = new int[5];
            //array[1] = new int[3];
            //array[2] = new int[7];

            //array[0][0] = 1; 
            //array[2][6] = 9;

            //Console.WriteLine(array[0][0]);
            //Console.WriteLine(array[2][6]);

            //Console.WriteLine("\n For: ");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < array[i].Length; j++)
            //    {
            //        Console.Write(array[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("\n Foreach:");

            //foreach (int[] array2 in array)
            //{
            //    foreach (int item in array2)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}

            Random rnd = new Random();

            int random = rnd.Next(1, 11);

            int userinput = 0;
            bool validation = false;

            int i = 0;


            bool[] array = new bool[10];
            Console.WriteLine(array[0]);


            Console.Title = "Zgadnij liczbę";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Zgadnij liczbę od 1 do 10! \n");
            Console.ResetColor();

            do
            {
                do
                {
                    Console.WriteLine("Podaj liczbę:");
                   validation =  int.TryParse(Console.ReadLine(), out userinput);
                    if(!validation)
                    {
                        
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Podana wartość nie jest liczbą \n");
                        Console.ResetColor();

                    
                    }
                }
                while (!validation);

                if (userinput<1 || userinput>10)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Podana wartość przekracza podany zakres \n");
                    Console.ResetColor();
                    continue;
                }

                if (array[userinput - 1])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ta liczba została już podana \n");
                    Console.ResetColor();
                    continue;
                }
                else
                {
                    array[userinput - 1] = true;
                }
                if (random < userinput)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Wylosowana liczba jest mniejsza od Twojej \n");
                    Console.ResetColor();
                }
                else if (random > userinput)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Wylosowana liczba jest większa od Twojej \n");
                    Console.ResetColor();
                }
                i++;

           

              




            }
            while
                (userinput != random);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Brawo, podana liczba jest prawidłowa!!! \n Liczba prób {i}");
            Console.ResetColor();












            Console.ReadKey();
           

           
     
        

        }
    }
}
