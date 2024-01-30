using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int zeilen = 20;
            int spalten = 40;
            
            //Zählerschleife für Zeilen
            for (int x = 0; x < zeilen; x++)
            { 
                //Zählerschleifen für spalten
                for (int y = 0; y < spalten; y++)
                {
                //Erster Durchlauf x = 0 , y = 0
                    //Wenn in der ersten oder letzten Zeile, die Zeile mit "-" für Rahmenbegrenzung füllen
                    if (x == 0 || x == zeilen - 1)
                    {
                        Console.Write("-");
                    }
                    //Wenn in der ersten oder letzten Zeile, die Zeile mit "|" für Rahmenbegrenzung füllen
                    else if (y == 0 || y == spalten - 1)
                    {
                        Console.Write("|");
                    }
                    //Auffüllen der zwischenräume
                    else
                    {
                        Console.Write(" ");
                    }
                
                }
                //Beginn der neuen Zeile
                Console.Write("\n");
            }
            
            Console.ReadKey();

        }
    }
}
