// Task34. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int length = ReadInt("array length");
int[] array = GetRandomArray(length, 100, 999);
PrintArray(array);
Console.WriteLine();
int count = Even(array);
Console.WriteLine(count);


int ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
    return int.Parse(Console.ReadLine());
}

int[] GetRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random random = new Random();

    for (int  i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int Even (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++; 
    }
    return count;
}
