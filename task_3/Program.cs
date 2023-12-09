// Задача 3: 
//  Напишите программу, которая перевернёт одномерный массив 
//  (первый элемент станет последним, второй – предпоследним и т.д.)

// Зададим исходный массив
int[] originalArray = { 1, 2, 3, 4, 5 };
int[] reversedArray = ReverseArray(originalArray);

Console.WriteLine("Исходный массив: " + String.Join(", ", originalArray));
Console.WriteLine("Перевернутый массив: " + String.Join(", ", reversedArray));

int[] ReverseArray(int[] array)
{
  int[] newArray = new int[array.Length];
  for (int i = 0; i < array.Length; i++)
  {
    newArray[i] = array[array.Length - 1 - i];
  }
  return newArray;
}