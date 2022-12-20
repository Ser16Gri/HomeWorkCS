//Console.WriteLine("Введите певое число: ");
//int numberA = int.Parse(Console.ReadLine());

//Console.WriteLine("Введите второе число: ");
//int numberB = int.Parse(Console.ReadLine());

//int max = numberA;
//int min = numberB;

//while (min > max)
//{
//    max = numberB;
//    min = numberA;
//}

//Console.WriteLine($"Большее число {max}");
//Console.WriteLine($"Меньшее число {min}");


int a1 = 5; int a2 = 2; int a3 = -9;
int b1 = 7; int b2 = 10; int b3 = -3;

int max1 = a1; int max2 = a2; int max3 = a3;
int min1 = b1;int min2 = b2; int min3 = b3;

if (max1 < min1) {max1 = b1; min1 = a1;}
if (max2 < min2) {max2 = b2; min2 = a2;}
if (max3 < min3) {max3 = b3; min3 = a3;}

Console.WriteLine($"max1 = {max1}");
Console.WriteLine($"min1 = {min1}");

Console.WriteLine($"max2 = {max2}");
Console.WriteLine($"min2 = {min2}");

Console.WriteLine($"max3 = {max3}");
Console.WriteLine($"min3 = {min3}");