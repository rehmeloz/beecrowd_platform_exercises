// 2862
int numeroDeCasos = int.Parse(Console.ReadLine());

for(int i = 0; i < numeroDeCasos; i++)
{
    int nivelDeEnergia = int.Parse(Console.ReadLine());

    if(nivelDeEnergia > 8000)
    {
        Console.WriteLine("Mais de 8000!");
    } 
    else 
    {
        Console.WriteLine("Inseto!");
    }
}