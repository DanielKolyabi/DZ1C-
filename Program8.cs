Console.WriteLine("Введите одно число!");
int n = Convert.ToInt32(Console.ReadLine());
int size = 0;
while(size<n)
{
    Console.Write($"{size} ");
    size = size+2;

}