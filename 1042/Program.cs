// 1042
string[] linha = Console.ReadLine().Split(' ');
int A = int.Parse(linha[0]);
int B = int.Parse(linha[1]);
int C = int.Parse(linha[2]);

 int[] valores = { A, B, C };
 int[] valoresOrdenados = (int[])valores.Clone();
Array.Sort(valoresOrdenados);

foreach (int valor in valoresOrdenados)
{
    Console.WriteLine(valor);
}
    Console.WriteLine();

foreach (int valor in valores)
{
    Console.WriteLine(valor);
}