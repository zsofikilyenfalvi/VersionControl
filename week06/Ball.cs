using System;
using.System.Windows.Forms;


public class Class1: Label
{
	public Class1()
	{
		AutoSize = false;
		Width = 50;
		Height = Width;
		Paint += Ball_Paint;
	}
    private void Ball_Paint(object sender, PaintEventArgs e)
    {
        DrawImage(e.Graphics);
    }

    protected void DrawImage(Graphics g)
    {
        g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, Width, Height);
    }

    public void MoveBall()
    {
        Left += 1;
    }

}
