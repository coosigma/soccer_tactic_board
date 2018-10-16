using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SoccerTacticBoard
{
    /// <summary>class Ball : APiece
    /// The class describes Ball piece
    /// </summary>
    class Ball : APiece
    {
        public enum ImageType { White, Orange};
        private ImageType ballImage;
        public Ball(string name, int x, int y, int w, int h, Color c, int number)
            : base(name, x, y, w, h, c)
        {
            ballImage = ImageType.White;
        }
        public ImageType BallImage 
        {
            get { return ballImage; }
            set { ballImage = value; }
        }
        public override void Draw(Graphics g)
        {
            if (g != null)
            {
                //  The background image of the ball
                Image backImage = GetBackImage();
                // Create Point for upper-left corner of image.
                Point p = new Point(x, y);
                // Draw image to screen.
                g.DrawImage(backImage, p);
            }
        }

        public override int x_pos //non abstract property
        {
            get { return x; }
            set { x = value; }
        }

        public override int y_pos //non abstract property
        {
            get { return y; }
            set { y = value; }
        }

        public override int Width //non abstract property
        {
            get { return width; }
            set { width = value; }
        }

        public override int Height //non abstract property
        {
            get { return height; }
            set { height = value; }
        }

        public override Color Color //non abstract property
        {
            get { return color; }
            set { color = value; }
        }

        public override string Name //non abstract property
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()
        {
            return "Ball at " + this.Position();
        }
        public Image GetBackImage()
        {
            Image backImage;
            if (ballImage == ImageType.White)
            {
               backImage = (Highlight)? Image.FromFile("WhiteBall_big.jpg") : Image.FromFile("WhiteBall.jpg");
            }
            else if (ballImage == ImageType.Orange)
            {
                backImage = (Highlight) ? Image.FromFile("OrangeBall_big.jpg") : Image.FromFile("OrangeBall.jpg");
            }
            else
            {
                backImage = (Highlight) ? Image.FromFile("WhiteBall_big.jpg") : Image.FromFile("WhiteBall.jpg");
            }
            return backImage;
        }
    }
}
