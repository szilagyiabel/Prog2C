using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Example {
    public class Program {
        public static void Main(string[] args) {

            if(args.Length != 1)
            {
                WriteLine("Hiba! Nem megfelelő számú argumentumot adott meg!");
                System.Environment.Exit(1);
            }

            string s = args[0];
            var stat = s.GetStatistics();

            WriteLine("Kisbetűk: "+ stat["lower"]);
            WriteLine("Nagybetűk: "+ stat["upper"]);
            WriteLine("Számjegyek: "+ stat["digit"]);
            WriteLine("Speciális karakterek: "+ stat["special"]);
        }
    }
}