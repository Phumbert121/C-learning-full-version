// // Задача 19
// Console.WriteLine("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number / 10000 == number % 10 &&
//     (number / 1000) % 10 == (number % 100) / 10)
//     Console.WriteLine("Да");
// else
//     Console.WriteLine("Нет");

// Задача 21
// Console.WriteLine("Введите координаты двух точек в 3D: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int z1 = Convert.ToInt32(Console.ReadLine());
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// int z2 = Convert.ToInt32(Console.ReadLine());
// double s = Math.Pow((Math.Pow(x2 - x1, 2) + 
//             Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 0.5);
// Console.Write(s);

// Задача 23
// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int i = 1;

// while (i <= N)
//     {
//         Console.Write(Math.Pow(i, 3));
//         Console.Write(" ");
//         i++;
//     }