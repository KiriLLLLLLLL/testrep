// 58.Написать программу, которая в двумерном массиве заменяет строки на столбцы
// или сообщить, что это невозможно (в случае, если матрица не квадратная).

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

void ChangeRowsToColumns(int[,] collection)
{
    if(collection.GetLength(0) == collection.GetLength(1))
    {
        for(int i = 0; i < collection.GetLength(0) ; i++)
        {
            for(int j = i ; j < collection.GetLength(1); j++)
            {
                int elem = collection[i, j];
                collection[i, j] = collection[j, i];
                collection[j, i] = elem;
            }
        }
    }
    else
    {
        Console.WriteLine("Матрица не квадратная!!");
        Console.WriteLine();
    }
}

int[,] array = new int[5, 5];

Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangeRowsToColumns(array);
PrintArray(array);
