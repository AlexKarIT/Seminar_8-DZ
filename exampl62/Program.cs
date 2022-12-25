/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


//Симпатичный вывод массива

void Printmatrix(int[,] inputMatrix)
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


// Объявление массива
Console.WriteLine("Введите число строк массива :");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов массива :");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[m, n];


// Заполнение змейкой

int count = 0;
int X = 0;
int Y = 0;
string direction = "line";
int directionX = 1; //направление вправо
int directionY = 1; //направление вниз
int Xlenght = array1.GetLength(1);  //начальный диапазон прохода по горизонтали
int Ylenght = array1.GetLength(0);   //начальный диапазон прохода по вертикали

while (count < array1.Length - 1)
{

    //проход по горизонтали
    if (direction == "line")
    {
        for (int i = 0; i < Xlenght - 1; i++)
        {
            if (array1[X, Y] == 0)
            {
                count++;
                array1[X, Y] = count;
                Y += directionX;
            }
        }
        if (count > array1.GetLength(1)) Xlenght--;      //уменьшаем диапазон (кроме первого прохода)     
        directionX *= -1;                                 //меняем направление
    }

    //проход по вертикали
    if (direction == "column")
    {
        for (int i = 0; i < Ylenght - 1; i++)
        {
            if (array1[X, Y] == 0)
            {
                count++;
                array1[X, Y] = count;
                X += directionY;
            }
        }
        Ylenght--;                                      //уменьшаем диапазон     
        directionY *= -1;                                //меняем направление
    }

    //горизонталь < > вертикаль
    if (direction == "column") direction = "line";
    else direction = "column";
}

array1[X, Y] = array1.Length; //заполняем последний элемент

Printmatrix(array1);