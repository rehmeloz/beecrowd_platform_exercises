// 2060
int quantidadeDeCasos = int.Parse(Console.ReadLine());

string[] valores = Console.ReadLine().Split();

int multiplosDe2 = 0;
int multiplosDe3 = 0;
int multiplosDe4 = 0;
int multiplosDe5 = 0;

for(int i = 0; i < quantidadeDeCasos; i++)
{
    int valor = int.Parse(valores[i]);

    if(valor % 2 == 0) multiplosDe2++;
    if(valor % 3 == 0) multiplosDe3++;
    if(valor % 4 == 0) multiplosDe4++;
    if(valor % 5 == 0) multiplosDe5++;

}

Console.WriteLine("{0} Multiplo(s) de 2", multiplosDe2);
Console.WriteLine("{0} Multiplo(s) de 3", multiplosDe3);
Console.WriteLine("{0} Multiplo(s) de 4", multiplosDe4);
Console.WriteLine("{0} Multiplo(s) de 5", multiplosDe5);