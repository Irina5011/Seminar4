// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.

int A = Prompt("Введите А = > ");
int B = Prompt("Введите B = > ");

int result = 1;
int i = 0;

while(i<B)

{
    result = A*A;
   i++;
}

 Console.WriteLine($"{A} в степени {B} равно {result}");

int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}