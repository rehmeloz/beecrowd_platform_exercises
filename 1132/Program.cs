// 1132
List<int> somaDosNumeros = new List<int>();

int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());

for(int i = X; i <= Y; i++)
{
    if(i  % 13  != 0)
    {
        somaDosNumeros.Add(i);
    }
}

int soma = somaDosNumeros.Sum();

Console.WriteLine(soma);
*/

/*
// 1924
int numeroDeCasos = int.Parse(Console.ReadLine());

for(int i = 0; i < numeroDeCasos; i++)
{
    string nomeDoCurso = Console.ReadLine();
}

Console.WriteLine("Ciencia da Computacao");