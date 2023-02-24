// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//В задаче использовано 3 метода. 1- метод ввода числа, 2- метод вывода результата, 3- метод подсчёта расстояния между то точками
int ReadData(string msg)//метод для ввода числа
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg, double val)//метод для вывода на экран
{
    Console.WriteLine(msg + val);
}

double CalcLen3D(int x1, int x2, int y1, int y2, int z1, int z2) //метод подсчёта
{
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
}

int x1 = ReadData("Введите координату Х точки А: ");
int y1 = ReadData("Введите координату Y точки А: ");
int z1 = ReadData("Введите координату Z точки А: ");
int x2 = ReadData("Введите координату Х точки B: ");
int y2 = ReadData("Введите координату Х точки B: ");
int z2 = ReadData("Введите координату Х точки B: ");

double res = CalcLen3D(x1, x2, y1, y2, z1, z2);
PrintData("Расстояние между точками А и В: ", res);