﻿using Tyuiu.AntonovDI.Sprint3.Tassk5.V23.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Антонов Д. И. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("* Выполнил: Антонов Даниил Иванович | ИСТНб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Найти значение выражения                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 2;
        int startValue1 = 1;
        int startValue2 = 1;
        int stopValue1 = 3;
        int stopValue2 = 10;

        Console.WriteLine("Переменная X - " + x);
        Console.WriteLine("Старт шага первой суммы ряда - " + startValue1);
        Console.WriteLine("Конец шага первой суммы ряда - " + stopValue1);
        Console.WriteLine("Старт шага второй суммы ряда - " + startValue2);
        Console.WriteLine("Конец шага второй суммы ряда - " + stopValue2);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Сумма ряда - " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

        Console.ReadKey();
    }
}