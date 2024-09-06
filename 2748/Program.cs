// 2748
Console.WriteLine("---------------------------------------");
for(int lines = 0; lines <= 5; lines++)
{
    Console.Write("|");
    for(int i = 0; i <= 37; i++)
    Console.Write(" ");
            
    Console.Write("|");
    Console.Write("\n");
}
Console.WriteLine("---------------------------------------");

Console.SetCursorPosition((39 - "Roberto".Length) / 2, 2);
Console.WriteLine("Roberto");
Console.SetCursorPosition((39 - "5786".Length) / 2, 4);
Console.WriteLine("5786");
Console.SetCursorPosition((39 - "UNIFEI".Length) / 2, 6);
Console.WriteLine("UNIFEI");