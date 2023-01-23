// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int num1 = number / 10000;
int num2 = (number / 1000) % 10;
int num3 = (number % 100) / 10;
int num4 = number % 10;

if (num1 == num4 && num2 == num3)
{
  System.Console.WriteLine("да");
}
else
{
  System.Console.WriteLine("нет");
}