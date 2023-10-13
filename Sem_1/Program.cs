using System.Diagnostics;

Console.Clear();
Console.Write("Введите число:  ");
int number =Convert.ToInt32(Console.ReadLine());

int Results=number*number;
Console.Write("Квадрат от числа " + number +" = "+Results);