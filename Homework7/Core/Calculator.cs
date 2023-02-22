using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core
{
    /// <summary>
    /// Класс калькулятор, выполняет матемаитческие действия с числами
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Метод, запускающий программу
        /// </summary>
        public static void start () {
            Console console = new Console();
            string button = console.Menu();

            while (!button.Equals("q")) {
                Numbers num1 = console.getNumber("Введите первый аргумент: ");
                Numbers num2 = console.getNumber("Введите второй аргумент: ");

                switch (button) {
                    case "0":
                        console.printResult("Результат сложения: ");
                        break;
                    case "1":
                        console.printResult("Результат вычитания: ");
                        break;
                    case "2":
                        console.printResult("Результат умножения: ");
                        break;
                    case "3":
                        console.printResult("Результат деления: ");
                        break;
                }
                button = console.Menu();
            }
        }
    }
}