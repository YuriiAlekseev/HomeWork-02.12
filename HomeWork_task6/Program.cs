Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse (Console.ReadLine());
if (0 == number % 2)
{
    Console.WriteLine("Данное число является четным");
}
else
{
    Console.WriteLine("Данное число является не четным");
}