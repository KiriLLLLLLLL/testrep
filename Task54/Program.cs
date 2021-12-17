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

void FindNumByIndex(int[,] collection, int elem)
{
    int k = 0;
    for(int i = 0; i < collection.GetLength(0); i++)
    {
        for(int j = 0; j < collection.GetLength(1); j++)
        {
            if(elem == collection[i, j])
            {
                Console.WriteLine($"Индекс элемента {i}, {j}");
                k++;
            }
        }
    }
    if (k == 0) Console.WriteLine("Такого элемента нет");
}

Console.WriteLine("Введите искомое число:");
int elem = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[5, 5];

Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();

FindNumByIndex(array, elem);
