Console.WriteLine("Введите певое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

int max = numberA;
int min = numberB;

while (min > max)
{
    max = numberB;
    min = numberA;
}

Console.WriteLine($"Большее число {max}");
Console.WriteLine($"Меньшее число {min}");
