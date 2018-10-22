using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using static SoccerTacticBoard.Ball;

namespace SoccerTacticBoard
{
    public partial class GraphicViewForm : Form, IBoardView
    {
        private BoardModel model;
        private int homeTeamCount = 0; // Record the number of the home team
        private int awayTeamCount = 0; // Record the number of the away team
        private Color homeTeamColor = Color.Red; // Record the color of the home team
        private Color awayTeamColor = Color.Blue; // Record the color of the away team
        private bool dragging;
        private bool showName=false;
        private Point mouseLocation; // variable for mouse location
        private static int pieceW = 25; // variable for piece's width
        private static int pieceH = pieceW; // variable for piece's height
        private int mainRefereeCount = 0; // Record the number of main referee
        private int assistantRefereeCount = 0; // Record the number of assistant referee
        private int ballCount = 0; // Record the number of ball
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
                if (p is Player)
                {
                    Player player = (Player)p;
                    player.Draw(g, showName);
                }
                else
                {
                    p.Draw(g);
                }
            }
        }
        /// <summary>Method: clearPanel
        /// Clear the Panel
        /// </summary>
        public void ClearPanel()
        {
            pnlField.Refresh();
        }
        /// <summary>Method: checkMenuItems
        /// According to the Number of Pieces to set the correct Menu Item status
        /// </summary>
        private void checkMenuItems()
        {
            /// The number of a team is from 0 to 18 /////////////
            /// The number of main referee is only 1 or 0 ////////
            /// The number of assistant referee is from 0 to 4 ///
            /// The number of ball is only 1 or 0 ////////////////
            if (homeTeamCount >= 18)
                homeTeamToolStripMenuItem1.Enabled = false;
            if (awayTeamCount >= 18)
                awayTeamToolStripMenuItem1.Enabled = false;
            if (homeTeamCount < 18)
            {
                homeTeamToolStripMenuItem1.Enabled = true;
                if (homeTeamCount < 1)
                    homeTeamToolStripMenuItem.Enabled = true; // Enable create team menu
            }
            if (awayTeamCount < 18)
            {
                awayTeamToolStripMenuItem1.Enabled = true;
                if (awayTeamCount < 1)
                    awayTeamToolStripMenuItem.Enabled = true; // Enable create team menu
            }
            if (mainRefereeCount >= 1)
                mainRefereeToolStripMenuItem.Enabled = false;
            if (assistantRefereeCount >= 4)
                assistantRefereeToolStripMenuItem.Enabled = false;
            if (mainRefereeCount < 1)
                mainRefereeToolStripMenuItem.Enabled = true;
            if (assistantRefereeCount < 4)
                assistantRefereeToolStripMenuItem.Enabled = true;
            if (ballCount > 0)
            {
                ballToolStripMenuItem.Enabled = false;
            }
            else
            {
                ballToolStripMenuItem.Enabled = true;
            }
        }
        /// <summary>Method: pnlField_MouseClick
        /// Check the right click menu and set variable to edit status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlField_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                return;
            if (txtNumber.Visible)
                changePlayerNumber(); // A way to finish editing Number of the editPiece
            if (txtName.Visible)
                changePlayerName(); // A way to finish editing Name of the editPiece
            if (e.Button == MouseButtons.Right)
            {
                mouseLocation = e.Location;
                checkMenuItems();
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
                // Control the content menu
                Point pt = pnlField.PointToScreen(e.Location);
                if (editPiece == null)
                {
                    pt = pnlField.PointToScreen(e.Location);
                    cmsField.Show(pt);
                }
                else if (editPiece is Player)
                {
                    checkColorChecked();
                    cmsPlayer.Show(pt);
                }
                else if (editPiece is Referee)
                {
                    cmsReferee.Show(pt);
                }
                else if (editPiece is Ball)
                {
                    checkBallTypeChecked();
                    cmsBall.Show(pt);
                }
            }
        }
        /// <summary>Method: checkBallTypeChecked
        /// Make the Ball type ToolStripMenuItems checked right
        /// </summary>
        private void checkBallTypeChecked()
        {
            if (editPiece != null && editPiece is Ball)
            {
                Ball b = (Ball)editPiece;
                if (b.BallImage == ImageType.White)
                {
                    ExclusiveCheckToolStripMenuItems(whiteToolStripMenuItem);
                }
                else if (b.BallImage == ImageType.Orange)
                {
                    ExclusiveCheckToolStripMenuItems(orangeToolStripMenuItem);
                }
                else
                {
                    Console.WriteLine("Ball Image Type Error.");
                }
            }                
        }
        /// <summary>Method: checkColorChecked
        /// Make the color ToolStripMenuItems checked right
        /// </summary>
        private void checkColorChecked()
        {
            if(editPiece != null && editPiece is Player)
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
            if (e.Button == MouseButtons.Left)
            {
                topPiece = null;
                ArrayList pl = model.PieceList; 
                for (int i = pl.Count; i > 0; i--)
                {
                    APiece p = (APiece)pl[i - 1];
                    Point m = new Point(e.X, e.Y);
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
        /// Onclick numberToolStripMenuItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editPiece != null && editPiece is Player)
            {
                Player p = (Player)editPiece;
                int xOff = 12;
                int yOff = 39;
                Point l = new Point(p.x_pos+xOff, p.y_pos+yOff);
                txtNumber.Text = p.Number.ToString();
                txtNumber.Location = l;
                txtNumber.Visible = true;
                txtNumber.Focus();
            }           
        }
        /// <summary>Method: changeTeamColor
        /// Change a team's color
        /// </summary>
        /// <param name="p"></param>
        /// <param name="c"></param>
        private void changeTeamColor(Player p, Color c)
        {
            foreach (APiece ap in model.PieceList)
            {
                if (!(ap is Player)) // next if ap is not a Player
                    continue;
                Player player = (Player)ap;
                if (player.IsHomeTeam != p.IsHomeTeam) // next if player is not in the target team
                    continue;
                player.Color = c;
            }
            if (p.IsHomeTeam) // Change the variable of the team color
            {
                homeTeamColor = c;
            }
            else
            {
                awayTeamColor = c;
            }
        }
        /// <summary>Method: blueToolStripMenuItem
        /// Onlick blueToolStripMenuItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ExclusiveCheckToolStripMenuItems((ToolStripMenuItem)sender);
            if (editPiece != null && editPiece is Player)
            {
                Player p = (Player)editPiece;
                changeTeamColor(p, Color.Blue);
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
                changeTeamColor(p, Color.Red);
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
                changeTeamColor(p, Color.Yellow);
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
        /// <summary>Method: txtNumber_TextChanged
        /// Treat when txtNumber TextChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            String text = txtNumber.Text;
            if (text.Length == 0)
            {
            }
            else if (text.Length > 2)
            {
                txtNumber.Text = text.Substring(0, 2);
            } else
            {
                Match m = Regex.Match(text, @"\d{1,2}");
                while (!m.Success && text.Length > 0)
                {
                    text = text.Substring(0, text.Length - 1);
                    m = Regex.Match(text, @"\d{1,2}");
                }
                txtNumber.Text = text;
                txtNumber.Select(text.Length, 0);
            }          
        }
        /// <summary>Method: txtNumber_KeyPress
        /// Treat when txtNumber KeyPress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // When pressed <Enter> key
            {
                e.Handled = true; // Stop the warning tone
                changePlayerNumber();
            }
        }
        /// <summary>Method: changePlayerNumber
        /// Change the Player's number
        /// </summary>
        private void changePlayerNumber()
        {
            if (editPiece != null && editPiece is Player)
            {
                Player p = (Player)editPiece;
                p.Number = Int32.Parse(txtNumber.Text);
                txtNumber.Visible = false;
                RefreshView();
            }
        }
        /// <summary>Method: nameToolStripMenuItem_Click
        /// Edite player's name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editPiece != null && editPiece is Player)
            {
                Player p = (Player)editPiece;
                int xOff = 1;
                int yOff = 62;
                Point l = new Point(p.x_pos + xOff, p.y_pos + yOff);
                txtName.Text = p.Name;
                txtName.Location = l;
                txtName.Visible = true;
                txtName.Focus();
            }
        }
        /// <summary>Method: txtName_KeyPress
        /// Treat when txtName KeyPress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // When pressed <Enter> key
            {
                e.Handled = true; // Stop the warning tone
                changePlayerName();
            }
        }
        /// <summary>Method: txtName_TextChanged
        /// Treat when txtName TextChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            String text = txtName.Text;
            if (text.Length == 0)
            {
            }
            else if (text.Length > 7)
            {
                txtNumber.Text = text.Substring(0, 7);
                txtNumber.Select(text.Length, 0);
            }
        }
        /// <summary>Method: changePlayerName
        /// Change the Player's name
        /// </summary>
        private void changePlayerName()
        {
            if (editPiece != null && editPiece is Player)
            {
                Player p = (Player)editPiece;
                p.Name = txtName.Text;
                txtName.Visible = false;
                RefreshView();
            }
        }
        /// <summary>Method: namesToolStripMenuItem1_Click
        /// Swap the status of show/hide Names
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void namesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showName = !showName;
            RefreshView();
        }
        /// <summary>Method: homeTeamToolStripMenuItem_Click
        /// Create home team
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homeTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int pop = 11;
            int xp = 50;
            int yp = 50;
            Color c = Color.Red;
            homeTeamColor = c;
            ArrayList pieceBatch = new ArrayList();
            for (int i = 1; i <= pop; i++)
            {
                homeTeamCount++;
                string n = "player" + homeTeamCount.ToString();
                Player player = new Player(n, xp, yp, pieceW, pieceH, c, homeTeamCount, true);
                pieceBatch.Add(player);
                xp += pieceW;
            }
            model.AddPieceBatch(pieceBatch);
            homeTeamToolStripMenuItem.Enabled = false;
        }
        /// <summary>Method: awayTeamToolStripMenuItem_Click
        /// Create away team
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void awayTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int pop = 11;
            int xp = 420;
            int yp = 50;
            Color c = Color.Blue;
            awayTeamColor = c;
            ArrayList pieceBatch = new ArrayList();
            for (int i = 1; i <= pop; i++)
            {
                awayTeamCount++;
                string n = "player" + awayTeamCount.ToString();
                Player player = new Player(n, xp, yp, pieceW, pieceH, c, awayTeamCount, false);
                pieceBatch.Add(player);
                xp += pieceW;
            }
            model.AddPieceBatch(pieceBatch);
            awayTeamToolStripMenuItem.Enabled = false;
        }
        /// <summary>Method: homeTeamToolStripMenuItem1
        /// Change the color of home team
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homeTeamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            homeTeamCount++;
            int xp = 0;
            int yp = 0;
            if (mouseLocation != null)
            {
                xp = mouseLocation.X - (pieceW / 2);
                yp = mouseLocation.Y - (pieceH / 2);
            }
            Color c = homeTeamColor;
            string n = "player" + homeTeamCount.ToString();
            Player player = new Player(n, xp, yp, pieceW, pieceH, c, homeTeamCount, true);
            model.AddPiece(player);
        }

        private void awayTeamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            awayTeamCount++;
            int xp = 0;
            int yp = 0;
            if (mouseLocation != null)
            {
                xp = mouseLocation.X - (pieceW / 2);
                yp = mouseLocation.Y - (pieceH / 2);
            }
            Color c = awayTeamColor;
            string n = "player" + awayTeamCount.ToString();
            Player player = new Player(n, xp, yp, pieceW, pieceH, c, awayTeamCount, false);
            model.AddPiece(player);
        }
        /// <summary>Method: deleteToolStripMenuItem_Click
        /// Delete selected player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editPiece != null && editPiece is Player)
            {
                Player p = (Player)editPiece;
                if (p.IsHomeTeam)
                {
                    homeTeamCount--;
                }
                else
                {
                    awayTeamCount--;
                }
                deletePiece(p);
                editPiece = null;
            }
        }
        /// <summary>Method: deletePiece
        /// Delete a piece from the piece list
        /// </summary>
        /// <param name="p"></param>
        private void deletePiece(APiece p)
        {
            try
            {
                model.PieceList.Remove(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            model.UpdateViews();
        }
        private DialogResult showWarningMessageBox(string message, string caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(this, message, caption, buttons);
            return result;
        }
        /// <summary>Method: deleteTheTeamToolStripMenuItem_Click
        /// Delete a team event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteTheTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editPiece != null && editPiece is Player)
            {
                Player p = (Player)editPiece;
                string team = (p.IsHomeTeam) ? "the home team" : "the away team";
                string message = "Do you really want to delete " + team + "?";
                string caption = "Deletion Confirmation";
                DialogResult result = showWarningMessageBox(message, caption);
                if (result == DialogResult.Yes)
                {
                    deleteWholeTeam(p);
                }
                else if (result == DialogResult.No)
                {
                    editPiece.Highlight = false;
                    return;
                }
            }
        }
        /// <summary>Method: deleteWholeTeam
        /// Delete the whole team of seleted player
        /// </summary>
        /// <param name="p"></param>
        private void deleteWholeTeam(Player p)
        {
            for (int i = model.PieceList.Count; i > 0; i--)
            {
                APiece ap = (APiece)model.PieceList[i - 1];
                if (!(ap is Player))
                    continue;
                Player player = (Player)ap;
                if (player.IsHomeTeam == p.IsHomeTeam)
                {
                    try
                    {
                        model.PieceList.RemoveAt(i-1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            if (p.IsHomeTeam)
            {
                homeTeamCount = 0;
            }
            else
            {
                awayTeamCount = 0;
            }
            model.UpdateViews();
        }
        /// <summary>Method: mainRefereeToolStripMenuItem_Click
        /// Create a main referee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainRefereeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainRefereeCount++;
            int xp = 0;
            int yp = 0;
            if (mouseLocation != null)
            {
                xp = mouseLocation.X - (pieceW / 2);
                yp = mouseLocation.Y - (pieceH / 2);
            }
            Color c = Color.Black;
            string n = "Referee";
            Referee referee = new Referee(n, xp, yp, pieceW, pieceH, c, "R");
            model.AddPiece(referee);
        }
        /// <summary>Method: assistantRefereeToolStripMenuItem
        /// Create a assistant referee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void assistantRefereeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            assistantRefereeCount++;
            int xp = 0;
            int yp = 0;
            if (mouseLocation != null)
            {
                xp = mouseLocation.X - (pieceW / 2);
                yp = mouseLocation.Y - (pieceH / 2);
            }
            Color c = Color.Black;
            string n = "Assistant Referee"+ assistantRefereeCount;
            Referee referee = new Referee(n, xp, yp, pieceW, pieceH, c, "A");
            model.AddPiece(referee);
        }
        /// <summary>Method: deleteToolStripMenuItem1
        /// Delete selected Referee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (editPiece != null && editPiece is Referee)
            {
                Referee r = (Referee)editPiece;
                if (r.Type.Equals("R"))
                {
                    mainRefereeCount--;
                }
                else if(r.Type.Equals("A"))
                {
                    assistantRefereeCount--;
                }
                else
                {
                    Console.WriteLine("Referee Type Error.");
                }
                try
                {
                    deletePiece(r);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                editPiece = null;
            }
        }
        /// <summary>Method: deleteAllRefereesToolStripMenuItem_Click
        /// Delete all Referees Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteAllRefereesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Do you really want to delete all Referees?";
            string caption = "Deletion Confirmation";
            DialogResult result = showWarningMessageBox(message, caption);
            if (result == DialogResult.Yes)
            {
                deleteAllReferees();
            }
            else if (result == DialogResult.No)
            {
                editPiece.Highlight = false;
                return;
            }
        }
        /// <summary>Method: deleteAllReferees
        /// Delete all Referees
        /// </summary>
        private void deleteAllReferees()
        {
            for (int i = model.PieceList.Count; i > 0; i--)
            {
                APiece ap = (APiece)model.PieceList[i - 1];
                if (!(ap is Referee))
                    continue;
                try
                {
                    model.PieceList.RemoveAt(i - 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            mainRefereeCount = 0;
            assistantRefereeCount = 0;
            model.UpdateViews();
        }
        /// <summary>Method: pnlField_MouseDoubleClick
        /// Main Referee whistle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlField_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ArrayList pl = model.PieceList;
            foreach (APiece p in pl)
            {
                Point m = new Point(e.X, e.Y);
                if (!(p is Referee))
                    continue;
                Referee r = (Referee)p;
                if (r.Type.Equals("R"))
                {
                    if (r.HitTest(m))
                    {
                        r.Highlight = true;
                        editPiece = r;
                        model.BringToFront(r);
                        r.Whistle();
                        break;
                    }
                }
            }
        }
        /// <summary>Method: GraphicViewForm_Load
        /// When Load the form (solving sound lag)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GraphicViewForm_Load(object sender, EventArgs e)
        {
            SoundPlayer sndVoid = new SoundPlayer(SoccerTacticBoard.Properties.Resources.Void);
            sndVoid.Play();
        }
        /// <summary>Method: whiteFootballToolStripMenuItem_Click
        /// Create a white ball
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void whiteFootballToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ballCount++;
            int xp = 0;
            int yp = 0;
            if (mouseLocation != null)
            {
                xp = mouseLocation.X - (pieceW / 2);
                yp = mouseLocation.Y - (pieceH / 2);
            }
            string n = "Ball";
            Ball ball = new Ball(n, xp, yp, pieceW, pieceH, ImageType.White);
            model.AddPiece(ball);
        }
        /// <summary>Method: orangeFootballToolStripMenuItem_Click
        /// Create an orange ball
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orangeFootBallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ballCount++;
            int xp = 0;
            int yp = 0;
            if (mouseLocation != null)
            {
                xp = mouseLocation.X - (pieceW / 2);
                yp = mouseLocation.Y - (pieceH / 2);
            }
            string n = "Ball";
            Ball ball = new Ball(n, xp, yp, pieceW, pieceH, ImageType.Orange);
            model.AddPiece(ball);
        }
        /// <summary>Method: whiteToolStripMenuItem_Click
        /// Change the ball to White Ball
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeBallType(ImageType.White);
        }
        /// <summary>Method: orangeToolStripMenuItem_Click
        /// Change the ball to Orange Ball
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeBallType(ImageType.Orange);
        }
        /// <summary>Method: changeBallType
        /// Change the ball image type
        /// </summary>
        /// <param name="i"></param>
        private void changeBallType(ImageType i)
        {
            ArrayList pl = model.PieceList;
            foreach (APiece p in pl)
            {
                if (!(p is Ball))
                    continue;
                Ball b = (Ball)p;
                b.BallImage = i;
                break;
            }
            model.UpdateViews();
        }
        /// <summary>Method: deleteToolStripMenuItem2_Click
        /// Delete the ball
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (editPiece != null && editPiece is Ball)
            {
                try
                {
                    model.PieceList.Remove(editPiece);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                editPiece = null;
                ballCount = 0;
                model.UpdateViews();
            }
        }
    }
}
