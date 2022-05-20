Console.Write("Введите номер плоскости от 1 до 4: ");
int n = int.Parse(Console.ReadLine());
string result = FindXy(n);
Console.WriteLine(result);

string FindXy(int num)
{
    string result = " ";
    if (num == 1)
    {
        result = "Диапозон возможных координат точек в этой четверти равен x и y";
    }
    else if (num == 2)
    {
        result = "Диапозон возможных координат точек в этой четверти равен x и y";
    }
    else if (num == 3)
    {
        result = "Диапозон возможных координат точек в этой четверти равен x и y";
    }
    else if (num == 4)
    {
        result = "Диапозон возможных координат точек в этой четверти равен x и y";
    }
    return result;
}