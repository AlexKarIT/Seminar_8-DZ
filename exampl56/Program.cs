/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

//Метод вычисления суммы элементов строк

double SumLine(double[,] inputMatrix, int line)
{
    double sum = 0;
    for (int i = 0; i < inputMatrix.GetLength(1); i++)
    {
        sum += inputMatrix[line, i];
    }

    return sum;
}

//поиск строки с меньшей суммой

int min = m - 1;
double Sum = SumLine(array1, m - 1);
for (int i = m - 2; i >= 0; i--)
{
    if (SumLine(array1, i) <= Sum)
    {
        min = i;
        Sum = SumLine(array1, i);
    }
}

//вишенка... дописал поиск строк, в которых такое же значение суммы
Console.WriteLine($"Наименьшая сумма элементов в {min + 1} строке");

for (int i = min + 1; i < m; i++)
{
    if (SumLine(array1, i) == Sum) Console.Write($", столько же в {i + 1} ");
}