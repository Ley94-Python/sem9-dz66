// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//  Console.WriteLine("введите целое положительное число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите целое положительное число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
 
// static int SumNumbers(int m, int n)
// {
//     if (m == 0 || n == 0) 
//     {
//     return 0;
//     }
//     if (m < n || m > n)
//     {       
//         return (m * SumNumbers(m + 1, n)); 
//         Console.Write($"{m} ");
//     }
//     if (m==n)
//     {
//       Console.Write($"{m} "); 
        
//     }
// }
// SumNumbers(M, N);

static int SumNumbers(int M, int N)
{
if (M == 0) return (N * (N + 1)) / 2;            // Если M равно нулю
else if (N == 0) return (M * (M + 1)) / 2;       // Если N равно нулю
else if (M == N) return M;                       // Если M=N
else if (M < N) return N + SumNumbers(M, N - 1); // Если M<N
else return N + SumNumbers(M, N + 1);            // Если M>N
}
        
       
Console.Write("M = ");
int M = int.Parse(Console.ReadLine());
Console.Write("N = ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма, S = {SumNumbers(M, N)}");
Console.ReadLine();
        