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
            this.ballToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refereeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.namesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPiece = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.homeTeamToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.awayTeamToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsField.SuspendLayout();
            this.cmsPiece.SuspendLayout();
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
            this.cmsField.Size = new System.Drawing.Size(211, 80);
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
            this.createToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
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
            this.homeTeamToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.homeTeamToolStripMenuItem.Text = "Home Team";
            this.homeTeamToolStripMenuItem.Click += new System.EventHandler(this.homeTeamToolStripMenuItem_Click);
            // 
            // awayTeamToolStripMenuItem
            // 
            this.awayTeamToolStripMenuItem.Name = "awayTeamToolStripMenuItem";
            this.awayTeamToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
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
            // ballToolStripMenuItem
            // 
            this.ballToolStripMenuItem.Name = "ballToolStripMenuItem";
            this.ballToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ballToolStripMenuItem.Text = "Ball";
            // 
            // refereeToolStripMenuItem
            // 
            this.refereeToolStripMenuItem.Name = "refereeToolStripMenuItem";
            this.refereeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.refereeToolStripMenuItem.Text = "Referee";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.namesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // namesToolStripMenuItem
            // 
            this.namesToolStripMenuItem.Name = "namesToolStripMenuItem";
            this.namesToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.namesToolStripMenuItem.Text = "Names";
            this.namesToolStripMenuItem.Click += new System.EventHandler(this.namesToolStripMenuItem_Click);
            // 
            // cmsPiece
            // 
            this.cmsPiece.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPiece.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsPiece.Name = "cmsPiece";
            this.cmsPiece.Size = new System.Drawing.Size(127, 52);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colourToolStripMenuItem,
            this.toolStripMenuItem2,
            this.numberToolStripMenuItem,
            this.nameToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // numberToolStripMenuItem
            // 
            this.numberToolStripMenuItem.Name = "numberToolStripMenuItem";
            this.numberToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.numberToolStripMenuItem.Text = "Number";
            this.numberToolStripMenuItem.Click += new System.EventHandler(this.numberToolStripMenuItem_Click);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.nameToolStripMenuItem.Text = "Name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueToolStripMenuItem,
            this.redToolStripMenuItem,
            this.yellowToolStripMenuItem});
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
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
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
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
            // homeTeamToolStripMenuItem1
            // 
            this.homeTeamToolStripMenuItem1.Name = "homeTeamToolStripMenuItem1";
            this.homeTeamToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.homeTeamToolStripMenuItem1.Text = "Home Team";
            this.homeTeamToolStripMenuItem1.Click += new System.EventHandler(this.homeTeamToolStripMenuItem1_Click);
            // 
            // awayTeamToolStripMenuItem1
            // 
            this.awayTeamToolStripMenuItem1.Name = "awayTeamToolStripMenuItem1";
            this.awayTeamToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.awayTeamToolStripMenuItem1.Text = "Away Team";
            this.awayTeamToolStripMenuItem1.Click += new System.EventHandler(this.awayTeamToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 6);
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
            this.cmsField.ResumeLayout(false);
            this.cmsPiece.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ContextMenuStrip cmsPiece;
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
    }
}