using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateUnitTests
{
    public class Calculation
    {
        //private int paramter2;
        //private int paramter1;

        //public string Operator { get; set; }

        public double calculatedResult { get; set; }

        public void Multiply(double parameter1, double parameter2)
        {
            if(parameter1 == double.MaxValue && parameter2 > 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            calculatedResult = (parameter1 * parameter2);
        }

        public void Divide(double parameter1, double parameter2)
        {
            if (parameter2 == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                calculatedResult = (parameter1 / parameter2);
            }
        }

        public void Subtract(double parameter1, double parameter2)
        {
            calculatedResult = (parameter1 - parameter2);
        }

        public void Add(double parameter1, double parameter2)
        {
            calculatedResult = (parameter1 + parameter2);
        }
    }
}
