using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            char userSympbol;
            int lenghtUserSymbol;
            int convertLengthNumber = 2;

            Console.Write("Введите имя: ");
            userName = Console.ReadLine();

            lenghtUserSymbol = userName.Length + convertLengthNumber;

            Console.Write("Введите символ: ");
            userSympbol = Console.ReadKey().KeyChar;
            Console.Clear();

            for (int i = 0; i < lenghtUserSymbol; i++)
                Console.Write(userSympbol);

            Console.WriteLine("\n" + userSympbol + userName + userSympbol);

            for (int i = 0; i < lenghtUserSymbol; i++)
                Console.Write(userSympbol);


            Console.ReadKey();
        }
    }
}