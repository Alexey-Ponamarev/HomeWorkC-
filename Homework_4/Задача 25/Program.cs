Console.Clear();
Console.WriteLine("Введите значение для А: ");
int numberA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение для B: ");
int numberB=Convert.ToInt32(Console.ReadLine());
int result=0;
for (int i=1; i<=numberB; i++) {
result = result+numberA;
}
Console.WriteLine($"Число {numberA} в степени {numberB} = {result}");
