//   Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//   452 -> 11
//   82 -> 10
//   9012 -> 12

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

  int SumNumber(int number)
  {    
    int count = Convert.ToString(number).Length;
    int temp = 0;
    int sum = 0;

    for (int i = 0; i < count; i++)
    {
      temp = number - number % 10;
      sum = sum + (number - temp);
      number = number / 10;
    }
   return sum;
  }
int sum = SumNumber(number);
Console.WriteLine(sum);