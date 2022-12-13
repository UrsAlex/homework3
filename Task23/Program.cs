// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

int AddInteger(int ver)
{
    Console.WriteLine($"Введите число: ");
    ver = int.Parse(Console.ReadLine());
    return ver;
}
void SquareNumb(int ver)
{
    int count = 0;
    Console.Write($"{ver} -> ");
    if( ver > 0)
    {
        for(count = 1; count <= ver; count++)
        {
            int temp = count * count * count;
            Console.Write($"{temp}, ");
        }    
    }
    // if (ver < 0)
    // {
    //     for(count = -1; count >= ver; count--)
    //     {
    //         int temp = count * count * count;
    //         Console.Write($"{temp}, ");
    //     }
    // }
    // else{Console.WriteLine(".");}
}
int Square = 0;
Square = AddInteger(Square);
SquareNumb(Square);