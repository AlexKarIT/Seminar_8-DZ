/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/



// Объявление массивов
Console.WriteLine("Введите число строк первого массива :");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов первого массива :");
int n1 = Convert.ToInt32(Console.ReadLine());

int m2 = n1;
Console.WriteLine($"Число строк второго массива принято равным числу столбцов первого: {m2}");

Console.WriteLine("Введите число столбцов второго массива :");
int n2 = Convert.ToInt32(Console.ReadLine());

double[,] array1 = new double[m1, n1];
double[,] array2 = new double[m2, n2];

//Метод заполнения массивов случайными числами

double[,] Сompletion(double[,] inputMatrix, int minValue, int maxValue)
{

    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            inputMatrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return inputMatrix;
}
//Симпатичный вывод массива

void Printmatrix(double[,] inputMatrix)
{

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

Сompletion(array1, 0, 10);
Сompletion(array2, 0, 10);

Console.WriteLine();
Console.WriteLine("Массив №1 :");
Printmatrix(array1);

Console.WriteLine();
Console.WriteLine("Массив №2 :");
Printmatrix(array2);


// Метод перемножения 2-х массивов

double[,] Сomposition(double[,] inputMatrix1, double[,] inputMatrix2)
{
    double[,] СompMatrix = new double[inputMatrix1.GetLength(0), inputMatrix2.GetLength(1)];
    for (int i = 0; i < inputMatrix1.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix2.GetLength(1); j++)
        {
            double Res = 0; //Сумма произведений для каждой ячейки
            for (int k = 0; k < inputMatrix1.GetLength(1); k++)
            {
                Res += inputMatrix1[i, k] * inputMatrix2[k, j];
                СompMatrix[i, j] = Res;
            }

        }
    }

    return СompMatrix;
}

double[,] array3 = Сomposition(array1, array2);

Console.WriteLine();
Console.WriteLine("Массив произведения :");
Printmatrix(array3);