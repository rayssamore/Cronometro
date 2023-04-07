using System;

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Menu();
        }
        static void Start(int time)
        {
            //int time = 10;
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime ++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
                
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(2500);
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            
            Console.WriteLine("S - Segundos => 10s = 10 segundos");
            Console.WriteLine("M - Segundos => 1m = 1minuto");
            Console.WriteLine("0 - Sair ");
            Console.WriteLine("Quanto tempo deseja contar? ");
            string resp =  Console.ReadLine().ToLower();
            char type = char.Parse(resp.Substring(resp.Length - 1,1));
            int time = int.Parse(resp.Substring(0,resp.Length - 1));
            int multiplier = 1;

            if (type == 'm') {
                multiplier = 60;
            }
            if (time == 0) {
                System.Environment.Exit(0);
            }

            PreStart(time * multiplier);


        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep (1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }
    }
}