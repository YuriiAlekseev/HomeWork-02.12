// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите цифру обозачающую день недели:  ");
int number = int.Parse(Console.ReadLine());

if (number < 1 || number >7) {
    Console.WriteLine("Введенное число не является днем недели ");
}   
else if (number == 6 || number == 7 ){  
    Console.WriteLine("Этот день являеться выходным ");
}
else { 
Console.WriteLine("Этот день не  являеться выходным");
}
