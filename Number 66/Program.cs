// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите число");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число (больше первого)");
int N = Convert.ToInt32(Console.ReadLine());
int sum = N;
int Count(int M, int N)
{
    if (N <= M)
    return sum;
      
    return sum = (N-1) + Count(M, N-1);
    
    
}

Console.WriteLine($"Сумма равна {Count(M,N)} ");