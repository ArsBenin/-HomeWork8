/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не корректое число. Введите натуральное число";

    while(true)
    {
        
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
    return result;
}

void PrintArray(int [,] matr)
{
    for (int i=0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            {
            Console.Write($"({matr[i,j]})");
            }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i=0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            {
            matr[i,j] = new Random().Next(1,10);
            }
    }
}

void MinSumLine(int[,] matr)
{
int[]sum = new int[matr.GetLength(0)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum[i]=sum[i]+matr[i,j];
        }
    }


int minIndex=0;
int min=sum[0];
for(int i = 0 ; i < matr.GetLength(0); i++)
    {
        if(min > sum[i])
        {
            min=sum[i];
            minIndex=i;
        }
    }

Console.WriteLine($"Строка с наименьшей суммой элементов №{minIndex+1}");
}


int m = GetNumber("Введите число строк массива");
int n = GetNumber("Введите число столбцов массива");
int [,] matrix = new int [m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
MinSumLine(matrix);