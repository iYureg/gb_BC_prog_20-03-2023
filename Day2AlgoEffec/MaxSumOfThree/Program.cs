// найти макс. сумму подряд идущих трех чисел в массиве


using static System.Console;
using System.Diagnostics;

Clear();
int[] array = 100000.Create()
                .Fill(1, 10);

// array.ConvertToStringAndPrintToConsole();

int m = 10000;

Stopwatch sw = new Stopwatch();

sw.Start();
int max = array.BadGetSum(m);
sw.Stop();

WriteLine($"BadGetSum: {max} --> {sw.ElapsedMilliseconds}");

sw.Reset();
sw.Start();
max = array.GoodGetSum(m);
sw.Stop();

WriteLine($"GoodGetSum: {max} --> {sw.ElapsedMilliseconds}");

