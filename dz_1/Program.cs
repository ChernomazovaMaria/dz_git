// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if ( a > b)
{ 
    Console.WriteLine ("Число {0} большее, число {1} меньшее",a,b);
}
else
{
    Console.WriteLine ("Число {0} большее, число {1} меньшее", b, a);
}