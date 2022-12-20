Console.WriteLine("Введите певое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int numberc = int.Parse(Console.ReadLine());

int max = numberA;

if(numberB > max)
{
    max = numberB;
}
if(numberc > max)
{
    max = numberc;
}
Console.Write($"Максимальное число {max}");
