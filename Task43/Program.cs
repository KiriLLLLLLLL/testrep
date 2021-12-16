Console.WriteLine("Сколько чисел вы хотите ввести?");
int count = Convert.ToInt32(Console.ReadLine());

int [] FillArray (int count)
{
    int [] collection = new int [count];
    for (int i = 0; i < count; i++)
    {
        collection[i] = Convert.ToInt32(Console.ReadLine());
    }
    return collection;
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

int IsPositive (int [] collection)
{
    int count = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] > 0) count++;
    }
    return count;
}

int [] array = FillArray(count);
PrintArray(array);
int result = IsPositive(array);
Console.WriteLine();
Console.WriteLine("Чисел больше нуля: " + result);