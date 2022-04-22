/* 1. Напишите метод, который выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. */

int Random(int a, int b)
{
    int number = new Random().Next(a, b);
    return number;
}

int Max(int num)
{
    int num1 = num / 10;
    int num2 = num % 10;
    int max = 0;

    if (num1 > num2) max = num1;
    if (num1 < num2) max = num2;

    return max;
}

int N = Random(10, 100);
Console.WriteLine(N);

int max = Max(N);
Console.WriteLine(max);
