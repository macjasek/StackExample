using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {

            char k = '1';
            var myStack = new Stack<string>();

            Menu();

            do
            {
                k = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (k)
                {
                    case '1':
                        Console.WriteLine("Wybrałeś opcję 1 - push. Wpisz wartość:");
                        var stackMember = Console.ReadLine();
                        if (stackMember != "")
                        {
                            myStack.Push(stackMember);
                        }
                        else
                        {                        
                            UserErrorMsg("Błąd! Wpisano pusty łańcuch!");
                        }
                        break;
                    case '2':
                        Console.WriteLine("Wybrałeś opcje 2 - pop. Usunięcie elementu ze stosu.");
                        if (myStack.Count > 0)
                        {
                            Console.WriteLine($"Usunięto {myStack.Pop()}");
                        }
                        else
                        {                     
                            UserErrorMsg ("Pusty stos. Usunięcie elementu niemożliwe.");                           
                        }
                        break;
                    case '3':
                        Console.WriteLine($"Wybrałeś opcję 3 - peek. Element na górze stosu to {myStack.Peek()}");
                        break;
                    case '4':
                        Console.WriteLine("Wybrałeś opcję 4 - list. Poniżej lista elementów ze stosu");
                        if (myStack.Count > 0)
                        {
                            foreach (var item in myStack)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else
                        {                          
                            UserErrorMsg("Pusty stos. Wyświetlenie elementów niemożliwe.");                           
                        }

                        break;
                    case '5':
                        Console.WriteLine("Wyjście");
                        break;
                    default:
                        UserErrorMsg("Nieznana komenda!");
                        break;
                }
                if (k == '5')
                {
                    break;
                }
                else
                {
                    Menu();
                }
            } while (true);
        }

        static void UserErrorMsg(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        static void Menu()
        {
            Console.WriteLine("Wybierz opcję 1-push, 2-pop, 3-peek, 4-list, 5-exit");
        }
    }
}
