Console.WriteLine("Введите певое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

int max = numberA;

while (numberB > max)
{
    max = numberB;
}
Console.Write($"Большее число {max}");
