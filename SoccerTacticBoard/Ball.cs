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
        public Ball(string name, int x, int y, int w, int h, ImageType i)
            : base(name, x, y, w, h, Color.Empty)
        {
            ballImage = i;
        }
        public ImageType BallImage 
        {
            get { return ballImage; }
            set { ballImage = value; }
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
        /// <summary>Method: Draw
        /// Override the virture draw method in base class
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {
            if (g != null)
            {
                //  The background image of the ball
                Image backImage = GetBackImage();
                float xOff = (Highlight) ? 4.1f : 4.1f;
                float yOff = (Highlight) ? 2.5f : 1.5f;
                // Draw image to screen.
                g.DrawImage(backImage, (float)x + xOff, (float)y + yOff);
            }
        }
        /// <summary>Method: GetBackImage
        /// To get correct image of the ball
        /// </summary>
        /// <returns></returns>
        public Image GetBackImage()
        {
            Image backImage;
            if (ballImage == ImageType.White)
            {
               backImage = Properties.Resources.WhiteBall;
            }
            else if (ballImage == ImageType.Orange)
            {
                backImage = backImage = Properties.Resources.OrangeBall;
            }
            else
            {
                backImage = backImage = Properties.Resources.WhiteBall;
            }
            return (Highlight)? new Bitmap(backImage, new Size(25, 25)) : new Bitmap(backImage, new Size(21, 21));
        }
    }
}
