// Задача 2:
//  Задайте массив заполненный случайными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// Установим размер массива
int size = 5;
int[] array = new int[size];
Random random = new Random();

// Заполняем массив случайными трехзначными числами
for(int i = 0; i < array.Length; i++)
{
  array[i] = random.Next(100,1000);
}

// Выводим массив
PrintArray(array);

// Подсчитываем количество четных чисел
int evenCount = 0;
foreach (int number in array)
{
  if (number % 2 == 0)
  {
    evenCount++;
  }
}

// Выведем результат
Console.WriteLine($"Количество четных числе в массиве: {evenCount}");

void PrintArray(int[] array)
{
  Console.WriteLine("[" + string.Join(", ", array) + "]");
}



