// Найти максимальное из трех чисел
int a = new Random().Next(1, 10);
int b = new Random().Next(1, 10);
int c = new Random().Next(1, 10);
int max;
int min=a;
Console.WriteLine(a + " " + b + " " + c);

if (a == b && b == c)
{
    Console.WriteLine("Числа равны");
}
else if (a >= b && a >= c)
{
    max = a;
    Console.WriteLine("Max number: " + max);
}
else if (b >= a && b > c)
{
    max = b;
    Console.WriteLine("Max number: " + max);
}
else if (c > a && c >= b)
{
    max = c;
    Console.WriteLine("Max number: " + max);
}


