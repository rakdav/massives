
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
//Случайная сортировка

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

//Шейкерная сортировка
//for(int i=0;i<mas.Length/2;i++)
//{
//    bool swapFlag = false;
//    for(int j=i;j<mas.Length-i-1;j++)
//    {
//        if(mas[j]>mas[j+1])
//        {
//            int temp = mas[j];
//            mas[j] = mas[j+1];
//            mas[j+1] = temp;
//            swapFlag = true;
//        }
//    }
//    for(int j=mas.Length-2-i;j>i;j--)
//    {
//        if (mas[j - 1] > mas[j])
//        {
//            int temp = mas[j-1];
//            mas[j-1] = mas[j];
//            mas[j] = temp;
//            swapFlag = true;
//        }
//    }
//    if (!swapFlag) break;
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
//for (int i = 1; i < mas.Length; i++)
//{
//    if (mas[i - 1] > mas[i])
//    {
//        int x = mas[i];
//        int j = i - 1;
//        while (j >= 0 && mas[j] > x)
//        {
//            mas[j + 1] = mas[j];
//            j = j - 1;
//        }
//        mas[j + 1] = x;
//    }
//}
//Сортировка Шеллла
int d = mas.Length / 2;
while(d>=1)
{
    for(int i = d; i < mas.Length; i++)
    {
        int j = i;
        while ((j >= d) && (mas[j - d] > mas[j]))
        {
            int temp = mas[j];
            mas[j]=mas[j-d];
            mas[j-d] = temp;
            j = j - d;
        }
    }
    d = d / 2;
}
foreach (int i in mas)
{
    Console.Write(i + " ");
}
Console.WriteLine();




