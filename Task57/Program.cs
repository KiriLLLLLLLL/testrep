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
            Console.Write($"{collection[i, j]}  ");
        }
    Console.WriteLine();
    }
}

void ChangeRows(int[,] collection)
{
    int rows = collection.GetLength(0);

    for(int j = 0; j < collection.GetLength(1); j++)
    {
        int elem = collection[0, j];
        collection[0, j] = collection[rows - 1, j];
        collection[rows - 1, j] = elem;
    }

}


int[,] array = new int[5, 4];

Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangeRows(array);
PrintArray(array);