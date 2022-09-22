// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

/*
void ShowNums(int m, int n)
{
    if (m >= n)
    {
        if (n < m) ShowNums(m - 1, n);
        Console.Write(m + " ");
    }
    else 
    {
        if (n > m) ShowNums(n - 1, m);
        Console.Write(n + " ");
    }
}
ShowNums(1, 9);
*/


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int Sum(int m, int n)
{
    if (m <= n) return Sum(m + 1, n) + m;
    else return 0;
}
Console.WriteLine("Enter the first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(m, n));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akerman(int n, int m)
{
    if (n == 0) return (m + 1);
    if (m == 0) return Akerman((n - 1), 1);
    return Akerman(n - 1, Akerman(n, m - 1));
}

Console.WriteLine(Akerman(2,3));