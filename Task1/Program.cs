// Задача № 1 Семинар 3
// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,90].

// Начальные условия:

// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
// Выводится: 5

int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
int count = 0;
foreach (int number in array)
{
    if (number >= 10 && number <= 90)
    {
        count++;
    }
    return count;
}



// Пример разворота числа
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int reversalNum = 0;
// while (num != 0)
// {
// reversalNum = reversalNum * 10 + num % 10;
// num /= 10;
// }
// Console.WriteLine(reversalNum);
