using System;
using KasjerConsola.Klasy;

namespace KasjerConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Sejf kasetka = new Sejf();
            DataStorage.Load(kasetka);
            int x = 1;
            while(x != 0)
            {
                x = menu();

                switch(x)
                {
                    case 1:
                        {
                            Console.Clear();
                            kasetka.Wypisz("Kasetka");
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.BackgroundColor = (ConsoleColor)0;
                            Console.Clear();
                            Console.WriteLine("Kasetka");
                            KasetkaWypełnij(kasetka);
                            Console.Clear();
                            kasetka.Wypisz("Kasetka \n");
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Sejf dzienny \n");
                            Console.WriteLine("Jeszcze nie ma! \n");
                            Console.ReadKey();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Sejf dzienny \n");
                            Console.WriteLine("Jeszcze nie ma! \n");
                            Console.ReadKey();
                            break;
                        }
                    case 8:
                        {
                            DataStorage.Storage(kasetka);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }




            

            //kasetka.Wypisz();
            //Console.WriteLine(kasetka.Wartość);

            
        }

        private static int menu()
        {
            int x;
            Console.Clear();
            //Console.BackgroundColor = (ConsoleColor)0;
            //Console.Clear();
            Console.WriteLine("Wybierz opcję z menu: \n");

            Console.WriteLine("(1): Pokaż 'Kasetka' ");
            Console.WriteLine("(2): Wprowadź ilości 'Kasetka' ");
            //Console.WriteLine("(4): Wprowadź ilości 'Sejf Dzienny' ");
            //Console.WriteLine("(6): Wprowadź ilości 'Sejf' ");
            Console.WriteLine("(8): Zapisz ");
            Console.WriteLine("(0): Zakończ Program");
            Console.WriteLine();
            Console.Write("Opcja:  ");
            bool succes = int.TryParse(Console.ReadLine(), out x);
            if(succes)
            {
            return x;
            }
            else
            {
                return 9;
            }
        }

        private static void KasetkaWypełnij(Sejf kasetka)
        {
            int ilosc;
            string iloscString = "0";
            Console.Write($"{kasetka.OpisN50000()} ");
            iloscString = Console.ReadLine();
            bool succes = int.TryParse(iloscString, out ilosc);
            if(succes)
            {
                //kasetka.ZmieńN50000(ilośćNominałów: int.Parse(iloscString));
                kasetka.ZmieńN50000(ilośćNominałów: ilosc);
            }

            iloscString = "0";
            succes = false;
            Console.Write($"{kasetka.OpisN20000()} ");
            iloscString = Console.ReadLine();
            succes = int.TryParse(iloscString, out ilosc);
            if (succes)
            {
                //kasetka.ZmieńN50000(ilośćNominałów: int.Parse(iloscString));
                kasetka.ZmieńN20000(ilośćNominałów: ilosc);
            }

            iloscString = "0";
            succes = false;
            Console.Write($"{kasetka.OpisN10000()} ");
            iloscString = Console.ReadLine();
            succes = int.TryParse(iloscString, out ilosc);
            if (succes)
            {
                //kasetka.ZmieńN50000(ilośćNominałów: int.Parse(iloscString));
                kasetka.ZmieńN10000(ilośćNominałów: ilosc);
            }
        }
    }
}
