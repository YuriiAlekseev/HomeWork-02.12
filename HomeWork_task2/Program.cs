Console.Clear();
Console.Write("Введите первое число: ");
int first_number = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int second_number = int.Parse(Console.ReadLine());
if (first_number > second_number)
{
    Console.WriteLine($"Число {first_number} больше, чем число {second_number}");
}
else 
{
    Console.WriteLine($"Число {second_number} больше, чем число {first_number}");
}