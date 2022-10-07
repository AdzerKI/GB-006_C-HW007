

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
    System.Console.Write($"{summ / matrix.GetLength(0)}, ");
}