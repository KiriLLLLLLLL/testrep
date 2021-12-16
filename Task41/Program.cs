void FillArray (double [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(50, 100) / 10.0;
    }
}

void PrintArray (double [] collection)
{
    int position = 0;
    while (position < collection.Length)
    {
        Console.Write($"{collection[position]}  ");
        position++;
    }
}

double [] FindMinMax (double [] collection)
{
    double min = collection[0];
    double max = collection[0];
    double [] minMax = {0, 0};

    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] < min)
        {
            min = collection[i];
            minMax[0] = min;
        }
        if (collection[i] > max)
        {
            max = collection[i];
            minMax[1] = max;
        }
    }
    return minMax;
}

double [] array = new double [10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

double [] result = FindMinMax(array);
PrintArray(result);
