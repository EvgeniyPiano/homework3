
// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int outputNum = ReadData("Введите пятизначное число: ");//ввод числа

if ((outputNum >= 10000) && (outputNum <= 99999))//проверка подходит ли число
{
    Dictionary<int, int> palindrome = DictionaryFill();//

    bool check = PalinTest(outputNum, palindrome);//условия и вывод подходящего текста на экран 
    if (check)
    {
        PrintData(outputNum, " это палиндром");
    }
    else
    {
        PrintData(outputNum, " это не палиндром");
    }
}
else
{
    Console.WriteLine("Введите пятизначное число");//вывод на экран если число не подходящее
}

int ReadData(string message)//метод для ввода числа
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(int num, string msg)//метод для вывода на экран
{
    Console.WriteLine(num + msg);
}

Dictionary<int, int> DictionaryFill()//метод заполнения 
{
    Dictionary<int, int> dictionary = new Dictionary<int, int>();
    int keyNum = 1;
    for (int secondNum = 0; secondNum <= 9; secondNum++)
    {
        for (int firstNum = 1; firstNum <= 9; firstNum++)
        {
            dictionary[keyNum] = firstNum * 1000 + secondNum * 100 + secondNum * 10 + firstNum;
            keyNum++;
        }
    }
    return dictionary;
}

bool PalinTest(int num, Dictionary<int, int> palindrome)//метод сравнивания элементов числа
{
    bool result = false;
    if (palindrome.ContainsValue((num / 1000) * 100 + (num % 100)))
    {
        result = true;
    }
    return result;
}