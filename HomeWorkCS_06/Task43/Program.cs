// Task43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



double b1 = ReadInt("b1");
double k1 = ReadInt("k1");
double b2 = ReadInt("b2");
double k2 = ReadInt("k2");

Intersection(b1, k1, b2, k2);

double ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
    return double.Parse(Console.ReadLine()!);
}

void Intersection(double b1, double k1, double b2, double k2)
{
    if (k1 != k2 && b1 != b2)
    {
        double x = 0;
        double y = 0;
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения: {x};{y}");
    }

    else if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Пересекаются");
    }

    else if (k1 == k2)
    {
        Console.WriteLine("Не пересекаются");
    }
}