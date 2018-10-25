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
        // variables for max values of parameters input by user
        int max_X = 775;
        int max_Y = 533;
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
                MessageBox.Show("Please select the object first");
                return;
            }
            if (txbX.Text.Equals(o) || txbY.Text.Equals(o))
            {
                MessageBox.Show("Please type in the position of X and Y");
                return;
            }
            int x = Convert.ToInt32(txbX.Text);
            int y = Convert.ToInt32(txbY.Text);
            if (x > max_X || y > max_Y)
            {
                MessageBox.Show("Maximum value for X is " + max_X
                + "\r\n" + "Maximum value for Y is " + max_Y + "\r\n",
                "Please Check the Values Entered",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                Color c;
                bool type;
                if (side.Equals("Home"))
                {
                    if (model.checkExceedMax("home team"))
                    {
                        MessageBox.Show("The maximum of a team is "+model.max_team_players+". You cannot add any more.");
                        return;
                    }
                    c = model.homeTeamColor;
                    type = true;
                    model.homeTeamCount++;
                }
                else
                {
                    if (model.checkExceedMax("away team"))
                    {
                        MessageBox.Show("The maximum of a team is " + model.max_team_players + ". You cannot add any more.");
                        return;
                    }
                    c = model.awayTeamColor;
                    type = false;
                    model.awayTeamCount++;
                }
                Player player = new Player(name, x, y, model.pieceW, model.pieceH, c, number, type);
                model.AddPiece(player);
            }
            else if (obj.Equals("Ball"))
            {
                if (cbbBallType.Text.Equals(o))
                {
                    MessageBox.Show("Please type in the type of ball");
                    return;
                }
                if (model.checkExceedMax("ball"))
                {
                    MessageBox.Show("The maximum of ball is " + model.max_ball + ". You cannot add any more.");
                    return;
                }
                string name = "Ball";
                model.ballCount++;
                Ball.ImageType type = (cbbBallType.Text.Equals("White")) ? Ball.ImageType.White : Ball.ImageType.Orange;
                Ball ball = new Ball(name, x, y, model.pieceW, model.pieceH, type);
                model.AddPiece(ball);
            }
            else if (obj.Equals("Referee"))
            {
                if (cbbRefereeType.Text.Equals(o))
                {
                    MessageBox.Show("Please type in the type of referee");
                    return;
                }
                string name;
                string ref_type;
                if (cbbRefereeType.Text.Equals("Main"))
                {
                    if (model.checkExceedMax("main referee"))
                    {
                        MessageBox.Show("The maximum of main referee is " + model.max_main_referee + ". You cannot add any more.");
                        return;
                    }
                    model.mainRefereeCount++;
                    name = "Referee";
                    ref_type = "R";
                }
                else
                {
                    if (model.checkExceedMax("assistant referee"))
                    {
                        MessageBox.Show("The maximum of assistant referee is " + model.max_assistant_referee + ". You cannot add any more.");
                        return;
                    }
                    model.assistantRefereeCount++;
                    name = "Assistant Referee "+model.assistantRefereeCount;
                    ref_type = "A";
                }
                Color c = Color.Black;
                Referee referee = new Referee(name, x, y, model.pieceW, model.pieceH, c, ref_type);
                model.AddPiece(referee);
            }
        }
        /// <summary>Method: btnUpdate_Click
        /// Update selected piece
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string o = string.Empty;
            var checkedButton = Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            string obj = checkedButton.Text;
            if (obj.Equals(o))
            {
                MessageBox.Show("Please select the object first");
                return;
            }
            string selector = txbSelector.Text;
            if (selector.Equals(o) && !obj.Equals("Ball"))
            {
                MessageBox.Show("Please type in the selector.");
                return;
            }
            int x = txbX.Text.Equals(string.Empty) ? 0 : Convert.ToInt32(txbX.Text);
            int y = txbY.Text.Equals(string.Empty) ? 0 : Convert.ToInt32(txbY.Text);
            if (x > max_X || y > max_Y)
            {
                MessageBox.Show("Maximum value for X is " + max_X
                + "\r\n" + "Maximum value for Y is " + max_Y + "\r\n",
                "Please Check the Values Entered",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (obj.Equals("Player"))
            {
                string selected_side = string.Empty;
                string selected_number = string.Empty;
                string pattern = @"^(home|away) (\d+)$";
                foreach (Match match in Regex.Matches(selector, pattern, RegexOptions.IgnoreCase))
                {
                    selected_side = match.Groups[1].Value;
                    selected_number = match.Groups[2].Value;
                }
                if (selected_side == string.Empty || selected_number == string.Empty)
                {
                    MessageBox.Show("The selector of player should be Home/Away<space>Number.");
                    return;
                }
                Player player = (Player)model.GetAPiece(typeof(Player), 
                    selected_side.ToLower(), Convert.ToInt32(selected_number));
                if (player == null)
                {
                    MessageBox.Show("Not Found the player.");
                    return;
                }
                string name = txbName.Text;
                if (!cbbColor.Text.Equals(o))
                    player.Color = Color.FromName(cbbColor.Text);
                if (!txbNumber.Text.Equals(o))
                    player.Number = Convert.ToInt32(txbNumber.Text);
                if (!txbName.Text.Equals(o))
                    player.Name = txbName.Text;
                if (!txbX.Text.Equals(o))
                    player.x_pos = Convert.ToInt32(txbX.Text);
                if (!txbY.Text.Equals(o))
                    player.y_pos = Convert.ToInt32(txbY.Text);
                model.BringToFront(player);
            }
            else if (obj.Equals("Ball"))
            {
                Ball ball = (Ball)model.GetAPiece(typeof(Ball), "Ball");
                if (!txbX.Text.Equals(o))
                    ball.x_pos = Convert.ToInt32(txbX.Text);
                if (!txbY.Text.Equals(o))
                    ball.y_pos = Convert.ToInt32(txbY.Text);
                model.BringToFront(ball);
            }
            else if (obj.Equals("Referee"))
            {
                Referee referee = (Referee)model.GetAPiece(typeof(Referee), selector);
                if (referee == null)
                {
                    MessageBox.Show("Not Found the referee. You can check the selector example above the textbox.");
                    return;
                }
                if (!txbX.Text.Equals(o))
                    referee.x_pos = Convert.ToInt32(txbX.Text);
                if (!txbY.Text.Equals(o))
                    referee.y_pos = Convert.ToInt32(txbY.Text);
                model.BringToFront(referee);
            }
            model.UpdateViews();
        }
        /// <summary>Method: btnDelete_Click
        /// Delete the selected piece
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string o = string.Empty;
            var checkedButton = Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            string obj = checkedButton.Text;
            if (obj.Equals(o))
            {
                MessageBox.Show("Please select the object first");
                return;
            }
            string selector = txbSelector.Text;
            if (selector.Equals(o) && !obj.Equals("Ball"))
            {
                MessageBox.Show("Please type in the selector.");
                return;
            }
            if (obj.Equals("Player"))
            {
                string selected_side = string.Empty;
                string selected_number = string.Empty;
                string pattern = @"^(home|away) (\d+)$";
                foreach (Match match in Regex.Matches(selector, pattern, RegexOptions.IgnoreCase))
                {
                    selected_side = match.Groups[1].Value;
                    selected_number = match.Groups[2].Value;
                }
                if (selected_side == string.Empty || selected_number == string.Empty)
                {
                    MessageBox.Show("The selector of player should be Home/Away<space>Number.");
                    return;
                }
                Player player = (Player)model.GetAPiece(typeof(Player),
                    selected_side.ToLower(), Convert.ToInt32(selected_number));
                if (player == null)
                {
                    MessageBox.Show("Not Found the player.");
                    return;
                }
                model.DeletePiece(player);
            }
            else if (obj.Equals("Ball"))
            {
                Ball ball = (Ball)model.GetAPiece(typeof(Ball), "Ball");
                if (ball == null)
                {
                    MessageBox.Show("Not Found the ball.");
                    return;
                }
                model.DeletePiece(ball);
            }
            else if (obj.Equals("Referee"))
            {
                Referee referee = (Referee)model.GetAPiece(typeof(Referee), selector);
                if (referee == null)
                {
                    MessageBox.Show("Not Found the referee. You can check the selector example above the textbox.");
                    return;
                }
                model.DeletePiece(referee);
            }
            model.UpdateViews();
        }
        /// <summary>Method: txbNumber_TextChanged
        /// Check the number of input must be a 
        /// positive integer with maximum 2 digits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbNumber_TextChanged(object sender, EventArgs e)
        {
            String text = txbNumber.Text;
            if (text.Length > 2)
            {
                txbNumber.Text = text.Substring(0, 2);
            }
            else
            {
                Match m = Regex.Match(text, @"\d{1,2}$");
                while (!m.Success && text.Length > 0)
                {
                    text = text.Substring(0, text.Length - 1);
                    m = Regex.Match(text, @"\d{1,2}$");
                }
                txbNumber.Text = text;
                txbNumber.Select(text.Length, 0);
            }
        }
        /// <summary>Method: txbX_TextChanged
        /// Check the number of input must be a 
        /// positive integer with maximum 3 digits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbX_TextChanged(object sender, EventArgs e)
        {
            String text = txbX.Text;
            if (text.Length > 3)
            {
                txbX.Text = text.Substring(0, 3);
            }
            else
            {
                Match m = Regex.Match(text, @"\d{1,3}$");
                while (!m.Success && text.Length > 0)
                {
                    text = text.Substring(0, text.Length - 1);
                    m = Regex.Match(text, @"\d{1,3}$");
                }
                txbX.Text = text;
                txbX.Select(text.Length, 0);
            }
        }
        /// <summary>Method: txbY_TextChanged
        /// Check the number of input must be a 
        /// positive integer with maximum 3 digits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbY_TextChanged(object sender, EventArgs e)
        {
            String text = txbY.Text;
            if (text.Length > 3)
            {
                txbY.Text = text.Substring(0, 3);
            }
            else
            {
                Match m = Regex.Match(text, @"\d{1,3}$");
                while (!m.Success && text.Length > 0)
                {
                    text = text.Substring(0, text.Length - 1);
                    m = Regex.Match(text, @"\d{1,3}$");
                }
                txbY.Text = text;
                txbY.Select(text.Length, 0);
            }
        }
        /// <summary>Method: btnClear_Click
        /// Clear all user inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            var checkedButton = Controls.OfType<RadioButton>()
                          .FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
                checkedButton.Checked = false;
            cbbBallType.SelectedIndex = -1;
            cbbColor.SelectedIndex = -1;
            cbbPlayerType.SelectedIndex = -1;
            cbbRefereeType.SelectedIndex = -1;
            txbName.Text = "";
            txbNumber.Text = "";
            txbX.Text = "";
            txbY.Text = "";
            txbSelector.Text = "";
        }
    }
}
