using System;



namespace P02.Graphic_Editor
{
    public abstract class Shape: IShape
    {
        public void DrawShape()
        {
            Console.WriteLine($"I'm {GetType().Name}");
        }
    }
}
