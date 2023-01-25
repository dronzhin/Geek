// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int GetIntUserNumber(string request)
{
    System.Console.Write(request);
    return int.Parse(Console.ReadLine());
}
double CalculateDistance(int x1, int x2, int y1, int y2,int z1,int z2)
{
    double answer = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    return answer;
}

int x1 = GetIntUserNumber("Введите x1 - ");
int x2 = GetIntUserNumber("Введите x2 - ");
int y1 = GetIntUserNumber("Введите y1 - ");
int y2 = GetIntUserNumber("Введите y2 - ");
int z1 = GetIntUserNumber("Введите z1 - ");
int z2 = GetIntUserNumber("Введите z2 - ");
double answer = Math.Round(CalculateDistance(x1, x2, y1, y2, z1, z2),2);
System.Console.WriteLine($"Длина отрезка равна {answer}");