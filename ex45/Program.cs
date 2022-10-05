// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
using static System.Console;
Clear();
WriteLine("Ввведите размер массива");
int[] numbers = new int[Convert.ToInt32(ReadLine())];
// string stringArray=String.Join(",", numbers);
FillArray(numbers);
WriteLine($"[{String.Join(",", numbers)}]");
int[] numbersCopy = ArrayCopy(numbers);
WriteLine($"[{String.Join(",", numbersCopy)}]");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        WriteLine($"Ввведите {i + 1}-й элемент массива");
        array[i] = Convert.ToInt32(ReadLine());
    }
}


int[] ArrayCopy(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[i];
    }
    return result;
}

