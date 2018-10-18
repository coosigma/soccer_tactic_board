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
    public class BoardModel
    {
        private ArrayList pieceList;
        private BoardController controller;
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
        /// <summary>method: AddShape
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
        /// <summary>method: UpdateShape
        /// Update a piece in the views
        /// </summary>
        /// <param name="aPiece"></param>
        public void UpdateShape(APiece aPiece)
        {
            UpdateViews();
        }
        /// <summary>method: DeleteShape
        /// Delete a piece from the views
        /// </summary>
        /// <param name="aPiece"></param>
        public void DeleteShape(APiece aPiece)
        {
            pieceList.Remove(aPiece);
            UpdateViews();
        }
        /// <summary>method: SendToBack
        /// method to resequence arrayList so selected shape is 
        /// drawn first
        /// </summary>
        /// <param name="aPiece"></param>
        public void SendToBack(APiece aPiece)
        {
            // first shape drawn is at the back			
            // temp arrayList to resort shapes so selected shape is drawn first
            ArrayList sortList = new ArrayList();
            // find index of shape to be drawn first
            int max = pieceList.IndexOf(aPiece);
            // first shape i.e. shape to send to back
            sortList.Add(aPiece);
            // copy to sortList in correct sequence
            for (int i = 0; i < max; i++)
            {
                sortList.Add(pieceList[i]);
            }

            // copy sortList back to shapeList
            for (int i = 0; i < sortList.Count; i++)
            {
                pieceList[i] = sortList[i];
            }
            UpdateViews();
        }
        /// <summary>method: BringToFront
        /// method to resequence arrayList so selected shape is 
        /// drawn last
        /// </summary>
        /// <param name="aPiece"></param>
        public void BringToFront(APiece aPiece)
        {
            // last shape drawn is at the front			
            // temp arrayList to resort shapes so selected shape is drawn last
            ArrayList sortList = new ArrayList(pieceList);
            // find index of shape to be drawn last
            int max = pieceList.IndexOf(aPiece);
            // find length of shapeList array
            int length = pieceList.Count;
            // copy shapeList to sortList excluding selected shape
            for (int i = max + 1; i < length; i++)
            {
                sortList[i - 1] = pieceList[i];
            }
            // last shape i.e. shape to bring to front
            sortList[length - 1] = pieceList[max];
            // copy sortList back to shapeList
            for (int i = 0; i < sortList.Count; i++)
            {
                pieceList[i] = sortList[i];
            }
            UpdateViews();
        }
        /// <summary>method: UpdateViews
        /// refresh all views
        /// </summary>
        public void UpdateViews()
        {
            controller.UpdateViews();
        }
    }
}
