/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SumOfNumbersBetween(int m, int n)
{
    if(m == n)
    {
        return m;
    }
    return m + SumOfNumbersBetween(m + 1, n);
}

int res = SumOfNumbersBetween(2, 5);
System.Console.WriteLine(res);