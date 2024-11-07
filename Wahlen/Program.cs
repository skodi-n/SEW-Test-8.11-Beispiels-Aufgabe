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
            Wahl Wahl1 = new Wahl();
            Wahl Wahl2 = new Wahl();
            
            Wahl1.BundestaatHinzufuegen();
            Wahl1.GetWinnerState();
            Console.WriteLine(Wahl1.Winner());
            
            


        }
    }
}