// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8

// void MaxDecimal(int num)
// {
//     int ed = num % 10;
//     int dec = num / 10;
//     if (ed>dec)
//     {
//         Console.WriteLine($"Большая цифра числа {num} -> {ed}"); // return ed
//     }
//     else
//     {
//         Console.WriteLine($"Большая цифра числа {num} -> {dec}"); // return dec
//     }
// }

// int randomnumber = new Random().Next(10, 99 + 1);

// MaxDecimal(randomnumber);

// Задача 2.
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98

// int DeleteDecimal(int num)
// {
//     int sot = num / 100;
//     int ed = num % 10;
//     return sot * 10 + ed;
// }


// int randomnumber = new Random().Next(100, 1000);
// Console.WriteLine(randomnumber);
// // int result = DeleteDecimal(randomnumber);
// // Console.WriteLine(result);
// Console.WriteLine(DeleteDecimal(randomnumber));

// Задача 3.
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да

