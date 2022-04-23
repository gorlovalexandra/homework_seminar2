/* 8. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. */

void WeekDay(int N)
{
    int Sat = 6;
    int Sun = 7;

    if (N < Sat)
    {
        Console.WriteLine("NO");
    }
    if (N > Sun)
    {
        Console.WriteLine("No weekday with this number");
    }
    if (N == Sat || N == Sun)
    {
        Console.WriteLine("YES");
    }
}

WeekDay(10);
Console.WriteLine();
