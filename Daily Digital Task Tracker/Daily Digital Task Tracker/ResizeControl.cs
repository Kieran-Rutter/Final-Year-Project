using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Digital_Task_Tracker
{
    internal class ResizeControl
    {

        public static void resizeTextControl(Control c, float originalFontSize, Rectangle originalFormSize, float height, float width)
        {
            float xRatio = (float)(width) / (float)(originalFormSize.Width);
            float yRatio = (float)(height) / (float)(originalFormSize.Height);

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
