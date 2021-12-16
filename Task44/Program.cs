Console.WriteLine("Введите число, которое нужно преобразовать:");
int number = Convert.ToInt32(Console.ReadLine());

string FromDecimalToBinary (int number)
{
    string result = String.Empty;
    while (number > 0)
    {
        int value = number % 2;
        result = value.ToString() + result;
        number = number / 2;
    }
    return result;
}

string resultBinary = FromDecimalToBinary(number);
Console.WriteLine(resultBinary);