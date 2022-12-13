// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

void CheckForPalidrom (int num)
{
    int rem;
    int sum = 0;
    int temp = num;
        while(num > 0)
        {
            rem = num % 10;
            num = num / 10;
            sum = sum * 10 + rem;
        }
            if(temp == sum)
            {
                Console.WriteLine("Это число полиндром");
            }
            else
            {
                Console.WriteLine("Это число не полиндром");
            }
}
Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());
CheckForPalidrom(num);