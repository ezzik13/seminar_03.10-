// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
using static System.Console;
Clear();
WriteLine("Введите три числа через пробел:");
string[] parameters=ReadLine()!.Split(new char[]{' ','#',','},StringSplitOptions.RemoveEmptyEntries);
IsItTriangle(int.Parse(parameters[0]),int.Parse(parameters[1]),int.Parse(parameters[2]));

void IsItTriangle(int a, int b, int c)
{
    if(a+b>c&&a+c>b&&c+b>a)     WriteLine("Треугольник со сторонами такой длины может существовать");
    else WriteLine("Треугольника со сторонами такой длины не существовует");
}
