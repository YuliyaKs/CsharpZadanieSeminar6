// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Введите любые числа через пробел: ");
string stringNums = Console.ReadLine();     // получаем от пользователя строку с числами
int[] arrayNums = GetArrayFromString(stringNums);     // преобразуем строку в массив чисел с помощью метода
Console.WriteLine(String.Join(", ", arrayNums));     // вывод массива
Console.WriteLine($"Вы ввели {CountPositiveNumbers(arrayNums)} чисел больше 0");

// Метод для перевода строки в массив чисел
int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);  // разбиваем строку на элементы массива
    int[] res = new int[nums.Length];       // задаем массив чисел

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);    // поэлементно переводим массив строк в массив чисел
    }
    return res;
}

// Метод для подсчета чисел больше 0
int CountPositiveNumbers(int[] array)
{
    int count = 0;
    foreach(int el in array)
    {
        count += el > 0 ? 1 : 0;       // складываем количество чисел больше 0
    }
    return count;
}
