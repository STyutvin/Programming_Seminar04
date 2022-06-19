internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 25: Напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
        Console.Write("Введите число А: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите степень В для числа А: ");
        int degree = Convert.ToInt32(Console.ReadLine());
        int Exponentiation(int a, int degree)
        {
            int result = 1;
            for (int i = 1; i <= degree; i++)
            {
                result = result * a;
            }
            return result;
        }
        Console.Write($"{a} ^ {degree} = {Exponentiation(a, degree)}");
    }
}