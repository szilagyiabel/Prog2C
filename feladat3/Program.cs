using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Example {
    public class Program {
        public static void Main(string[] args) {

            var fname = "input.txt";
            string line;
            var f = new StreamReader(fname);
            var sum = 0;

            while ((line = f.ReadLine()) != null)
            {
                if(Math.Abs(int.Parse(line)) % 2 == 0)
                {
                    sum += Math.Abs(int.Parse(line));
                }
                else
                {
                    sum += 2 * (Math.Abs(int.Parse(line)));
                }
            }
            WriteLine(sum);
            f.Close();
        }
    }
}