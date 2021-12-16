void FillArray (int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(10, 100);
    }
}

void PrintArray (int [] collection)
{
    int position = 0;
    while (position < collection.Length)
    {
        Console.Write($"{collection[position]}  ");
        position++;
    }
}

int [] SumOfPairs (int [] collection)
{
    int length = 0;
    int [] sumOfPairs = new int [length];
    if (collection.Length % 2 == 0)
    {
        length = collection.Length / 2;
    }
    else
    {
        length = collection.Length / 2 + 1;
    }

    for (int i = 0; i < length; i++)
    {
        sumOfPairs[i] = collection[i] * collection[collection.Length - i - 1];
    }

    return sumOfPairs;
}

int [] array = new int [7];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int [] rezult = SumOfPairs(array);
PrintArray(rezult);