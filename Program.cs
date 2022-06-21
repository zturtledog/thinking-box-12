using System;

namespace thinking_box_12 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            subwin win = new subwin();
            win.init(450,450,"Thinking Box","./assets/icon.ico",true);
        }

        class subwin : window {
            public override void draw() {
                fill(new color(0,0,0));//HSV(12,36.1,95.7)
                clear();
                fill(new color(207,76,66));
                ellipse(45,45,45,45);

                // Console.WriteLine((new color(0,0,0)).fromhsv().toString());
            } 
        }
    }
}
