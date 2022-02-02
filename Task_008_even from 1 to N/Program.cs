// Показать четные числа от 1 до N
int maxN = new Random().Next(1,100);
int minN = 1;
Console.WriteLine("Диапазон от 1 до " + maxN);
Console.Write("Все четные числа данного диапазона: ");
while (minN<=maxN)
{
    if ((minN%2)==0)
    {
    Console.Write(" "+minN+" ");
    }
    minN++;
}