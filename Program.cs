/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все
 натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNNums(int n)  // Метод рекусивной функции для вывода чисел от n до 1
{
    Console.Write(n + "  ");
    if(n > 1)  ShowNNums(n - 1);
   // Console.Write(n + "  ");   
}
Console.WriteLine("Input size of your array");
int n = Convert.ToInt32(Console.ReadLine());
ShowNNums(n);
*/
/*
Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int SumNumsNM(int N, int M)  // Рекусивный метод вычисления суммы натуральных чисел от M до N
{
    if(M == N) return N;
    else if(N > M)
    {
        return SumNumsNM(N, (M + 1)) + M;
    }             
    return N;  
}

Console.WriteLine("Input namber N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input namber M");
int M = Convert.ToInt32(Console.ReadLine());
if(M > N) (N, M) = (M, N);
SumNumsNM(N, M);
Console.WriteLine($"The sum of digits interval: {SumNumsNM(N, M)}");
*/ 
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int AkkermannFun(int m, int n)  // Рекусивный метод вычисления функции Аккермана для натуральных чисел M, N
{
    if (m == 0) return n + 1;
    else if ((m != 0) && (n == 0))
        return AkkermannFun(m - 1, 1);
    else
        return AkkermannFun(m - 1, AkkermannFun(m, n - 1));
}
Console.WriteLine("Input namber M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input namber N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The value Ackermann function for digits M and N is: {AkkermannFun(m, n)}");