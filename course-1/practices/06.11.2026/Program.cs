// Задание 1
int number = 10;

if (number > 0)
{
    Console.WriteLine("Число положительное");
}
if (number < 0)
{
    Console.WriteLine("Число отрицательное");
}
if (number == 0)
{
    Console.WriteLine("Число равно нулю");
}
// Задание 2
Console.Write("Введите ваш возраст: ");
int age = Convert.ToInt32(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("Вы совершеннолетний");
}
else
{
    Console.WriteLine("Вы несовершеннолетний");
}

// Задание 3
int num = 7;

if (num % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}