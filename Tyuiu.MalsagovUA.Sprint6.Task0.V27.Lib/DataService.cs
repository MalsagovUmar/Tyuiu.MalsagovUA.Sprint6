using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MalsagovUA.Sprint6.Task0.V27.Lib
{
    public class DataService : ISprint6Task0V27
    {
        public double Calculate(int x)
        {
            double res = Math.Round((-(Math.Pow(x, 3)) + 4 * Math.Pow(x, 2) - ((double)3 / 2) * x), 3);
            return res;
        }
    }
}
