/* 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. */

void Number(int N)
{
    if (N % 7 == 0 && N % 23 == 0)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}

Number(14);
Console.WriteLine();
