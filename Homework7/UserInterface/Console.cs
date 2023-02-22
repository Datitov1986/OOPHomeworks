using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserInterface
{
    /// <summary>
    /// Класс, реализующий взаимодействие пользователя с программой
    /// </summary>
    public class Console
    {
        public void printResult(string msg, Numbers result)
        {
            Console.WriteLine(msg + " : " + result);
        }
        public string menu()
        {
            Console.WriteLine("""Choise operation: 0 - сложение, 1 - вычитание, 2 - умножение, 3 - деление, q - выйти из калькулятора""");
                                                      
                                
        }
    }
}