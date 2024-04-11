﻿int n = 5; // размер массива равен 5
int[] array = { 20, 4, 7, 100, 90 }; // Массив чисел
int i = 0; // Индекс для перебора элементов массива
int max = array[0]; // Начальное значение максимального элемента (первый элемент массива)

while (i < n) // Пока индекс меньше размера массива
{
    if (array[i] > max) // Если текущий элемент больше текущего максимального
    {
        max = array[i]; // Обновляем максимальное значение
    }
    i = i + 1; // Переходим к следующему элементу массива
}
Console.WriteLine(max); // Выводим максимальное значение

max = array[0]; // Начальное значение максимального элемента (первый элемент массива)
for (int j = 0; j < n; j++) // Для каждого элемента массива
{
    if (array[j] > max) // Если элемент больше текущего максимального
    {
        max = array[j]; // Обновляем максимальное значение
    }
}
Console.WriteLine(max); // Выводим максимальное значение

max = array[0]; // Начальное значение максимального элемента (первый элемент массива)
foreach (int e in array) // Для каждого элемента массива
{
    if (e > max) // Если элемент больше текущего максимального
    {
        max = e; // Обновляем максимальное значение
    }
}
Console.WriteLine(max); // Выводим максимальное значение