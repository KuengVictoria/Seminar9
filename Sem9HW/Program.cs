// Семинар 9 Задача1 Задайте значения N. Написать программу ,
// которая выведет все натуральные числа в промежутке от N до 1.
//Рекурсия

/*void displayNumbers(int n)
{
    if (n > 1)
    {
        Console.Write(n + ", ");
        displayNumbers(n - 1);
    }
    else if (n == 1)
        Console.Write(n);
}

Console.WriteLine("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

displayNumbers(n);
*/

// Задача2 Задать значения М и N. Написать программу, которая найдет сумму 
// натуральных элементов в промежутке от м до N.

/*int sumBetween(int m, int n)
{
    if (m <= n)
        return sumBetween(m+1, n) + m;
    else
        return 0;
            
}

Console.WriteLine("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(sumBetween(m, n));
*/
// Задача 3 Напишите программу вычисления функций Аккермана с помощью рекурсии.
//Данны два неотрицательных числа m и n.

/*int Ackermann(int m, int n)
{
    if (m > 0)
    {
        if (n > 0)
            return Ackermann(m - 1, Ackermann(m, n - 1));
        else if (n == 0)
            return Ackermann(m - 1, 1);
    }
    else if (m == 0)
    {
        if (n >= 0)
            return n + 1;
    }

    throw new System.ArgumentOutOfRangeException();
}

Console.WriteLine("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Ackermann(m, n));
*/