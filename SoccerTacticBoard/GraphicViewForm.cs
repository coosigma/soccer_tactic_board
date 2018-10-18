using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerTacticBoard
{
    public partial class GraphicViewForm : Form, IBoardView
    {
        private BoardModel model;
        // set method for model
        public BoardModel Model
        {
            set
            {
                model = value;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public GraphicViewForm()
        {
            InitializeComponent();
        }
        /// <summary>Method: RefreshView
        /// Refresh the View
        /// </summary>
        public void RefreshView()
        {
            // clear the panel
            ClearPanel();
            // redraw all pieces
            ReDraw();
        }
        /// <summary>method: reDraw
        /// Redraws all the pieces in the model
        /// </summary>
        public void ReDraw()
        {
            // create arrayList from model
            ArrayList pieces = model.PieceList;
            Graphics g = this.pnlField.CreateGraphics();
            // draw all pieces in array
            foreach (APiece p in pieces)
            {
                p.Draw(g);
            }
        }
        /// <summary>Method: clearPanel
        /// Clear the Panel
        /// </summary>
        public void ClearPanel()
        {
            pnlField.Refresh();
        }

        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int xp = 50;
            int yp = 50;
            int w = 25;
            int h = w;
            Color c = Color.Blue;
            ArrayList pieceBatch = new ArrayList();
            for (int i = 1; i <= 11; i++)
            {
                string n = "player" + i.ToString();
                Player player = new Player(n, xp, yp, w, h, c, i);
                pieceBatch.Add(player);
                xp += w;
            }
            model.AddPieceBatch(pieceBatch);
        }

        private void pnlField_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point pt = pnlField.PointToScreen(e.Location);
                cmsField.Show(pt);
            }
        }
    }
}
