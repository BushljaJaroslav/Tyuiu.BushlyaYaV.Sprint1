
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BushlyaYaV.Sprint1.Task7.V10.Lib
{
    public class DataService : ISprint1Task7V10
    {
        public double Calculate(double x)
        {
            var res = Math.Round(2 * (Math.Cos(3 * x) / Math.Sin(3 * x)) - ((Math.Log(Math.Cos(x))) / (Math.Log(1 + x * x))), 3);
            return res;
        }
    }
}
