// 1019
int N = int.Parse(Console.ReadLine());

TimeSpan duracao = TimeSpan.FromSeconds(N);
string formato = $"{duracao.Hours + (duracao.Days * 24)}:{duracao.Minutes:D1}:{duracao.Seconds:D1}";

Console.WriteLine(formato);
