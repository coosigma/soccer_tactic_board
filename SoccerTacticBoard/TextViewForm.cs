﻿using System;
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
    public partial class TextViewForm : Form, IBoardView
    {
        public TextViewForm()
        {
            InitializeComponent();
        }

        public void RefreshView()
        {
            throw new NotImplementedException();
        }
    }
}
