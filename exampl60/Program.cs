/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

// Объявление массива
Console.WriteLine("Введите число слоёв массива :");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число строк массива :");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов массива :");
int t = Convert.ToInt32(Console.ReadLine());

double[,,] array1 = new double[m, n, t];

//Метод заполнения массивов случайными числами

double[,,] Сompletion(double[,,] inputMatrix, int minValue, int maxValue)
{
for (int i = 0; i < inputMatrix.GetLength(0); i++)
{
    for (int j = 0; j < inputMatrix.GetLength(1); j++)
    {
        for (int k = 0; k < inputMatrix.GetLength(2); k++)
        {
            array1[i, j, k] = new Random().Next(minValue, maxValue + 1);
        }
    }
}
return inputMatrix;
}


//Метод печати трёхмерного массива

void Printmatrix (double[,,] inputMatrix)
{
Console.WriteLine();
for (int i = 0; i < inputMatrix.GetLength(0); i++)
{
    Console.WriteLine($"Слой {i}_______");
    for (int j = 0; j < inputMatrix.GetLength(1); j++)
    {
        for (int k = 0; k < inputMatrix.GetLength(2); k++)
        {
            Console.Write($"{array1[i, j, k]} ( {i}, {j}, {k} ) \t");
        }
        Console.WriteLine();
    }   
    Console.WriteLine();
}

}


Сompletion(array1, 0, 99);
Printmatrix (array1);
