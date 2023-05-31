using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("valik");
            Console.WriteLine("1 FirstOrDefault");
            Console.WriteLine("2 Expect");
            Console.WriteLine("3 IfElse");
            Console.WriteLine("4 Forloop");
            
                int valik = int.Parse(Console.ReadLine());

            switch (valik)
            {
                case 1:
                    FirstOrDefault();
                    break;

                case 2:
                    Except();
                    break;

                case 3:
                    IfElsefailid();
                    break;

                case 4:
                    ForLoop();
                    break;

                    default:
                    Console.WriteLine("error");
                    break;
            }
        }



        public static void FirstOrDefault()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("First or Default");

            var firstOrDefault = NumberList.numberList.LastOrDefault();

            Console.WriteLine(firstOrDefault);
        }


        public static void Except()
        {
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

            var result = strList1.Except(strList2);

            foreach (var item in result)
            {
                Console.WriteLine("Except: " + item);
            }
        }
        public static void IfElsefailid()
        {
            Console.WriteLine("Kui url on vale, siis annab" +
                "veateate. Kui on õige, siis ütleb, " +
                "et kõik on korras");
            Console.WriteLine("Kui on ]ige, siis loob faili " +
                "koos sinu sisestatud tekstiga");
            //kasutada if ja else

            string wrongPath = "V:/Users/opilane/Desktop/FileToDesktop.txt";
            string wrightPath = "C:/Users/opilane/Desktop/FileToDesktop.txt";

            Console.WriteLine("Tee valik numbriga:");
            Console.WriteLine("1 on vale url");
            Console.WriteLine("2 on õige url");
            string choose = Console.ReadLine();

            if (choose == "1")
            {
                try
                {
                    string inputText = Console.ReadLine();
                    File.WriteAllText(wrongPath, inputText);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ei salevstanud desktopile file kuna " +
                        "seda urli ei ole");
                    Console.WriteLine(ex.Message);
                }
            }
            if (choose == "2")
            {
                string inputText = Console.ReadLine();
                File.WriteAllText(wrightPath, inputText);

                Console.WriteLine("Salvestas edukalt desktopile");
            }
        }
        public static void ForLoop()
        {
            int i, j, rows;

            Console.WriteLine("Numbri püramiid");

            Console.WriteLine("Sisesta ridade arv");

            rows = Convert.ToInt32(Console.ReadLine());


            for (i =0; i <= rows; i++)
            {
                for (j = 0; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i + 1; j++)
                {

                    Console.Write(i + j);
                }
                Console.Write("\n");

            }
        }
    }
}





