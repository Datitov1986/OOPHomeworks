using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Numbers
{
    public abstract class Numbers: IBaseOperations
    {
        protected double x;
        protected double y;

        public T Numbers(T x, T y) 
        {
            this.x = x.doubleValue();
            this.y = y.doubleValue(); 
        }
    }
}