Console.WriteLine("Введите 1й элемент массива:");
string elem1 = Console.ReadLine();
Console.WriteLine("Введите 2й элемент массива:");
string elem2 = Console.ReadLine();
Console.WriteLine("Введите 3й элемент массива:");
string elem3 = Console.ReadLine();
Console.WriteLine("Введите 4й элемент массива:");
string elem4 = Console.ReadLine();
Console.WriteLine("Введите 5й элемент массива:");
string elem5 = Console.ReadLine();

string[] array = new string[]{elem1,elem2,elem3,elem4,elem5};

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] +", ");
    }
    Console.Write("]");
}

int NumberElementsLessThanThree(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i].Length <= 3) {count++;}    
        }
    return count;
} 

string[] ArrayElemLessThanThree(string[] arr, int arrElem)
{
    string[] resultArray = new string[arrElem];
    int j = 0;
    while (j < arrElem)
        {
            for (int i = 0; i < arr.Length; i++)
                {
                    if(arr[i].Length <= 3) 
                    {
                        resultArray[j] = arr[i];
                        j++;
                    }    
                }
        }
    return resultArray;
}









