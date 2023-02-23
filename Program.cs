// Домашняя работа к семминару №3

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void CubeNumber (int number)
// {
// int count = 1;

// while (count <= number)
// {
//     Console.WriteLine($"{number} ->  {Math.Pow(count, 3)}");
//     count++;
// }
// }
// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// CubeNumber(x);

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// void Palindrome (int num)
// {
//    int tenthousand = num / 10000;
//    int thousand = (num / 1000) % 10;
//    int dec = (num / 10) % 10;
//    int ed = num % 10;

//     if(thousand == dec && tenthousand == ed) Console.WriteLine($" {num} -> Да");  
//     else
// {
//     Console.WriteLine($" {num} -> Нет");  
// }     
// }

// Console.WriteLine("Введите пятизначнаое число");
// int x = Convert.ToInt32(Console.ReadLine());
// Palindrome (x);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance (double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2) + Math.Pow(zb-za,2) ),2); 
// }

// Console.WriteLine("Input coordinate x for first point:");
// double xa = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate y for first point:");
// double ya = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate z for first point:");
// double za = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate x for second point:");
// double xb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate y for second point:");
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate z for first point:");
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between our points -> {FindDistance(xa,ya,za,xb,yb,zb)}");