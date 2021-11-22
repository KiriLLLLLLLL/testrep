Console.WriteLine("Введите два целых числа");
string firstNum = Console.ReadLine();
int numA = Convert.ToInt32(firstNum);
string secondNum = Console.ReadLine();
int numB = Convert.ToInt32(secondNum);
int sum = numA + numB;
Console.Write("Сумма чисел равна: " + sum);