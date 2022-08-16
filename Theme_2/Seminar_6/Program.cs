/* Задача №39 Задан массив, перевернуть его и вывести на экран */

/*void PrintArray(int [] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}
Console.Write("Введите размерность массива N: ");
int sitze = Convert.ToInt32(Console.ReadLine());
int [] array = new int[sitze];
for(int i = 0; i < sitze; i++)
{
    array[i] = new Random().Next(1, 10);
}
int [] ResultArray = new int[sitze];
int index = 0;
for(int i = sitze-1; i >= 0; i--)
{
    ResultArray[index] = array[i];
    index++;
}
PrintArray(array);
Console.WriteLine();
PrintArray(ResultArray);*/







/* Задача №40 напишите программу которая принимает на вход 3 числа и проверяет, может ли существовать
треугольник со сторонами такой длинны */

/*Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());
if((a+b) > c && (a+c) > b && (c+b) > a) Console.WriteLine($"Теугольник со сторонами {a}, {b}, {c} - существует");
else Console.WriteLine($"Теугольник со сторонами {a}, {b}, {c} - НЕ СУЩЕСТВУЕТ");*/









/* Задача 42 Напишите программу которая будет преобразовывать число из десятичного в двоичное*/

/*Console.Write("Введите число N, которое хотите преобразовать: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = "";
while(number > 0)
{
    result = (number % 2) + result;
    number /= 2;
}
Console.WriteLine(result);*/








/* Задача 45 с клавиатуры задается размер двумерного массива, найти максимум и минимум и их индексы, и 
среднеарифметическое; массив формируется произвольно и вывести двумерный массив на экран */

/*void PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0) ; i++)   // matr.GetLength(0) = 3 количество строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // matr.GetLength(1) = 4 количество столбцов
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int [,] matr)
{
    
    for (int i = 0; i < matr.GetLength(0) ; i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,100);           
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int y = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[x,y];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
int max = matrix[0,0];
int min = matrix[0,0];
int x1 = 0;
int x2 = 0;
int y1 = 0;
int y2 = 0;
int count = 0;
int arifm = 0;
for(int i=0; i < matrix.GetLength(0); i++)
{
    for(int j=0; j < matrix.GetLength(1); j++)
    {
        if(matrix[i,j] > max)
        {
            max = matrix[i,j];
            x1 = i;
            y1 = j;
        }
        if(matrix[i,j] < min)
        {
            min = matrix[i,j];
            x2 = i;
            y2 = j;
        }
    
        
        arifm += matrix[i,j];
        count++;
    }
}
double result = arifm / count;
Console.WriteLine($"Максимальное число массива = {max}; строка: {x1+1} столбец: {y1+1}");
Console.WriteLine($"Минимальное число массива = {min}; строка: {x2+1} столбец: {y2+1}");
Console.WriteLine($"Среднеарифметическое  массива = {result}");*/