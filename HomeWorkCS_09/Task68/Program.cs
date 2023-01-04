// Task68. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int m = ReadInt("m (НЕ больше 3)");
int n = ReadInt("n");
Console.WriteLine(FunctionAkkerman(m, n));

int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

int FunctionAkkerman (int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    else if ((m != 0) && (n == 0)) 
    {
        return FunctionAkkerman (m - 1, 1);
    }
    return FunctionAkkerman (m - 1, FunctionAkkerman (m, n - 1));
}