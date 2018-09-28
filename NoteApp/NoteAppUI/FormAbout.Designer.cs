namespace NoteApp
{
    partial class FormAbout
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LabelAuthor = new System.Windows.Forms.Label();
            this.LabelFeedBack = new System.Windows.Forms.Label();
            this.LabelGitHub = new System.Windows.Forms.Label();
            this.LabelCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTitle.Location = new System.Drawing.Point(12, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(120, 31);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "NoteApp";
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.Location = new System.Drawing.Point(15, 49);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(43, 13);
            this.LabelVersion.TabIndex = 1;
            this.LabelVersion.Text = "v. 1.0.0";
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.AutoSize = true;
            this.LabelAuthor.Location = new System.Drawing.Point(12, 97);
            this.LabelAuthor.Name = "LabelAuthor";
            this.LabelAuthor.Size = new System.Drawing.Size(124, 13);
            this.LabelAuthor.TabIndex = 2;
            this.LabelAuthor.Text = "Author: Pavel Kazantsev";
            // 
            // LabelFeedBack
            // 
            this.LabelFeedBack.AutoSize = true;
            this.LabelFeedBack.Location = new System.Drawing.Point(12, 144);
            this.LabelFeedBack.Name = "LabelFeedBack";
            this.LabelFeedBack.Size = new System.Drawing.Size(173, 13);
            this.LabelFeedBack.TabIndex = 3;
            this.LabelFeedBack.Text = "e-mail for feedback: gcsoft@mail.ru";
            // 
            // LabelGitHub
            // 
            this.LabelGitHub.AutoSize = true;
            this.LabelGitHub.Location = new System.Drawing.Point(12, 193);
            this.LabelGitHub.Name = "LabelGitHub";
            this.LabelGitHub.Size = new System.Drawing.Size(143, 13);
            this.LabelGitHub.TabIndex = 4;
            this.LabelGitHub.Text = "GitHub: pavel0508/NoteApp";
            // 
            // LabelCopyright
            // 
            this.LabelCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelCopyright.AutoSize = true;
            this.LabelCopyright.Location = new System.Drawing.Point(12, 252);
            this.LabelCopyright.Name = "LabelCopyright";
            this.LabelCopyright.Size = new System.Drawing.Size(130, 13);
            this.LabelCopyright.TabIndex = 5;
            this.LabelCopyright.Text = "2018 Pavel Kazantsev (C)";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 274);
            this.Controls.Add(this.LabelCopyright);
            this.Controls.Add(this.LabelGitHub);
            this.Controls.Add(this.LabelFeedBack);
            this.Controls.Add(this.LabelAuthor);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.LabelTitle);
            this.Name = "FormAbout";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.Label LabelAuthor;
        private System.Windows.Forms.Label LabelFeedBack;
        private System.Windows.Forms.Label LabelGitHub;
        private System.Windows.Forms.Label LabelCopyright;
    }
}