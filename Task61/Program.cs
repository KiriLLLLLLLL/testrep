// Составить частотный словарь элементов двумерного массива


void FillArray (int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(1, 10);
        }

    }
}

void PrintArray (int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write("{0, 5}", $"{collection[i, j]}");
        }
    Console.WriteLine();
    }
}

int[] UnicElements (int[,] collection)
{
    int[] newArray = new int[collection.Length];
    int k = 0;
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            newArray[k++] = collection[i, j];
        }
    }
    int[] unicArray = newArray.Distinct().ToArray();
    Array.Sort(unicArray);
    return unicArray;
}

void CountElements (int[,] collection, int[] array)
{


    for (int i = 0; i < array.Length; i++)
    {
        int count = 0;
        for (int j = 0; j < collection.GetLength(0); j++)
        {
            for (int k = 0; k < collection.GetLength(1); k++)
            {
                if (array[i] == collection[j, k]) count++;

            }
        }
    Console.WriteLine($"{array[i]} встречается {count} раз");
    }
}


int[,] array = new int[5, 5];

Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
int[] unic = UnicElements(array);
for (int i = 0; i < unic.Length; i++)
{
    Console.Write(unic[i] + " ");
}
Console.WriteLine();
CountElements(array, unic);