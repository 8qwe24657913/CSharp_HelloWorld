using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Static {
    class HelloWorld {
        static readonly Random random = new Random();
        static readonly Array colors = Enum.GetValues(typeof(ConsoleColor));
        static private void ShowName(string name) {
            var fr = Console.ForegroundColor;
            var bg = Console.BackgroundColor;
            Console.ForegroundColor = (ConsoleColor)colors.GetValue(random.Next(colors.Length));
            if (Console.BackgroundColor == Console.ForegroundColor) {
                Console.BackgroundColor = Console.BackgroundColor == ConsoleColor.White ? ConsoleColor.Black : ConsoleColor.White;
            }
            Console.Write(name);
            Console.ForegroundColor = fr;
            Console.BackgroundColor = bg;
        }
        static public void Show(string greeting, string[] names) {
            if (names.Length == 0) {
                Console.WriteLine("Hint: you can specify startup parameters to assign the object to greet.");
                names = new string[] { "World" };
            }
            Console.Write($"{greeting} ");
            ShowName(names[0]);
            for (int i = 1; i < names.Length - 1; i++) {
                Console.Write(", ");
                ShowName(names[i]);
            }
            if (names.Length > 1) {
                Console.Write(" and ");
                ShowName(names[names.Length - 1]);
            }
            Console.WriteLine("!");
        }
    }
}
