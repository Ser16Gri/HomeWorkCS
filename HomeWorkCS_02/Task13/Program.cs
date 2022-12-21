Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());

int c = 0;

if (N > 99 && N < 99999)
{
    if (N > 99 && N < 999)
    {
        c = N % 10;
        Console.WriteLine($"Третья цифра {c}");
    }
        if (N > 9999 && N < 99999)
        {
            c = (N / 100) % 10;
            Console.WriteLine($"Третья цифра {c}");
        }
            if (N > 999 && N < 9999)
            {
                Console.WriteLine("Вы ввели неправильное число");
            }
}
else Console.WriteLine("Третьей цифры нет");