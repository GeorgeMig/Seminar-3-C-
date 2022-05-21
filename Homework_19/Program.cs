// ПРОГРАММА, КОТОРАЯ ПРИНИМАЕТ НА ВХОД ПЯТИЗНАЧНОЕ ЧИСЛО И ПРОВЕРЯЕТ, ЯВЛЯЕТСЯ ЛИ ОНО ПАЛИНДРОМОМ

Console.Write("Введите любое пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int onepartnum = num /1000;
int twopartnum = FindPalindrom (num);
Console.WriteLine(onepartnum == twopartnum ? "Да, число является палиндромом" : "Нет, число не является палиндромом");

int FindPalindrom (int number)
{
    int twopartnumber = (((number % 100) % 10) * 10) + ((number % 100) / 10);
    return twopartnumber;
}


// решено черезх метод для закрепления материала, а так можно и без него решить. 