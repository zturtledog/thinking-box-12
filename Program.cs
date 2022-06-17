using System;

namespace thinking_box_12 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            window win = new window();
            win.init(450,450,"Thinking Box","./assets/icon.ico",true);
        }
    }
}
