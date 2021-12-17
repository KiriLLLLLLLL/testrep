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


int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        if(i % 2 == 0 && j % 2 == 0)
        {
            array[i, j] *= array[i, j];
        }
    }
}

PrintArray(array);