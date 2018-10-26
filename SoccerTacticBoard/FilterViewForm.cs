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
    public partial class FilterViewForm : Form, IBoardView
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
        public FilterViewForm()
        {
            InitializeComponent();
        }
        /// <summary>Method: clearPanel
        /// Clear the Panel
        /// </summary>
        public void ClearPanel()
        {
            pnlField.Refresh();
        }
        /// <summary>Method RefreshView
        /// RefreshView for implement the interface
        /// and to call the private method refreshView(for overload)
        /// </summary>
        public void RefreshView()
        {
            refreshView();
        }
        /// <summary>Method: refreshView
        /// refresh the View
        /// </summary>
        private void refreshView(Type mode = null, string type = "")
        {
            // clear the panel
            ClearPanel();
            // redraw all pieces
            ReDraw(mode, type);
        }
        /// <summary>method: reDraw
        /// Redraws the pieces in the model
        /// </summary>
        public void ReDraw(Type mode, string type)
        {
            bool showName = ckbShowName.Checked;
            // create arrayList from model
            ArrayList pieces = model.PieceList;
            Graphics g = this.pnlField.CreateGraphics();
            // draw all pieces in arrayList
            foreach (APiece p in pieces)
            {
                if (p is Player && (mode == null || p.GetType() == mode))
                {
                    Player player = (Player)p;
                    bool side = type.Equals("home") ? true : false;
                    if (type.Equals("")||player.IsHomeTeam == side)
                        player.Draw(g, showName);
                }
                else if (p is Referee && (mode == null || p.GetType() == mode))
                {
                    Referee referee = (Referee)p;
                    string ref_type = type.Equals("main") ? "R" : "A";
                    if (type.Equals("") || referee.Type.Equals(ref_type))
                        referee.Draw(g);
                }
                else if (p is Ball && (mode == null || p.GetType() == mode))
                {
                    p.Draw(g);
                }
            }
        }
        /// <summary>Method: FilterViewForm_Load
        /// Initialise the cbbFilterList when form is loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterViewForm_Load(object sender, EventArgs e)
        {
            cbbFilterList.SelectedIndex = 0;
        }

        private void cbbFilterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbFilterList.Text == "All Pieces")
                refreshView();
            else if (cbbFilterList.Text == "Players Only")
                refreshView(typeof(Player));
            else if (cbbFilterList.Text == "Home Team Only")
                refreshView(typeof(Player), "home");
            else if (cbbFilterList.Text == "Away Team Only")
                refreshView(typeof(Player), "away");
            else if (cbbFilterList.Text == "Referees Only")
                refreshView(typeof(Referee));
            else if (cbbFilterList.Text == "Main Referee Only")
                refreshView(typeof(Referee), "main");
            else if (cbbFilterList.Text == "Assistant Referees Only")
                refreshView(typeof(Referee), "assistant");
            else if (cbbFilterList.Text == "Ball Only")
                refreshView(typeof(Ball));
            else
                refreshView();
        }
        /// <summary>Method: ckbShowName_CheckedChanged
        /// Change the status of showing name player's name or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckbShowName_CheckedChanged(object sender, EventArgs e)
        {
            cbbFilterList_SelectedIndexChanged(sender, e);
        }
    }
}
