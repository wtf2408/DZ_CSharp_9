// Задача 64: Задайте значение N. Напишите метод, который выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
System.Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumbersFromNTo1(n);
void PrintNumbersFromNTo1(int n)
{
    if (n == 1) Console.WriteLine(n);
    else
    {
        Console.Write($"{n} ");
        PrintNumbersFromNTo1(n-1);
    } 
}