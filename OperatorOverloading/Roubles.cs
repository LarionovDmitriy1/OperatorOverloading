using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading;

public class Roubles
{
    public decimal Summ { get; set; }
    public static explicit operator Roubles(Dollar dollar)
    {
        decimal summ = dollar.Summ * (decimal)70.45;
        return new Roubles() { Summ = summ };
    }
}
