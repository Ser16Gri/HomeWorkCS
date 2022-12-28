// Task41 Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int M = ReadInt("M");
CountPosNum(M);


int ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
    return int.Parse(Console.ReadLine()!);
}

void CountPosNum(int M)
{
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        int number = ReadInt("number");
        if (number > 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Positive numbers: {count}");
}