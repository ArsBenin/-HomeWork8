/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
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

void ChangeMatrix(int[,] matr)
{
    int temp=0;
for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int x = j + 1; x < matr.GetLength(1); x++)
            {
                if (matr[i,j] > matr[i,x])
                {
                temp = matr[i,x];
                matr[i,x] = matr[i,j];
                matr[i,j] = temp;
                }
            }
        }
    }
    PrintArray(matr);
}




int m = GetNumber("Введите число строк массива");
int n = GetNumber("Введите число столбцов массива");
int [,] matrix = new int [m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ChangeMatrix(matrix);