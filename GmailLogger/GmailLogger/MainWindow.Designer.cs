namespace GmailLogger
{
    partial class GmailLogger
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
            System.Windows.Forms.Label toLabel;
            System.Windows.Forms.Label label1;
            this.recipientText = new System.Windows.Forms.TextBox();
            this.bodyText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.attachFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.attachmentButton = new System.Windows.Forms.Button();
            this.subjectText = new System.Windows.Forms.TextBox();
            toLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.Cursor = System.Windows.Forms.Cursors.Default;
            toLabel.Location = new System.Drawing.Point(12, 40);
            toLabel.Name = "toLabel";
            toLabel.Size = new System.Drawing.Size(23, 13);
            toLabel.TabIndex = 2;
            toLabel.Text = "To:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = System.Windows.Forms.Cursors.Default;
            label1.Location = new System.Drawing.Point(12, 66);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 13);
            label1.TabIndex = 6;
            label1.Text = "Subject:";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // recipientText
            // 
            this.recipientText.Location = new System.Drawing.Point(64, 37);
            this.recipientText.Name = "recipientText";
            this.recipientText.Size = new System.Drawing.Size(100, 20);
            this.recipientText.TabIndex = 0;
            // 
            // bodyText
            // 
            this.bodyText.Location = new System.Drawing.Point(64, 89);
            this.bodyText.Multiline = true;
            this.bodyText.Name = "bodyText";
            this.bodyText.Size = new System.Drawing.Size(292, 132);
            this.bodyText.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(281, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // attachFileDialog
            // 
            this.attachFileDialog.FileName = "Attachment";
            this.attachFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.attachFileDialog_FileOk);
            // 
            // attachmentButton
            // 
            this.attachmentButton.Location = new System.Drawing.Point(64, 242);
            this.attachmentButton.Name = "attachmentButton";
            this.attachmentButton.Size = new System.Drawing.Size(75, 23);
            this.attachmentButton.TabIndex = 4;
            this.attachmentButton.Text = "Attach File";
            this.attachmentButton.UseVisualStyleBackColor = true;
            this.attachmentButton.Click += new System.EventHandler(this.Attachment_Click);
            // 
            // subjectText
            // 
            this.subjectText.Location = new System.Drawing.Point(64, 63);
            this.subjectText.Name = "subjectText";
            this.subjectText.Size = new System.Drawing.Size(100, 20);
            this.subjectText.TabIndex = 5;
            // 
            // GmailLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 277);
            this.Controls.Add(label1);
            this.Controls.Add(this.subjectText);
            this.Controls.Add(this.attachmentButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(toLabel);
            this.Controls.Add(this.bodyText);
            this.Controls.Add(this.recipientText);
            this.Name = "GmailLogger";
            this.Text = "Gmail Logger";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox recipientText;
        private System.Windows.Forms.TextBox bodyText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog attachFileDialog;
        private System.Windows.Forms.Button attachmentButton;
        private System.Windows.Forms.TextBox subjectText;
    }
}

