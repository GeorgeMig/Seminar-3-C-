//ПРОГРАММА, КОТОРАЯ ПРИНИМАЕТ НА ВХОД ЧИСЛО (N) И ВЫДАЕТ ТАБЛИЦУ КУБОВ ЧИСЕЛ ОТ ! ДО N.

Console.Write("Введите любое число: ");
double num = double.Parse(Console.ReadLine());
double count = 1;

Console.WriteLine("|{0,10}|{1,10}|", "Число", "Куб");
while (count <= num)
{
    double square = Math.Pow(count, 3);
    Console.WriteLine("|{0,10}|{1,10}|", count, square);
    count++;
}