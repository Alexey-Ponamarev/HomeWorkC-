// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает
// все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0)
{
N *= -1; // N = N * -1
Console.WriteLine("Вы ввели отрц. число N, я умножил его на -1 :)");
}
int negativeN = N * -1; // -N

while (negativeN <= N)
{
Console.Write(negativeN + " ");
negativeN += 1; // negativeN = negativeN + 1
}