Console.WriteLine("Введите трехзначное число");
int N = int.Parse(Console.ReadLine());

int b = 0;

if (N > 99 && N < 999 )
{
    b = (N / 10) % 10;
    Console.WriteLine($"Вторая цифра этого числа {b}");
}
else Console.WriteLine("Вы ввели неправильное число");


