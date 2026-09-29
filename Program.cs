using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("facteur 1:");
            var chiffre1=System.Console.ReadLine();
            float c1=float.Parse(chiffre1);
            System.Console.Write("operateur ? ");
            var op = System.Console.Read();
            System.Console.ReadLine();
            System.Console.WriteLine("facteur 2:");
            var chiffre2 = System.Console.ReadLine();
            float c2 = float.Parse(chiffre2);
            float resultat = 0;
            switch (op)
            {
                case '-':resultat = c1 - c2;break;
                case '+':resultat = c2 + c1;break;
                case '/': resultat = c1 / c2; break;
                case '*': resultat = c2 * c1; break;
            }

           

            Console.Write(chiffre1 + (char)op + chiffre2+"=");
            Console.Write(resultat);
           

        }
    }
}
