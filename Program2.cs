
static int Sum(int A, int B)
{
    int count = 1;
    int c = A;
    while (count < B)
    {
        c = c * A;

        count = count + 1;


    }
    return c;
}
Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{A}->{Sum(A, B)} ");