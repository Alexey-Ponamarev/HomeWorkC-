// 3. Напишите программу, которая
// будет выдавать название дня недели
// по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
Console.Clear();
Console.WriteLine("Введите день недели ");
int NumberOfDay = Convert.ToInt32(Console.ReadLine());
if (NumberOfDay == 1)
{
    Console.WriteLine("Понедельник");
}
else if (NumberOfDay == 2)
{
    Console.WriteLine("Вторник");
}
else if (NumberOfDay == 3)
{
    Console.WriteLine("Среда");
}
else if (NumberOfDay == 4)
{
    Console.WriteLine("Четверг");
}
else if (NumberOfDay == 5)
{
    Console.WriteLine("Пятица");
}
else if (NumberOfDay == 6)
{
    Console.WriteLine("Суббота");
}
else if (NumberOfDay == 7)
{
    Console.WriteLine("Воскресенье");
}
else //Все остальные случаи
{
    Console.WriteLine("Нет такого дня недели");
}