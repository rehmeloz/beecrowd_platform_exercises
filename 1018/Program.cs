// 1018
int N = int.Parse(Console.ReadLine());
        
Console.WriteLine(N);
        
int[] notas = { 100, 50, 20, 10, 5, 2, 1 };
int[] quantidade = new int[notas.Length];

int valorRestante = N;
        
for (int i = 0; i < notas.Length; i++)
{
    quantidade[i] = valorRestante / notas[i];
    valorRestante %= notas[i];
}

for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"{quantidade[i]} nota(s) de R$ {notas[i]},00");
}
