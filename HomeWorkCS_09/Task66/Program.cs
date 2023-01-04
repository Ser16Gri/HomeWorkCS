// Task66. Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = ReadInt("M");
int n = ReadInt("N");
Console.WriteLine(SumElements (m, n));

int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

int SumElements (int m, int n)
{
    if (m == n)
    {
        return m;
    }
    return m + SumElements (m + 1, n);
}