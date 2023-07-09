// Напишите программу, которая на вход принимает число (N>0), а на выходе показывает все четные числа от 1 до N.
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a>0){
    for (int i=1; i<=a; i++){
        if (i %2==0){
            Console.WriteLine (i);
        }
    }
}
else {
    Console.WriteLine("Число должно быть больше 0");
}