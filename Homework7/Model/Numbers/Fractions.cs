using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Numbers
{
    public class Fractions: Numbers, IFractions
    {
        public T fractionNumber(T x, T y)
        {
            super (x,y);
        }
        public override double getNumerator()
        {
            return x;
        }
        public override double getDenominator()
        {
            return y;
        }
        public override string toString()
        {
            if(this.x > 0)
            {
                return Math.Round(this.x) + "/" + Math.Round(this.y);
            }
            if(this.x < 0)
            {
                return "-" + this.x + "/" + this.y;
            }
            return 0;
        }
        public override Numbers sum (Numbers number)
        {
            return new fractionNumber (this.x + number.x, 
                                    this.y + number.y);
        }
        public override Numbers sub (Numbers number)
        {
            return new fractionNumber (this.x - number.x,
                                        this.y - number.y);
        }
        public override Numbers mult (Numbers number)
        {
            return new fractionNumber (this.x * number.x,
                                        this.y * number.y);
        }
        public override Numbers div (Numbers number)
        {
            return new fractionNumber(this.x * number.y,
                                        this.y * number.x);
        }
    }
}