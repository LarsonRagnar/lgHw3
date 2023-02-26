// Задача 21

// Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.WriteLine("Введите координату по оси X 1 точки");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату по оси Y 1 точки");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату по оси Z 1 точки");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату по оси X 2 точки");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату по оси Y 2 точки");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату по оси Z 2 точки");
// int z2 = Convert.ToInt32(Console.ReadLine());                                                                
// var result = Math.Sqrt(Math.Pow(x2 - x1, 2 ) + Math.Pow(y2 - y1, 2 ) + Math.Pow(z2 - z1, 2 ) );
// Console.WriteLine($"Растояние между точками равно {Math.Round (result, 3)}");


// Задача 23

// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.WriteLine("Введите Число N ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i <= N; i++)
// {
//     Console.Write(Math.Pow(i, 3) + "\t");
// }


// Задача 19

// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


// Console.WriteLine("Введите пятизгачное число ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int number = number1;
// int reversNumber = 0;
// if (number >=10000 && number <= 100000)
// {
//     while (number>0)
//         {
//             reversNumber= reversNumber * 10 + number % 10;
//             number= number /10;
//         }
//         if (reversNumber==number1)
//         {
//             Console.WriteLine($"Чичло является полиндромом {number1} {reversNumber} ");
            
//         }
//         else
//         {
//             Console.WriteLine($"Чичло не является полиндромом ");
    
//         }
// }
// else
// {
// Console.WriteLine($"Число не пятизначное повторите операцию");
// }





    







