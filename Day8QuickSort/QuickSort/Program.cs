// быстрая сортировка

// using static Sorting;

// int size = 10;
// var arr = size.CreateArray()
//             .Show()
//             .SortQuick(0, size - 1)
//             .Show()
//             ;


int[] arr2 = Infrastructure.CreateArray(10, 0, 12);

Infrastructure.Show(arr2);

Sorting.SortQuick(arr2, 0, arr2.Length - 1);
Infrastructure.Show(arr2);
