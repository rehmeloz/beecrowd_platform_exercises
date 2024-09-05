// 1113
while(true)
{
string[] linha = Console.ReadLine().Split(" ");
int X = int.Parse(linha[0]);
int Y = int.Parse(linha[1]);

if(X == Y)
{
    break;
}
else if(X < Y)
{
     Console.WriteLine("Crescente");
}
else
{
     Console.WriteLine("Decrescente");
}
}