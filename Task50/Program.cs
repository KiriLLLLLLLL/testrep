void FillArray (double [,] collection)
{
    for(int i = 0; i < collection.GetLength(0); i++)
    {
        for(int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(100, 1000) / 10.0;
        }

    }
}

void PrintArray (double [,] collection)
{
    for(int i = 0; i < collection.GetLength(0); i++)
    {
        for(int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write($"{collection[i, j]}  ");
        }
    Console.WriteLine();
    }
}

double[,] array = new double[4, 4];
FillArray(array);
PrintArray(array);