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
                if(collection[i, k] < collection[i, collection.GetLength(1) - 1])
                {
                    int elem = collection[i, k];
                    collection[i, k] = collection[i, k + 1];
                    collection[i, k + 1] = elem;
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
