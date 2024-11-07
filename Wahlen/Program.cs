using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            Wahl Partei1 = new Wahl(" ", " ", 0, 0,0,0,0);
            Wahl Partei2 = new Wahl(" ", " ", 0, 0,0,0,0);
            Partei1.BundestaatHinzufuegen();
            Partei1.GetWinnerState(Partei2);
            Console.WriteLine(Partei1.Winner(Partei2));
            
            


        }
    }
}