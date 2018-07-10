using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRCform
{
    static class DummyWindowControler
    {
        private const int X_MARGIN = 5;
        private const int Y_MARGIN = 5;

        public static void DisplayFallingBalls(Graphics graphics, int x, int y, int width, int height)
        {
            DisplayFrame(graphics, x, y, width, height);
            graphics.Dispose();
        }

        private static void DisplayFrame(Graphics graphics, int x, int y, int width, int height)
        {
            SolidBrush brush = new SolidBrush(Color.FromArgb(100, 100, 100));
            graphics.FillRectangle(brush, new Rectangle(x + X_MARGIN, y + Y_MARGIN, width - 2 * X_MARGIN, height - 2 * Y_MARGIN));
            brush = new SolidBrush(Color.FromArgb(90, 90, 90));
            graphics.FillRectangle(brush, new Rectangle(x + X_MARGIN + 5, y + Y_MARGIN + 5, width - 2 * (X_MARGIN + 5), height - 2 * (Y_MARGIN + 5)));
            brush = new SolidBrush(Color.White);
            graphics.FillRectangle(brush, new Rectangle(x + X_MARGIN + 10, y + Y_MARGIN + 10, width - 2*(X_MARGIN + 10), height - 2*(Y_MARGIN+10)));
        }
    }
}
