﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Здесь собираются методы (подпрограммы, функции) для сокращения написания
// новых программ

int PromtInt(string message) //Функция ввода символов как целого числа. Запрашивает на входе
// строку запроса, какие именно данные нужны
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int PromtIntCheck(string message) //Функция ввода символов как целого числа с проверкой. Можно указать
// строка запроса, какие именно данные нужны. 
{
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine(), out int temp)) return temp;
    else
    {
        Console.WriteLine("Неверно введено число");
        return 0;
    }
}

string PromtStr(string message) //Функция ввода символов как строки символов. Можно указать
// строку запроса, какие именно данные нужны
{
    Console.WriteLine(message);
    return Console.ReadLine();
}

double PromtDouble(string message) //Функция ввода символов как числа с дробной частью с проверкой.
// При вызове нужна строка запроса, какие именно данные нужны
{
    Console.WriteLine(message);
    double temp = 0;
    if (double.TryParse(Console.ReadLine(), out temp))
        return temp;
    else
    {
        Console.WriteLine("Неверно введено число");
        return -1;
    }
}

bool Palindrom(string message) //Функция определения, является-ли строка палиндромом
{
    int ls = message.Length;
    int ls2 = ls / 2;
    string a = message.Substring(0, ls2);
    string b = "";
    for (int i = ls - 1; i >= (ls - ls2); i--)
    {
        b = b + message[i];
    }
    if (a == b)
        return true;
    else
        return false;
}

void FillPrintRandArray(int[] Arr, int scope) // Функция заполнения массива заданным диапазоном случайных 
// значений натуральных чисел и вывода этого массива в консоль.
{
    for(int i = 0; i< Arr.Length; i++)
    {
        Arr[i] = Random.Shared.Next(0,scope + 1);
        Console.Write(Arr[i] + " ");
    }
}

int[] MultiArray(int[] arr) // Функция перемножения попарно элементов массива. Пары относительно центра массива
{
    int[] answer = new int[arr.Length/2 + arr.Length % 2];
    for(int i = 0; i < arr.Length/2; i++)
    {
        answer[i] = arr[i]*arr[arr.Length -i-1];
    }
    if(arr.Length % 2 == 1) answer[answer.Length-1] = arr[arr.Length/2];
    return answer;
}

int[] RandArray(int lenght, int min = -9, int max = 10) //Функция заполнения массива случайными целыми числами
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(min, max);
    }
    return answer;
}

void printArr(int[] Mas) // Функция вывода на консоль одномерного массива
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + " ");
    }
    Console.WriteLine();
}

int SummOddElemArray(int[] arr) // Функция суммирования всех нечётных эл-тов массива.
{
    int res = 0;
    foreach (int i in arr)
    {
        if(i % 2 != 0) res = res + i; 
    }
    return res;
}

double DispersionArr(double[] arr) //Функция нахождения разницы между мин.и макс. значенями массива
{
    double minVal=arr[0];
    double maxVal=arr[0];
    foreach (double i in arr)
    {
        if(minVal > i) minVal = i;
        if(maxVal < i) maxVal = i;
    }
    return maxVal - minVal;
}

double[] RandArray(int lenght, double min = -100, double max = 100) //Функция заполнения массива случайными целыми числами
{
    double[] answer = new double[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().NextDouble()*(max-min) + min;
    }
    return answer;
}

void printArr(double[] Mas) // Функция вывода на консоль одномерного массива чисел с плавающей запятой
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write($"{Mas[pos]:f2} ");
    }
    Console.WriteLine();
}

int SummOddPosArray(int[] arr) // Функция суммирования всех эл-тов массива на нечётных позициях.
{
    int res = 0;
    for(int i = 1; i < arr.Length; i = i+2) res = res + arr[i];
    return res;
}

int CountingNegNumbers(int[] arr) // Функция подсчёта количества отрицательных чисел в массиве
{
    int res = 0;
    foreach (int i in arr)
    {
        if(i < 0) res = res + 1;
    }
    return res;
}

int[] PromtSeveralInt(string message) //Функция ввода нескольких целых чисел, разделённых пробелами или
// запятыми. Запрашивает на входе строку запроса, какие именно данные нужны.
{
    Console.WriteLine(message);
    string? str = Console.ReadLine(); // Проверяем наличие символов на вводе
    if (str == null)
        return new int[] { 0 }; // Если нет символов, то возврат нулевого массива

    char[] separators = new char[] { ' ', '.', ',' }; // Задаём разделители символов (чисел)
    string[] numbers = str.Split(separators, StringSplitOptions.RemoveEmptyEntries); //создаём массив строковых чисел
    int[] res = new int[numbers.Length]; // Создаём массив для записи в него чисел
    for (int i = 0; i < numbers.Length; i++) // Цикл преобразования массива строк в массив целых чисел
    {
        if (int.TryParse(numbers[i], out int temp))
            res[i] = temp;
        else
        {
            Console.WriteLine("Неверно введены числа"); // Если есть символы, отличные от цифр, то выводим сообщение об ошибке
            return new int[] { 0 }; // и выходим из функции с нулевым массивом
        }
    }
    return res;
}

double[] CalcXY(int[] arr) // Функция расчёта точки пересечения 2-х прямых на плоскости,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; элементы массива слева направо 
// соответствуют перечислению их в уравнениях.
{
    double[] res = { 0, 0 };
    if (arr[2] - arr[0] == 0) //Проверка равенства угла наклона прямых
    {
        Console.WriteLine("Прямые параллельны");
        return res;
    }
    res[0] = (arr[1] - arr[3]) / (arr[2] - arr[0]); // Расчёт абсциссы
    res[1] = (arr[1] * arr[2] - arr[3] * arr[0]) / (arr[2] - arr[0]); // Расчёт ординаты
    return res;
}

string Convert (int dec) // Преобразует целое число в строковое двоичное, записанное задом наперёд.
{
    int rem = 0;
    int div = dec;
    string res = "";
    do
    {
        rem = div % 2;
        div = div / 2;
        res = res + rem;
    }
    while(div != 0);
    return res;
}