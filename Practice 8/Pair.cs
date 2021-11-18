using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_8
{
    class Pair : ISum, IProduct, IQuotient, IDifference, IComparable, ICloneable
    {
        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }

        public int First { get; private set; }
        public int Second { get; private set; }

        public string Sum() => $"{First} + {Second} = {First + Second}";
    
        public string Difference() => $"{First} - {Second} = {First - Second}";

        public string Product() => $"{First} * {Second} = {First * Second}";

        public string Quotient() => $"{First} / {Second} = {Convert.ToDouble(First) / Convert.ToDouble(Second)}";

        public int CompareTo(object firstpair)
        {
            Pair pair = (Pair)firstpair;
            return First + pair.First - (Second + pair.Second);
        }

        public Pair ShallowClone()
        {
            return (Pair)this.MemberwiseClone();
        }

        public object Clone()
        {
            return new Pair(First, Second);
        }
    }
}
