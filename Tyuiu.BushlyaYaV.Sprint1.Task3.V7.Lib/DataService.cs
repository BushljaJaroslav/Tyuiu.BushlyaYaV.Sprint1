﻿
using tyuiu.cources.programming.interfaces.Sprint1;

//return Math.Round(verst * 1066.8 / 1000 , 3);
namespace Tyuiu.BushlyaYaV.Sprint1.Task3.V7.Lib
{
    public class DataService : ISprint1Task3V7
    {
        public double VerstsToKilometers(double verst)
        {
            return Math.Round(verst * 1066.8 / 1000 , 3);
        }
    }
}
