



//Color topLeft topRight botLeft botRight

using FindTheExtremePointsOfTheRectangles.Models;

Rectangle main = new Rectangle(System.Drawing.Color.Green, new Point(0, 15), new Point(15, 15), new Point(0, 0), new Point(15, 0));
//Rectangle main = new Rectangle(Color.Green, new Point(0, 10), new Point(10,10), new Point(0, 0), new Point(10,0));

Rectangle[] minor =
{
    new Rectangle(System.Drawing.Color.Pink,new Point(1,11), new Point(5,11), new Point(1,8), new Point(5,8)),
    new Rectangle(System.Drawing.Color.Blue,new Point(3,12), new Point(9,12), new Point(3,10), new Point(9,10)),
    new Rectangle(System.Drawing.Color.Blue,new Point(8,11), new Point(11,11), new Point(8,7), new Point(11,7)),
    new Rectangle(System.Drawing.Color.Pink,new Point(6,8), new Point(9,8), new Point(6,3), new Point(9,3)),
    new Rectangle(System.Drawing.Color.Green,new Point(2,9), new Point(7,9), new Point(2,5), new Point(7,5))
};

System.Drawing.Color[] colors = new System.Drawing.Color[] { System.Drawing.Color.Green, System.Drawing.Color.Blue };

Rectangle result = main.OutlineTheAreaRectangles(minor, colors);

Console.ReadLine();
