using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Classes
{
    class calculate:Ioperations
    {
        public double Sum { get; set; }

        public bool Control0 { get; set; } = true;

        List<double> numbers = new List<double>();
        List<string> operations = new List<string>();
        public List<double> Numbers { get => numbers; set => numbers = value; }
        public List<string> Operations { get => operations; set => operations = value; }

        public double addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public double extraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public double multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public double division(double num1, double num2)
        {
            if (num2 == 0)
            {
                MessageBox.Show("0 ' a bölüm hatası");
                return -1;
            }else if(num1 == 0)
            {
                return num1;
            }

            return num1 / num2;
        }

        public void search_calculate_mul( int count)
        {
            double sum1;
            while(count > 0)
            {
                int index = operations.IndexOf("*");
                operations.RemoveAt(index);
                sum1 = multiplication(Numbers[index], Numbers[index + 1]);
                if(numbers.Count != 1)
                {
                    numbers.RemoveAt(index);
                    numbers.RemoveAt(index);
                    numbers.Insert(index, sum1);
                }
                count--;
            }

            
        }

        public void search_calculate_div(int count)
        {
            double sum1;
            while (count > 0)
            {
                int index = operations.IndexOf("/");
                operations.RemoveAt(index);
                sum1 = division(Numbers[index], Numbers[index + 1]);
                if(sum1 == -1)
                {
                    Control0 = false;
                    operations.Clear();
                    numbers.Clear();
                }
                else if (numbers.Count != 1)
                {
                    numbers.RemoveAt(index);
                    numbers.RemoveAt(index);
                    numbers.Insert(index, sum1);
                }
                count--;
            }
        }

        public void search_calculate_add(int count)
        {
            double sum1;
            while (count > 0)
            {
                int index = operations.IndexOf("+");
                operations.RemoveAt(index);
                sum1 = addition(Numbers[index], Numbers[index + 1]);
                if (numbers.Count != 1)
                {
                    numbers.RemoveAt(index);
                    numbers.RemoveAt(index);
                    numbers.Insert(index, sum1);
                }
                count--;
            }
        }

        public void search_calculate_ext(int count)
        {
            double sum1;
            while (count > 0)
            {
                int index = operations.IndexOf("-");
                operations.RemoveAt(index);
                sum1 = extraction(Numbers[index], Numbers[index + 1]);
                if (numbers.Count != 1)
                {
                    numbers.RemoveAt(index);
                    numbers.RemoveAt(index);
                    numbers.Insert(index, sum1);
                }
                count--;
            }
        }


        public void Calculate()
        {
            int count;
            count = operations.Count(str => str.Contains("*"));
            if(count != 0)
            {
                search_calculate_mul(count);
            }
            count = operations.Count(str => str.Contains("/"));
            if (count != 0)
            {
                search_calculate_div(count);
            }
            count = operations.Count(str => str.Contains("+"));
            if (count != 0)
            {
                search_calculate_add(count);
            }
            count = operations.Count(str => str.Contains("-"));
            if (count != 0)
            {
                search_calculate_ext(count);
            }
            if(Numbers.Count != 0)
            {
                Sum = Numbers[0];
            }

        }
    }
}
