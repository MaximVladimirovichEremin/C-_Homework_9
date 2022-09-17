// ДЗ семинар 9 

// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

// //Запрос данных от пользователя
// int ReadData(string line){
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "1");
//     return num;
// }


// //Рекурсия числа от M до N
// string RecursOneToN(int m, int n){
//     if (n < m){
//         return "";
//     }
//     else
//     {
//         string outLine = RecursOneToN(m,n - 1) + ", " + n;
//         return outLine;
//     }
// }

// //Вывод результата
// void PrintData(string prefix, string num){
//     Console.WriteLine(prefix + num);
// }


// int inputNumber1 = ReadData("Введите число M:");
// int inputNumber2 = ReadData("Введите число N:");
// string outLine = RecursOneToN(inputNumber1, inputNumber2);
// PrintData("Числа от M до N: ", outLine);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// //Запрос данных от пользователя
// int ReadData(string line){
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "1");
//     return num;
// }


// //рекурсивная функция нахождения суммы чисел от от M до N.
// int Sum(int m, int n){
//     if (n < m){
//         return 0;
//     }
//     else
//     {
//         int sum = Sum(m,n - 1) + n;
//         return sum;
//     }
// }

// //Вывод результата
// void PrintData(string prefix, int num){
//     Console.WriteLine(prefix + num);
// }


// int inputNumber1 = ReadData("Введите число M:");
// int inputNumber2 = ReadData("Введите число N:");
// int sum = Sum(inputNumber1, inputNumber2);
// PrintData("Сумма натуральных чиселот M до N = ",sum);



// // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// //m = 2, n = 3 -> A(m,n) = 29

// //Запрос данных от пользователя
// int ReadData(string line){
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "1");
//     return num;
// }
// ///Метод вычисления функции Аккермана:
// int AckermannFunction (int m, int n){
//     if (m == 0) return n + 1;
//     if (m != 0 && n == 0) return AckermannFunction(m - 1, 1);
//     if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//     return AckermannFunction(m, n);
// }

// //Вывод результата
// void PrintData(string prefix, int num){
//     Console.WriteLine(prefix + num);
// }

// int inputNumber2 = ReadData("Введите число M:");
// int inputNumber1 = ReadData("Введите число N:");
// int akker= AckermannFunction(inputNumber1, inputNumber2);
// PrintData("Сумма натуральных чиселот M до N = ",akker);



