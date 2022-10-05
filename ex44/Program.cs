// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
using static System.Console;
Clear();
WriteLine("Ввведите порядковый номер числа фибоначи:");
int number = Convert.ToInt32(ReadLine());
if (number == 1)
    WriteLine("1) 1");
if (number == 2)
{
    WriteLine("1) 1");
    WriteLine("2) 1");
}
if(number>2)
    Fibonacci(number);


void Fibonacci(int n)
{
    int i = 2;
    double[] fibo = new double[n];
    fibo[0] = 1;
    fibo[1] = 1;

    WriteLine("1) 1");
    WriteLine("2) 1");
    while (i < n)
    {
        fibo[i] = fibo[i - 1] + fibo[i - 2];
        WriteLine($"{i + 1}) {fibo[i]}");
        i++;
    }
}