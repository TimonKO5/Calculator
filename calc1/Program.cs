double num1 = 0; double num2 = 0;

Console.WriteLine("Добро пожаловать в калькулятор!\r");
Console.WriteLine();

Console.WriteLine("Введите первое число:");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число:");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Выберите, что вам нужно выполнить:");
Console.WriteLine("\t1 - Сложить");
Console.WriteLine("\t2 - Вычесть");
Console.WriteLine("\t3 - Умножить");
Console.WriteLine("\t4 - Разделить");
Console.WriteLine("-------------------------------------");
Console.Write("Ваш выбор:");

switch (Console.ReadLine())
{
    case "1":
        Console.WriteLine($"Ответ: {num1} + {num2} = " + (num1 + num2));
        break;
    case "2":
        Console.WriteLine($"Ответ: {num1} - {num2} = " + (num1 - num2));
        break;
    case "3":
        Console.WriteLine($"Ответ: {num1} * {num2} = " + (num1 * num2));
        break;
    case "4":
        Console.WriteLine($"Ответ: {num1} / {num2} = " + (num1 / num2));
        break;
    case "Я гей":
        Console.WriteLine("Я тоже)");
        break;
}

Console.Write("Нажмите любую кнопку чтобы выйти из приложения.");
Console.ReadKey();