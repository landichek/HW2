// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет //

Console.WriteLine ("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int a = 100;

if ( a <= number)
{
Console.WriteLine("Вторая цифра : {0}",  number.ToString().ToCharArray()[2]);
}

else
{
Console.WriteLine ("Третьей цифры нет");
}
