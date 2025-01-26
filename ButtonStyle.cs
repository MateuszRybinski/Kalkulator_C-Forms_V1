using System.Drawing;
using System.Windows.Forms;

namespace Kalkulator_V1
{
    internal class ButtonStyle
    {
        public static void ApplyStyle(Button button)
        {
            // Podstawowy styl przycisku
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.Gray;
            button.ForeColor = Color.White;
            button.Font = new Font("Arial", 10, FontStyle.Bold);

            // Zaokrąglenie krawędzi
            button.Region = new Region(new System.Drawing.Drawing2D.GraphicsPath(
                new PointF[]
                {
                new PointF(0, 10),
                new PointF(10, 0),
                new PointF(button.Width - 10, 0),
                new PointF(button.Width, 10),
                new PointF(button.Width, button.Height - 10),
                new PointF(button.Width - 10, button.Height),
                new PointF(10, button.Height),
                new PointF(0, button.Height - 10)
                },
                new byte[]
                {
                (byte)System.Drawing.Drawing2D.PathPointType.Start,
                (byte)System.Drawing.Drawing2D.PathPointType.Line,
                (byte)System.Drawing.Drawing2D.PathPointType.Line,
                (byte)System.Drawing.Drawing2D.PathPointType.Line,
                (byte)System.Drawing.Drawing2D.PathPointType.Line,
                (byte)System.Drawing.Drawing2D.PathPointType.Line,
                (byte)System.Drawing.Drawing2D.PathPointType.Line,
                (byte)System.Drawing.Drawing2D.PathPointType.CloseSubpath
                }
            ));

            // Efekt zmiany koloru przy najechaniu
            button.MouseEnter += (s, e) => { button.BackColor = Color.DarkGray; };
            button.MouseLeave += (s, e) => { button.BackColor = Color.Gray; };
        }
    }
}
