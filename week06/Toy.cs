using System;
using.System.Windows.Forms;

public abstract class Toy: Label
{
    protected override void DrawImage(Graphics g)
    {
        g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, Width, Height);
    }
}
