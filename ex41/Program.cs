// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
using static System.Console;
Clear();
WriteLine("Введите числа через пробел:");
string numbers=ReadLine();
string[] numberToOne= new string[numbers.Length];
int m=0;

for(int i=0;i<numbers.Length;i++)
{
    if(numbers[i]==' ')
    {
        m++;
    }
    else
    {
        numberToOne[m]=numberToOne[m]+$"{numbers[i]}";
    }
}
m++;
int[]resultNumbers=new int[m];
StringToNumber(resultNumbers, numberToOne);
int count=0;
for(int i=0; i<m;i++)
{
    if(resultNumbers[i]>0)
    {
        count++;
    }
}
WriteLine($"Количество чисел больше 0 = {count}");
void StringToNumber(int[] array, string[] stringArray)
{
    int m=array.Length;
    Write("[");
    for (int i=0;i<m-1;i++)
    {
        array[i]=Convert.ToInt32(stringArray[i]);
        Write($"{array[i]}, ");
    }
    WriteLine($"{array[m-1]=Convert.ToInt32(stringArray[m-1])}]");
}