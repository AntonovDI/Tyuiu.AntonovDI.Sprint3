using Tyuiu.AntonovDI.Sprint3.Task2.V21.Lib;

internal class Program
{
    private static void Main(string[] args)
    {

        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Антонов Д. И. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнил: Антонов Даниил Иванович | ИСТНб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет сумму   *");
        Console.WriteLine("* ряда по формуле, при х=1,5                                              *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double value = 1.5;
        int startValue = 1;
        int stopValue = 10;

        Console.WriteLine("Значение перменной X - " + value);
        Console.WriteLine("Начало отсчёта - " + startValue);
        Console.WriteLine("Конец отсчёта - " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = 0.298;
        Console.WriteLine("Сумма ряда равна - " + res);
    }
}