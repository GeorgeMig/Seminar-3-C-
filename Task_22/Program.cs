Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine());
int count = 1;

Console.WriteLine("|{0,10}|{1,10}|", "Число", "Корень");
while (count <= num)
{
    int square = count * count;
    Console.WriteLine("|{0,10}|{1,10}|", count, square);
    count++;
}