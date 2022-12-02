using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading;

public class MyNumber
{
    public int Value { get; set; }

    public static MyNumber operator +(MyNumber counter1, MyNumber counter2)
    {
        return new MyNumber { Value = counter1.Value + counter2.Value };
    }
    public static MyNumber operator *(MyNumber counter1, MyNumber counter2)
    {
        return new MyNumber { Value = counter1.Value * counter2.Value };
    }
    public static MyNumber operator -(MyNumber counter1, MyNumber counter2)
    {
        return new MyNumber() { Value = counter1.Value - counter2.Value };
    }
    public static MyNumber operator /(MyNumber counter1, MyNumber counter2)
    {
        return new MyNumber() { Value = counter1.Value / counter2.Value };
    }
}
}
