/* 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] 
*/

bool Check(int numberRows)
{
 return numberRows > 0;
}

void PrintArray(string[] arr)
{
 int count = arr.Length;
 int position = 0;
 Console.Write("[");
 while (position < count)
 {
  Console.Write("'"+ arr[position] + "'");
  position++;
 }
 Console.Write("]");
}

int NumberElem(string[] array, int symb)
{
 int count = 0;
 for (int i = 0; i < array.Length; i++)
 {
  if (array[i].Length <= symb) count++;
 }
 return count;
}

string[] ArrayThreeSymbChar(string[] array, int symb, int res)
{
 string[] resultArray = new string[res];
 int indexOfResultArray = 0;
 for (int i = 0; i < array.Length; i++)
 {
  if (array[i].Length <= symb)
  {
   resultArray[indexOfResultArray] = array[i];
   indexOfResultArray++;
  }
 }
 return resultArray;
}

void PrintArrayHowExample(string[] arr, string[] array)
{
 int count = arr.Length;
 int position = 0;
 Console.Write("[");
 while (position < count)
 {
  Console.Write("'" + arr[position] + "'");
  position++;
 }
 Console.Write("]->[");
 count = array.Length;
 position = 0;
 while (position < count)
 {
  Console.Write("'" + array[position] + "'");
  position++;
 }
 Console.Write("]");
}

int symbol = 3;
Console.WriteLine("Введите число строк массива");
int numberOfArrayRows = Convert.ToInt32(Console.ReadLine());

while (!Check(numberOfArrayRows))
{
 Console.Write("Введите натуральное число: ");
 numberOfArrayRows = Convert.ToInt32(Console.ReadLine());
}

string[] array = new string[numberOfArrayRows];
for (int i = 0; i < array.Length; i++)
{
 Console.WriteLine($"Введите {i + 1} строку массива");
 array[i] = Console.ReadLine();
}

Console.Write("Заданный массив: ");
PrintArray(array);
Console.WriteLine();

int result = NumberElem(array, symbol);
Console.Write($"Количество элементов меньше либо равно {symbol} в заданном массиве = {result}.");

Console.WriteLine();
string[] resultArray = ArrayThreeSymbChar(array, symbol, result);
Console.Write($"Массив из строк, длина которых меньше, либо равна {symbol} символам: ");
PrintArray(resultArray);
Console.WriteLine();

Console.Write("Ответ: ");
PrintArrayHowExample(array, resultArray);


