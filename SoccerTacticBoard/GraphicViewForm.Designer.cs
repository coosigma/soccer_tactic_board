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
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ballToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refereeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPiece = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // 
            // cmsField
            // 
            this.cmsField.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsField.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem});
            this.cmsField.Name = "cmsField";
            this.cmsField.Size = new System.Drawing.Size(127, 28);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem,
            this.ballToolStripMenuItem,
            this.refereeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.teamToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // playerToolStripMenuItem
            // 
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 6);
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.teamToolStripMenuItem.Text = "Team";
            this.teamToolStripMenuItem.Click += new System.EventHandler(this.teamToolStripMenuItem_Click);
            // 
            // cmsPiece
            // 
            this.cmsPiece.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPiece.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cmsPiece.Name = "cmsPiece";
            this.cmsPiece.Size = new System.Drawing.Size(127, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // GraphicViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 749);
            this.Controls.Add(this.pnlField);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GraphicViewForm";
            this.Text = "GraphicViewForm";
            this.cmsField.ResumeLayout(false);
            this.cmsPiece.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}