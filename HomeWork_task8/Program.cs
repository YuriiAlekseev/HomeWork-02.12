Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int i = 1;
while (i < number+1){ 
        Console.Write($"{i}, ");
        i++;
}

