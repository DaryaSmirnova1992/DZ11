// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] array = new int[4, 4];
int count = 0;
int i = 0;
int j = 0;

for(j = 0; j < array.GetLength(1); j++)   // 0 строка
{
    array[i,j] = 1 + count;
    count++;
}

j = 3;

for(i = 1; i < array.GetLength(0); i++)   // 3 столбец
{
    array[i,j] = 1 + count;
    count++;
}

i = 3;
for(j = 2; j >= 0; j -= 1)                // 3 строка
{
    array[i,j] = 1 + count;
    count++;
}

j = 0;
for(i = 2; i >= 1; i -= 1)                // 0 столбец
{
    array[i,j] = 1 + count;
    count++;
}

i = 1;                                    // 1 строка
for(j = 1; j <= 2; j++)
{
    array[i,j] = 1 + count;
    count++;
}

i = 2;
for(j = 2; j >= 1; j -=1)                 // 2 строка
{
    array[i,j] = 1 + count;
    count++;
}

for(i = 0; i < array.GetLength(0); i++)
{
    for(j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine(" ");