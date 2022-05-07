using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Список доступных команд:");
            Console.WriteLine("setLogin - установить логин");
            Console.WriteLine("setPassword - установить пароль");
            Console.WriteLine("changeBackgroundColor - изменить цвет заднего фона");
            Console.WriteLine("changeFontColor - изменить цвет шрифта");
            Console.WriteLine("info - показывает информацию");
            Console.WriteLine("esc - закрыть программу");
            string userInput;
            string login = "No Login";
            string password = "No password";
            string changeBackgroundColor = "StandartBackgroundColor";
            string changeFontColor = "StandartFontColor";

            do
            {
                Console.WriteLine("Введите команду");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "setLogin":
                        Console.WriteLine("Ведите логин");
                        login = Console.ReadLine();
                        break;
                    case "setPassword":
                        Console.WriteLine("Ведите пароль");
                        password = Console.ReadLine();
                        break;
                    case "changeBackgroundColor":
                        Console.WriteLine("Доступные цвета:Blue,Red");
                        changeBackgroundColor = Console.ReadLine();

                        if (changeBackgroundColor == "Blue")
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                        }
                        else if (changeBackgroundColor == "Red")
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        break;
                    case "changeFontColor":
                        Console.WriteLine("Доступные цвета: Yellow,Green");
                        changeFontColor = Console.ReadLine();

                        if (changeFontColor == "Yellow")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else if (changeFontColor == "Green")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        break;
                    case "info":
                        Console.WriteLine(login);
                        Console.WriteLine(password);
                        Console.WriteLine(changeBackgroundColor);
                        Console.WriteLine(changeFontColor);
                        break;
                    default:
                        Console.WriteLine("не распознано");
                        break;
                }
            }
            while (userInput != "esc");
            Console.WriteLine("Завершение работы");
        }
    }
}
