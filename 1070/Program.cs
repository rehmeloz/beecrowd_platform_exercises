// 1070
int X = int.Parse(Console.ReadLine());

if(X % 2 == 0)
{
    X++;
}

for(int i = 0; i < 6; i++)
{
    Console.WriteLine(X);
    X += 2;
}