// Задача 60. ...Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размера 2 x 2 x 2

int[,,] Arr = new int[2, 2, 2];
FillArray(Arr);
PrintIndex(Arr);

void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < Arr.GetLength(2); k++)
            {
                Console.Write($"{Arr[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void FillArray(int[,,] arr)
{
    int count = 11;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}