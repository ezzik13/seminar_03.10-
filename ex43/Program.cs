// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
using static System.Console;
Clear();
WriteLine("Введите значение k1, b1, k2, b2 для функций через пробел:");
string[] parameters = ReadLine()!.Split(new char[] { ' ', '#', ',' }, StringSplitOptions.RemoveEmptyEntries);
GetXY(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));



void GetXY(double k1, double b1, double k2, double b2)
{
    double x = 0;
    double y = 0;
    if (k1 == k2 && b1 == b2)
    {
        WriteLine("Прямые совпадают");
    }
    if (k1 == k2 && b1 != b2)
    {
        WriteLine("Прямые параллельны");
    }
    else
    {
        x = Math.Round((b2 - b1) / (k1 - k2), 2);
        y = Math.Round(k1 * x + b1, 2);
    }
WriteLine($"Координаты пересечния прямых от функций с заданными параметрами({x}; {y})");
}