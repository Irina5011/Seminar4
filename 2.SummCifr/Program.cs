// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int number = Prompt("Введите число = > ");

int sum = 0;

while (number >= 1)                     
{
    sum = sum + number%10;              
    number = (number - number%10)/10;   
}

Console.WriteLine($"{sum} это сумма цифр в вашем числе");

int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}