Console.WriteLine("Напишите порядковый номер дня недели.");
int number = Convert.ToInt32(Console.ReadLine());


if (number > 5 && number <= 7)

    Console.WriteLine("Да, этот день выходной!");

else if (number >= 1 && number <= 5 )
    Console.WriteLine("Увы, но это рабочий день!");
else
    Console.WriteLine("Число введино не верно!");