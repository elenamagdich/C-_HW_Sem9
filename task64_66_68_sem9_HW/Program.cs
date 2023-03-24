// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// int start = 1;
// // Concequense(number, start);


// void Concequense(int n, int start)
// {
//     if (start > n)
//     {
//         return;
//     }
//     else
//     {
//         Concequense(n, start + 1);
//         Console.Write($"{start} ");
//     }
// }


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.Write("Введите число M: ");
// int M = int.Parse(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());
// SumNumMN(M, N);

// void SumNumMN(int M, int N)
// {
//     Console.Write(SumNum(M - 1, N));
// }

// int SumNum(int M, int N)
// {
//     int result = M;
//     if (M == N) return 0;
//     else 
//     {
//         M++;
//         result = M + SumNum(M, N);
//         return result;
//     }
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Console.Write("Введите число M: ");
// int M = int.Parse(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());
// AkkermanFunction(M,N);

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
AkkermanRecurce(m,n);

void AkkermanRecurce(int m, int n)
{
    Console.Write(AkkermanNum(m, n)); 
}

int AkkermanNum(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return AkkermanNum(m - 1, 1);
    else return (AkkermanNum(m - 1, AkkermanNum(m, n - 1)));
  }