using System;
using Raylib_cs;
using System.Globalization;
using System.Numerics;

namespace thinking_box_12 {
    class window {
        color istroke = new color(0,0,0);
        color ifill = new color(0,0,0);
        
        bool dfill = true;
        bool dstroke = true;

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

        //ifill(color ccllt)
        //istroke(color ccllt)


        public void fill(color ccllt) {
            ifill = ccllt;
        }

        public void ellipse(int x, int y, int width, int height) {
            if (dfill)
            Raylib.DrawEllipse(x+(width/2), y+(height/2), width, height, ifill.get());
            
            if (dstroke)
            Raylib.DrawEllipseLines(x+(width/2), y+(height/2), width, height, istroke.get());
        }




        public void clear() {
            Raylib.ClearBackground(ifill.get());
        }
    }

    public class color {
        Color cllo;

        public color(float hue, float saturation, float value) {
            cllo = Raylib.ColorFromHSV(hue, saturation, value);
        }

        // public color(int r, int b, int g) {
        //     // cllo = Raylib.Graphics.Raylib.Color.rgb(r,g,b);
        // }

        public color(int colo) {
            cllo = Raylib.GetColor((uint)colo);
        }

        public color(string hex) {
            cllo = Raylib.GetColor((uint)(int.Parse(hex, NumberStyles.HexNumber)));
        }

        public Color get() {
            return cllo;
        }

        public int from() {
            return Raylib.ColorToInt(cllo);
        }  

        public string fromhex() {
            return (Raylib.ColorToInt(cllo)).ToString("x");
        }

        public vector3 fromhsv() {
            return (new vector3(Raylib.ColorToHSV(cllo)));//new vector3(3,3,3);
        }
    }

    public class vector3 {
        public double x;
        public double y;
        public double z;

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

        public vector3(Vector3 vec) {
            x = vec.X;
            y = vec.Y;
            z = vec.Z;
        }

        public string toString() {
            return("x:"+x+", y:"+y+", z:"+z);
        }
    }
}
