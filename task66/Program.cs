// Задача 66: Задайте значения M и N. Напишите метод, который найдёт сумму натуральных элементов в промежутке от M до N. Через рекурсию!

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30
System.Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumElementsFromMToN(m, n)); 
int SumElementsFromMToN(int m, int n)
{
    if(m == n) return n;
    else return n + SumElementsFromMToN(m,n-1);
}