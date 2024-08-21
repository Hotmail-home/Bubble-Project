using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class BubblePanel : Panel
{
    public BubblePanel()
    {
        // To avoid flickering
        this.DoubleBuffered = true;
        BackColor = Color.Transparent;
        Size = new Size(250, 250);
    }

    private Color bc = Color.FromArgb(128, Color.Aqua);

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

        
        // Define the bubble shape
        int borderRadius = 50; // Adjust for roundness
        Rectangle bubbleBounds = new Rectangle(10, 10, this.Width - 20, this.Height - 20);

        // Create a shadow effect
        Rectangle shadowBounds = new Rectangle(bubbleBounds.X + 10, bubbleBounds.Y + 10, bubbleBounds.Width, bubbleBounds.Height);
        using (GraphicsPath shadowPath = new GraphicsPath())
        {
            shadowPath.AddEllipse(shadowBounds);
            using (PathGradientBrush shadowBrush = new PathGradientBrush(shadowPath))
            {
                shadowBrush.CenterColor = Color.FromArgb(60, Color.Black); // Transparent shadow
                shadowBrush.SurroundColors = new[] { Color.Transparent };
                e.Graphics.FillPath(shadowBrush, shadowPath);
            }
        }

        // Add rainbow layers on top
        AddRainbowLayers(e.Graphics, bubbleBounds);

        // Create the bubble shape with base color
        using (GraphicsPath bubblePath = new GraphicsPath())
        {
            bubblePath.AddEllipse(bubbleBounds);

            using (LinearGradientBrush bubbleBrush = new LinearGradientBrush(bubbleBounds, Color.FromArgb(bc.R / 2, bc.G / 2, bc.B / 2), bc, LinearGradientMode.Vertical))
            {
                e.Graphics.FillPath(bubbleBrush, bubblePath);
            }

            // Draw the bubble border
            using (Pen pen = new Pen(Color.FromArgb(25, Color.Black), 3))
            {
                e.Graphics.DrawPath(pen, bubblePath);
            }
        }

        // Add glossy highlight (water reflection effect)
        Rectangle highlightBounds = new Rectangle(bubbleBounds.X + 15, bubbleBounds.Y + 15, bubbleBounds.Width / 2, bubbleBounds.Height / 2);
        using (GraphicsPath highlightPath = new GraphicsPath())
        {
            highlightPath.AddEllipse(highlightBounds);
            using (PathGradientBrush highlightBrush = new PathGradientBrush(highlightPath))
            {
                highlightBrush.CenterColor = Color.FromArgb(128, Color.White); // Semi-transparent white
                highlightBrush.SurroundColors = new[] { Color.Transparent };
                e.Graphics.FillPath(highlightBrush, highlightPath);
            }
        }


       
    }

    private void AddRainbowLayers(Graphics g, Rectangle bounds)
    {
        // Define the rainbow colors
        Color[] rainbowColors = new Color[]
        {
            Color.Red,
            Color.Orange,
            Color.Yellow,
            Color.Green,
            Color.Blue,
            Color.Indigo,
            Color.Violet
        };

        // Loop through the rainbow colors and draw layers
        int layerOffset = 1; // Increase the offset to reduce the number of layers
        foreach (var color in rainbowColors)
        {
            Rectangle layerBounds = new Rectangle(bounds.X + layerOffset, bounds.Y + layerOffset, bounds.Width - layerOffset * 2, bounds.Height - layerOffset * 2);

            // Avoid drawing if the bounds are too small
            if (layerBounds.Width <= 0 || layerBounds.Height <= 0)
                break;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(layerBounds);
                using (PathGradientBrush brush = new PathGradientBrush(path))
                {
                    brush.CenterColor = Color.FromArgb(100, color); // Semi-transparent color
                    brush.SurroundColors = new[] { Color.Transparent };
                    g.FillPath(brush, path);
                }
            }

            layerOffset += 5; // Adjust layer thickness
        }
    }

    protected override CreateParams CreateParams
    {
        get
        {
            var cp = base.CreateParams;
            cp.ExStyle |= 0x00000020;
            return cp;
        }
    }


}
