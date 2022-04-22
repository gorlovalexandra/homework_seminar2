/* 2. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. */

int Number(int n)
{
    // int result = (n % 100) / 10;
    // return result;

    return (n % 100) / 10;
}

int N = Number(498);

Console.WriteLine(N);
