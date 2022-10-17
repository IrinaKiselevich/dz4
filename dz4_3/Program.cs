// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите размер массива : ");
int size = Convert.ToInt32(Console.ReadLine());
int [] FillArray()
{
    int[] array = new int[size];
    for (int i=0;i<size;i++)
   {
    array[i]=new Random().Next(0,9);
   }
   return array;
}
 void PrintArray(int[] array)
    {
        for(int i =0;i<size;i++)
        if(i<size-1)
        Console.Write($"{array[i]}, ");
        else
        Console.Write($"{array[i]}");
    }
int[] massiv = FillArray();
PrintArray(massiv);
