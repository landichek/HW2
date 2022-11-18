// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа//

Console.WriteLine ("Введите трехзначное число число:");
int number = Convert.ToInt32(Console.ReadLine());

int a = 100;
int b = 999;

if (a <= number && b >= number)
{
Console.WriteLine("Вторая цифра : {0}",  number.ToString().ToCharArray()[1]);
}

else
{
Console.WriteLine ("Число не является трехзначным. Введите трехзначное число число");
}
