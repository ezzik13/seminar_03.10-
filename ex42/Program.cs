// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
using static System.Console;
Clear();
Write("Введите числов десятичной системе счисления:");
int chislo = Convert.ToInt32(ReadLine());
string dvoichnoeChislo = Convert10to2(chislo);
WriteLine(dvoichnoeChislo);



string Convert10to2(int number)
{
    string result=null;
    if (number==0) return "0";
    while (number > 0)
    {
        result = number % 2 + result;
        number = number / 2;
    }
    return result;

}