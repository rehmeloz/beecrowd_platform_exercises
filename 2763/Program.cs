// 2763
string cpf = Console.ReadLine();

string[] partes = cpf.Split(new char[] { '.', '-'});

foreach (string parte in partes)
{
    Console.WriteLine(parte);
}
