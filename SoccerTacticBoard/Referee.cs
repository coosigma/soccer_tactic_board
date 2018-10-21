using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;

namespace SoccerTacticBoard
{
    /// <summary>class Referee : APiece
    /// The class describes Referee piece
    /// </summary>
    class Referee : APiece
    {
        private string type; // Referee type (R = Main Referee, A = Assistant Referee)
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <param name="c"></param>
        /// <param name="number"></param>
        public Referee(string name, int x, int y, int w, int h, Color c, string t)
           : base(name, x, y, w, h, c)
        {
            type = t;
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
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
            return name + " at " + this.Position();
        }
        /// <summary>Method: Draw
        /// Override the virture draw method in base class
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {
            base.Draw(g);
            int FontSize = (Highlight) ? 16 : 14;
            Font drawFont = new Font("Arial", FontSize);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            StringFormat drawFormat = new StringFormat();
            float xOff = (Highlight) ? 4.1f : 4.1f;
            float yOff = (Highlight) ? 2.5f : 1.5f;
            g.DrawString(type, drawFont, drawBrush, x + xOff, y + yOff, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
        }
    }
}
