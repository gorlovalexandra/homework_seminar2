/* 5. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого. */

void Square(int a, int b)
{
    if (a == b * b || b == a * a)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}

Square(8, 9);
Console.WriteLine();
