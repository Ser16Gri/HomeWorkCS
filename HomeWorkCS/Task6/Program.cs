Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());

string s = "";

if (n % 2 ==0)
{
    s = "Да";
}
else
{
    s = "Нет";
}
Console.WriteLine(s);