// Задача 56.Задайте прямоугольный двумерный массив. Напишите программу которая будет находить строку с наименьшей суммой элементов

int Promt (string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine()!;
    int result = int.Parse (ReadInput);
    return result;
}

//Создание массива 
int [,] GenerateArray(int row1, int colmn1, int maxValue, int minValue)
{
    int [,] array = new int[row1, colmn1];
    Random random = new Random();
    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < colmn1; j++)
        {
            array[i, j] = random.Next(minValue, maxValue);
        }
    }
    return array;
}


// Метод вывода массива
void PrintArray(int[,] array)
{
    int length_0 = array.GetLength(0);
    int length_1 = array.GetLength(1);
        for (int i = 0; i < length_0; i++)
    {
        for (int j = 0; j < length_1; j++)
        { Console.Write($"{array[i, j]}  "); };
        Console.WriteLine();
    }

    
}

// метод вычисления суммы элементов строк и нахождение строки с минимальным значением

void Arithmetic_mean(int[,] array)
{
    int length_0 = array.GetLength(0);
    int length_1 = array.GetLength(1);
    int[] array_summ = new int[length_0];
    for (int i = 0; i < length_0; i++)
    {
        int tmp = 0;
        for (int j = 0; j < length_1; j++) tmp = tmp + array[i, j];
        array_summ[i]=tmp;
        Console.WriteLine($"Сумма элементов {i+1}-ой строки равно {array_summ[i]}"); 
    }
    int min = array_summ[0];
    int f_min = 0;
    for (int f = 0; f < length_0; f++) 
    {
        if (min > array_summ[f]) {min = array_summ[f];f_min = f;}
    }
    Console.WriteLine($"{f_min+1}-я строка имеет наименьшее зхначение суммы элементов = {min}");
}



int row = Promt("Введите количество строк  :");
int colmn = Promt("Введите количество столбцов  :");

int min = Promt("Введите минимальное значение для массива  :");
int max = Promt("Введите максимальное значение для массива  :");


int [,] array = GenerateArray(row, colmn, max, min);
PrintArray(array);
Arithmetic_mean(array);
