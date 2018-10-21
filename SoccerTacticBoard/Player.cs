﻿using System;
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
        private Color infoColor; // The font colour of the number
        private string infoFont;
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
            infoColor = (c == Color.Yellow)? Color.Black: Color.White;
            infoFont = "Arial";
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
        public string InfoFont
        {
            get { return infoFont; }
            set { infoFont = value; }
        }
        public Color InfoColor
        {
            get { return infoColor; }
            set { infoColor = value; }
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
        /// <summary>Method: Draw
        /// The Draw adapted Player behavior
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g, bool showName)
        {
            base.Draw(g);
            float NumberXOff = (Highlight) ? 5f : 4.5f;
            float NumberYOff = (Highlight) ? 2.5f : 2f;
            int NumberFontSize = (Highlight) ? 16 : 14;
            WriteInfo(g, number.ToString(), NumberXOff, NumberYOff, NumberFontSize);
            if (showName)
            {
                float NameXOff = (Highlight) ? -5.5f : -5f;
                float NameYOff = (Highlight) ? 28.5f : 28f;
                int NameFontSize = (Highlight) ? 10 : 8;
                WriteInfo(g, name, NameXOff, NameYOff, NameFontSize);
            }
        }
        /// <summary>Method: WriteInfo
        /// Write info to the Graphic View
        /// </summary>
        /// <param name="g"></param>
        /// <param name="info"></param>
        /// <param name="xOff"></param>
        /// <param name="yOff"></param>
        /// <param name="FontSize"></param>
        public void WriteInfo(Graphics g, string info, float xOff, float yOff, int FontSize)
        {
            Font drawFont = new Font(infoFont, FontSize);
            SolidBrush drawBrush = new SolidBrush(infoColor);
            StringFormat drawFormat = new StringFormat();
            g.DrawString(info, drawFont, drawBrush, x + xOff, y + yOff, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
        }
    }
}
