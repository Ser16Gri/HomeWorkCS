// Task60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




int ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
    return int.Parse(Console.ReadLine());
}

void PrintThirdDimensionArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{i}-{j}-{k}: {array[i, j, k]} ");
            }
        }
    }
    Console.WriteLine();
}

int[,,] GetThreeDimensionUniqueArray(int length1, int length2, int length3)
{
    int[,,] array = new int[length1, length2, length3];
    Random rnd = new Random();

    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            for (int k = 0; k < length3; k++)
            {
                int value = rnd.Next(100);
                if (!HasValueInThreeDimensionmArray(array, value))
                    array[i, j, k] = value;
                else
                {
                    k--;
                }
            }
        }
    }

    return array;
}

bool HasValueInThreeDimensionmArray(int[,,] array, int value)
{
    foreach (int item in array)
    {
        if (item == value)
        {
            return true;
        }
    }

    return false;
}

int[,,] array = GetThreeDimensionUniqueArray(ReadInt("Length1"), ReadInt("Length 2"), ReadInt("Length3"));
PrintThirdDimensionArray(array);