// 1072
int quantidadeValores = int.Parse(Console.ReadLine());
double valores;
int valoresIn = 0;
int valoresOut = 0;

for(int i = 0; i < quantidadeValores; i++)
{
    valores = double.Parse(Console.ReadLine());

    if(valores >= 10 && valores <= 20)
    {
        valoresIn++;
    }
    if(valores < 10 || valores > 20)
    {
        valoresOut++;
    }
}
Console.WriteLine("{0} in", valoresIn);
Console.WriteLine("{0} out", valoresOut);