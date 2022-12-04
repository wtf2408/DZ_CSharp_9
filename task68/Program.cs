// Задача 68: Напишите метод вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29
System.Console.Write("Введите M: ");
long m = Convert.ToInt64(Console.ReadLine());
System.Console.Write("Введите N: ");
long n = Convert.ToInt64(Console.ReadLine());
Console.WriteLine(AckermanFunction(m,n));
long AckermanFunction(long m, long n)
{
    if(m == 0) return n+1;
    if(m > 0 && n == 0) return AckermanFunction(m -1 , 1);
    else /*(m > 0 && n > 0)*/ return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}