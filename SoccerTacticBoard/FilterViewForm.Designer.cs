namespace SoccerTacticBoard
{
    partial class FilterViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterViewForm));
            this.pnlField = new System.Windows.Forms.Panel();
            this.cbbFilterList = new System.Windows.Forms.ComboBox();
            this.ckbShowName = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // pnlField
            // 
            this.pnlField.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlField.BackgroundImage")));
            this.pnlField.Location = new System.Drawing.Point(16, 15);
            this.pnlField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlField.Name = "pnlField";
            this.pnlField.Size = new System.Drawing.Size(1067, 698);
            this.pnlField.TabIndex = 0;
            // 
            // cbbFilterList
            // 
            this.cbbFilterList.FormattingEnabled = true;
            this.cbbFilterList.Items.AddRange(new object[] {
            "Select display.....",
            "All Pieces",
            "Players Only",
            "Home Team Only",
            "Away Team Only",
            "Referees Only",
            "Main Referee Only",
            "Assistant Referees Only",
            "Ball Only"});
            this.cbbFilterList.Location = new System.Drawing.Point(148, 722);
            this.cbbFilterList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbFilterList.Name = "cbbFilterList";
            this.cbbFilterList.Size = new System.Drawing.Size(567, 23);
            this.cbbFilterList.TabIndex = 1;
            this.cbbFilterList.SelectedIndexChanged += new System.EventHandler(this.cbbFilterList_SelectedIndexChanged);
            // 
            // ckbShowName
            // 
            this.ckbShowName.AutoSize = true;
            this.ckbShowName.Location = new System.Drawing.Point(811, 725);
            this.ckbShowName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbShowName.Name = "ckbShowName";
            this.ckbShowName.Size = new System.Drawing.Size(173, 19);
            this.ckbShowName.TabIndex = 2;
            this.ckbShowName.Text = "Show Player\'s Name";
            this.ckbShowName.UseVisualStyleBackColor = true;
            this.ckbShowName.CheckedChanged += new System.EventHandler(this.ckbShowName_CheckedChanged);
            // 
            // FilterViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 845);
            this.Controls.Add(this.ckbShowName);
            this.Controls.Add(this.cbbFilterList);
            this.Controls.Add(this.pnlField);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FilterViewForm";
            this.Text = "FilterViewForm";
            this.Load += new System.EventHandler(this.FilterViewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlField;
        private System.Windows.Forms.ComboBox cbbFilterList;
        private System.Windows.Forms.CheckBox ckbShowName;
    }
}