//Task1();
//Task2();
//Task3();
//Task4();


void Task1()

{
    //Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

    System.Console.WriteLine("Enter the number");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if (number % 7 == 0 && number % 23 == 0) System.Console.WriteLine("Yes");
        else System.Console.WriteLine("No");
    }
    else System.Console.WriteLine("Error format");
}

void Task2()
{
    //Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

    System.Console.WriteLine("Enter the first number and press button \"enter\" then enter the second the number. Numers != 0");

    if (int.TryParse(Console.ReadLine(), out int x) && int.TryParse(Console.ReadLine(), out int y))
    {
        if (x != 0 && y != 0)
        {
            if (x > 0 && y > 0) System.Console.WriteLine("1");
            else if (x < 0 && y > 0) System.Console.WriteLine("2");
            else if (x < 0 && y < 0) System.Console.WriteLine("3");
            else System.Console.WriteLine("4");
        }
        else System.Console.WriteLine("Numers != 0");
    }
    else System.Console.WriteLine("Error format");

}

void Task3()
{
    //Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

    System.Console.WriteLine("Enter the number. Diaposon [10,99]");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if (number >= 10 && number <= 99)
        {
            System.Console.WriteLine(Math.Max(number / 10, number % 10));
        }
        else System.Console.WriteLine("Diaposon [10,99]");
    }
    else System.Console.WriteLine("Error format");
}

void Task4()
{
    //Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

    System.Console.WriteLine("Enter the natural number");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if (number > 0)
        {
            for (int i = number.ToString().Length - 1; i >= 0; i--)
            {
                System.Console.Write(number.ToString()[i] + " ");
            }

            System.Console.WriteLine();

            for (int i = 0; i <= number.ToString().Length - 1; i++)
            {
                System.Console.Write(number.ToString()[i] + " ");
            }
        }
        else System.Console.WriteLine("Natural number!");

    }
    else System.Console.WriteLine("Error format");
}
