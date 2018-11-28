namespace NoteApp
{
    partial class FormEditNote
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelCreated = new System.Windows.Forms.Label();
            this.LabelChanged = new System.Windows.Forms.Label();
            this.FieldTitle = new System.Windows.Forms.TextBox();
            this.ComboBoxCategory = new System.Windows.Forms.ComboBox();
            this.DateTimeCreated = new System.Windows.Forms.DateTimePicker();
            this.DateTimeChanged = new System.Windows.Forms.DateTimePicker();
            this.TextNote = new System.Windows.Forms.TextBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.TimerForCheckError = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(12, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(30, 13);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Title:";
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(12, 35);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(52, 13);
            this.LabelCategory.TabIndex = 1;
            this.LabelCategory.Text = "Category:";
            // 
            // LabelCreated
            // 
            this.LabelCreated.AutoSize = true;
            this.LabelCreated.Location = new System.Drawing.Point(12, 61);
            this.LabelCreated.Name = "LabelCreated";
            this.LabelCreated.Size = new System.Drawing.Size(47, 13);
            this.LabelCreated.TabIndex = 2;
            this.LabelCreated.Text = "Created:";
            // 
            // LabelChanged
            // 
            this.LabelChanged.AutoSize = true;
            this.LabelChanged.Location = new System.Drawing.Point(205, 61);
            this.LabelChanged.Name = "LabelChanged";
            this.LabelChanged.Size = new System.Drawing.Size(50, 13);
            this.LabelChanged.TabIndex = 3;
            this.LabelChanged.Text = "Modified:";
            // 
            // FieldTitle
            // 
            this.FieldTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldTitle.Location = new System.Drawing.Point(92, 6);
            this.FieldTitle.Name = "FieldTitle";
            this.FieldTitle.Size = new System.Drawing.Size(433, 20);
            this.FieldTitle.TabIndex = 4;
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Location = new System.Drawing.Point(92, 32);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(130, 21);
            this.ComboBoxCategory.TabIndex = 5;
            this.ComboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategory_SelectedIndexChanged);
            // 
            // DateTimeCreated
            // 
            this.DateTimeCreated.Enabled = false;
            this.DateTimeCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeCreated.Location = new System.Drawing.Point(92, 59);
            this.DateTimeCreated.Name = "DateTimeCreated";
            this.DateTimeCreated.Size = new System.Drawing.Size(91, 20);
            this.DateTimeCreated.TabIndex = 6;
            // 
            // DateTimeChanged
            // 
            this.DateTimeChanged.Enabled = false;
            this.DateTimeChanged.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeChanged.Location = new System.Drawing.Point(261, 59);
            this.DateTimeChanged.Name = "DateTimeChanged";
            this.DateTimeChanged.Size = new System.Drawing.Size(97, 20);
            this.DateTimeChanged.TabIndex = 7;
            // 
            // TextNote
            // 
            this.TextNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextNote.Location = new System.Drawing.Point(15, 85);
            this.TextNote.Multiline = true;
            this.TextNote.Name = "TextNote";
            this.TextNote.Size = new System.Drawing.Size(510, 252);
            this.TextNote.TabIndex = 8;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.Location = new System.Drawing.Point(439, 343);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(86, 25);
            this.ButtonCancel.TabIndex = 10;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.Location = new System.Drawing.Point(347, 343);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(86, 25);
            this.ButtonOK.TabIndex = 11;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // TimerForCheckError
            // 
            this.TimerForCheckError.Enabled = true;
            this.TimerForCheckError.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormEditNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 380);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.TextNote);
            this.Controls.Add(this.DateTimeChanged);
            this.Controls.Add(this.DateTimeCreated);
            this.Controls.Add(this.ComboBoxCategory);
            this.Controls.Add(this.FieldTitle);
            this.Controls.Add(this.LabelChanged);
            this.Controls.Add(this.LabelCreated);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.LabelTitle);
            this.MinimumSize = new System.Drawing.Size(386, 277);
            this.Name = "FormEditNote";
            this.Text = "Add/Edit Note";
            this.Load += new System.EventHandler(this.formEditNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelCreated;
        private System.Windows.Forms.Label LabelChanged;
        private System.Windows.Forms.TextBox FieldTitle;
        private System.Windows.Forms.ComboBox ComboBoxCategory;
        private System.Windows.Forms.DateTimePicker DateTimeCreated;
        private System.Windows.Forms.DateTimePicker DateTimeChanged;
        private System.Windows.Forms.TextBox TextNote;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Timer TimerForCheckError;
    }
}