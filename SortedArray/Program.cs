///отсортированный метод, заполненный рандмом и поиска индекса введенного числа

int[] array = new int[10];
FillArrayWithRandom(array);
Console.Write("Array: ");
PrintArray(array);
SelectionSort(array);
Console.Write("Sorted Array: ");
PrintArray(array);
Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine());
int index = FindIndex(array, num);
Console.WriteLine("Index of number = " + index);

void FillArrayWithRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

int FindIndex(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return i;
    }
    return -1;
}
