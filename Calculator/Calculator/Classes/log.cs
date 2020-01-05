using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Calculator.Classes
{
    class log
    {
        DateTime time = DateTime.Now;

        string path = @"C:\Users\huzey\source\repos\Simple-Calculator-with-OOP\Calculator\Calculator\Log\Log.txt";

        public void logging(string operations ,double sum)
        {
            File.AppendAllText(path, operations + " = " + sum +"   "+time.ToString("MM/dd/yyyy") +"   " +time.ToString("HH:mm")  +Environment.NewLine);
        }


    }
}
