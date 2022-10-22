// void Fill_array(int[] array)
// {
//     int index = 0;
//     while (index < 10)
//     {
//         array[index] = new Random().Next(100, 1000);
//         index++;
//     }
//     index = 0;
//     while (index < 10)
//     {
//         Console.WriteLine(array[index]);
//         index++;
//     }
// }

// int[] array = new int[10];

// Fill_array(array);
// int index = 0;
// int count = 0;

// while (index < 10)
//     {
//         if (array[index] % 2 == 0)
//             count++;
//         index++;
//     }
// Console.Write(count);

// Задача 36

// void Fill_array(int[] array)
// {
//     int index = 0;
//     while (index < 4)
//     {
//         array[index] = new Random().Next(100, 1000);
//         index++;
//     }
//     index = 0;
//     while (index < 4)
//     {
//         Console.WriteLine(array[index]);
//         index++;
//     }
// }

// int[] array = new int[4];

// Fill_array(array);
// int index = 0;
// int summ = 0;

// while (index < 4)
//     {
//         if (index % 2 == 1)
//             summ = summ + array[index];
//         index++;
//     }
// Console.Write(summ);

// Задача 38

// void Fill_array(double[] array)
// {
//     int index = 0;
//     while (index < 4)
//     {
//         array[index] = new Random().NextDouble();
//         index++;
//     }
//     index = 0;
//     while (index < 4)
//     {
//         Console.WriteLine(array[index]);
//         index++;
//     }
// }

// double[] array = new double[4];

// Fill_array(array);
// int index = 1;
// double max = array[0];
// double min = array[0];

// while (index < 4)
// {
//     if (array[index] > max) max = array[index];
//     if (array[index] < min) min = array[index];
//     index++;
// }

// Console.Write(max - min);