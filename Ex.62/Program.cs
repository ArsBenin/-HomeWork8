/*
Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/

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
        int number = 1;
        int columns = matr.GetLength(0);
        int line = matr.GetLength(1);
        for (int y = 0; y < line; y++) 
        {
            matr[0,y] = number;
            number++;
        }
        for (int x = 1; x < columns; x++) 
        {
            matr[x,line - 1] = number;
            number++;
        }
        for (int y = line - 2; y >= 0; y--) 
        {
            matr[columns - 1,y] = number;
            number++;
        }
        for (int x = columns - 2; x > 0; x--) 
        {
            matr[x,0] = number;
            number++;
        }
//периметр заполнен
        
//точка начала заполнения внутри
int i = 1;
int j = 1;
 
        while (number < columns * line) 
        {
//вправо
            while (matr[i,j + 1] == 0) 
            {
                matr[i,j] = number;
                number++;
                j++;
            }
 
//вниз
            while (matr[i + 1,j] == 0) {
                matr[i,j] = number;
                number++;
                i++;
            }
 //влево
            while (matr[i,j - 1] == 0)
            {
                matr[i,j] = number;
                number++;
                j--;
            }
 //вверх
            while (matr[i - 1,j] == 0) 
            {
                matr[i,j] = number;
                number++;
                i--;
            }
        }
 
//Заполняем последнюю ячейку
        for (int x = 0; x < columns; x++)
        {
            for (int y = 0; y < line; y++) 
            {
                if (matr[x,y] == 0) {
                    matr[x,y] = number;
                }
            }
        }
 
}    


int [,] matrix = new int [4, 4];
FillArray(matrix);
PrintArray(matrix);
