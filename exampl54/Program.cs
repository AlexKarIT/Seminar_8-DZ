/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


// Объявление массива
Console.WriteLine("Введите число строк массива :");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов массива :");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array1 = new double[m, n];

Console.WriteLine("Введите максимальное значение которое может принять элемент массива :");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное значение которое может принять элемент массива :");
int minValue = Convert.ToInt32(Console.ReadLine());

//Заполнение массива

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array1[i, j] = new Random().Next(minValue, maxValue + 1);
    }
}


//Симпатичный вывод массива

void Printmatrix(double[,] inputMatrix)
{
    Console.WriteLine();
    Console.WriteLine("Полученный массив :");

    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            String text = Convert.ToString(inputMatrix[i, j]);
            int L = text.Length;
            Console.Write(" |" + new string(' ', 5 - L) + inputMatrix[i, j]);
        }
        Console.WriteLine();
        Console.WriteLine(new string('-', inputMatrix.GetLength(1) * 7));
    }

}

Printmatrix(array1);

//метод упорядочивания строки по убыванию

double[,] Sort(double[,] inputMatrix, int line)
{
    for (int j = 0; j < inputMatrix.GetLength(1) - 1; j++)
    {
        double max = inputMatrix[line, j];

        for (int i = j; i < inputMatrix.GetLength(1); i++)
        {
            double temp = 0;
            if (inputMatrix[line, i] > max)
            {
                max = inputMatrix[line, i];
                temp = inputMatrix[line, i];
                inputMatrix[line, i] = inputMatrix[line, j];
                inputMatrix[line, j] = temp;
            }

        }

    }
    return inputMatrix;
}

for (int k = 0; k < m; k++)
{
    Sort(array1, k);
}

Console.WriteLine();
Console.WriteLine("Упорядочиваем строки массива по убыванию ");

Printmatrix(array1);
