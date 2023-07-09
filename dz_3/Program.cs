// Напишите программу, которая на вход принимает число и выдает, является ли число четным. 
Console.WriteLine ("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2==0)
{
    Console.WriteLine ("Число {0} четное", a);
}
else
{
    Console.WriteLine ("Число {0} нечетное",a);
}
