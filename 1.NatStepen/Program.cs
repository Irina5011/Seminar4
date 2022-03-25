// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.

int A = Prompt("Введите А = > ");
int B = Prompt("Введите B = > ");

int i = 0, ans = 1;

while(i < B)
{
    ans = ans*A;
    i++;
}

 Console.WriteLine($"{A} в степени {B} равно {ans}");

int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}