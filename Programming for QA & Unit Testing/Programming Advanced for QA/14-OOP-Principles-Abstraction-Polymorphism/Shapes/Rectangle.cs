using System;
namespace Shapes
{
    public class Rectangle : IDrawable
    {
        public int Height { get; set;}
        public int Width { get; set; }

        public Rectangle(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public void Draw()
        {
            DrawLine(this.Width, '*', '*');
            for (int i = 1; i < this.Height - 1; i++)
            {
                DrawLine(this.Width, '*', ' ');
            }
            DrawLine(this.Width, '*', '*');
        }

        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; i++)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }
    }
}

