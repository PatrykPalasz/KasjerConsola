﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KasjerConsola.Klasy
{
    public class DataStorage
    {
        // czemu static?
        public static void Storage(Sejf sejf)
        {
            Console.Clear();
            Console.WriteLine("Zapisano: \n");
            Console.WriteLine($"{ sejf.OpisN50000()} : {sejf.StanN50000()} szt.");
            Console.WriteLine($"{ sejf.OpisN20000()} : {sejf.StanN20000()} szt.");
            Console.WriteLine($"{ sejf.OpisN10000()} : {sejf.StanN10000()} szt.");
            Console.ReadKey(); // jeszcze nie zapisano! :) co jak bedzie wyjatek?? :) 

                FileStream stream = new FileStream("kasjer.dat", FileMode.Create);

                StreamWriter writer = new StreamWriter(stream);

                writer.WriteLine(sejf.StanN50000());
                writer.WriteLine(sejf.StanN20000());
                writer.WriteLine(sejf.StanN10000());

                writer.Dispose();



        }

        // czemu static?
        // czemu zwraca kasetke? kasetka sie nie zmienia w tej metodzie...
        public static Sejf Load(Sejf kasetka)
        {
            try
            {            
                FileStream stream = new FileStream("kasjer.dat", FileMode.Open);

                StreamReader reader = new StreamReader(stream);

                kasetka.ZmieńN50000(int.Parse(reader.ReadLine()));
                kasetka.ZmieńN20000(int.Parse(reader.ReadLine()));
                kasetka.ZmieńN10000(int.Parse(reader.ReadLine()));

                reader.Dispose();

                return kasetka; // return 1
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Spodziewany błąd: {exception.Message}");
                Console.ReadKey();
                return kasetka; // return 2 -pczemu?
            }

        }
    }
}
