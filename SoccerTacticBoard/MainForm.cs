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
    public partial class MainForm : Form
    {
        private BoardModel theModel;
        private BoardController theController;
        private GraphicViewForm graphicViewForm;
        private TextViewForm textViewForm;
        private FilterViewForm filterViewForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SetUpMVC();
        }
        /// <summary>Method: SetUpMVC
        /// make controller
        /// make model
        /// make views and 
        /// show views
        /// </summary>
        private void SetUpMVC()
        {
            // make controller
            theController = new BoardController();
            // make model
            theModel = new BoardModel(theController);
            // make views
            graphicViewForm = new GraphicViewForm();
            textViewForm = new TextViewForm();
            filterViewForm = new FilterViewForm();
            graphicViewForm.Model = theModel;
            textViewForm.Model = theModel;
            filterViewForm.Model = theModel;

            theController.AddView(graphicViewForm);
            theController.AddView(textViewForm);
            theController.AddView(filterViewForm);

            //show views
            filterViewForm.Show();
            textViewForm.Show();
            graphicViewForm.Show();

        }
    }
}
