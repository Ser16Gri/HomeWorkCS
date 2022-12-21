Console.WriteLine("Введите день недели цифрой");
int n = int.Parse(Console.ReadLine());

string d = "";

if (n > 0 && n < 6)
{
    d = "Нет";
    Console.WriteLine(d);

}
else if (n > 5 && n < 8)
{
    d = "Да";
    Console.WriteLine(d);
}
else Console.WriteLine("Нет такого дня недели");