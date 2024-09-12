// 2717
int minutosParaOFim = int.Parse(Console.ReadLine());

string[] linha = Console.ReadLine().Split(" ");
int A = int.Parse(linha[0]);
int B = int.Parse(linha[1]);

if (A + B > minutosParaOFim)
{
    Console.WriteLine("Deixa para amanha!");
} 
else 
{
    Console.WriteLine("Farei hoje!");
}