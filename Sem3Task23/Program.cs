// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом

int ReadData(string msg)//метод для ввода числа N
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}


string LineBuilder(int num, int Pow)// метод подсчёта
{
    string res = string.Empty;
    for (int i = 1; i <= num; i++)
    {
        res = res + Math.Pow(i, Pow) + " \t";
    }
    return res;
}

int N = ReadData("Введите число N: ");

Console.WriteLine(LineBuilder(N,1));
Console.WriteLine("");
Console.WriteLine(LineBuilder(N, 3)); // вводим в переменную Pow, которая находится в методе нужную нам степень возведения