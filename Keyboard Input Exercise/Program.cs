using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_Input_Exercise
{
    class Program
    {
        static bool shouldQuit = false;

        static void MakeBeep(char key)
        {
            Console.Beep(key * 50, key * 5);
        }
        static void ListenForQuietKey(char key)
        {
            if (key == ' ') shouldQuit = true;
        }
        static void Main(string[] args)
        {
            ConsoleKeyEventPublisher consoleKeyEventPublisher = new ConsoleKeyEventPublisher();

            consoleKeyEventPublisher.Subscribe(MakeBeep);
            consoleKeyEventPublisher.Subscribe(ListenForQuietKey);

            while (shouldQuit == false)
            {
                consoleKeyEventPublisher.Update();
            }
        }
    }
}
