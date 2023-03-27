// int n = Random.Shared.Next(10000000);


double s = 0;


for (int n = 0; n < 90; n++)
{
    int count = 0;
    int i = n;
    while (i > 0)
    {
        count++;
        s += i;
        i /= 2;
    }
    Console.WriteLine($"n:{n} count:{count}");
}

// 14 / 5 = 2.8 
// 14 div 5 = 2 
// 14 mod 5 = 4