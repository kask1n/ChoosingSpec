/*
Задача:
Написать программу, которая из имеющегося массива строк
формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

string[] GetStringAndFillNewArray()
{
  string[] separators = { ",", " " };

  Console.WriteLine("Введите данные через запятую или пробел и нажмите Enter для создания массива:");
  string getString = Console.ReadLine()!;
  Console.WriteLine();

  string[] stringsArray = getString.Split(separators, StringSplitOptions.RemoveEmptyEntries);

  return stringsArray;
}

string[] FilterAndFillNewArray(string[] stringsArray)
{
  int filter = 3;
  int count = 0;

  for (int i = 0; i < stringsArray.Length; i++)
  {
    if (stringsArray[i].Length <= filter)
      count++;
  }

  string[] filteredArr = new string[count];
  count = 0;

  for (int i = 0; i < stringsArray.Length; i++)
  {
    if (stringsArray[i].Length <= 3)
    {
      filteredArr[count] = stringsArray[i];
      count++;
    }
  }

  return filteredArr;
}

Console.WriteLine();
string[] stringsArray = GetStringAndFillNewArray();
Console.WriteLine("Исходный массив строк: [{0}]", string.Join(", ", stringsArray));

string[] filteredArr = FilterAndFillNewArray(stringsArray);
Console.WriteLine("-> Искомый массив строк: [{0}]", string.Join(", ", filteredArr));


// The example displays the following output:

// Введите данные через запятую или пробел и нажмите Enter для создания массива:
// hello, 2, world, :-)

// Исходный массив строк: [hello, 2, world, :-)]
// -> Искомый массив строк: [2, :-)]

// -----------------------------------------------------------------------------

// Введите данные через запятую или пробел и нажмите Enter для создания массива:
// 1234, 1567, -2, computer_science

// Исходный массив строк: [1234, 1567, -2, computer_science]
// -> Искомый массив строк: [-2]

// -----------------------------------------------------------------------------

// Введите данные через запятую или пробел и нажмите Enter для создания массива:
// Russia, Denmark, Kazan

// Исходный массив строк: [Russia, Denmark, Kazan]
// -> Искомый массив строк: []