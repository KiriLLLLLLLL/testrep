void FillArray (int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(100, 1000);
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

int [] EvenOdd (int [] collection)
{
    int [] evenOdd = {0, 0};
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] % 2 == 0)
        {
            evenOdd[0] = evenOdd[0] + 1;
        }
        else  evenOdd[1] = evenOdd[1] + 1;
    }
    return evenOdd;
}

int [] array = new int [20];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int [] newArray = EvenOdd(array);

Console.WriteLine($"Количество четных чисел = {newArray[0]}");
Console.WriteLine($"Количество нечетных чисел = {newArray[1]}");