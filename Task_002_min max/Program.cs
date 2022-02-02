// Даны два числа. Показать большее и меньшее число
int a = new Random().Next(1,100);
int b = new Random().Next(1,100);
int max;
int min;
Console.WriteLine("number1: " +a);
Console.WriteLine("number2: " +b);
if (a>b)
{
    min=b;
    max=a;
    Console.WriteLine("Min = " + min + "  Max = " + max);
} 
else if (a<b)
{
    min=a;
    max=b;
    Console.WriteLine("Min = " + min + "  Max = " + max);
}
else
Console.WriteLine("Числа равны");