using System;

class Program
{
    static void Theme()
    {
        // Aynı tema birden farklı yerde kullanıldı
        Console.SetCursorPosition(0, 0);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("----------Calculator----------");
        Console.ResetColor();
        return;
    } 
    static void Main()
    {
        double result;
        bool restart = true;

        Theme();

        Console.WriteLine("You can use 4 functions at this version of program.\n1) +\n2) -\n3) *\n4) /");

        // İlk sayıyı al
        Console.Write("Please insert first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        // İkinci sayıyı al
        Console.Write("Please insert second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        while (restart)
        {
            Console.WriteLine("Please select a function (Select a number near your function, ex: press 1 for '+' function): ");
            int function = Convert.ToInt32(Console.ReadLine());  // İşlem numarasını al

            switch (function)
            {
                case 1:  // Toplama
                    result = number1 + number2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"The result is: {result}");
                    Console.ResetColor();
                    break;

                case 2:  // Çıkarma
                    result = number1 - number2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"The result is: {result}");
                    Console.ResetColor();
                    break;

                case 3:  // Çarpma
                    result = number1 * number2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"The result is: {result}");
                    Console.ResetColor();
                    break;

                case 4:  // Bölme
                    if (number2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero!");
                    }
                    else
                    {
                        result = (double)number1 / number2;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"The result is: {result}");
                        Console.ResetColor();
                    }
                    break;

                default:
                    Console.WriteLine("Invalid option! Please choose a valid function.");
                    break;
            }

            // Tekrar işlem yapmak isteyip istemediği sorulabilir
            Console.WriteLine("Do you want to perform another calculation? (yes/no): ");
            string again = Console.ReadLine().ToLower();
            if (again == "yes" || again == "y")
            {
                Theme();
                // Yeni işlem yapılacaksa tekrar kullanıcıdan sayı al

                Console.Clear();
                Console.WriteLine("You can use 4 functions at this version of program.\n1) +\n2) -\n3) *\n4) /");

                Console.Write("Please insert first number: ");
                number1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please insert second number: ");
                number2 = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Goodbye:)");
                restart = false;
                Console.ReadKey();
                break;
            }
        }
    }
}
