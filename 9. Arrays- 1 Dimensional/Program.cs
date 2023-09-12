using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Arrays__1_Dimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration of variables
            int[] luckynumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            Console.WriteLine(luckynumbers.Length);
            Console.WriteLine(luckynumbers[0]);
            Console.WriteLine("The average is " + luckynumbers.Average());

            string[] friends = new string[5];
            friends[0] = "Tim";
            friends[1] = "Nono";
            friends[2] = Console.ReadLine();

            //friends[6]= "Jj";
            Console.WriteLine(friends[2]);

           //freeze console
           Console.ReadLine();
        }
    }
}
