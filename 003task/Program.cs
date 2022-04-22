/* 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно первому числу, то программа выводит остаток от деления. */

void Method(int numA, int numB)
{
    if (numB % numA == 0)
    {
        Console.WriteLine("yes");
    }
    else
    {
        int remains = numB / numA;
        Console.WriteLine("no, remains " + remains);
    }
}

Method(5, 36);
Console.WriteLine();
