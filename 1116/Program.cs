// 1116
while(true)
{
int numeroDeCasos = int.Parse(Console.ReadLine());

for(int i = 0; i < numeroDeCasos; i++)
{
    string[] linha = Console.ReadLine().Split(" ");
    int A = int.Parse(linha[0]);
    int B = int.Parse(linha[1]);
    
    if(A < 0)
    {
        Console.WriteLine("divisao impossivel");
    } else
    {
        double resultado = A / B;
        Console.WriteLine("{0:F1}", resultado);
    }
}
}