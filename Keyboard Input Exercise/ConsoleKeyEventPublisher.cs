using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_Input_Exercise
{
    class ConsoleKeyEventPublisher
    {
        public delegate void TKeyPressed(char key);

        //assign an empty lampa func
        private TKeyPressed KeyPressedEvent = (char key) => { };
        
        public void Subscribe(TKeyPressed func)
        {
            KeyPressedEvent += func;
        }
        public void Update()
        {
            if (Console.KeyAvailable)
            {
                char keyPressed = Console.ReadKey(true).KeyChar;

                KeyPressedEvent(keyPressed);
            }
        }
    }
}
