using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MalsagovUA.Sprint6.Task2.V24.Lib
{
    public class DataService : ISprint6Task2V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[stopValue - startValue + 1];
            for (int x = startValue, i = 0; x <= stopValue; i++, x++)
            {
                if (2 - x != 0)
                {
                    result[i] = Math.Round(Math.Sin(x) + (Math.Cos(x) + 1) / (2 - x) + 2 * x, 2);
                }
                else
                {
                    result[i] = 0;
                }
            }
            return result;
        }
    }
}
