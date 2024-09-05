// 1044
string[] linha = Console.ReadLine().Split(' ');
double A = double.Parse(linha[0]);
double B = double.Parse(linha[1]);


if (B % A == 0 || A % B == 0)
{
    Console.WriteLine("Sao Multiplos");
} 
else
{
    Console.WriteLine("Nao sao Multiplos");
}
