/*Задача 53 Задайте двумерный массив, напишите программу которая поменяет местами
первую и последнюю строчку массива */

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

void NewFillArray(int [,] math, int[,] NewMath, int x, int y)
{
    for(int i = 0; i < x; i++)
    {
        if(i == 0)
        {
            for(int j = 0; j < y; j++)
            {
                NewMath[i,j] = math[x-1,j];
            }
        }

        if(i == x-1)
        {
            for(int j = 0; j < y; j++)
            {
                NewMath[i,j] = math[0,j];
            }
        }    

        if(i > 0 && i < x-1)
        {
            for(int j = 0; j < y; j++)
            {
                NewMath[i,j] = math[i,j];
            }
        } 
        
    }
}


Console.Write("Введите количество строк двумерного массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int y = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[x,y];
int [,] NewArray = new int[x,y]; 

Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
NewFillArray(array, NewArray, x, y);
Console.WriteLine();
PrintArray(NewArray);*/





/*Задача 53 Задайте двумерный массив, напишите программу которая поменяет местами
строки и столбцы, если это невозможно нужно вывести соответствующее сообщение */

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

void NewArr(int [,] matr, int [,] arr)
{
    for (int i = 0; i < matr.GetLength(0) ; i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[i,j] = matr[j,i];
        }
    }
}

Console.Write("Введите количество строк двумерного массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int y = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[x,y];
int [,] NewArray = new int[x,y]; 


try
{
    Console.WriteLine("-------");
    FillArray(array);
    PrintArray(array);
    Console.WriteLine("-------");
    NewArr(array,NewArray);
    PrintArray(NewArray);
}
catch
{
    Console.WriteLine("Числа размерности должны быть равны чтобы распечатать измененную матрицу ");
}*/






/*Задача 57 Cоставить частотный словарь элементов двумерного массива. Частотный словарь содержит 
информацию о том, сколько раз встречается элемент входных данных */

/*void FillArray(int [,] math)
{
    for(int i = 0; i < math.GetLength(0); i++)
    {
        for(int j = 0; j < math.GetLength(1); j++)
        {
            math[i,j] = new Random().Next(1,7);
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

void CountChar(int [,] matr, int number, List<int> numList)
{
    int count = 0;
    for (int i = 0; i < matr.GetLength(0) ; i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(matr[i,j] == number) count++;         
        }
    }
    numList.Add(number);
    Console.WriteLine($"Число {number} встречается в массиве {count} раз");
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

List<int> numList = new List<int>();

for (int i = 0; i < x ; i++)
{
    for (int j = 0; j < y; j++)
    {
        if(numList.Contains(array[i,j]) == false) CountChar(array, array[i,j], numList);
    }
}*/


















