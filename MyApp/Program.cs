// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
int n = 6;
for (int i = 3; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}


for (int i = n; i >= 3; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}