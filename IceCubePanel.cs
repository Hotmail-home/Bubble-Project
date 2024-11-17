using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class IceCubePanel : Panel
{
    public IceCubePanel()
    {
        // To avoid flickering
        this.DoubleBuffered = true;
        BackColor = Color.Transparent;
        Size = new Size(250, 250);
    }
    private Color bc = Color.FromArgb(128, Color.LightBlue);

    [Category("AMRO Extra Options")]
    public Color BC
    {
        get { return bc; }
        set
        {
            bc = value;
            this.Invalidate();
        }
    }


    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Set smoothing for better quality
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Define the ice cube shape
        Rectangle iceCubeBounds = new Rectangle(10, 10, this.Width - 20, this.Height - 20);

        // Draw the ice cube with translucent layers and gradients
        DrawIceCube(e.Graphics, iceCubeBounds);
    }

    private void DrawIceCube(Graphics g, Rectangle bounds)
    {
        // Create a translucent blue base color for the ice cube
        Color iceBlue = Color.FromArgb(180, bc);

        // Create a gradient brush for the ice cube's top layer
        using (LinearGradientBrush iceBrush = new LinearGradientBrush(bounds, Color.White, iceBlue, LinearGradientMode.ForwardDiagonal))
        {
            // Draw the base of the ice cube
            g.FillRectangle(iceBrush, bounds);
        }

        // Add some frosty highlights on the top and bottom
        Rectangle topHighlightBounds = new Rectangle(bounds.X + 10, bounds.Y + 10, bounds.Width - 20, bounds.Height / 4);
        Rectangle bottomHighlightBounds = new Rectangle(bounds.X + 10, bounds.Bottom - bounds.Height / 4 - 10, bounds.Width - 20, bounds.Height / 4);

        using (GraphicsPath topPath = new GraphicsPath())
        {
            topPath.AddRectangle(topHighlightBounds);
            using (PathGradientBrush topBrush = new PathGradientBrush(topPath))
            {
                topBrush.CenterColor = Color.FromArgb(120, Color.White);
                topBrush.SurroundColors = new[] { Color.Transparent };
                g.FillPath(topBrush, topPath);
            }
        }

        using (GraphicsPath bottomPath = new GraphicsPath())
        {
            bottomPath.AddRectangle(bottomHighlightBounds);
            using (PathGradientBrush bottomBrush = new PathGradientBrush(bottomPath))
            {
                bottomBrush.CenterColor = Color.FromArgb(100, Color.White);
                bottomBrush.SurroundColors = new[] { Color.Transparent };
                g.FillPath(bottomBrush, bottomPath);
            }
        }

        // Draw the ice cube border
        using (Pen icePen = new Pen(Color.FromArgb(180, Color.SkyBlue), 2))
        {
            g.DrawRectangle(icePen, bounds);
        }

        // Add some cracks or patterns inside the ice cube to make it look more realistic
        DrawIceCracks(g, bounds);
    }

    private void DrawIceCracks(Graphics g, Rectangle bounds)
    {
        // Create some random lines or curves to simulate cracks inside the ice cube
        using (Pen crackPen = new Pen(Color.FromArgb(120, Color.WhiteSmoke), 1))
        {
            // Example cracks (you can create more complex patterns)
            g.DrawLine(crackPen, bounds.X + 20, bounds.Y + 30, bounds.X + 60, bounds.Y + 80);
            g.DrawLine(crackPen, bounds.X + 40, bounds.Y + 60, bounds.X + 80, bounds.Y + 120);
            g.DrawLine(crackPen, bounds.X + 10, bounds.Y + 100, bounds.X + 70, bounds.Y + 150);
        }
    }
}
