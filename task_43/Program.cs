// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите коэффициенты уравнений b1, k1, b2, k2 через ',' и без пробелов");
string num = Convert.ToString(Console.ReadLine());

int[] arr = num.Split(',').Select(int.Parse).ToArray();

if (arr[0] == arr[2] && arr[1] == arr[3])
{
    Console.WriteLine("Прямые совпадают");
}


if (arr[1] == arr[3])
{
    Console.WriteLine("Прямые не пересекаются");
}

double x;
double y;

if (arr[0] == arr[2])
{
    x = 0;
    y = arr[3]*x+arr[2];

    Console.WriteLine($"Прямые пересекаются в точке ({x},{y})");
}
else
{
    x = (arr[1] - arr[3]) / (arr[2] - arr[0]);
    y = arr[3] * x + arr[2];
    
    Console.WriteLine($"Прямые пересекаются в точке ({x},{y})");
}