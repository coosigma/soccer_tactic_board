using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SoccerTacticBoard
{
    public abstract class APiece
    {
        protected string name;
        protected int x;
        protected int y;
        protected int width;
        protected int height;
        protected Color color;
        protected Color lineColor;
        // Is this piece seleted
        bool highlight;

        /// <summary>
        /// Constructor
        /// </summary>
        public APiece(string n, int x, int y, int w,
            int h, Color c)
        {
            name = n;
            this.x = x;
            this.y = y;
            width = w;
            height = h;
            color = c;
            highlight = false;
            lineColor = (c == Color.Yellow) ? Color.Black : Color.White;
        }
        /// <summary>virtual method: Draw
        /// Draw the circle piece
        /// </summary>
        /// <param name="g"></param>
        public virtual void Draw(Graphics g) 
        {
            float magnification = 1.15f;
            int line_width = 2;
            if (g != null)
            {
                Brush br = new SolidBrush(color);
                if (Highlight) // If selected, draw it bigger
                {
                    g.FillEllipse(br, x, y, width * magnification, height * magnification);
                }
                else
                {
                    g.FillEllipse(br, x, y, width, height);
                }
           
                // make slightly smaller than shape to avoid shadow
                float borderDiameter = (Highlight) ? (float)(width * magnification - line_width) : (float)(width - line_width);
                // draw border around circle
                Pen p = new Pen(lineColor, line_width);
                p.DashStyle = DashStyle.Solid;
                // to avoid shadow position move position by 1.5
                float xFloat = (float)(x + (line_width / 2));
                float yFloat = (float)(y + (line_width / 2));
                g.DrawEllipse(p, xFloat, yFloat, borderDiameter, borderDiameter);
                p.Dispose();
            }
        }
        

        public bool Highlight
        {
            get { return highlight; }
            set { highlight = value; }
        }
        public Color LineColor
        {
            get { return lineColor; }
            set { lineColor = value; }
        }

        public string Position()  //non abstract method
        {
            return "(" + x.ToString() + "," + y.ToString() + ")";
        }

        public abstract int x_pos //abstract property
        { get; set; }

        public abstract int y_pos //abstract property
        { get; set; }

        public abstract int Width //abstract property
        { get; set; }

        public abstract int Height //abstract property
        { get; set; }

        public abstract Color Color //abstract property
        { get; set; }

        public abstract string Name //abstract property
        { get; set; }

        /// <summary> virtual method: DebutTest
        /// Test the piece whether in the field or not
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public virtual bool DebutTest(Rectangle field)
        {
            Point pt = new Point(x+(width/2), y+(height/2));
            //default behaviour
            return field.Contains(pt);
        }
        /// <summary>virtual method: HitTest
        /// Test whether the mouse in hit the piece
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public virtual bool HitTest(Point p)
        {
            Rectangle ellipse = new Rectangle(x, y, width, height);
            // use the bounding box of your ellipse instead
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(ellipse);
            //default behaviour
            return myPath.IsVisible(p);
        }
    }
}
