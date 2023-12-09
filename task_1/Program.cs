// Задача 1:
// Напишите программу, которая бесконечно запрашивает 
// целые числа с консоли. Программа завершается 
// при вводе символа ‘q’ или при вводе числа,
// сумма цифр которого чётная.

while (true)
{
  Console.WriteLine("Введите число или `q` для выхода:");
  string? input = Console.ReadLine();

  if (input == "q")
  {
    break;
  }

  // Пробуем преобразовать строку в число
  if (int.TryParse(input, out int number))
  {
    // Если преобразование прошло успешно,
    //  проверяем является ли сумма цифр четной
    if (IsSumOfDigitsEven(number))
    {
      Console.WriteLine("Сумма цифр четная, программа завершена.");
      break;
    }
  }
  else
  {
    // Сообщаем пользователю, если введено не число
    Console.WriteLine("Введено не число. Пожалуйста, введите целое число.");
  }
}

bool IsSumOfDigitsEven(int number)
{
  int sum = 0;
  while (number > 0)
  {
    // Добавляем последнюю цифру к сумме
    sum += number % 10;
    number /= 10;
  }

  return sum % 2 == 0;
}
