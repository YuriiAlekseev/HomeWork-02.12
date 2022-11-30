Console.Clear();
Console.Write("Введите первое число: ");
int first_number = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int second_number = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int third_number = int.Parse(Console.ReadLine());
int max = first_number;
if (second_number > max)
{
max = second_number;
if (third_number > max)
{
max = third_number;
}
}
Console.WriteLine($"Максимальное из введенных чисел является число: {max}");