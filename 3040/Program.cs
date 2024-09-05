// 3040
int numeroDeCasos = int.Parse(Console.ReadLine());

for(int i = 0; i < numeroDeCasos; i++)
{
    string[] linha = Console.ReadLine().Split(" ");

    int altura = int.Parse(linha[0]);
    int diametro = int.Parse(linha[1]);
    int QuantidadeDeGalhos = int.Parse(linha[2]);

    if((altura >= 200 && altura <= 300) && (diametro >= 50) && (QuantidadeDeGalhos >= 150))
    {
        Console.WriteLine("Sim");
    } else 
    {
        Console.WriteLine("Nao");
    }
}