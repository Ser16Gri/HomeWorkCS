// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Ведите пятизначное число:");
string n = Console.ReadLine();

if (4 < n.Length && n.Length < 6)
{
    if (n[0] == n[4] || n[1] == n[3])
    {
        Console.WriteLine($"Является палиндромом");
    }
    else Console.WriteLine($"Не является палиндромом");
}
else Console.WriteLine($"Вы ввели не правильное число");

