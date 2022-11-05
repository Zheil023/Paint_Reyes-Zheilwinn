using System;

namespace Paint_Reyes__Zheilwinn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

public interface IPaintTool
{
    void MouseOver();
    void MouseUp();
}

public class PencilTool:IPaintTool
{
    public void MouseOver()
    {
        Console.WriteLine("Show pencil icon");
    }

    public void MouseUp()
    {
        Console.WriteLine("Draw a line.");
    }

  
}

public class SquareTool : IPaintTool
{
    public void MouseOver()
    {
        Console.WriteLine("Show square icon");
    }

    public void MouseUp()
    {
        Console.WriteLine("Draw a square.");
    }
}

public class EraserTool : IPaintTool
{
    public void MouseOver()
    {
        Console.WriteLine("Show an eraser icon");
    }

    public void MouseUp()
    {
        Console.WriteLine("Show an eraser icon");
    }
}



   

