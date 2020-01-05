using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    interface Ioperations
    {
        double addition(double num1, double num2);

        double extraction(double num1, double num2);

        double multiplication(double num1, double num2);

        double division(double num1, double num2);
    }
}
