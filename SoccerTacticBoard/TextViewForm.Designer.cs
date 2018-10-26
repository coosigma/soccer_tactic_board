namespace SoccerTacticBoard
{
    partial class TextViewForm
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
            this.pnlDrawOn = new System.Windows.Forms.Panel();
            this.lsbLog = new System.Windows.Forms.ListBox();
            this.rdbPlayer = new System.Windows.Forms.RadioButton();
            this.rdbBall = new System.Windows.Forms.RadioButton();
            this.rdbReferee = new System.Windows.Forms.RadioButton();
            this.lblType = new System.Windows.Forms.Label();
            this.txbX = new System.Windows.Forms.TextBox();
            this.cbbPlayerType = new System.Windows.Forms.ComboBox();
            this.cbbBallType = new System.Windows.Forms.ComboBox();
            this.cbbRefereeType = new System.Windows.Forms.ComboBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txbY = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbbColor = new System.Windows.Forms.ComboBox();
            this.lblSelector = new System.Windows.Forms.Label();
            this.txbSelector = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlDrawOn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDrawOn
            // 
            this.pnlDrawOn.Controls.Add(this.lsbLog);
            this.pnlDrawOn.Location = new System.Drawing.Point(48, 36);
            this.pnlDrawOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDrawOn.Name = "pnlDrawOn";
            this.pnlDrawOn.Size = new System.Drawing.Size(751, 452);
            this.pnlDrawOn.TabIndex = 20;
            // 
            // lsbLog
            // 
            this.lsbLog.FormattingEnabled = true;
            this.lsbLog.ItemHeight = 15;
            this.lsbLog.Location = new System.Drawing.Point(51, 22);
            this.lsbLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsbLog.Name = "lsbLog";
            this.lsbLog.Size = new System.Drawing.Size(645, 409);
            this.lsbLog.TabIndex = 0;
            // 
            // rdbPlayer
            // 
            this.rdbPlayer.AutoSize = true;
            this.rdbPlayer.Location = new System.Drawing.Point(48, 586);
            this.rdbPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.rdbPlayer.Name = "rdbPlayer";
            this.rdbPlayer.Size = new System.Drawing.Size(76, 19);
            this.rdbPlayer.TabIndex = 2;
            this.rdbPlayer.TabStop = true;
            this.rdbPlayer.Text = "Player";
            this.rdbPlayer.UseVisualStyleBackColor = true;
            // 
            // rdbBall
            // 
            this.rdbBall.AutoSize = true;
            this.rdbBall.Location = new System.Drawing.Point(48, 636);
            this.rdbBall.Margin = new System.Windows.Forms.Padding(4);
            this.rdbBall.Name = "rdbBall";
            this.rdbBall.Size = new System.Drawing.Size(60, 19);
            this.rdbBall.TabIndex = 7;
            this.rdbBall.TabStop = true;
            this.rdbBall.Text = "Ball";
            this.rdbBall.UseVisualStyleBackColor = true;
            // 
            // rdbReferee
            // 
            this.rdbReferee.AutoSize = true;
            this.rdbReferee.Location = new System.Drawing.Point(48, 686);
            this.rdbReferee.Margin = new System.Windows.Forms.Padding(4);
            this.rdbReferee.Name = "rdbReferee";
            this.rdbReferee.Size = new System.Drawing.Size(84, 19);
            this.rdbReferee.TabIndex = 9;
            this.rdbReferee.TabStop = true;
            this.rdbReferee.Text = "Referee";
            this.rdbReferee.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(149, 552);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 15);
            this.lblType.TabIndex = 19;
            this.lblType.Text = "Type";
            // 
            // txbX
            // 
            this.txbX.Location = new System.Drawing.Point(150, 512);
            this.txbX.Margin = new System.Windows.Forms.Padding(4);
            this.txbX.Name = "txbX";
            this.txbX.Size = new System.Drawing.Size(56, 25);
            this.txbX.TabIndex = 0;
            this.txbX.TextChanged += new System.EventHandler(this.txbX_TextChanged);
            // 
            // cbbPlayerType
            // 
            this.cbbPlayerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPlayerType.FormattingEnabled = true;
            this.cbbPlayerType.Items.AddRange(new object[] {
            "Home",
            "Away"});
            this.cbbPlayerType.Location = new System.Drawing.Point(152, 584);
            this.cbbPlayerType.Margin = new System.Windows.Forms.Padding(4);
            this.cbbPlayerType.Name = "cbbPlayerType";
            this.cbbPlayerType.Size = new System.Drawing.Size(111, 23);
            this.cbbPlayerType.TabIndex = 3;
            // 
            // cbbBallType
            // 
            this.cbbBallType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBallType.FormattingEnabled = true;
            this.cbbBallType.Items.AddRange(new object[] {
            "White",
            "Orange"});
            this.cbbBallType.Location = new System.Drawing.Point(152, 634);
            this.cbbBallType.Margin = new System.Windows.Forms.Padding(4);
            this.cbbBallType.Name = "cbbBallType";
            this.cbbBallType.Size = new System.Drawing.Size(111, 23);
            this.cbbBallType.TabIndex = 8;
            // 
            // cbbRefereeType
            // 
            this.cbbRefereeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRefereeType.FormattingEnabled = true;
            this.cbbRefereeType.Items.AddRange(new object[] {
            "Main",
            "Assistant"});
            this.cbbRefereeType.Location = new System.Drawing.Point(152, 684);
            this.cbbRefereeType.Margin = new System.Windows.Forms.Padding(4);
            this.cbbRefereeType.Name = "cbbRefereeType";
            this.cbbRefereeType.Size = new System.Drawing.Size(111, 23);
            this.cbbRefereeType.TabIndex = 10;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(147, 493);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(15, 15);
            this.lblX.TabIndex = 18;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(223, 492);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(15, 15);
            this.lblY.TabIndex = 17;
            this.lblY.Text = "Y";
            // 
            // txbY
            // 
            this.txbY.Location = new System.Drawing.Point(226, 512);
            this.txbY.Margin = new System.Windows.Forms.Padding(4);
            this.txbY.Name = "txbY";
            this.txbY.Size = new System.Drawing.Size(56, 25);
            this.txbY.TabIndex = 1;
            this.txbY.TextChanged += new System.EventHandler(this.txbY_TextChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(284, 552);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(95, 15);
            this.lblColor.TabIndex = 16;
            this.lblColor.Text = "Team Colour";
            // 
            // cbbColor
            // 
            this.cbbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbColor.FormattingEnabled = true;
            this.cbbColor.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Yellow"});
            this.cbbColor.Location = new System.Drawing.Point(284, 585);
            this.cbbColor.Margin = new System.Windows.Forms.Padding(4);
            this.cbbColor.Name = "cbbColor";
            this.cbbColor.Size = new System.Drawing.Size(109, 23);
            this.cbbColor.TabIndex = 4;
            // 
            // lblSelector
            // 
            this.lblSelector.Location = new System.Drawing.Point(281, 625);
            this.lblSelector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelector.Name = "lblSelector";
            this.lblSelector.Size = new System.Drawing.Size(247, 53);
            this.lblSelector.TabIndex = 15;
            this.lblSelector.Text = "Selector\r\n(e.g. \"Home 1\", \"Referee\", \"Assistant Referee 1\")";
            // 
            // txbSelector
            // 
            this.txbSelector.Location = new System.Drawing.Point(284, 684);
            this.txbSelector.Margin = new System.Windows.Forms.Padding(4);
            this.txbSelector.Name = "txbSelector";
            this.txbSelector.Size = new System.Drawing.Size(132, 25);
            this.txbSelector.TabIndex = 11;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(691, 544);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(108, 29);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(691, 618);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 29);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(691, 691);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 29);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(552, 691);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 29);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear Input";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txbNumber
            // 
            this.txbNumber.Location = new System.Drawing.Point(414, 585);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(70, 25);
            this.txbNumber.TabIndex = 5;
            this.txbNumber.TextChanged += new System.EventHandler(this.txbNumber_TextChanged);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(515, 585);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 25);
            this.txbName.TabIndex = 6;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(411, 552);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(55, 15);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(512, 552);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // TextViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 751);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbNumber);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txbSelector);
            this.Controls.Add(this.lblSelector);
            this.Controls.Add(this.cbbColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txbY);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.cbbRefereeType);
            this.Controls.Add(this.cbbBallType);
            this.Controls.Add(this.cbbPlayerType);
            this.Controls.Add(this.txbX);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.rdbReferee);
            this.Controls.Add(this.rdbBall);
            this.Controls.Add(this.rdbPlayer);
            this.Controls.Add(this.pnlDrawOn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TextViewForm";
            this.Text = "TextViewForm";
            this.pnlDrawOn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawOn;
        private System.Windows.Forms.ListBox lsbLog;
        private System.Windows.Forms.RadioButton rdbPlayer;
        private System.Windows.Forms.RadioButton rdbBall;
        private System.Windows.Forms.RadioButton rdbReferee;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txbX;
        private System.Windows.Forms.ComboBox cbbPlayerType;
        private System.Windows.Forms.ComboBox cbbBallType;
        private System.Windows.Forms.ComboBox cbbRefereeType;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txbY;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbbColor;
        private System.Windows.Forms.Label lblSelector;
        private System.Windows.Forms.TextBox txbSelector;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txbNumber;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
    }
}