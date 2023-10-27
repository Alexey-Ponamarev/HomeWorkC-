
// double[] array = new double[] { 3, 7.4, 22.3, 2, 78 };
// double SummArray = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     SummArray = SummArray + array[i];// Суммируем элементы массива для дальнейшего вычисления макс и мин элемента
// }

// // Ищем максимальный элемент
// double MaxElement = array[0];// Считаем что на данный момент самый максимальный элемент с индексом 0.
// double DeltaMax = SummArray - array[0];// Определяем "вес" данного элемента в сумме массива.
// for (int i = 0; i < array.Length; i++)
// {
//     double DeltaCurrent = SummArray - array[i];
//     if (DeltaMax > DeltaCurrent)
//     {
//         DeltaMax = DeltaCurrent; // Определяем наименьший "вес" в сумме массива среди его элементов.
//         MaxElement = array[i];// Наибольший элемент
//     }
// }


// // Ищем минимальный элемент
// double MinElement = array[0];// Считаем что на данный момент самый минимальный элемент с индексом 0.
// double DeltaMin = SummArray - array[0]; // Определяем "вес" данного элемента в сумме массива.
// for (int i = 0; i < array.Length; i++)
// {
//     double DeltaCurrent = SummArray - array[i];
//     if (DeltaMin < DeltaCurrent)
//     {
//         DeltaMin = DeltaCurrent;// Определяем наименьший "вес" в сумме массива среди его элементов.
//         MinElement = array[i]; // Наименьший элемент.
//     }
// }

// double Diff = MaxElement - MinElement; // Разность мин и макс элемента.

// Console.WriteLine(MaxElement);
// Console.WriteLine(MinElement);
// Console.WriteLine(Diff);

using System;

public class Answer
{
       public static double FindMax(double[] array)
{     // Введите свое решение ниже

    double SummArray = 0;
 for (int i = 0; i<array.Length; i++)
{
    SummArray = SummArray + array[i];// Суммируем элементы массива для дальнейшего вычисления макс и мин элемента
}
// Ищем максимальный элемент
double MaxElement = array[0];// Считаем что на данный момент самый максимальный элемент с индексом 0.
double DeltaMax = SummArray - array[0];// Определяем "вес" данного элемента в сумме массива.
for (int i = 0; i < array.Length; i++)
{
    double DeltaCurrent = SummArray - array[i];
    if (DeltaMax > DeltaCurrent)
    {
        DeltaMax = DeltaCurrent; // Определяем наименьший "вес" в сумме массива среди его элементов.
        MaxElement = array[i];// Наибольший элемент
    }
}
return MaxElement;

}

public static double FindMin(double[] array)
{     // Введите свое решение ниже
double SummArray = 0;
 for (int i = 0; i<array.Length; i++)
{
    SummArray = SummArray + array[i];// Суммируем элементы массива для дальнейшего вычисления макс и мин элемента
}

// Ищем минимальный элемент
double MinElement = array[0];// Считаем что на данный момент самый минимальный элемент с индексом 0.
double DeltaMin = SummArray - array[0]; // Определяем "вес" данного элемента в сумме массива.
for (int i = 0; i < array.Length; i++)
{
    double DeltaCurrent = SummArray - array[i];
    if (DeltaMin < DeltaCurrent)
    {
        DeltaMin = DeltaCurrent;// Определяем наименьший "вес" в сумме массива среди его элементов.
        MinElement = array[i]; // Наименьший элемент.
    }
}

return MinElement;

}

public static double CalcDifferenceBetweenMaxMin(double[] array)
{// Введите свое решение ниже

double Difference = FindMax(array)-FindMin(array); // Разность мин и макс элемента.
return Difference;

}

public static void PrintArray(double[] array)
{// Введите свое решение ниже

Console.WriteLine($"{String.Join("\t", array)}");
}
// Не удаляйте и не меняйте метод Main! 


public static void Main(string[] args)
{
    double[] array;
    if (args.Length == 0)
    {
        array = new double[] { 3, 7.4, 22.3, 2, 78 };
    }
    else
    {
        // Иначе, парсим аргументы в массив чисел
        string[] argStrings = args[0].Split(", ");
        array = new double[argStrings.Length];
        for (int i = 0; i < argStrings.Length; i++)
        {
            if (double.TryParse(argStrings[i], out double number))
            {
                array[i] = number;
            }
            else
            {
                Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                return;
            }
        }
    }

    Console.WriteLine("Массив:");
    PrintArray(array);
    double diff = CalcDifferenceBetweenMaxMin(array);
    Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
}
}