// Выяснить является ли число чётным
int a = new Random().Next(1,100);
Console.WriteLine(a);
if ((a%2)==0)
{
    Console.WriteLine("Число " + a + " чётное");
}
else 
Console.WriteLine("Число " + a + " не чётное");
