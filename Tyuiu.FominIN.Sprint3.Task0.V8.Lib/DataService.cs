using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.FominIN.Sprint3.Task0.V8.Lib
{
    public class DataService : ISprint3Task0V8
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for ( i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + (Math.Pow(i, i) + 1) * Math.Cos(4);
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
