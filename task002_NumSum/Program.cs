//Программа, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int NumSum(int number)
{
    int counter = Convert.ToString(number).Length;
    int first = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      first = number - number % 10;
      result = result + (number - first);
      number = number / 10;
    }
    return result;
}

int final = NumSum(number);
Console.WriteLine("Сумма цифр в числе: " + final);