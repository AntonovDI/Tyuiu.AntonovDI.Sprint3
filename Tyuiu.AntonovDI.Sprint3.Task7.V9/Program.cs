using Tyuiu.AntonovDI.Sprint3.Task7.V9.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Антонов | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #9                                                              *");
Console.WriteLine("* Выполнил: Антонов| ИСТНб-25-1                                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue = -5;

int stopValue = 5;

int len = ds.GetMassFunction(startValue, stopValue).Length;

double[] valueArray;
valueArray = new double[len];

valueArray = ds.GetMassFunction(startValue, stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("+----------+----------+");
Console.WriteLine("|    X     |   f(x)   |");
Console.WriteLine("+----------+----------+");
for (int i = 0; i <= len - 1; i++)
{
    Console.WriteLine("|{0,5:d}     | {1, 7:f2}  |", startValue, valueArray[i]);
    startValue++;
}
Console.WriteLine("+----------+----------+");
Console.ReadKey();