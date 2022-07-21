/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
*/

void PrintArray(int [,,] matr)
{
    for (int x=0; x < matr.GetLength(0); x++)
    {
        for (int y = 0; y < matr.GetLength(1); y++)
            {
                for(int z = 0; z < matr.GetLength(1); z++)
            Console.Write($"{matr[x,y,z]}({x},{y},{z})   ");
            Console.WriteLine();
            }
    }
}

void FillArray(int[,,] matr)
{
    int amountElements = matr.GetLength(0) * matr.GetLength(1) * matr.GetLength(2);
    int[] exammatrix = new int [amountElements];
    Random rnd = new Random();
    for(int i =0; i < exammatrix.Length; i++)
    {
        while(true)
        {
            int number = rnd.Next(10,100);
            if(!exammatrix.Contains(number))
            {
                exammatrix[i] = number;
                break;
            }
        }
    }
    
    int count = 0;

    for(int i = 0; i < matr.GetLength(0);i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            for(int z = 0; z < matr.GetLength(2); z++)
            {
                matr[i, j, z] = exammatrix[count];
                count++;
            }
        }
    }
}

int [,,] matrix = new int [2,2,2];
FillArray(matrix);
PrintArray(matrix);