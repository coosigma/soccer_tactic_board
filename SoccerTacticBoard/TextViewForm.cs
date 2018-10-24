using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerTacticBoard
{
    public partial class TextViewForm : Form, IBoardView
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
        public TextViewForm()
        {
            InitializeComponent();
        }
        /// <summary>Method: RefreshView
        /// Refresh this view
        /// </summary>
        public void RefreshView()
        {
            // clear listBox
            lsbLog.Items.Clear();
            foreach (APiece p in model.PieceList)
            {
                lsbLog.Items.Add(p);
            }
        }
        /// <summary>Method: btnCreate_Click
        /// Create piece to piecelist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string o = string.Empty;
            var checkedButton = Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            string obj = checkedButton.Text;
            if (obj.Equals(o))
            {
                MessageBox.Show("Please check the object first");
                return;
            }
            if (txbX.Text.Equals(o) || txbY.Text.Equals(o))
            {
                MessageBox.Show("Please type in the position of X and Y");
                return;
            }
            int x = Convert.ToInt32(txbX.Text);
            int y = Convert.ToInt32(txbY.Text);
            if (obj.Equals("Player"))
            {
                string side = cbbPlayerType.Text;
                string name = txbName.Text;
                if (!cbbColor.Text.Equals(o))
                {
                    if (side.Equals("Home"))
                    {
                        model.homeTeamColor = Color.FromName(cbbColor.Text);
                    }
                    else
                    {
                        model.awayTeamColor = Color.FromName(cbbColor.Text);
                    }                    
                }               
                if (side.Equals(o) || name.Equals(o) || txbNumber.Text.Equals(o))
                {
                    MessageBox.Show("Please select side and type in a number and a name.");
                    return;
                }
                int number = Convert.ToInt32(txbNumber.Text);
                Color c = (side.Equals("Home")) ? model.homeTeamColor : model.awayTeamColor;
                Player player = new Player(name, x, y, model.pieceW, model.pieceH, c, number, side.Equals("Home"));
                model.AddPiece(player);
            }
            else if (obj.Equals("Ball"))
            {
                if (cbbBallType.Text.Equals(o))
                {
                    MessageBox.Show("Please type in the type of ball");
                    return;
                }
                string name = "Ball";
                Ball.ImageType type = (cbbBallType.Text.Equals("White")) ? Ball.ImageType.White : Ball.ImageType.Orange;
                Ball ball = new Ball(name, x, y, model.pieceW, model.pieceH, type);
                model.AddPiece(ball);
            }
        }

    }
}
