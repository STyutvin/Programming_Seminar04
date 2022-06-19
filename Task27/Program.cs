//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int SumNumber(int n)
  {  
    int counter = Convert.ToString(n).Length;
    int reminder = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      reminder = n - n % 10;
      result = result + (n - reminder);
      n = n / 10;
    }
   return result;
  }

int sumNumber = SumNumber(n);
Console.WriteLine("Сумма цифр в числе N: " + sumNumber);