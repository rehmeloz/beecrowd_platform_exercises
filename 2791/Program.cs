// 2791
string[] posicaoDoFeijao = Console.ReadLine().Split(" ");

int posicao1 = int.Parse(posicaoDoFeijao[0]);
int posicao2 = int.Parse(posicaoDoFeijao[1]);
int posicao3 = int.Parse(posicaoDoFeijao[2]);
int posicao4 = int.Parse(posicaoDoFeijao[3]);

if(posicao1 > 0)
{
    Console.WriteLine("1");
} 
else if(posicao2 > 0)
{
    Console.WriteLine("2");
}
else if(posicao3 > 0)
{
    Console.WriteLine("3");
}
else if(posicao4 > 0)
{
    Console.WriteLine("4");
}