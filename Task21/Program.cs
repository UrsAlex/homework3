// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.

int [] AddArray(int[] array)
{
    for(int count = 0; count < array.Length; count++)
    {
        Console.Write($"Введите {count + 1} ось координаты ");
        int ver = int.Parse(Console.ReadLine());
        array[count] = ver;
    }
    return array;
}
void FromFistToSecond(int[] arr1, int[] arr2)
{
    double size = Math.Sqrt(Math.Pow(arr2[0] - arr1[0], 2) + Math.Pow(arr2[1] - arr1[1], 2) + Math.Pow(arr2[2] - arr1[2], 2));
    Console.WriteLine(size); 
}

int[] FirstPoint = new int [3];
FirstPoint = AddArray(FirstPoint);
int[] SecondPoint = new int [3];
SecondPoint = AddArray(SecondPoint);
FromFistToSecond(FirstPoint, SecondPoint);
