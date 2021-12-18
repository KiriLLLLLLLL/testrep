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

void DescendingRows(int[,] collection)
{
    for(int i = 0; i < collection.GetLength(0); i++)
    {
        for(int j = 0; j < collection.GetLength(1); j++)
        {
            for(int k = 0; k < collection.GetLength(1); k++)
            {
                if(collection[i, j] >= collection[i, k])
                {
                    int elem = collection[i, j];
                    collection[i, j] = collection[i, k];
                    collection[i, k] = elem;
                }
            }
        }
    }
}

int[,] array = new int[5, 4];

Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
DescendingRows(array);
PrintArray(array);
