using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isEnd = false;
            string exit = "exit";
            string message;

            Console.WriteLine($"Сообщение будет выводится пока вы не напишите {exit}");

            while (isEnd == false) {
                Console.WriteLine("Введите сообщение");
                message = Console.ReadLine();
                if (message == exit)
                {
                    Console.WriteLine("Конец");
                    isEnd = true;
                }
            }

            Console.ReadKey();
        }
    }
}
