using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBS_Africa_Calculator
{
  class Function
  {

    public double Addition(double num1, double num2)
    {
      return num1 + num2;

    }

    public  double Multiply(double num1 , double num2){
      return num1 * num2;

    }

    public double Subtraction(double num1, double num2)
    {
      if( num1 > num2)
      {
        return num1 - num2;
      }
      return num1 - num2;

    }

    public double Division(double num1, double num2)  // best can use float
    {
      return num1 / num2;

    }
  }
}
