// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным//

Console.WriteLine ("Введите цифру, обозначающую день недели");

int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 6 || dayNumber == 7) 
{
Console.WriteLine("День выходной");
}
else if ((dayNumber < 6 && dayNumber > 0))
    {
      Console.WriteLine ("День не является выходным");
    }
else
{
Console.WriteLine ("Такого дня недели нет");
}