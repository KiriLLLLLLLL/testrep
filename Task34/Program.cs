void FillArray(int [] collection)
{
    int lenght = collection.Length;

    for (int i = 0; i < lenght; i++)
    {
        collection[i] = new Random().Next(-9, 10);
    }
}

void PrintArray (int [] collection)
{
    int lenght = collection.Length;
    int position = 0;
    while (position < lenght)
    {
        Console.Write($"{collection[position]},  ");
        position++;
    }
}

int [] SumArray (int [] collection)
{
    int [] sumArray = {0, 0};
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        if (collection[i] >= 0)
        {
            sumArray[0] = sumArray[0] + collection[i];
        }
        else  sumArray[1] = sumArray[1] + collection[i];
    }
    return sumArray;
}



int [] array = new int[12];

FillArray(array);
int [] newArray = SumArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Сумма положительных элементов массива: " + newArray[0]);
Console.WriteLine("Сумма отрицательных элементов массива: " + newArray[1]);