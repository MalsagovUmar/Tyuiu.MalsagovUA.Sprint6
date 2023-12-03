using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MalsagovUA.Sprint6.Task1.V4.Lib
{
    public class DataService : ISprint6Task1V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[Math.Abs(startValue) + Math.Abs(stopValue) + 1];
            for (int i = startValue, x = 0; i <= stopValue; i++, x++)
            {
                if ((i + 1.2) != 0)
                {
                    result[x] = Math.Round(((Math.Sin(i)) / (i + 1.2)) - Math.Sin(i) * 2 - 2 * i, 2);
                }
                else
                {
                    result[x] = 0;
                }
            }
            return result;
        }
    }
}
