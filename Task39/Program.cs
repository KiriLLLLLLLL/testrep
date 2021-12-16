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

int SumOddIndex (int [] collection)
{
    int sumOddIndex = 0;
    for (int i = 1; i < collection.Length; i += 2)
    {
        sumOddIndex = sumOddIndex + collection[i];
    }
    return sumOddIndex;
}

int [] array = new int [10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int sum = SumOddIndex(array);
Console.WriteLine(sum);
