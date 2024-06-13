using System.Drawing;

namespace FindTheExtremePointsOfTheRectangles.Models
{
    public class Rectangle
    {
        private Color Color { get; set; }
        private Point TopLeft { get; set; }
        private Point TopRight { get; set; }
        private Point BotLeft { get; set; }
        private Point BotRight { get; set; }

        public Rectangle(Color color, Point topLeft, Point topRight, Point botLeft, Point botRight)
        {
            Color = color;
            TopLeft = topLeft;
            TopRight = topRight;
            BotLeft = botLeft;
            BotRight = botRight;
        }

        public Rectangle OutlineTheAreaRectangles(Rectangle[] minor, System.Drawing.Color[] colors)
        {
            if (colors == null || colors.Length == 0 || minor.Length == 0 || minor == null) { return null; }

            double left = minor.Where(x => x.TopLeft.X >= TopLeft.X && colors.Contains(x.Color)).Min(x => x.TopLeft.X);
            double top = minor.Where(x => x.TopLeft.Y <= TopLeft.Y && colors.Contains(x.Color)).Max(x => x.TopLeft.Y);
            double right = minor.Where(x => x.BotRight.X <= BotRight.X && colors.Contains(x.Color)).Max(x => x.BotRight.X);
            double bot = minor.Where(x => x.BotRight.Y >= BotRight.Y && colors.Contains(x.Color)).Min(x => x.BotRight.Y);

            TopLeft = new Point(left, top);
            TopRight = new Point(right, top);
            BotLeft = new Point(left, bot);
            BotRight = new Point(right, bot);

            return this;
        }
    }

}
