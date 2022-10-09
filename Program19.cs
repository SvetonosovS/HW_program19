//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
int num;
{
while (true) 
    {
    Console.Write("Введите целое пятизначное число: ");
    if (int.TryParse(Console.ReadLine(), out num))
        break;
    Console.WriteLine($"Ошибка ввода");   
    } 

Console.Write(num +" -> ");

if (num <= 9999 | num >= 100000)
    {
    Console.WriteLine("Ошибка ввода");
    }
 
 int a1 = num / 10000;
 int a2 = num % 10;
 int a3 = num / 1000 % 10;
 int a4 = num / 10 % 10;

if (a1==a2 && a3==a4)
    Console.WriteLine("Да");
if (num >=10000 && num <=99999 && a1!=a2 && a3!=a4)
    Console.WriteLine("Нет");
}
