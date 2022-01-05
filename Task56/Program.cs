//Попросить комментарий!!!!!! Не понимаю, как работает
//Попросить комментарий!!!!!! Не понимаю, как работает
//Попросить комментарий!!!!!! Не понимаю, как работает
//Попросить комментарий!!!!!! Не понимаю, как работает



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

void PrintArray1 (int [] collection)
{
    int position = 0;
    while (position < collection.Length)
    {
        Console.Write($"{collection[position]}  ");
        position++;
    }
}

int[] ColumnArithmeticMean(int[,] collection)
{
    int length0 = collection.GetLength(0);
    int[] arithmMean = new int[collection.GetLength(1)];

    for(int j = 0; j < collection.GetLength(1); j++)
    {
        int summ = 0;
        for(int i = 0; i < length0; i++)
        {
            summ += collection[i, j];

        }
        arithmMean[j] = summ / length0;
    }
    return arithmMean;
}

int[,] array = new int[6, 7];

Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();

int[] result = ColumnArithmeticMean(array);
PrintArray1(result);

//Попросить комментарий!!!!!! Не понимаю, как работает
//Попросить комментарий!!!!!! Не понимаю, как работает
//Попросить комментарий!!!!!! Не понимаю, как работает
//Попросить комментарий!!!!!! Не понимаю, как работает
