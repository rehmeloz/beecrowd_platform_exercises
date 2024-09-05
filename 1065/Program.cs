// 1065
List<double> valores = new List<double>();
double valor;

for(double i = 0; i < 5; i++)
{
    valor = double.Parse(Console.ReadLine());
    valores.Add(valor);
}

int valoresPares = 0;
foreach(double v in valores)
{
    if(v % 2 == 0)
    {
        valoresPares++;
        
    }
}
Console.WriteLine("{0} valores pares", valoresPares);