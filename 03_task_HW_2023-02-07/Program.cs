// S##### 03_task_HW_2023-02-07
// Написать программу копирования массива
Console.Clear();
Console.WriteLine("Написать программу копирования массива" !);

int ReadNum (string message)                   // ввод числа
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size, int low, int hight) // создание массива с заданными параметрами
{
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(low, hight + 1);
    return arr;
}

int[] CopyArray (int[] arrOrig, int[] arrCopy)  // Копирование массива
{
    for (int i = 0; i < arrOrig.Length; i++)
        arrCopy[i] = arrOrig[i];
    return arrCopy;
}

void PrintArr (int[] array)
{
    foreach(int element in array)
    Console.Write($"{element} \t" !);

    Console.WriteLine();
}

int lenght = ReadNum("Ведите размер массива: " !);
int stNum = ReadNum("Ведите минимальное число в массиве: " !);
int endNum = ReadNum("Ведите максимальное число в массиве: " !);
Console.WriteLine();
int[] arrayOrigin = CreateArray( lenght, stNum, endNum);          // Создаём оригинальный массив
Console.WriteLine($"Создан оригинальный массив на {lenght} ячеек содержащих числа в диапазоне {stNum} - {endNum}" !);
PrintArr(arrayOrigin);
int[] arrayCopy = new int[lenght];                        // создаём массив для копирования того же размера
Console.WriteLine($"Создан массив для копирования из {lenght} ячеек : " !);
PrintArr(arrayCopy);
CopyArray( arrayOrigin, arrayCopy);                       // копируем содерж. оригинального массива в массив копию 
Console.WriteLine($"Оригинальный массив из {lenght} ячеек скопирован в массив копию: " !);
PrintArr(arrayCopy);
Console.WriteLine();