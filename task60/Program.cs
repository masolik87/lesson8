/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[] GetOneMeasureArray(int minValue, int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = minValue;
        minValue++;
    }
    return array;
}

int[,,] GetTripleArray(int depth, int rows, int columns)
{
    int arrayRandomIndex = 1;
    int[] oneArray = GetOneMeasureArray(-99, 199);
    int[,,] array = new int[depth, rows, columns];
    Random randomValue = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                arrayRandomIndex = randomValue.Next(109, 198);
                if (oneArray[arrayRandomIndex] == 0)
                {
                    arrayRandomIndex = randomValue.Next(10, 89);
                }
                if (array[i, j, k] == 0)
                {
                    array[i, j, k] = oneArray[arrayRandomIndex];
                    oneArray[arrayRandomIndex] = 0;
                    k = 0;
                    j = 0;
                    i = 0;
                }
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write("\t" + array[i, j, k]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
void PrintIndexedArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"{i + 1} размерность массива:");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"Индекс |{i},{j},{k}|  =  ({array[i, j, k]})");
            }
        }
    }
}

int[,,] array = GetTripleArray(3, 3, 6);
Console.WriteLine();

PrintArray(array);
Console.WriteLine();

Console.WriteLine("Построчная печать массива с добавлением идекса элемента:");
PrintIndexedArray(array);