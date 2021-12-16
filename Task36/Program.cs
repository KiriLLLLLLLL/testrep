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

bool FindNumber (int [] collection, int num)
{
    bool isNum = false;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] == num)
        {
            isNum = true;
            break;
        }
    }
    return isNum;
}

int [] array = new int [20];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int someNumber = new Random().Next(10, 100);
bool isNum = FindNumber(array, someNumber);
Console.WriteLine($"Искомое число: {someNumber}");

if (isNum)
{
    Console.WriteLine("Есть!");
}
else Console.WriteLine("Нет!!");


