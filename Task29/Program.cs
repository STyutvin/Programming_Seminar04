internal class Program
{
    private static void Main(string[] args)
    {
        //Напишите программу, которая задает массив из 8 случайных чисел и выводит отсортированный по модулю массив.
        int[] array = new int[8]; //задание массива с именем array из 8 элементов

        void FillArray(int[] rndArray) //задание метода для заполнения какого-то массива с заданным количеством случайных элементов
        {
            int length = rndArray.Length; //данную переменную отдельно можно не объявлять, а задать в условии цикла
            for (int index = 0; index < length; index++)
            {
                rndArray[index] = new Random().Next(-99, 99);
            }
        }

        void PrintArray(int[] prntArray) //задание метода для вывода элементов любого массива на консоль
        {
            int count = prntArray.Length; //данную переменную отдельно можно не объявлять, а задать в условии цикла
            for (int position = 0; position < count; position++)
            {
                Console.Write(prntArray[position] + " ");
            }
            Console.WriteLine();
        }

        void SortToRise(int[] arrToSort) // задание метода для сортировки элементов массива по возрастанию
        {
            for (int k = 0; k < arrToSort.Length - 1; k++)
            {
                int minPos = k;
                for (int j = k + 1; j < arrToSort.Length; j++)
                {
                    if (Math.Abs(arrToSort[j]) < Math.Abs(arrToSort[minPos])) minPos = j;
                }
                int temp = arrToSort[k];
                arrToSort[k] = arrToSort[minPos];
                arrToSort[minPos] = temp;
            }
        }
        FillArray(array);
        Console.Write("Случайно заданный массив из 8-ми элементов: ");
        PrintArray(array);
        SortToRise(array);
        Console.Write("Отсортированный по модулю случайно заданный массив: ");
        PrintArray(array);
    }
}