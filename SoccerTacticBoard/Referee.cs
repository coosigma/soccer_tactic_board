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
        // Yellow card and red card lists
        private ArrayList yellowCardPlayers;
        private ArrayList redCardPlayers;
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
        public Referee(string name, int x, int y, int w, int h, Color c)
           : base(name, x, y, w, h, c)
        {
            yellowCardPlayers = new ArrayList();
            redCardPlayers = new ArrayList();
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
            return "Referee at " + this.Position();
        }

    }
}
