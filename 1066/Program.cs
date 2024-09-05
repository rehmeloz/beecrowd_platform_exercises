// 1066
List<double> valores = new List<double>();
double valor;

for(double i = 0; i < 5; i++)
{
    valor = double.Parse(Console.ReadLine());
    valores.Add(valor);
}

int valoresPar = 0;
int valoresImpar = 0;
int valoresPositivos = 0;
int valoresNegativos = 0;

foreach (int v in valores)
{
    if(v % 2 == 0)
    {
        valoresPar++;
    }
    if(v % 2 != 0)
    {
        valoresImpar++;
    }
    if(v > 0)
    {
        valoresPositivos++;
    }
    if(v < 0)
    {
        valoresNegativos++;
    }
}
Console.WriteLine("{0} valor(es) par(es)", valoresPar);
Console.WriteLine("{0} valor(es) impar(es)", valoresImpar);
Console.WriteLine("{0} valor(es) positivo(s)", valoresPositivos);
Console.WriteLine("{0} valor(es) negativo(s)", valoresNegativos);