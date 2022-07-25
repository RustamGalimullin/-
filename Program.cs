///Zadacha21();

    //Напишите программу, которая принимает на вход 
    //координаты двух точек и находит расстояние между ними в 3D пространстве


void Zadacha21()
{
    Console.WriteLine("Введите координаты первой точки");
    double x1 = Convert.ToInt32(Console.ReadLine());
    double y1 = Convert.ToInt32(Console.ReadLine());
    double z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты второй точки");
    double x2 = Convert.ToInt32(Console.ReadLine());
    double y2 = Convert.ToInt32(Console.ReadLine());
    double z2 = Convert.ToInt32(Console.ReadLine());

    
    
    double xx = x2 - x1;
    double yy = y2 - y1;
    double zz = z2 - z1;


    double result = Math.Sqrt(xx*xx + yy*yy + zz*zz );
    Console.WriteLine("Расстояние :  " + result);
}
///Zadacha21(); 

//A (3,6,8); B (2,1,-7), -> 15.84

///A (7,-5, 0); B (1,-1,9) -> 11.53



///// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Zadacha23()
{
    Console.WriteLine("Введите число N");
    int N = Convert.ToInt32(Console.ReadLine());
    double num = 1;
    double res;
    Console.WriteLine($"Число {N}");
    while (num <= N)
    {
        res = Math.Pow(num, 3);
        Console.WriteLine($"{num}*{num}={res}");
        num++;
    }
    
}
///Zadacha23();

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

///Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Zadacha19()
{

Console.Write("Введите число: ");
string? number = Console.ReadLine();
void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - Палиндром.");
  }
    else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}
    else Console.WriteLine($"Введи правильное число");

}
Zadacha19();
    
    //14212 -> нет

    ////12821 -> да

    ////23432 -> да



