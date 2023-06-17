// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine();
//System.Console.WriteLine(num.Length);
if(num.Length != 5)
{
    System.Console.WriteLine("Неправильный ввод данных");
}
else if(num[0] == num[4] && num[1] == num[3])
{
    System.Console.WriteLine("Введённое число является палиндромом");
}
else
{
    System.Console.WriteLine("Введённое число не является палиндромом");
}
