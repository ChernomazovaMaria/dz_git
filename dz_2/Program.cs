// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
    Console.WriteLine ("Число {0} максимальное", a);
}
else if (b > a && b > c)
{
    Console.WriteLine ("Число {0} максимальное", b);
}
else if (c > a && c > b)
{
    Console.WriteLine ("Число {0} максимальное", c);
}
else 
{
    Console.WriteLine ("Все числа равны");
}