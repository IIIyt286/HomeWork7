// // Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// int M = new Random().Next(1,10);
// int N = new Random().Next(10,21);
// Console.WriteLine($"M = {M} N = {N}");

// void printNum(int firstNum, int endNum)
// {
//     if (firstNum == endNum + 1)
//     {
//         return;
//     }
//     Console.Write($"|{firstNum}|");
//     firstNum++;
//     printNum(firstNum, endNum);
// }
// printNum(M,N);


// // Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int m = new Random().Next(0,3);
// int n = new Random().Next(0,3);
// Console.WriteLine($"m = {m} n = {n}");

// int akkerman (int m, int n)
// {
//     if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (m > 0 && n == 0)
//         {
//             return akkerman(m - 1, 1);
//         }
//         else if (m > 0 && n > 0)
//         {
//             return akkerman(m - 1, akkerman(m, n - 1));
//         }
//         else
//         {
//             return -1;
//         }
// }
// int result = akkerman(m,n);
// Console.WriteLine(result);

// //Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// int[] arr = new int[]{1,2,3,4,5,6,4,7,8,9};
// int i = arr.Length - 1;
// void printReturnArr(int[] array, int index)
// {
//     if(index < 0)
//     {
//         return;
//     }
//     Console.Write($"|{array[index]}|");
//     index = index - 1;
//     printReturnArr(array, index);
// }
// printReturnArr(arr, i);