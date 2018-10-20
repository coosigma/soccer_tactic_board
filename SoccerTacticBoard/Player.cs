using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SoccerTacticBoard
{
    /// <summary>class Player : APiece
    /// The class describes Player piece
    /// </summary>
    class Player : APiece
    {
        private int number; // The number of the player
        private Color numberColor; // The font colour of the number
        private string numberFont;
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
        public Player(string name, int x, int y, int w, int h, Color c, int number)
            : base(name, x, y, w, h, c)
        {
            this.number = number;
            numberColor = (c == Color.Yellow)? Color.Black: Color.White;
            numberFont = "Arial";
        }
        /// <summary>override method: ToString
        /// to display piece as text
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Player: " + Number.ToString() + " ("+name+") at " + this.Position();
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public string NumberFont
        {
            get { return numberFont; }
            set { numberFont = value; }
        }
        public Color NumberColor
        {
            get { return numberColor; }
            set { numberColor = value; }
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
        public override void Draw(Graphics g)
        {
            base.Draw(g);
            int FontSize = (Highlight) ? 16 : 14;
            Font drawFont = new Font(numberFont, FontSize);
            SolidBrush drawBrush = new SolidBrush(numberColor);
            StringFormat drawFormat = new StringFormat();
            float xOff = (Highlight) ? 5f : 4.5f;
            float yOff = (Highlight) ? 2.5f : 2f;
            g.DrawString(number.ToString(), drawFont, drawBrush, x+xOff, y+yOff, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
        }
    }
}
