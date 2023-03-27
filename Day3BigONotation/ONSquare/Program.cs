// O(n^2)

int n = Convert.ToInt32(Console.ReadLine());

// 1  2  3  4  5
// 2  4  6  8 10
// 3  6  9 12 15
// 4  8 12 16 20
// 5 10 15 20 25 





for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        Console.Write(i * j + "\t");

    }
    Console.WriteLine();
    Console.WriteLine();
}


Console.WriteLine(" ========     O(n^2)     =======");
Console.WriteLine();

int[,] matrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
    }
}



for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + "\t");

    }
    Console.WriteLine();
    Console.WriteLine();
}

Console.WriteLine(" =======     O(n^2 / 2)     ======= ");
// O(n^2 / 2)