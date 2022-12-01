Console.WriteLine("Введите 1 число!");
int a = Convert.ToInt32(Console.ReadLine());
int s;
while (a < 99 && a > 1000 )
{
s = (a / 10) % 10;
Console.WriteLine($"Вторая цифра числа {s}! ");
}
Console.WriteLine("Введино некоректное число!");