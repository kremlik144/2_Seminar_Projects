/* Задача 46. Задайте двумерный массив, размером х*у ,  заполненный случайными цифрами */

/*void FillArray(int [,] math)
{
    for(int i = 0; i < math.GetLength(0); i++)
    {
        for(int j = 0; j < math.GetLength(1); j++)
        {
            math[i,j] = new Random().Next(1,15);
        }
    }
}

void PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0) ; i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк двумерного массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int y = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[x,y];

Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();*/









/* Задача 46. Задайте двумерный массив, размером х*у , каждый элемент равен сумме его индексов, и вывести массив
на экран  */

/*void FillArray(int [,] math)
{
    for(int i = 0; i < math.GetLength(0); i++)
    {
        for(int j = 0; j < math.GetLength(1); j++)
        {
            math[i,j] = i +j;                        // ОТЛИЧИЕ ОТ ПРЕДЫДУЩЕЙ ЗАДАЧИ ТУТ :)
        }
    }
}

void PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0) ; i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк двумерного массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int y = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[x,y];

Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();*/










/* Задача 49. Задайте двумерный массив, размером х*у , найти и заменить элементы с четными индексами на квадраты
этих элементов   */

/*void FillArray(int [,] math)
{
    for(int i = 0; i < math.GetLength(0); i++)
    {
        for(int j = 0; j < math.GetLength(1); j++)
        {
            math[i,j] = new Random().Next(1,15);
        }
    }
}

void PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0) ; i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void NewArray(int [,] math)
{
    for(int i = 0; i < math.GetLength(0); i++)
    {
        for(int j = 0; j < math.GetLength(1); j++)
        {
            if ( i % 2 == 0 && j %2 == 0) math[i,j] *= math[i,j]; 
        }
    }
}


Console.Write("Введите количество строк двумерного массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int y = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[x,y];

Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
NewArray(array);
Console.WriteLine();
PrintArray(array);*/









/* Задача 49. Задайте двумерный массив, размером х*у, причем х=у, посчитайте сумму элементов по диогонали  */

/*void FillArray(int [,] math)
{
    for(int i = 0; i < math.GetLength(0); i++)
    {
        for(int j = 0; j < math.GetLength(1); j++)
        {
            math[i,j] = new Random().Next(1,9);
        }
    }
}

void PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0) ; i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int NewArray(int [,] matr)
{
    int summ = 0;
    for (int i = 0; i < matr.GetLength(0) ; i++)
    {
        summ += matr[i,i];
    }
    return summ;
}


Console.Write("Введите количество строк двумерного массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int y = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[x,y];

Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов по диогонали = {NewArray(array)}");*/