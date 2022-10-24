// // Задача 47

// Console.WriteLine("Введите количество строк и столбцов m и n: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());

// double[,]matrix = new double[m, n];

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matrix[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
//     }
// }

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// // Задача 50 (запускать совместно с предыдущей задачей)

// Console.WriteLine("Введите позиции элемента массива l(строки) и k(столбца): ");
// int l = Convert.ToInt32(Console.ReadLine());
// int k = Convert.ToInt32(Console.ReadLine());

// if (l >= m || k >= n)
// {
//     Console.WriteLine("Такого числа в массиве нет.");
//     return;
// }
// Console.WriteLine("Вот этот элемент: " + matrix[l, k]);

// Задача 52

// Console.WriteLine("Введите количество строк и столбцов m и n: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int[,]matrix = new int[m, n];
// double average = 0;

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matrix[i, j] = new Random().Next(0, 100);
//     }
// }

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// for (int j = 0; j < n; j++)
// {
//     for (int i = 0; i < m; i++)
//     {
//         average += matrix[i, j];
//     }
//     Console.WriteLine("Среднее арифметическое " + j + "-го столбца: " + average / m);
//     average = 0;
// }