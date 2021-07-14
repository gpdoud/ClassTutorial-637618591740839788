using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTutorial {
    class TqlMath {

        public TqlMath(int a) {
            this.A = a;
            this.B = a;
        }
        public TqlMath(int a, int B) {
            A = a;
            if(B <= 0) {
                Console.WriteLine("B must be GT zero");
                return;
            }
            this.B = B;
        }

        public int A { get; set; }
        public int B { get; set; }

        public int Sum() {
            return A + B;
        }
        public int Diff() {
            return A - B;
        }
    }
}
