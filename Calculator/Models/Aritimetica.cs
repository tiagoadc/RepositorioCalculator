using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class Aritimetica
    {
        public decimal N1 { get; set; }
        public decimal N2 { get; set; }
        public decimal N3 { get; set; }

        public decimal Soma()
        {
            return N1 + N2;
        }
    }
}
