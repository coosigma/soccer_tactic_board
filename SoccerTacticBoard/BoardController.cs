using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerTacticBoard
{
    /// <summary>
    /// The controller of the project as this is a MVC programme.
    /// </summary>
    public class BoardController
    {
        private ArrayList ViewList;
        /// <summary>
        /// Constructor
        /// </summary>
        public BoardController()
        {
            ViewList = new ArrayList();
        }
        /// <summary>method: AddView
        /// Add view to view list
        /// </summary>
        /// <param name="aView"></param>
        public void AddView(IBoardView aView)
        {
            ViewList.Add(aView);
        }

        public void UpdateViews()
        {
            foreach (IBoardView v in ViewList)
            {
                v.RefreshView();
            }
        }

    }
}
