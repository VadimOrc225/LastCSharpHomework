//64
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
void Count(int N)
{
    if (N == 1)
    {
        Console.Write($"{N} "); //Делаем от 1 до N, так как от N до 1 
                                // разобрано на семинаре
    }
    else
    {
        Count(N - 1);
        Console.Write($"{N} ");
    }
}
Count(N);
