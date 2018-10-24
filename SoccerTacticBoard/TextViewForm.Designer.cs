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
            this.txbInput = new System.Windows.Forms.TextBox();
            this.pnlDrawOn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDrawOn
            // 
            this.pnlDrawOn.Controls.Add(this.lsbLog);
            this.pnlDrawOn.Location = new System.Drawing.Point(36, 29);
            this.pnlDrawOn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDrawOn.Name = "pnlDrawOn";
            this.pnlDrawOn.Size = new System.Drawing.Size(563, 362);
            this.pnlDrawOn.TabIndex = 0;
            // 
            // lsbLog
            // 
            this.lsbLog.FormattingEnabled = true;
            this.lsbLog.ItemHeight = 12;
            this.lsbLog.Location = new System.Drawing.Point(38, 18);
            this.lsbLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsbLog.Name = "lsbLog";
            this.lsbLog.Size = new System.Drawing.Size(485, 328);
            this.lsbLog.TabIndex = 0;
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(74, 436);
            this.txbInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(485, 21);
            this.txbInput.TabIndex = 1;
            // 
            // TextViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 492);
            this.Controls.Add(this.txbInput);
            this.Controls.Add(this.pnlDrawOn);
            this.Name = "TextViewForm";
            this.Text = "TextViewForm";
            this.pnlDrawOn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawOn;
        private System.Windows.Forms.ListBox lsbLog;
        private System.Windows.Forms.TextBox txbInput;
    }
}