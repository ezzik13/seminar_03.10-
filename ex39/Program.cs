// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

using static System.Console;
Clear();
Write("Ввведите размер массива, минимальное и маскимальное значение через пробел:");
string[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
// WriteLine(array);
// ReverseArray(array);
string strArray=String.Join(",",array);
WriteLine($"[{String.Join(", ",array)}]");
ReverseArray(array);


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void ReverseArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length/2; i++)
    {
        int temp=inArray[i];
        inArray[i]=inArray[inArray.Length-1-i];
        inArray[inArray.Length-1-i]=temp;
    }
    WriteLine($"[{String.Join(", ",inArray)}]");
}