/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

// создает рандомный двумерный массив double
double[,] RandomArrayDouble (int firstArrayQuantity, int secondArrayQuantity, int minimum, int maximum, int accuracy) {
    double[,] array = new double[firstArrayQuantity, secondArrayQuantity];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * (maximum - minimum) + minimum;
            array[i, j] = Math.Round(array[i, j], accuracy);
        }
    }

    return array; 
}

// возвращает строку из двумерного массива double
string ArrayDoubleToString(double[,] arr){
    string result = string.Empty;

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {            
            result = result + $"{arr[i, j]} ";
        }
        result = result + $"\n";
    }

    return result;
}

// создаем массив
int m = 3, n = 4;
double[,] matrix = RandomArrayDouble(m,n,-10,10,1);

// выводим решение
System.Console.WriteLine($"m = {m}, n = {n}.");
System.Console.WriteLine($"{ArrayDoubleToString(matrix)}");


/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 
17 -> такого числа в массиве нет */

// создает рандомный двумерный массив int
int[,] RandomArray (int firstArrayQuantity, int secondArrayQuantity, int minimum, int maximum) {
    int[,] array = new int[firstArrayQuantity, secondArrayQuantity];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minimum,maximum+1);
        }
    }

    return array; 
}

// возвращает строку из двумерного массива int
string ArrayIntToString(int[,] arr){
    string result = string.Empty;

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {            
            result = result + $"{arr[i, j]} ";
        }
        result = result + $"\n";
    }

    return result;
}

// принимаем индексы строки и столбца
System.Console.Write("Введите индекс строки ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите индекс столбца ");
int y = Convert.ToInt32(Console.ReadLine());

// создаем массив
int[,] matrix = RandomArray(5,4,-10,10);

// выводим массив
System.Console.WriteLine();
System.Console.WriteLine($"{ArrayIntToString(matrix)}"); 

// проверяем не превышают ли введенные индексы размеры массива
// и выводим решение
if (x < matrix.GetLength(0) && y < matrix.GetLength(1))
{
    System.Console.WriteLine($"{x}, {y} -> {matrix[x, y]}");
} else {
    System.Console.WriteLine($"{x}, {y} -> такого числа в массиве нет");
}


/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

// создает рандомный двумерный массив int
int[,] RandomArray (int firstArrayQuantity, int secondArrayQuantity, int minimum, int maximum) {
    int[,] array = new int[firstArrayQuantity, secondArrayQuantity];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minimum,maximum+1);
        }
    }

    return array; 
}

// возвращает строку из двумерного массива int
string ArrayIntToString(int[,] arr){
    string result = string.Empty;

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {            
            result = result + $"{arr[i, j]} ";
        }
        result = result + $"\n";
    }

    return result;
}

// создаем массив
int[,] matrix = RandomArray(3,4,1,10);

// выводим массив
System.Console.WriteLine();
System.Console.WriteLine($"{ArrayIntToString(matrix)}"); 

System.Console.Write($"Среднее арифметическое каждого столбца: ");

for (int i = 0; i < matrix.GetLength(1); i++)
{
    double summ = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        summ = summ + matrix[j, i];
    }
    System.Console.Write($"{summ}, ");
}