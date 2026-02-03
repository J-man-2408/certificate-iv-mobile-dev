using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statistics_exercise
{
    internal class NumberCruncher
    {
        double[] data = new double[1000];
        int count;

        public void addNumber(double number)
        {
            data[count] = number;
            count++;
        }

        public void displayData()
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
        }

        public void removeLastNumber()
        {

        }
    }
    
}
