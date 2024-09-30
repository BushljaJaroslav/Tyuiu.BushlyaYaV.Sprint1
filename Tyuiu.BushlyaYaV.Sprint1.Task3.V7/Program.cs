

using Tyuiu.BushlyaYaV.Sprint1.Task3.V7.Lib;

// Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.
// Расчеты: Написать программу пересчета расстояния из верст в километры (1 верста — это 1066,8 м). Ответ округлите до 3 знаков после запятой.

namespace Tyuiu.BushlyaYaV.Sprint1.Task3.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 1 | Выполнил: Бушля Я. В. | ИСНТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Бушля Ярослав Владимирович | ИСТНб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу пересчета расстояния из верст в километры.           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int verst;
            Console.WriteLine(" Введите расстояние в верстах:");
            verst = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(verst +" " + "верст - это" + " " + ds.VerstsToKilometers(verst) +" " + "км");

            Console.ReadKey();



        }
    }
}
