using System;
using Raylib_cs;

namespace thinking_box_12 {
    class window {
        color stroke = new color(0,0,0);

        public void init(int w,int h,string title,string icon,bool ires) {
            if (ires) {
                Raylib.SetConfigFlags(ConfigFlags.FLAG_WINDOW_RESIZABLE);
            }
            
            Raylib.InitWindow(w, h, title);
            Raylib.SetWindowIcon(Raylib.LoadImage(icon));
        
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                
                draw();

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }

        public virtual void draw() {
            Raylib.ClearBackground(Color.WHITE);
            Raylib.DrawText("now that you have a window, overite the draw function", 12, 12, 20, Color.BLACK);
        }

        //drawing functions

        // text
        // rect
        // line
        // ellipse(x,y,width,height)
            //void DrawEllipse(int centerX, int centerY, float radiusH, float radiusV, Color color);              // Draw ellipse
            //void DrawEllipseLines(int centerX, int centerY, float radiusH, float radiusV, Color color);         // Draw ellipse outline

        // point(int posX, int posY, Color color)
        // bezier
        // triangle
        // clear
        
        //color functions

        //fill(color ccllt)
        //stroke(color ccllt)


        public void ellipse(int x, int y, float width, float height) {
            
        }
    }

    public class color {
        Color cllo;

        public color(float hue, float saturation, float value) {
            cllo = Raylib.ColorFromHSV(hue, saturation, value);
        }

        public Color get() {
            return cllo;
        }

        public vector3 from() {
            // Raylib.Vector3 vlc = Raylib.ColorToHSV(cllo);

            // return new vector3(vlc.x,vlc.y,vlc.z);
            return new vector3(0,0,0);
        }  
    }

    public class vector3 {
        double x;
        double y;
        double z;

        public vector3(double x, double y, double z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public vector3(int x, int y, int z) {
            this.x = (double)x;
            this.y = (double)y;
            this.z = (double)z;
        }

        public vector3(float x, float y, float z) {
            this.x = (double)x;
            this.y = (double)y;
            this.z = (double)z;
        }

        public double getx() {
            return x;
        }
        
        public double gety() {
            return y;
        }
        
        public double getz() {
            return z;
        }

        public string toString() {
            return("x:"+x+", y:"+y+", z:"+z);
        }
    }
}
