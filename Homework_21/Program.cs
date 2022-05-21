Console.Write("Введите координату х точки А: ");
int xA = int.Parse(Console.ReadLine());
Console.Write("Введите координату y точки А: ");
int yA = int.Parse(Console.ReadLine());
Console.Write("Введите координату c точки А: ");
int zA = int.Parse(Console.ReadLine());

Console.Write("Введите координату х точки B: ");
int xB = int.Parse(Console.ReadLine());
Console.Write("Введите координату y точки B: ");
int yB = int.Parse(Console.ReadLine());
Console.Write("Введите координату c точки B: ");
int zB = int.Parse(Console.ReadLine());

float dis = getDistance(xA, yA, zA, xB, yB, zB);

float getDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    float result = (float)(Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2))));
    return result;
}

Console.WriteLine("Расстояние между точками = " + "{0:0.00}", dis);