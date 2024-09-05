// 1099
int numeroDeCasos = int.Parse(Console.ReadLine());
int[] resultados = new int[numeroDeCasos];

for (int i = 0; i < numeroDeCasos; i++)
{
    string[] numeros = Console.ReadLine().Split(" ");
    int X = int.Parse(numeros[0]);
    int Y = int.Parse(numeros[1]);

    if (X > Y)
    {
        int temp = X;
        X = Y;
        Y = temp;
    }

    int somaDeImpares = 0;

    for (int z = X + 1; z < Y; z++)
    {
        if (z % 2 != 0) 
        {
            somaDeImpares += z;
        }
    }
    resultados[i] = somaDeImpares;
}

for(int i = 0; i < numeroDeCasos; i++)
{
    Console.WriteLine(resultados[i]);
}