// 60. В прямоугольной матрице найти строку с наименьшей суммой элементов.

void FillArray (int [,] collection)
{
    for(int i = 0; i < collection.GetLength(0); i++)
    {
        for(int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(10, 100);
        }

    }
}

void PrintArray (int [,] collection)
{
    for(int i = 0; i < collection.GetLength(0); i++)
    {
        for(int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write("{0, 5}", $"{collection[i, j]}");
        }
    Console.WriteLine();
    }
}

void FindMaxSumString(int [,] collection)
{
    int sumMin = int.MaxValue; // Как можно сделать без MaxValue???
    int rowMin = 0;
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        int sumString = 0;
        for(int j = 0; j < collection.GetLength(1); j++)
        {
            sumString += collection[i, j];
        }
        Console.Write(sumString + " ");
        if (sumString < sumMin)
        {
            sumMin = sumString;
            rowMin = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Строка с минимальной суммой: {rowMin + 1}, сумма: {sumMin}");
}

int[,] array = new int[6, 5];

Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
FindMaxSumString(array);