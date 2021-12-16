void FillArray (int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(-50, 150);
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

int QuantityElements (int [] collection)
{
    int count = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] <= 99 && collection[i] >= 10)
        {
            count++;
        }
    }
    return count;
}

int [] array = new int [123];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int result = QuantityElements (array);
Console.WriteLine("Количество чисел в диапазоне 10-99 = " + result);