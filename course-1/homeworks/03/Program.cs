
Console.WriteLine("Введите *C для конвертации в *F) :");
float tmprtC = float.Parse(Console.ReadLine());
float tmprtF = tmprtC * 9 / 5 + 32;
Console.WriteLine(tmprtF);

Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int c = int.Parse(Console.ReadLine());

int average = (a + b + c) / 3;

Console.WriteLine($"Среднее арифметическое чисел {a}, {b} и {c} равно {average}");

Console.WriteLine("Введите первое число:");
float x = float.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
float y = float.Parse(Console.ReadLine());

Console.WriteLine($"сумма = {x + y}");
Console.WriteLine($"разность = {x - y}");
Console.WriteLine($"произведение = {x * y}");
Console.WriteLine($"частное = {x / y}");
