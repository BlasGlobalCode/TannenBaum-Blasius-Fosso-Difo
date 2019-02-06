using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaum
{
  class Program
  {

    int dx;

    static void Main(string[] args)
    {

      Program x = new Program();
      x.Start();
    }

        public void Start()
        {
            Console.WriteLine("\t\t\txxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx " + "\n");
            Console.WriteLine("\t\t\tX WILLKOMMEN BEI BESSER-LEBEN X" + "\n");
            Console.WriteLine("\t\t\txxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx " + "\n\n");


            //Console.WriteLine(Console.BufferWidth.GetHashCode());
            //Console.WriteLine(Console.BufferHeight.GetHashCode());

            int ein, opt, fam, bus, del;
            string wahl;
            ein = 7;
            opt = 10;
            fam = 15;
            bus = 20;
            del = 25;

            Console.WriteLine("\t\tWaehlen Sie zwichen Einsteiger <E>, Optimist <O>,");
            Console.WriteLine("\t\tFamilie <F>, Business <B>, oder Deluxe <D>");
            Console.WriteLine("\t\toder beenden Sie das Programm mit eXit <X>");
            Console.Write("\n\n" + "\t\t");
            wahl = Console.ReadLine().ToLower();

            //einsteigerrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr

            if (wahl == "x")
            {
                return;
            }

            if (wahl == "e")
            {
                Console.Clear();
                Console.WriteLine("Modell Einsteiger:");
                Console.WriteLine("\n*******************************************************");
                Start1(4, 1, 2, 'X', 'X', 'X');
                Console.WriteLine("\n\n*******************************************************");
                Console.WriteLine("\t\tDer Preis für den Tannenbaum betragt " + ein + " Euro");
            }


            //optimistttttttttttttttttttttttttttttttttttttttttttttttttttttttt

            if (wahl == "o")
            {
                Console.Clear();
                Console.WriteLine("Modell Optimist:");
                Console.WriteLine("\n*******************************************************");
                Start1(4, 1, 4, 'A', 'i', 'i');
                Console.WriteLine("\n\n*******************************************************");
                Console.WriteLine("\t\tDer Preis für den Tannenbaum betragt " + opt + " Euro");
            }


            //Familieeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee

            if (wahl == "f")
            {
                Console.Clear();
                Console.WriteLine("Modell Familie:");
                Console.WriteLine("\n*******************************************************");
                Start1(4, 1, 7, 'A', 'i', 'i');
                Console.WriteLine("\n\n*******************************************************");
                Console.WriteLine("\t\tDer Preis für den Tannenbaum betragt " + fam + " Euro");
            }


            //businesssssssssssssssssssssssssssssssssssssssssssssssssssssssss

            if (wahl == "b")
            {
                Console.Clear();
                Console.WriteLine("Modell Business:");
                Console.WriteLine("\n*******************************************************");
                Start1(4, 1, 11, 'A', 'i', 'i');
                Console.WriteLine("\n\n*******************************************************");
                Console.WriteLine("\t\tDer Preis für den Tannenbaum betragt " + bus + " Euro");
            }


            //Deluxeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee

            if (wahl == "d")
            {
                Console.Clear();
                Console.WriteLine("Modell Deluxe:");
                Console.WriteLine("\n*******************************************************");
                Start1(4, 1, 11, 'A', 'i', 'i');
                Console.WriteLine("\n\n*******************************************************");
                Console.WriteLine("Der Preis für den Tannenbaum betragt " + del + " Euro");
            }
            Console.ReadLine();
        }

        public void Start1(int dy, int dxx, int a, Char cb, Char cr, Char cs)
        {

            //------------------------------------
            //a = 5;      //     x          anzahl
            //   x x x
            //(x x)x x x
            //------------------------------------
            //dy = 1;     //_________      distanc y
            //    ^
            //    |
            //    v
            //----x----
            //  x x x 
            //x x x x x
            //------------------------------------
            dx = dxx;    //        x      distanc x
                         //      x x x
                         //<-->x x x x x
                         //------------------------------------
                         //cb = 'x';//        x      Char von Blat
                         //      x(x)x
                         //    x(x x x)x
                         //------------------------------------
                         //cr = 'i';//        x      Char vom Rand
                         //     (x)x(x)
                         //   (x)x x x(x)
                         //------------------------------------
                         // cs = 'i';//       (x)     Char von der spitze
                         //      x x x 
                         //    x x x x x
                         //------------------------------------

            set(a + 1, dy, cs);

            for (int i = 1; i <= a; i++)
            {

                fill((a - i) + 1, (a + i) - 1, i + dy, cb);

            }

            for (int i = 1; i <= a; i++)
            {

                boarder((a - i), (a + i), i + dy, cr);

            }

            set(a + 1, a + (dy + 1), 'T');
        }

        public void set(int x, int y, char cr)
        {


            Console.SetCursorPosition((x + (dx - 1)), y);
            Console.Write(cr);

        }

        public void fill(int x1, int x2, int y, char cr)
        {

            int f = (x2 - 1) - (x1 - 1);
            Console.SetCursorPosition((x1 + (dx)), y);

            for (int i = 0; i <= f; i++)
            {
                Console.Write(cr);
            }
        }

        public void boarder(int x1, int x2, int y, char cr)
        {

            Console.SetCursorPosition(x1 + (dx), y);
            Console.Write(cr);
            Console.SetCursorPosition(x2 + (dx), y);
            Console.Write(cr);

        }
    }
}
