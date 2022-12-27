// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// Console.WriteLine("Решение:");
int length = ReadInt("Размер массива");
double[] array = GetRandomDoubleArray(length);
PrintDoubleArrayByString(array);
Console.WriteLine();
Console.WriteLine($"Максимальный элемент : {MaxFromArray(array)};");
Console.WriteLine($"Минимальный элемент : {MinFromArray(array)};");
Console.WriteLine();
double difference = MaxFromArray(array) - MinFromArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива : {difference}.");


int ReadInt(string argumentName)
{
	Console.Write($"Введите число {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

double[] GetRandomDoubleArray(int length)
{
	double[] array = new double[length];
    Random random = new Random();
   
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.NextDouble() * 100;
	}
	return array;
}

void PrintDoubleArrayByString(double[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
        if (i == (array.Length - 1))
        {
           Console.WriteLine($"{array[i]}."); 
        }
        else
        {
           Console.Write($"{array[i]}, ");
        }
    }
}

double MinFromArray(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
	{
       if (array[i] < min)
       min = array[i];
	}
    return min;
}

double MaxFromArray(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
	{
       if (array[i] > max)
       max = array[i];
	}
    return max;
}