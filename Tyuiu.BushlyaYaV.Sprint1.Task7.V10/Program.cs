using Tyuiu.BushlyaYaV.Sprint1.Task7.V10.Lib;

namespace Tyuiu.BushlyaYaV.Sprint1.Task7.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Бушля Я. В. | ИСТНб-24-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Бушля Ярослав Владимирович | ИСТНб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                     ln(cos(x))                                          *");
            Console.WriteLine("* z = 2 * ctg(3x) -  ————————————                                         *");
            Console.WriteLine("*                     ln(1 + x^2)                                         *");
            Console.WriteLine("***************************************************************************");

            double x;

            Console.WriteLine("Введите зачение x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" z = " + ds.Calculate(x));
            Console.ReadLine();








        }
    }
}
