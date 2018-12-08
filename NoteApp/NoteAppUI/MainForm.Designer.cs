namespace NoteAppUi
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitContainerMain = new System.Windows.Forms.SplitContainer();
            this.TablelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEditNote = new System.Windows.Forms.Button();
            this.ButtonAddNote = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ComboCategory = new System.Windows.Forms.ComboBox();
            this.LabelShowCategory = new System.Windows.Forms.Label();
            this.ListNotes = new System.Windows.Forms.ListBox();
            this.TableNote = new System.Windows.Forms.TableLayoutPanel();
            this.TextNote = new System.Windows.Forms.TextBox();
            this.TableLayoutTitle = new System.Windows.Forms.TableLayoutPanel();
            this.FieldTitle = new System.Windows.Forms.Label();
            this.TableLayoutCategory = new System.Windows.Forms.TableLayoutPanel();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.FieldCategory = new System.Windows.Forms.Label();
            this.SplitContainerTime = new System.Windows.Forms.SplitContainer();
            this.DateTimeCreated = new System.Windows.Forms.DateTimePicker();
            this.LabelCreated = new System.Windows.Forms.Label();
            this.DateTimeChanged = new System.Windows.Forms.DateTimePicker();
            this.LabelModified = new System.Windows.Forms.Label();
            this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).BeginInit();
            this.SplitContainerMain.Panel1.SuspendLayout();
            this.SplitContainerMain.Panel2.SuspendLayout();
            this.SplitContainerMain.SuspendLayout();
            this.TablelLeft.SuspendLayout();
            this.TableLayoutPanelButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TableNote.SuspendLayout();
            this.TableLayoutTitle.SuspendLayout();
            this.TableLayoutCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerTime)).BeginInit();
            this.SplitContainerTime.Panel1.SuspendLayout();
            this.SplitContainerTime.Panel2.SuspendLayout();
            this.SplitContainerTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(801, 24);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNoteToolStripMenuItem,
            this.EditNoteToolStripMenuItem,
            this.RemoveNoteToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // AddNoteToolStripMenuItem
            // 
            this.AddNoteToolStripMenuItem.Name = "AddNoteToolStripMenuItem";
            this.AddNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.AddNoteToolStripMenuItem.Text = "Add Note";
            this.AddNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // EditNoteToolStripMenuItem
            // 
            this.EditNoteToolStripMenuItem.Name = "EditNoteToolStripMenuItem";
            this.EditNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.EditNoteToolStripMenuItem.Text = "Edit Note";
            this.EditNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // RemoveNoteToolStripMenuItem
            // 
            this.RemoveNoteToolStripMenuItem.Name = "RemoveNoteToolStripMenuItem";
            this.RemoveNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.RemoveNoteToolStripMenuItem.Text = "Remove Note";
            this.RemoveNoteToolStripMenuItem.Click += new System.EventHandler(this.removeNoteToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SplitContainerMain
            // 
            this.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerMain.Location = new System.Drawing.Point(0, 24);
            this.SplitContainerMain.Name = "SplitContainerMain";
            // 
            // SplitContainerMain.Panel1
            // 
            this.SplitContainerMain.Panel1.Controls.Add(this.TablelLeft);
            this.SplitContainerMain.Panel1MinSize = 217;
            // 
            // SplitContainerMain.Panel2
            // 
            this.SplitContainerMain.Panel2.Controls.Add(this.TableNote);
            this.SplitContainerMain.Panel2MinSize = 400;
            this.SplitContainerMain.Size = new System.Drawing.Size(801, 422);
            this.SplitContainerMain.SplitterDistance = 227;
            this.SplitContainerMain.TabIndex = 3;
            // 
            // TablelLeft
            // 
            this.TablelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablelLeft.ColumnCount = 1;
            this.TablelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablelLeft.Controls.Add(this.TableLayoutPanelButtons, 0, 2);
            this.TablelLeft.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.TablelLeft.Controls.Add(this.ListNotes, 0, 1);
            this.TablelLeft.Location = new System.Drawing.Point(3, 3);
            this.TablelLeft.Name = "TablelLeft";
            this.TablelLeft.RowCount = 3;
            this.TablelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TablelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TablelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TablelLeft.Size = new System.Drawing.Size(221, 416);
            this.TablelLeft.TabIndex = 0;
            // 
            // TableLayoutPanelButtons
            // 
            this.TableLayoutPanelButtons.ColumnCount = 4;
            this.TableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.TableLayoutPanelButtons.Controls.Add(this.ButtonDelete, 0, 0);
            this.TableLayoutPanelButtons.Controls.Add(this.ButtonEditNote, 0, 0);
            this.TableLayoutPanelButtons.Controls.Add(this.ButtonAddNote, 0, 0);
            this.TableLayoutPanelButtons.Location = new System.Drawing.Point(3, 392);
            this.TableLayoutPanelButtons.Name = "TableLayoutPanelButtons";
            this.TableLayoutPanelButtons.RowCount = 1;
            this.TableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelButtons.Size = new System.Drawing.Size(205, 21);
            this.TableLayoutPanelButtons.TabIndex = 2;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonDelete.FlatAppearance.BorderSize = 0;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Image = global::NoteAppUi.Properties.Resources.icons8_мусор;
            this.ButtonDelete.Location = new System.Drawing.Point(57, 3);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(20, 15);
            this.ButtonDelete.TabIndex = 5;
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ButtonEditNote
            // 
            this.ButtonEditNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonEditNote.FlatAppearance.BorderSize = 0;
            this.ButtonEditNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditNote.Image = global::NoteAppUi.Properties.Resources.icons8_редактировать_графический_отчет;
            this.ButtonEditNote.Location = new System.Drawing.Point(30, 3);
            this.ButtonEditNote.Name = "ButtonEditNote";
            this.ButtonEditNote.Size = new System.Drawing.Size(20, 15);
            this.ButtonEditNote.TabIndex = 4;
            this.ButtonEditNote.UseVisualStyleBackColor = true;
            this.ButtonEditNote.Click += new System.EventHandler(this.buttonEditNote_Click);
            // 
            // ButtonAddNote
            // 
            this.ButtonAddNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAddNote.FlatAppearance.BorderSize = 0;
            this.ButtonAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddNote.Image = global::NoteAppUi.Properties.Resources.icons8_файл;
            this.ButtonAddNote.Location = new System.Drawing.Point(3, 3);
            this.ButtonAddNote.Name = "ButtonAddNote";
            this.ButtonAddNote.Size = new System.Drawing.Size(20, 15);
            this.ButtonAddNote.TabIndex = 3;
            this.ButtonAddNote.UseVisualStyleBackColor = true;
            this.ButtonAddNote.Click += new System.EventHandler(this.buttonAddNote_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ComboCategory, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelShowCategory, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(215, 26);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // ComboCategory
            // 
            this.ComboCategory.Dock = System.Windows.Forms.DockStyle.Right;
            this.ComboCategory.FormattingEnabled = true;
            this.ComboCategory.Items.AddRange(new object[] {
            "All",
            "Work",
            "Home",
            "HealthAndSport",
            "People",
            "Documents",
            "Finance",
            "Miscellaneous"});
            this.ComboCategory.Location = new System.Drawing.Point(110, 3);
            this.ComboCategory.Name = "ComboCategory";
            this.ComboCategory.Size = new System.Drawing.Size(102, 21);
            this.ComboCategory.TabIndex = 6;
            this.ComboCategory.SelectedIndexChanged += new System.EventHandler(this.ComboCategory_SelectedIndexChanged_1);
            // 
            // LabelShowCategory
            // 
            this.LabelShowCategory.Location = new System.Drawing.Point(3, 0);
            this.LabelShowCategory.Name = "LabelShowCategory";
            this.LabelShowCategory.Size = new System.Drawing.Size(101, 26);
            this.LabelShowCategory.TabIndex = 0;
            this.LabelShowCategory.Text = "Show Category:";
            this.LabelShowCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListNotes
            // 
            this.ListNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListNotes.FormattingEnabled = true;
            this.ListNotes.Location = new System.Drawing.Point(3, 35);
            this.ListNotes.Name = "ListNotes";
            this.ListNotes.Size = new System.Drawing.Size(215, 342);
            this.ListNotes.TabIndex = 5;
            this.ListNotes.SelectedIndexChanged += new System.EventHandler(this.ListNotes_SelectedIndexChanged);
            // 
            // TableNote
            // 
            this.TableNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableNote.ColumnCount = 1;
            this.TableNote.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 564F));
            this.TableNote.Controls.Add(this.TextNote, 0, 1);
            this.TableNote.Controls.Add(this.TableLayoutTitle, 0, 0);
            this.TableNote.Location = new System.Drawing.Point(3, 3);
            this.TableNote.Name = "TableNote";
            this.TableNote.RowCount = 2;
            this.TableNote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.TableNote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableNote.Size = new System.Drawing.Size(564, 416);
            this.TableNote.TabIndex = 0;
            // 
            // TextNote
            // 
            this.TextNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextNote.Location = new System.Drawing.Point(3, 89);
            this.TextNote.Multiline = true;
            this.TextNote.Name = "TextNote";
            this.TextNote.ReadOnly = true;
            this.TextNote.Size = new System.Drawing.Size(558, 324);
            this.TextNote.TabIndex = 0;
            // 
            // TableLayoutTitle
            // 
            this.TableLayoutTitle.ColumnCount = 1;
            this.TableLayoutTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutTitle.Controls.Add(this.FieldTitle, 0, 0);
            this.TableLayoutTitle.Controls.Add(this.TableLayoutCategory, 0, 1);
            this.TableLayoutTitle.Controls.Add(this.SplitContainerTime, 0, 2);
            this.TableLayoutTitle.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutTitle.Name = "TableLayoutTitle";
            this.TableLayoutTitle.RowCount = 3;
            this.TableLayoutTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TableLayoutTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.TableLayoutTitle.Size = new System.Drawing.Size(558, 80);
            this.TableLayoutTitle.TabIndex = 1;
            // 
            // FieldTitle
            // 
            this.FieldTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FieldTitle.Location = new System.Drawing.Point(3, 0);
            this.FieldTitle.Name = "FieldTitle";
            this.FieldTitle.Size = new System.Drawing.Size(552, 32);
            this.FieldTitle.TabIndex = 0;
            // 
            // TableLayoutCategory
            // 
            this.TableLayoutCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutCategory.ColumnCount = 2;
            this.TableLayoutCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.TableLayoutCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutCategory.Controls.Add(this.LabelCategory, 0, 0);
            this.TableLayoutCategory.Controls.Add(this.FieldCategory, 1, 0);
            this.TableLayoutCategory.Location = new System.Drawing.Point(3, 35);
            this.TableLayoutCategory.Name = "TableLayoutCategory";
            this.TableLayoutCategory.RowCount = 1;
            this.TableLayoutCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutCategory.Size = new System.Drawing.Size(552, 16);
            this.TableLayoutCategory.TabIndex = 1;
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(3, 0);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(52, 13);
            this.LabelCategory.TabIndex = 0;
            this.LabelCategory.Text = "Category:";
            // 
            // FieldCategory
            // 
            this.FieldCategory.AutoSize = true;
            this.FieldCategory.Location = new System.Drawing.Point(68, 0);
            this.FieldCategory.Name = "FieldCategory";
            this.FieldCategory.Size = new System.Drawing.Size(0, 13);
            this.FieldCategory.TabIndex = 1;
            // 
            // SplitContainerTime
            // 
            this.SplitContainerTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainerTime.Location = new System.Drawing.Point(3, 57);
            this.SplitContainerTime.Name = "SplitContainerTime";
            // 
            // SplitContainerTime.Panel1
            // 
            this.SplitContainerTime.Panel1.Controls.Add(this.DateTimeCreated);
            this.SplitContainerTime.Panel1.Controls.Add(this.LabelCreated);
            this.SplitContainerTime.Panel1MinSize = 194;
            // 
            // SplitContainerTime.Panel2
            // 
            this.SplitContainerTime.Panel2.Controls.Add(this.DateTimeChanged);
            this.SplitContainerTime.Panel2.Controls.Add(this.LabelModified);
            this.SplitContainerTime.Panel2MinSize = 194;
            this.SplitContainerTime.Size = new System.Drawing.Size(552, 20);
            this.SplitContainerTime.SplitterDistance = 229;
            this.SplitContainerTime.TabIndex = 2;
            // 
            // DateTimeCreated
            // 
            this.DateTimeCreated.CustomFormat = "dd.MM.yy HH:MM:ss";
            this.DateTimeCreated.Enabled = false;
            this.DateTimeCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeCreated.Location = new System.Drawing.Point(71, 0);
            this.DateTimeCreated.Name = "DateTimeCreated";
            this.DateTimeCreated.Size = new System.Drawing.Size(155, 20);
            this.DateTimeCreated.TabIndex = 1;
            // 
            // LabelCreated
            // 
            this.LabelCreated.AutoSize = true;
            this.LabelCreated.Location = new System.Drawing.Point(3, 3);
            this.LabelCreated.Name = "LabelCreated";
            this.LabelCreated.Size = new System.Drawing.Size(47, 13);
            this.LabelCreated.TabIndex = 0;
            this.LabelCreated.Text = "Created:";
            // 
            // DateTimeChanged
            // 
            this.DateTimeChanged.CustomFormat = "dd.MM.yy HH:MM:ss";
            this.DateTimeChanged.Enabled = false;
            this.DateTimeChanged.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeChanged.Location = new System.Drawing.Point(59, 0);
            this.DateTimeChanged.Name = "DateTimeChanged";
            this.DateTimeChanged.Size = new System.Drawing.Size(179, 20);
            this.DateTimeChanged.TabIndex = 2;
            // 
            // LabelModified
            // 
            this.LabelModified.AutoSize = true;
            this.LabelModified.Location = new System.Drawing.Point(3, 3);
            this.LabelModified.Name = "LabelModified";
            this.LabelModified.Size = new System.Drawing.Size(50, 13);
            this.LabelModified.TabIndex = 1;
            this.LabelModified.Text = "Modified:";
            // 
            // noteBindingSource
            // 
            this.noteBindingSource.DataSource = typeof(NoteApp.Note);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 446);
            this.Controls.Add(this.SplitContainerMain);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(637, 165);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.SplitContainerMain.Panel1.ResumeLayout(false);
            this.SplitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).EndInit();
            this.SplitContainerMain.ResumeLayout(false);
            this.TablelLeft.ResumeLayout(false);
            this.TableLayoutPanelButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TableNote.ResumeLayout(false);
            this.TableNote.PerformLayout();
            this.TableLayoutTitle.ResumeLayout(false);
            this.TableLayoutCategory.ResumeLayout(false);
            this.TableLayoutCategory.PerformLayout();
            this.SplitContainerTime.Panel1.ResumeLayout(false);
            this.SplitContainerTime.Panel1.PerformLayout();
            this.SplitContainerTime.Panel2.ResumeLayout(false);
            this.SplitContainerTime.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerTime)).EndInit();
            this.SplitContainerTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer SplitContainerMain;
        private System.Windows.Forms.TableLayoutPanel TablelLeft;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelButtons;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEditNote;
        private System.Windows.Forms.Button ButtonAddNote;
        private System.Windows.Forms.TableLayoutPanel TableNote;
        private System.Windows.Forms.TextBox TextNote;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.DateTimePicker DateTimeCreated;
        private System.Windows.Forms.Label LabelCreated;
        private System.Windows.Forms.DateTimePicker DateTimeChanged;
        private System.Windows.Forms.Label LabelModified;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.BindingSource noteBindingSource;
        private System.Windows.Forms.TableLayoutPanel TableLayoutTitle;
        private System.Windows.Forms.Label FieldTitle;
        private System.Windows.Forms.TableLayoutPanel TableLayoutCategory;
        private System.Windows.Forms.Label FieldCategory;
        private System.Windows.Forms.SplitContainer SplitContainerTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox ComboCategory;
        private System.Windows.Forms.Label LabelShowCategory;
        private System.Windows.Forms.ListBox ListNotes;
    }
}

