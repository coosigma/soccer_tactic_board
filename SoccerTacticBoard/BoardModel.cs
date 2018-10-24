using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace SoccerTacticBoard
    /// <summary>
    /// The model of the project as this is a MVC programme.
    /// </summary>
{
    enum Errors
    {
        NoError,
        NotFound,
        ExceedMax,
        ExceedRange,
        InvalidPara
    }
    public class BoardModel
    {
        private ArrayList pieceList;
        private BoardController controller;
        public int homeTeamCount = 0; // Record the number of the home team
        public int awayTeamCount = 0; // Record the number of the away team
        public Color homeTeamColor = Color.Red; // Record the color of the home team
        public Color awayTeamColor = Color.Blue; // Record the color of the away team
        public int pieceW = 25; // variable for piece's width
        public int pieceH = 25; // variable for piece's height
        public int mainRefereeCount = 0; // Record the number of main referee
        public int assistantRefereeCount = 0; // Record the number of assistant referee
        public int ballCount = 0; // Record the number of ball
        public int max_team_players = 18;
        public int max_ball = 1;
        public int max_main_referee = 1;
        public int max_assistant_referee = 4;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="bc"></param>
        public BoardModel(BoardController bc)
        {
            pieceList = new ArrayList();
            controller = bc;
        }
        public ArrayList PieceList
        {
            get
            {
                return pieceList;
            }
        }
        /// <summary>method: AddPiece
        /// Add a piece to the views
        /// </summary>
        /// <param name="aPiece"></param>
        public void AddPiece(APiece aPiece)
        {
            pieceList.Add(aPiece);
            UpdateViews();
        }
        /// <summary>Method: AddPieceBatch
        /// Add a batch of piece ot views
        /// </summary>
        /// <param name="pieceBatch"></param>
        public void AddPieceBatch(ArrayList pieceBatch)
        {
            foreach (APiece p in pieceBatch)
            {
                pieceList.Add(p);
            }            
            UpdateViews();
        }
        /// <summary>method: UpdatePiece
        /// Update a piece in the views
        /// </summary>
        /// <param name="aPiece"></param>
        public void UpdatePiece(APiece aPiece)
        {
            UpdateViews();
        }
        /// <summary>method: DeletePiece
        /// Delete a piece from the views
        /// </summary>
        /// <param name="aPiece"></param>
        public void DeletePiece(APiece aPiece)
        {
            pieceList.Remove(aPiece);
            UpdateViews();
        }
        /// <summary>method: SendToBack
        /// method to resequence arrayList so selected piece is 
        /// drawn first
        /// </summary>
        /// <param name="aPiece"></param>
        public void SendToBack(APiece aPiece)
        {
            // first Piece drawn is at the back			
            // temp arrayList to resort Pieces so selected Piece is drawn first
            ArrayList sortList = new ArrayList();
            // find index of Piece to be drawn first
            int max = pieceList.IndexOf(aPiece);
            // first Piece i.e. Piece to send to back
            sortList.Add(aPiece);
            // copy to sortList in correct sequence
            for (int i = 0; i < max; i++)
            {
                sortList.Add(pieceList[i]);
            }

            // copy sortList back to PieceList
            for (int i = 0; i < sortList.Count; i++)
            {
                pieceList[i] = sortList[i];
            }
            //UpdateViews();
        }
        /// <summary>method: BringToFront
        /// method to resequence arrayList so selected piece is 
        /// drawn last
        /// </summary>
        /// <param name="aPiece"></param>
        public void BringToFront(APiece aPiece)
        {
            // last Piece drawn is at the front			
            // temp arrayList to resort Pieces so selected Piece is drawn last
            ArrayList sortList = new ArrayList(pieceList);
            // find index of Piece to be drawn last
            int max = pieceList.IndexOf(aPiece);
            // find length of PieceList array
            int length = pieceList.Count;
            // copy PieceList to sortList excluding selected Piece
            for (int i = max + 1; i < length; i++)
            {
                sortList[i - 1] = pieceList[i];
            }
            // last Piece i.e. Piece to bring to front
            sortList[length - 1] = pieceList[max];
            // copy sortList back to PieceList
            for (int i = 0; i < sortList.Count; i++)
            {
                pieceList[i] = sortList[i];
            }
            //UpdateViews();
        }
        /// <summary>method: UpdateViews
        /// refresh all views
        /// </summary>
        public void UpdateViews()
        {
            controller.UpdateViews();
        }
        public bool checkExceedMax(string obj)
        {
            if (obj.Equals("home team"))
            {
                return homeTeamCount >= max_team_players;
            }
            else if (obj.Equals("away team"))
            {
                return awayTeamCount >= max_team_players;
            }
            else if (obj.Equals("main referee"))
            {
                return mainRefereeCount >= max_main_referee;
            }
            else if (obj.Equals("assistant referee"))
            {
                return assistantRefereeCount >= max_assistant_referee;
            }
            else if (obj.Equals("ball"))
            {
                return ballCount >= max_ball;
            }
            Console.WriteLine("Check Maximum Type Error.");
            return true; // type error cannot pass this check
        }
    }
}
