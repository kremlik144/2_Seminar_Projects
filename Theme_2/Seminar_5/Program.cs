/*Задача 1 пользователь вводит размерность массива, генерируется массив из случайных чисел от -9 до 10,
после чего в переменные записываются значания всех положительных и отрицательных элементов
массива соответственно и эти переменные выводятся на экран 
void PrintArray(int [] col)
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
int positive_sum = 0;
int negative_sum = 0;
for(int i = 0; i < sitze; i++)
{
    array[i] = new Random().Next(-9, 10);
    if(array[i] > 0) positive_sum += array[i];
    else negative_sum += array[i];
}
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел массива = {positive_sum}");
Console.WriteLine($"Сумма отрицательных чисел массива = {negative_sum}");*/








/*Задача 2 пользователь вводит размерность массива, генерируется массив от -9 до 10, после чего выводиться этот
массив на экран, а за ним выводится массив где все цифры заменены на противоположные, т.е. -1 = 1
void PrintArray(int [] col)
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
    array[i] = new Random().Next(-9, 10);
}
PrintArray(array);
for(int i = 0; i < array.Length; i++) array[i] = array[i] * -1;
Console.WriteLine();
PrintArray(array);*/







/*Задача 3 Задаем массив и определяем, присутствует ли заданное число в массиве
void PrintArray(int [] col)
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
Console.Write("Введите число которое ищите в сгенерируемом массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 0;
bool flag = false;
int [] array = new int[sitze];
for(int i = 0; i < sitze; i++)
{
    array[i] = new Random().Next(0, 10);
    if (array[i] == number) 
    {
        index = i;
        Console.WriteLine($"Искомое число есть, под индексом: {index}");
        flag = true;
    } 
}
if (flag == false) Console.WriteLine("Такого числа нет");
PrintArray(array);*/








/*Задача 4 задайте массив из 123 случайных чисел и найдите количество элементов, значения которых
лежат в отрезке [10, 99] 
Console.Write("Введите размерность массива N: ");
int sitze = Convert.ToInt32(Console.ReadLine());
int result = 0;
int [] array = new int[sitze];
for(int i = 0; i < sitze; i++)
{
    array[i] = new Random().Next(0,123);
}
for(int i = 0; i < array.Length; i++)
{
    if(array[i] >= 10 && array[i] <= 99) result++;
}
Console.WriteLine($"Количество вхождений равно: {result}");*/







/* Задача 5 НЕ ДОДЕЛАНА найдите произведение пар чисел в одномерном массиве, пара это первый и последний элемент, второй
и предпоследний. Записать это все в новый массив 
void PrintArray(int [] col)
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
int sitze_result = 0;
if(sitze % 2 == 0) sitze_result = sitze/2;
if(sitze == 3) sitze_result = sitze-1;
if(sitze % 2 != 0) sitze_result = sitze-2;
int [] array = new int[sitze];
int [] result_array = new int[sitze_result];
int index = 1;
for(int i = 0; i < sitze; i++)
{
    array[i] = new Random().Next(1,10);
}
for(int i = 0; i <(sitze/2); i++)
{
    result_array[i] = array[i] * array[^index];
    index++;
}
if(sitze % 2 != 0)
{
    result_array[result_array.Length -1] = array[(array.Length/2)-1] * array[(array.Length/2)-1];
}
Console.Write("Заданный массив : ");
PrintArray(array);
Console.WriteLine();
Console.Write("Новый массив : ");
PrintArray(result_array);*/