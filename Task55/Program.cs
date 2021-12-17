//Как сделать с прямоугольным массивом??????????
//Как сделать с прямоугольным массивом??????????
//Как сделать с прямоугольным массивом??????????
//Как сделать с прямоугольным массивом??????????
//Как сделать с прямоугольным массивом??????????

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

int SummElemDiagonal(int[,] collection)
{
    int j = 0;
    int summ = -1;
    if(collection.GetLength(0) == collection.GetLength(1))
    {
        for(int i = 0; i < collection.GetLength(1); i++)
        {
            summ = collection[i, j] + summ;
            j++;
        }
    }
    return summ;
}

int[,] array = new int[5, 5];

Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();

if (SummElemDiagonal(array) != -1)
{
Console.WriteLine($"Сумма элементов на главной диагонали = {SummElemDiagonal(array)}");
}
else Console.WriteLine("Матрица не квадратная!");


//Как сделать с прямоугольным массивом??????????
//Как сделать с прямоугольным массивом??????????
//Как сделать с прямоугольным массивом??????????
//Как сделать с прямоугольным массивом??????????
//Как сделать с прямоугольным массивом??????????
