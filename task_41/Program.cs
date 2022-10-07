// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] array = new int[10];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{   
   array[i] = rand.Next(0,10);
}

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество чисел больше 0 равно: {count}");
var str = string.Join(" ", array);
Console.WriteLine(str);