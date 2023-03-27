using System;
using static System.Console;

int n = 5;

int[] array = new int[n];

for (int i = 0; i < n; i++)
    array[i] = Convert.ToInt32(ReadLine());

//[4, 5, 3, 1, 2]
// O(n)
// [1, 2, 3, 4, 5] - O(n * log(n))
// ((5 + 1) / 2) * 5

WriteLine("[" + String.Join(", ", array) + "]");
WriteLine(array[3]);