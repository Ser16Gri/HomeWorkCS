//   Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//   1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//   6, 1, 33 -> [6, 1, 33]


Main();

void Main()
{
 bool isWorking = true;
   while (true)
   {
      Console.Write("Input command: ");
      switch (Console.ReadLine())
      {
         case "Task29": Task29(); break;
         case "exit": isWorking = false; break;
      }
      Console.WriteLine();
   }
}

void Task29()
{
   Console.WriteLine("Task29");

   int[] array = GetArray(ReadInt("array length"));

   Console.WriteLine(ArrayToString(array));
}


int ReadInt(string argumentName)
{
   Console.Write($"Input {argumentName}:");
   return int.Parse(Console.ReadLine());
}


int[] GetArray(int length)
{
   int[] array = new int[length];

   for (int i = 0; i < array.Length; i++)
   {
      array[i] = ReadInt($"element {i}");
   }
   return array;
}
 
string ArrayToString(int[] array)
{
   string result = string.Empty;

   for (int i = 0; i < array.Length; i++)
   {
      result += $"{array[i]}, ";
   }
   return result;
}
