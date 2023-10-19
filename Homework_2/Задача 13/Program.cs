// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6  

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear(); // Очищаем консоль от предыдущих команд
        Console.WriteLine("Введите трехзначное число: "); // Вводим число

        // Проверяем что введенное число состоит только из цифр
        string StringNumber = Console.ReadLine();
        int number; // Объевляем переменную чтобы потом в нее положить значение
        bool isNumber = int.TryParse(StringNumber, out number);


        if (isNumber && StringNumber.Length >= 3) //Если условие истина
        {
            Console.WriteLine($"{StringNumber} => {StringNumber[2]}"); // Вывод результата
        }
        else
        {
            Console.WriteLine("В числе менее 3 цифр либо присутствуют буквы"); // Вывод результата
        }
    }
}