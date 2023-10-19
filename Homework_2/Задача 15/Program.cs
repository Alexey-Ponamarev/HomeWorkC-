
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear(); // Очищаем консоль от предыдущих команд
        Console.WriteLine("Введите номер дня недели: "); // Вводим номер дня недели

        // Проверяем что введена цифра
        string StringNumber = Console.ReadLine();
        int NumberDay; // Объевляем переменную чтобы потом в нее положить значение
        bool isNumber = int.TryParse(StringNumber, out NumberDay);

        if (isNumber && StringNumber.Length ==1 && NumberDay>5 && NumberDay<8 && NumberDay>0) //Если условие истина
        {
            Console.WriteLine($"День недели {StringNumber} - выходной день"); // Вывод результата
        }
        else if(isNumber && StringNumber.Length ==1 && NumberDay<=5 && NumberDay<8 && NumberDay>0)
        {
          Console.WriteLine($"День недели {StringNumber} - рабочий день"); // Вывод результата  
        }
        else
        {
            Console.WriteLine("Данные введены не корректно"); // Вывод результата
        }
    }

}