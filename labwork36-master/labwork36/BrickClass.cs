using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Brick
{
    public Rectangle Rect { get; set; }
    public Color Color { get; set; }
    public bool IsActive { get; set; }

    public Brick(Rectangle rect, Color color)
    {
        Rect = rect;
        Color = color;
        IsActive = true;
    }
}

namespace labwork36
{
    internal class BrickClass
    {
    }
}
