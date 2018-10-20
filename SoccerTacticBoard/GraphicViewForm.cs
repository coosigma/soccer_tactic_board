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
        private bool dragging;
        APiece topPiece; //  variable for selected piece
        APiece editPiece; // variable for piece to edit
        // variables for mouse position
        Point lastPosition = new Point(0, 0);
        Point currentPosition = new Point(0, 0);
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
            // draw all pieces in arrayList
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
            blueToolStripMenuItem.Checked = true;
            ArrayList pieceBatch = new ArrayList();
            for (int i = 1; i <= 3; i++)
            {
                string n = "player" + i.ToString();
                Player player = new Player(n, xp, yp, w, h, c, i);
                pieceBatch.Add(player);
                xp += w;
            }
            model.AddPieceBatch(pieceBatch);
        }
        /// <summary>Method: pnlField_MouseClick
        /// Check the right click menu and set variable to edit status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlField_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                editPiece = null;
                ArrayList pl = model.PieceList;
                for (int i = pl.Count; i > 0; i--)
                {
                    APiece p = (APiece)pl[i - 1];
                    Point m = new Point(e.X, e.Y);                    
                    if (p.HitTest(m))
                    {
                        p.Highlight = true;
                        editPiece = p;
                        model.BringToFront(p);
                        break;
                    }
                }
                try
                {
                    APiece pre;
                    if (editPiece != null)
                    {
                        pre = (APiece)pl[pl.Count - 2];
                    }
                    else
                    {
                        pre = (APiece)pl[pl.Count - 1];
                    }
                    pre.Highlight = false;
                }
                catch (ArgumentOutOfRangeException) { }
                RefreshView();
                Point pt = pnlField.PointToScreen(e.Location);
                if (editPiece == null)
                {
                    pt = pnlField.PointToScreen(e.Location);
                    cmsField.Show(pt);
                } else
                {
                    checkColorChecked();
                    cmsPiece.Show(pt);
                }
            }
        }
        /// <summary>Method: checkColorChecked
        /// Make the color ToolStripMenuItems checked right
        /// </summary>
        public void checkColorChecked()
        {
            if(editPiece != null)
            {
                if (editPiece.Color == Color.Blue)
                {
                    ExclusiveCheckToolStripMenuItems(blueToolStripMenuItem);                    
                }
                else if (editPiece.Color == Color.Red)
                {
                    ExclusiveCheckToolStripMenuItems(redToolStripMenuItem);
                }
                else if (editPiece.Color == Color.Yellow)
                {
                    ExclusiveCheckToolStripMenuItems(yellowToolStripMenuItem);
                }

            }
            
        }
        /// <summary>Method: pnlField_MouseDown
        /// check if mouse is over piece and set variable to 
        /// enable piece to be moved
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlField_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left && topPiece != null)
            if (e.Button == MouseButtons.Left)
            {
                topPiece = null;
                ArrayList pl = model.PieceList; 
                for (int i = pl.Count; i > 0; i--)
                {
                    APiece p = (APiece)pl[i - 1];
                    Point m = new Point(e.X, e.Y);
                    Console.WriteLine(p.HitTest(m));
                    if (p.HitTest(m))
                    {
                        dragging = true;
                        p.Highlight = true;
                        topPiece = p;
                        model.BringToFront(topPiece);
                        break;
                    }                    
                }
                try
                {
                    APiece pre;
                    if (topPiece != null)
                    {
                        pre = (APiece)pl[pl.Count - 2];
                    }
                    else
                    {
                        pre = (APiece)pl[pl.Count - 1];
                    }
                    pre.Highlight = false;
                }
                catch (ArgumentOutOfRangeException) { } 
                RefreshView();
            }                
        }
        /// <summary>Method: pnlField_MouseUp
        /// method to stop dragging of piece
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlField_MouseUp(object sender, MouseEventArgs e)
        {
            if (topPiece != null)
            {
                System.Console.WriteLine("Left Mouse Up");
                topPiece.Highlight = false;
                model.UpdateViews();
                dragging = false;                
            }
        }
        /// <summary>Method: pnlField_MouseMove
        /// When the piece is selected by MouseDown and until the MouseUp,
        /// achieve the drag and drop to this piece
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlField_MouseMove(object sender, MouseEventArgs e)
        {
            // set last position to current position
            lastPosition = currentPosition;
            // set current position to mouse position
            currentPosition = new Point(e.X, e.Y);
            // calculate how far mouse has moved 
            int xMove = currentPosition.X - lastPosition.X;
            int yMove = currentPosition.Y - lastPosition.Y;
            if (dragging)
            {
                topPiece.x_pos += xMove;
                topPiece.y_pos += yMove;
                RefreshView();
            }
        }
        /// <summary>Method: numberToolStripMenuItem
        /// oOnclick numberToolStripMenuItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editPiece != null)
            {
                TextBox txt = new TextBox();
                int xOff = 5;
                int yOff = 5;
                Point l = new Point(editPiece.x_pos+xOff, editPiece.y_pos+yOff);
                txt.Location = l;
                txt.Width = 20;
                txt.Leave += new EventHandler(txt_Leave);
                pnlField.Controls.Add(txt);
            }           
        }
        /// <summary>Method: txt_Leave
        /// Generate the textbox for changing the player's number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void txt_Leave(object sender, EventArgs e)
        {
            using (Graphics g = this.pnlField.CreateGraphics())
            {
                g.DrawString(((TextBox)sender).Text, ((TextBox)sender).Font, Brushes.Black, ((TextBox)sender).Location);
            }
            ((TextBox)sender).Leave -= new EventHandler(txt_Leave);
            pnlField.Controls.Remove((TextBox)sender);
            ((TextBox)sender).Dispose();
            pnlField.Invalidate();
        }
        /// <summary>Method: blueToolStripMenuItem
        /// Onlick blueToolStripMenuItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExclusiveCheckToolStripMenuItems((ToolStripMenuItem)sender);
            if (editPiece != null && editPiece is Player)
            {
                Player p = (Player)editPiece;
                p.Color = Color.Blue;
                p.LineColor = Color.White;
                p.NumberColor = Color.White;
                model.UpdateViews();
            }
        }
        /// <summary>Method: redToolStripMenuItem
        /// Onlick redToolStripMenuItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExclusiveCheckToolStripMenuItems((ToolStripMenuItem)sender);
            if (editPiece != null && editPiece is Player)
            {
                Player p = (Player)editPiece;
                p.Color = Color.Red;
                p.LineColor = Color.White;
                p.NumberColor = Color.White;
                model.UpdateViews();
            }
        }
        /// <summary>Method: yellowToolStripMenuItem
        /// Onlick yellowToolStripMenuItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExclusiveCheckToolStripMenuItems((ToolStripMenuItem)sender);
            if (editPiece != null && editPiece is Player)
            {
                Player p = (Player)editPiece;
                p.Color = Color.Yellow;
                p.LineColor = Color.Black;
                p.NumberColor = Color.Black;
                model.UpdateViews();
            }
        }
        /// <summary>Method: ExclusiveCheckToolStripMenuItems
        /// Check the selected item and uncheck the orders
        /// </summary>
        /// <param name="selectedMenuItem"></param>
        public void ExclusiveCheckToolStripMenuItems(ToolStripMenuItem selectedMenuItem)
        {
            selectedMenuItem.Checked = true;
            // Select the other MenuItens from the ParentMenu(OwnerItens) and unchecked this,
            // The current Linq Expression verify if the item is a real ToolStripMenuItem
            // and if the item is a another ToolStripMenuItem to uncheck this.
            foreach (var ltoolStripMenuItem in (from object
            item in selectedMenuItem.Owner.Items
                                                let ltoolStripMenuItem = item as ToolStripMenuItem
                                                where ltoolStripMenuItem != null
                                                where !item.Equals(selectedMenuItem)
                                                select ltoolStripMenuItem))
                (ltoolStripMenuItem).Checked = false;
            editPiece.Highlight = false;
        }
    }
}
