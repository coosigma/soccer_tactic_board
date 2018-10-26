namespace SoccerTacticBoard
{
    partial class GraphicViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicViewForm));
            this.pnlField = new System.Windows.Forms.Panel();
            this.cmsField = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.awayTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeTeamToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.awayTeamToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ballToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refereeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainRefereeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assistantRefereeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.namesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPlayer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.numberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteTheTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmsReferee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteAllRefereesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsBall = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.whiteFootballToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeFootBallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsField.SuspendLayout();
            this.cmsPlayer.SuspendLayout();
            this.cmsReferee.SuspendLayout();
            this.cmsBall.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlField
            // 
            this.pnlField.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlField.BackgroundImage")));
            this.pnlField.Location = new System.Drawing.Point(9, 42);
            this.pnlField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlField.Name = "pnlField";
            this.pnlField.Size = new System.Drawing.Size(1067, 698);
            this.pnlField.TabIndex = 0;
            this.pnlField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlField_MouseClick);
            this.pnlField.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlField_MouseDoubleClick);
            this.pnlField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlField_MouseDown);
            this.pnlField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlField_MouseMove);
            this.pnlField.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlField_MouseUp);
            // 
            // cmsField
            // 
            this.cmsField.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsField.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.cmsField.Name = "cmsField";
            this.cmsField.Size = new System.Drawing.Size(127, 52);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamToolStripMenuItem,
            this.toolStripMenuItem1,
            this.playerToolStripMenuItem,
            this.ballToolStripMenuItem,
            this.refereeToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeTeamToolStripMenuItem,
            this.awayTeamToolStripMenuItem});
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.teamToolStripMenuItem.Text = "Team";
            // 
            // homeTeamToolStripMenuItem
            // 
            this.homeTeamToolStripMenuItem.Name = "homeTeamToolStripMenuItem";
            this.homeTeamToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.homeTeamToolStripMenuItem.Text = "Home Team";
            this.homeTeamToolStripMenuItem.Click += new System.EventHandler(this.homeTeamToolStripMenuItem_Click);
            // 
            // awayTeamToolStripMenuItem
            // 
            this.awayTeamToolStripMenuItem.Name = "awayTeamToolStripMenuItem";
            this.awayTeamToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.awayTeamToolStripMenuItem.Text = "Away Team";
            this.awayTeamToolStripMenuItem.Click += new System.EventHandler(this.awayTeamToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 6);
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeTeamToolStripMenuItem1,
            this.awayTeamToolStripMenuItem1});
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.playerToolStripMenuItem.Text = "Player";
            // 
            // homeTeamToolStripMenuItem1
            // 
            this.homeTeamToolStripMenuItem1.Name = "homeTeamToolStripMenuItem1";
            this.homeTeamToolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.homeTeamToolStripMenuItem1.Text = "Home Team";
            this.homeTeamToolStripMenuItem1.Click += new System.EventHandler(this.homeTeamToolStripMenuItem1_Click);
            // 
            // awayTeamToolStripMenuItem1
            // 
            this.awayTeamToolStripMenuItem1.Name = "awayTeamToolStripMenuItem1";
            this.awayTeamToolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.awayTeamToolStripMenuItem1.Text = "Away Team";
            this.awayTeamToolStripMenuItem1.Click += new System.EventHandler(this.awayTeamToolStripMenuItem1_Click);
            // 
            // ballToolStripMenuItem
            // 
            this.ballToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteFootballToolStripMenuItem,
            this.orangeFootBallToolStripMenuItem});
            this.ballToolStripMenuItem.Name = "ballToolStripMenuItem";
            this.ballToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ballToolStripMenuItem.Text = "Ball";
            // 
            // refereeToolStripMenuItem
            // 
            this.refereeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainRefereeToolStripMenuItem,
            this.assistantRefereeToolStripMenuItem});
            this.refereeToolStripMenuItem.Name = "refereeToolStripMenuItem";
            this.refereeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.refereeToolStripMenuItem.Text = "Referee";
            // 
            // mainRefereeToolStripMenuItem
            // 
            this.mainRefereeToolStripMenuItem.Name = "mainRefereeToolStripMenuItem";
            this.mainRefereeToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.mainRefereeToolStripMenuItem.Text = "Main Referee";
            this.mainRefereeToolStripMenuItem.Click += new System.EventHandler(this.mainRefereeToolStripMenuItem_Click);
            // 
            // assistantRefereeToolStripMenuItem
            // 
            this.assistantRefereeToolStripMenuItem.Name = "assistantRefereeToolStripMenuItem";
            this.assistantRefereeToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.assistantRefereeToolStripMenuItem.Text = "Assistant Referee";
            this.assistantRefereeToolStripMenuItem.Click += new System.EventHandler(this.assistantRefereeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.namesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // namesToolStripMenuItem
            // 
            this.namesToolStripMenuItem.Name = "namesToolStripMenuItem";
            this.namesToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.namesToolStripMenuItem.Text = "Names";
            this.namesToolStripMenuItem.Click += new System.EventHandler(this.namesToolStripMenuItem_Click);
            // 
            // cmsPlayer
            // 
            this.cmsPlayer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPlayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem3,
            this.deleteTheTeamToolStripMenuItem});
            this.cmsPlayer.Name = "cmsPiece";
            this.cmsPlayer.Size = new System.Drawing.Size(196, 82);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colourToolStripMenuItem,
            this.toolStripMenuItem2,
            this.numberToolStripMenuItem,
            this.nameToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueToolStripMenuItem,
            this.redToolStripMenuItem,
            this.yellowToolStripMenuItem});
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.colourToolStripMenuItem.Text = "Team Colour";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.yellowToolStripMenuItem.Text = "Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(174, 6);
            // 
            // numberToolStripMenuItem
            // 
            this.numberToolStripMenuItem.Name = "numberToolStripMenuItem";
            this.numberToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.numberToolStripMenuItem.Text = "Number";
            this.numberToolStripMenuItem.Click += new System.EventHandler(this.numberToolStripMenuItem_Click);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.nameToolStripMenuItem.Text = "Name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(192, 6);
            // 
            // deleteTheTeamToolStripMenuItem
            // 
            this.deleteTheTeamToolStripMenuItem.Name = "deleteTheTeamToolStripMenuItem";
            this.deleteTheTeamToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.deleteTheTeamToolStripMenuItem.Text = "Delete the team";
            this.deleteTheTeamToolStripMenuItem.Click += new System.EventHandler(this.deleteTheTeamToolStripMenuItem_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(579, 12);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(24, 25);
            this.txtNumber.TabIndex = 2;
            this.txtNumber.Visible = false;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(675, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(53, 25);
            this.txtName.TabIndex = 3;
            this.txtName.Visible = false;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // cmsReferee
            // 
            this.cmsReferee.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsReferee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem1,
            this.toolStripMenuItem4,
            this.deleteAllRefereesToolStripMenuItem});
            this.cmsReferee.Name = "cmsReferee";
            this.cmsReferee.Size = new System.Drawing.Size(218, 58);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(217, 24);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(214, 6);
            // 
            // deleteAllRefereesToolStripMenuItem
            // 
            this.deleteAllRefereesToolStripMenuItem.Name = "deleteAllRefereesToolStripMenuItem";
            this.deleteAllRefereesToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.deleteAllRefereesToolStripMenuItem.Text = "Delete All Referees";
            this.deleteAllRefereesToolStripMenuItem.Click += new System.EventHandler(this.deleteAllRefereesToolStripMenuItem_Click);
            // 
            // cmsBall
            // 
            this.cmsBall.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsBall.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteToolStripMenuItem,
            this.orangeToolStripMenuItem,
            this.toolStripMenuItem5,
            this.deleteToolStripMenuItem2});
            this.cmsBall.Name = "cmsBall";
            this.cmsBall.Size = new System.Drawing.Size(211, 110);
            // 
            // whiteFootballToolStripMenuItem
            // 
            this.whiteFootballToolStripMenuItem.Name = "whiteFootballToolStripMenuItem";
            this.whiteFootballToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.whiteFootballToolStripMenuItem.Text = "White Football";
            this.whiteFootballToolStripMenuItem.Click += new System.EventHandler(this.whiteFootballToolStripMenuItem_Click);
            // 
            // orangeFootBallToolStripMenuItem
            // 
            this.orangeFootBallToolStripMenuItem.Name = "orangeFootBallToolStripMenuItem";
            this.orangeFootBallToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.orangeFootBallToolStripMenuItem.Text = "Orange FootBall";
            this.orangeFootBallToolStripMenuItem.Click += new System.EventHandler(this.orangeFootBallToolStripMenuItem_Click);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.whiteToolStripMenuItem.Text = "White";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // orangeToolStripMenuItem
            // 
            this.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            this.orangeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.orangeToolStripMenuItem.Text = "Orange";
            this.orangeToolStripMenuItem.Click += new System.EventHandler(this.orangeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(207, 6);
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem2.Text = "Delete";
            this.deleteToolStripMenuItem2.Click += new System.EventHandler(this.deleteToolStripMenuItem2_Click);
            // 
            // GraphicViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 749);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.pnlField);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GraphicViewForm";
            this.Text = "GraphicViewForm";
            this.Load += new System.EventHandler(this.GraphicViewForm_Load);
            this.cmsField.ResumeLayout(false);
            this.cmsPlayer.ResumeLayout(false);
            this.cmsReferee.ResumeLayout(false);
            this.cmsBall.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.TopMost = true;
        }

        #endregion

        private System.Windows.Forms.Panel pnlField;
        private System.Windows.Forms.ContextMenuStrip cmsField;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ballToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refereeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem teamToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsPlayer;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem namesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem awayTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeTeamToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem awayTeamToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem deleteTheTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainRefereeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assistantRefereeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsReferee;
        private System.Windows.Forms.ContextMenuStrip cmsBall;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem deleteAllRefereesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteFootballToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orangeFootBallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
    }
}