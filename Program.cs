
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
Print(BubbleSort(mas));
//метод пузырька
int[] BubbleSort(int[] mas)
{
    for (int i = 0; i < mas.Length - 1; i++)
    {
        for (int j = i + 1; j < mas.Length; j++)
        {
            if (mas[i] > mas[j])
            {
                int temp = mas[i];
                mas[i] = mas[j];
                mas[j] = temp;
            }
        }
    }
    return mas;
}

//Шейкерная сортировка
int[] ShakerSort(int[] mas)
{
    for (int i = 0; i < mas.Length / 2; i++)
    {
        bool swapFlag = false;
        for (int j = i; j < mas.Length - i - 1; j++)
        {
            if (mas[j] > mas[j + 1])
            {
                int temp = mas[j];
                mas[j] = mas[j + 1];
                mas[j + 1] = temp;
                swapFlag = true;
            }
        }
        for (int j = mas.Length - 2 - i; j > i; j--)
        {
            if (mas[j - 1] > mas[j])
            {
                int temp = mas[j - 1];
                mas[j - 1] = mas[j];
                mas[j] = temp;
                swapFlag = true;
            }
        }
        if (!swapFlag) break;
    }
    return mas;
}
//сортировка выбором
int[] ChoiceSort(int[] mas)
{
    for (int i = 0; i < mas.Length - 1; i++)
    {
        int iMin = i;
        for (int j = i + 1; j < mas.Length; j++)
            if (mas[j] < mas[iMin]) iMin = j;
        if (iMin != i)
        {
            int temp = mas[i];
            mas[i] = mas[iMin];
            mas[iMin] = temp;
        }
    }
    return mas;
}
//простыми вставками
int[] InsertSort(int[] mas)
{
    for (int i = 1; i < mas.Length; i++)
    {
        if (mas[i - 1] > mas[i])
        {
            int temp = mas[i];
            int j = i - 1;
            while (j >= 0 && mas[j] > temp)
            {
                mas[j + 1] = mas[j];
                j--;
            }
            mas[j + 1] = temp;
            foreach (int k in mas)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
        }
    }
    return mas;
}

//простые вставками с барьером
int[] InsertSortBarier(int[] mas)
{
    for (int i = 1; i < mas.Length; i++)
    {
        if (mas[i - 1] > mas[i])
        {
            int x = mas[i];
            int j = i - 1;
            while (j >= 0 && mas[j] > x)
            {
                mas[j + 1] = mas[j];
                j = j - 1;
            }
            mas[j + 1] = x;
        }
    }
    return mas;
}
//Сортировка Шелла
int[] ShellSort(int[] mas)
{
    int d = mas.Length / 2;
    while (d >= 1)
    {
        for (int i = d; i < mas.Length; i++)
        {
            int j = i;
            while ((j >= d) && (mas[j - d] > mas[j]))
            {
                int temp = mas[j];
                mas[j] = mas[j - d];
                mas[j - d] = temp;
                j = j - d;
            }
        }
        d = d / 2;
    }
    return mas;
}
void Print(int[] mas)
{
    foreach (int i in mas)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}




