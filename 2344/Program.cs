// 2344
int nota = int.Parse(Console.ReadLine());

if(nota == 0)
{
    Console.WriteLine("E");
} if(nota >= 1 && nota <= 35)
{
    Console.WriteLine("D");
} if(nota >= 36 && nota <= 60)
{
    Console.WriteLine("C");
} if(nota >= 61 && nota <= 85)
{
    Console.WriteLine("B");
} if(nota >= 86 && nota <= 100)
{
    Console.WriteLine("A");
}