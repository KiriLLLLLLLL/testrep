void FillArray (int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(-9, 10);
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

void SwitchArray (int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = -collection[i];
    }
}


int [] array = new int [10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SwitchArray(array);
PrintArray(array);