// 1064
 double soma = 0;
 int numerosPositivos = 0;

for(int i = 0; i < 6; i++)
{
    double valor = double.Parse(Console.ReadLine());

    if(valor > 0)
    {
        soma += valor;
        numerosPositivos++;
    }
}
if(numerosPositivos > 0)
{
    double media = soma / numerosPositivos;
    Console.WriteLine("{0} valores positivos", numerosPositivos);
    Console.WriteLine("{0:F1}", media);
}