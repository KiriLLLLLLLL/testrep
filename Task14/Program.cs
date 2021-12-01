Console.WriteLine("Введите два целых числа:");
Int64 num1 = Convert.ToInt64(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 % num1 == 0)
{
    Console.WriteLine("Кратно, все супер!");
}
else
{
    Console.Write("Похоже не кратно, остаток: ");
    Console.WriteLine(num2 % num1);
}