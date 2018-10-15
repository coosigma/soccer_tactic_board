using System;
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

        public void RefreshView()
        {
            throw new NotImplementedException();
        }
    }
}
