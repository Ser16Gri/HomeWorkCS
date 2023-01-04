// Task64. Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


 int n = ReadInt("N");
 PrintNumbersFromNTo (n);

int ReadInt(string argumentName)
{
	Console.Write($"Введите число {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

void PrintNumbersFromNTo (int n)
{
    if (n <= 1)
    {
        Console.WriteLine(n);
        return;
    }
    Console.Write($"{n}, ");
    PrintNumbersFromNTo (n - 1);
}