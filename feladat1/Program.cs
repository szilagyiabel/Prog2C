using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Example {
    public class Program {
        public static void Main(string[] args) {

            var i = 1;
            var i1 = 1;
            var i2 = i + i1;
            
            while (i2.ToString().Length != 10)
            {
                i = i1;
                i1 = i2;
                i2 = i + i1;
            }
            WriteLine(i2);
        }
    }
}