using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ShadowPanel : Panel
{
    private int shadowSize = 10;
    private Color shadowColor = Color.Gray;

    public int ShadowSize
    {
        get { return shadowSize; }
        set { shadowSize = value; Invalidate(); }
    }

    public Color ShadowColor
    {
        get { return shadowColor; }
        set { shadowColor = value; Invalidate(); }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        DrawShadow(e.Graphics);
    }

    private void DrawShadow(Graphics g)
    {
        Rectangle shadowBounds = new Rectangle(
            this.ClientRectangle.X + shadowSize,
            this.ClientRectangle.Y + shadowSize,
            this.ClientRectangle.Width - shadowSize,
            this.ClientRectangle.Height - shadowSize
        );

        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddRectangle(shadowBounds);
            using (PathGradientBrush brush = new PathGradientBrush(path))
            {
                brush.CenterColor = Color.FromArgb(180, shadowColor);
                brush.SurroundColors = new Color[] { Color.Transparent };
                brush.FocusScales = new PointF(0.8f, 0.8f);
                g.FillRectangle(brush, shadowBounds);
            }
        }
    }
}
