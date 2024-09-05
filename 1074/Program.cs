//1074
List<string> resultados = new List<string>();
double qntValores = double.Parse(Console.ReadLine());

double valor;

for(int i = 0; i < qntValores; i++)
{
    valor = double.Parse(Console.ReadLine());

    if(valor % 2 == 0 && valor > 0)
    {
        resultados.Add("EVEN POSITIVE");
    }
    else if(valor % 2 == 0 && valor < 0)
    {
        resultados.Add("EVEN NEGATIVE");
    }
    else if(valor % 2 != 0 && valor > 0)
    {
        resultados.Add("ODD POSITIVE");
    }
    else if(valor % 2 != 0 && valor < 0)
    {
        resultados.Add("ODD NEGATIVE");
    }
    else if(valor == 0)
    {
        resultados.Add("NULL");
    }
}

foreach (string resultado in resultados)
{
    Console.WriteLine(resultado);
}