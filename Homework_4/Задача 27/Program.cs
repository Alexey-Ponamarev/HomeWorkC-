Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"Сумма всех цифр числа {number} равна {GetSumm(number)}");

int GetSumm(int A)
{
    int NumbInteger;
    int NumbRemaind;
    int summ = 0;
    do
    {
        NumbInteger = A / 10;
        NumbRemaind = A % 10;
        summ = summ + NumbRemaind;
        A = NumbInteger;
    } while (NumbInteger > 0);
    return summ;
}