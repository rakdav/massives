using System.ComponentModel;

Console.Write("Введите размер массива:");
int n = int.Parse(Console.ReadLine()!);
int[] mas = new int[n];
Random r = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = r.Next(10, 100);
    Console.Write(mas[i] + " ");
}
Console.WriteLine();
//метод пузырька
//for (int i = 0; i < mas.Length-1; i++)
//{
//    for (int j = i+1; j < mas.Length; j++)
//    {
//        if (mas[i] >mas[j])
//        {
//            int temp = mas[i];
//            mas[i]= mas[j]; 
//            mas[j]= temp;
//        }
//    }
//}
//сортировка выбором
//for (int i = 0; i < mas.Length - 1; i++)
//{
//    int iMin = i;
//    for (int j = i + 1; j < mas.Length; j++)
//        if (mas[j] < mas[iMin]) iMin = j;
//    if (iMin != i)
//    {
//        int temp = mas[i];
//        mas[i] = mas[iMin];
//        mas[iMin] = temp;
//    }
//}
//простыми вставками
//for (int i = 1; i < mas.Length; i++)
//{
//    if (mas[i - 1] > mas[i])
//    {
//        int temp = mas[i];
//        int j = i - 1;
//        while (j >= 0 && mas[j] > temp)
//        {
//            mas[j + 1] = mas[j];
//            j--;
//        }
//        mas[j + 1] = temp;
//        foreach (int k in mas)
//        {
//            Console.Write(k + " ");
//        }
//        Console.WriteLine();
//    }
//}
//простые вставками с барьером
for(int i=1;i<mas.Length;i++)
{
    if (mas[i - 1] > mas[i])
    {
        int x = mas[i];
        int j = i - 1;
        while (j >= 0 && mas[j]>x)
        {
            mas[j + 1] = mas[j];
            j = j - 1;
        }
        mas[j + 1] = x;
    }
}
foreach (int i in mas)
{
    Console.Write(i + " ");
}
Console.WriteLine();