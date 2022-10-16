/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16

Вариант 1 (без использования Pow).

Console.WriteLine ("Введите число А: ");
int A = int.Parse (Console.ReadLine ()!);
Console.WriteLine ("Введите число B: ");
int B = int.Parse (Console.ReadLine ()!);

if (B <= 0)
{
    Console.WriteLine ($"Число {B} не является натуральным");
}
else
{
    Console.WriteLine ($"Число {A} в степени {B} составляет {GetDegree(A, B)}");
}

int GetDegree (int number, int degree)
{
    int res = 1;
    for (int i = 1; i <= degree; i++)
    {
        res = res * number;
    }
    return res;
}

Вариант 2 (с использованием Pow).

Console.WriteLine ("Введите число А: ");
int A = int.Parse (Console.ReadLine ()!);
Console.WriteLine ("Введите натуральное число B: ");
int B = int.Parse (Console.ReadLine ()!);

if (B <= 0)
{
    Console.WriteLine ($"Число {B} не является натуральным");
}
else
{
    Console.WriteLine ($"Число {A} в степени {B} составляет {GetDegree(A, B)}");
}

int GetDegree (int number, int degree)
{
    int res = Convert.ToInt32(Math.Pow(number, degree));
    return res;
}
*/
/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

Вариант 1 (математически)

Console.WriteLine ("Введите любое положительное число: ");
int N = int.Parse (Console.ReadLine ()!);
if (N < 0)
{
    Console.WriteLine ($"Число {N} не является положительным");
}
else
{
    Console.WriteLine ($"Сумма цифр в числе {N} составляет {AccFig(N)}");
}

int AccFig (int number)
{
    int count = 0;
    do
    {
        number = number / 10;
        count++;
    }
    while (number > 0);
    return count;
}

Вариант 2 (через строки)

Console.WriteLine ("Введите любое положительное число: ");
string N = Console.ReadLine ()!;

if (N[0] == '-') Console.WriteLine ($"Число {N} не является положительным");
else Console.WriteLine ($"Сумма цифр в числе {N} составляет {N.Length}");
*/
/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

Вариант 1

int[] array = GetArray(8, -10, 50); 
Console.WriteLine ($"[{String.Join(", ", array)}]"); 

int[] GetArray (int size, int minValue, int maxValue) 
{ 
    int[] res = new int[size]; 

    for (int i = 0; i < size; i++) 
    { 
        res[i] = new Random().Next(minValue, maxValue + 1); 
    } 
    return res; 
}

Вариант 2

int[] array = new int[8]; 
FillArray(array); 
PrintArray(array); 
Console.WriteLine(); 

void FillArray(int[] collection) 
{ 
    int length = collection.Length; 
    int index = 0; 

    while (index < length) 
    { 
        collection[index] = new Random().Next(-10, 50); 
        index++; 
    } 

} 

void PrintArray(int[] col) 
{ 
    int count = col.Length; 
    int position = 0; 
    Console.Write("[");
    while(position < (count - 1)) 
    { 
        Console.Write($"{col[position]}, "); 
        position++; 
    }
    Console.Write($"{col[count -1]}]");
}
*/