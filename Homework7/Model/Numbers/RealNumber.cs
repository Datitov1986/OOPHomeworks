using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Numbers
{
    public class RealNumber: Numbers, IReal
    {
        public T realNumber(T value)
        {
            super(value, 0);
        }
        public override double getReal()
        {
            return x;
        }
        public override string toString()
        {
            return string.Format("%s", this.x);
        }
        public override Numbers sum (Numbers number)
        {
            return new realNumber (this.x + number.x);
        }
        public override Numbers sub (Numbers number)
        {
            return new realNumber (this.x - number.x);
        }
        public override Numbers mult (Numbers number)
        {
            return new realNumber (this.x * number.x);
        }
        public override Numbers div (Numbers number)
        {
            return new realNumber(this.x / number.x);
        }
    }
}