while (true)
{
    Console.Write("ввод операции: ");
    int operation = Convert.ToInt32(Console.ReadLine());
    if (operation == 9)
    {
        break;
    }
    Console.Write("ввод 1 числа: ");
    float num1 = Convert.ToInt32(Console.ReadLine());
    float num2;
    float result;
    switch (operation)
    {
        case 1:
            Console.Write("ввод 2 числа: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            break;
        case 2:
            Console.Write("ввод 2 числа: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 - num2);
            break;
        case 3:
            Console.Write("ввод 2 числа: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 * num2);
            break;
        case 4:
            Console.Write("ввод 2 числа: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("попытка деления на 0");
                break;
            }
            Console.WriteLine(num1 / num2);
            break;
        case 5:
            Console.Write("ввод 2 числа: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            result = 1;
            for (int i = 1; i <= num2; i++)
            {
                result *= num1;
            }
            Console.WriteLine(result);
            break;
        case 6:
            if (num1 < 0)
            {
                Console.WriteLine("попытка получения корня отрицательного числа");
                break;
            }
            Console.WriteLine(Math.Sqrt(num1));
            break;
        case 7:
            Console.WriteLine(num1 / 100);
            break;
        case 8:
            if (num1 < 0)
            {
                Console.WriteLine("попытка получения факториала отрицательного числа");
                break;
            }
            else if (num1 == 0)
            {
                Console.WriteLine("0");
                break;
            }
            result = 1;
            for (int i = 1; i <= num1; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
            break;
    }
}
