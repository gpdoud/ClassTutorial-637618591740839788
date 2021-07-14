using System;

namespace ClassTutorial {
    class Program {
        static void Main(string[] args) {

            var m1 = new Major("Math");
            var m2 = new Major("Engineering");
            var m3 = new Major("Education");
            m3.Id = 88;


            
            //var tqlmath = new TqlMath(21, 30);
            //tqlmath.A = 41;
            ////tqlmath.A = 21;
            ////tqlmath.B = 30;
            //var sum = tqlmath.Sum();
            //Console.WriteLine($"Sum of {tqlmath.A} and {tqlmath.B} is {sum}");
            //var diff = tqlmath.Diff();
            //Console.WriteLine($"Diff of {tqlmath.A} and {tqlmath.B} is {diff}");
        }
    }
}
