using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Digital_Task_Tracker
{
    internal class Resize
    {
        //Resize control function to calculate new sizes
        public static void resizeControl(Rectangle r, Control c, float originalFontSize, Rectangle originalFormSize, float height, float width)
        {
            float xRatio = (float)(width) / (float)(originalFormSize.Width);
            float yRatio = (float)(height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

            float ratio = xRatio;
            if (xRatio >= yRatio)
            {
                ratio = yRatio;
            }
            float fontScale = 1f;
            float newFontSize = originalFontSize * ratio * fontScale;
            Font newFont = new Font(c.Font.FontFamily, newFontSize);
            c.Font = newFont;
        }
    }
}
