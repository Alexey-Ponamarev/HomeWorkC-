Console.Write("Ведите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] result = FillArray(size);
Console.Write($"[{String.Join(";", result)}]");

int[] FillArray(int size)
{
    int[] MyArray = new int[size];

    for (int i=0; i<MyArray.Length;i++)
    {
        MyArray[i]=new Random().Next(-100,100);
    }
    return MyArray;
}


// int[] result = GetBinaryArray(8); // Получили массив на 8 эл.
// Console.WriteLine($"[{String.Join("; ", result)}]");

// int[] GetBinaryArray(int size)
// {
//     // тип_данных [] имя_массива = new int[размер]
//     int[] array = new int[size];
//     // Изначально массив заполнен НУЛЯМИ
//     for (int i = 0; i < array.Length; i++) // array.Length = size
//     {
//         array[i] = new Random().Next(2); // [0, 2)
//         // Next(2) => Next(0, 2)
//     }
//     return array;
// }