/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random arrayRandomValue = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = arrayRandomValue.Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void SearchArrayRowsMinimalSum(int[,] array)
{
    int sumFirstString = 0;
    int sumSecondString = 0;
    int minString = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumFirstString = sumFirstString + array[i, j];
        }

        if (sumSecondString == 0)
        {
            sumSecondString = sumFirstString;
        }

        if (sumFirstString < sumSecondString)
        {
            sumSecondString = sumFirstString;
            minString = i + 1;
        }
        Console.WriteLine($"Сумма строки {sumFirstString}");
        sumFirstString = 0;
    }
    Console.WriteLine();
    Console.WriteLine($"Строка с наименьшей суммой элементов = {minString}");
}
int[,] array = GetArray(4, 4);
PrintArray(array);
Console.WriteLine();
SearchArrayRowsMinimalSum(array);