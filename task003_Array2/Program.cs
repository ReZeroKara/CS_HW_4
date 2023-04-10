//Программ, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 1000);
        index++;
    }
}

void PrintArray(int[] shelf)
{
    int closet = shelf.Length;
    int position = 0;
    while (position < closet)
    {
        Console.Write(shelf[position] + ", ");
        position++;
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);