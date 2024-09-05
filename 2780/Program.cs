// 2780
int distancia = int.Parse(Console.ReadLine());

if(distancia <= 800)
{
    Console.WriteLine("1");
} else if(distancia > 800 && distancia <= 1400)
{
    Console.WriteLine("2");
} else if(distancia > 1400 && distancia <= 2000)
{
    Console.WriteLine("3");
}