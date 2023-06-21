// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void PrintNumbers(int n)
{
    if (n > 1)
    {
        System.Console.Write($"{n}, ");
        PrintNumbers(n - 1);
    }
    if (n == 1)
        System.Console.WriteLine(1);
}

System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumbers(n);
/////////////////////////////////////////////////////////////////////////////////////////////////////




// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
void FindSum(int m, int n)
{

    if (m<=n)
    {
    sum +=m;
    FindSum(m+1,n);
    }
}
FindSum(m,n);
System.Console.WriteLine(sum);


////////////////////////////////////////////////////////////////////////////////////////////////////////////



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int k =0;
int Akk(int n, int m)
{
    k++;
    if (n == 0)
        return m + 1;
    if (m==0)
          return Akk(n - 1, 1);
            return Akk(n - 1, Akk(n, m - 1));
}

System.Console.WriteLine("Введите число M: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akk(n, m));
