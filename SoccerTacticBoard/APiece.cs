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
        }
        /// <summary>virtual method: Draw
        /// Draw the circle piece
        /// </summary>
        /// <param name="g"></param>
        public virtual void Draw(Graphics g) 
        {
            if (g != null)
            {
                Brush br = new SolidBrush(color);
                if (Highlight) // If selected, draw it bigger
                {
                    g.FillEllipse(br, x, y, width + 3, height + 3);
                }
                else
                {
                    g.FillEllipse(br, x, y, width, height);
                }
           
                // make slightly smaller than shape to avoid shadow
                float borderDiameter = (Highlight) ? (float)(width) : (float)(width - 3);
                // draw border around circle
                Pen p = new Pen(Color.White, 3);
                p.DashStyle = DashStyle.Solid;
                // to avoid shadow position move position by 1.5
                float xFloat = (float)(x + 1.5);
                float yFloat = (float)(y + 1.5);
                g.DrawEllipse(p, xFloat, yFloat, borderDiameter, borderDiameter);
                p.Dispose();
            }
        }
        

        public bool Highlight
        {
            get { return highlight; }
            set { highlight = value; }
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
    }
}
