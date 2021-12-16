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
int[] CopyArray(int[] collection)
{
    int[] newArray = new int[collection.Length];
    for(int i = 0; i < collection.Length; i++)
    {
        newArray[i] = collection[i];
    }
    return newArray;
}
int[] array = new int[6];


FillArray(array);
PrintArray(array);
Console.WriteLine();

int[] newArray = CopyArray(array);

PrintArray(newArray);