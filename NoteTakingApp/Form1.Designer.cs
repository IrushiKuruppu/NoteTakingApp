namespace NoteTakingApp
{
    partial class NoteTaker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTitle = new TextBox();
            txtNote = new TextBox();
            lblTitle = new Label();
            lblNote = new Label();
            previousNotes = new DataGridView();
            btnLoad = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnNewNote = new Button();
            ((System.ComponentModel.ISupportInitialize)previousNotes).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(613, 55);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(547, 27);
            txtTitle.TabIndex = 0;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(613, 151);
            txtNote.Margin = new Padding(3, 4, 3, 4);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(547, 424);
            txtNote.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(613, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(66, 28);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Title :";
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNote.Location = new Point(613, 107);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(79, 28);
            lblNote.TabIndex = 3;
            lblNote.Text = "Notes :";
            // 
            // previousNotes
            // 
            previousNotes.BackgroundColor = SystemColors.Window;
            previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousNotes.Location = new Point(14, 17);
            previousNotes.Margin = new Padding(3, 4, 3, 4);
            previousNotes.Name = "previousNotes";
            previousNotes.RowHeadersWidth = 51;
            previousNotes.RowTemplate.Height = 25;
            previousNotes.Size = new Size(571, 499);
            previousNotes.TabIndex = 4;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.Location = new Point(14, 537);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(264, 39);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(301, 537);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(284, 39);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(301, 584);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(284, 39);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnNewNote
            // 
            btnNewNote.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewNote.Location = new Point(14, 584);
            btnNewNote.Margin = new Padding(3, 4, 3, 4);
            btnNewNote.Name = "btnNewNote";
            btnNewNote.Size = new Size(264, 39);
            btnNewNote.TabIndex = 7;
            btnNewNote.Text = "New Note";
            btnNewNote.UseVisualStyleBackColor = true;
            btnNewNote.Click += btnNewNote_Click;
            // 
            // NoteTaker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1174, 651);
            Controls.Add(btnSave);
            Controls.Add(btnNewNote);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(previousNotes);
            Controls.Add(lblNote);
            Controls.Add(lblTitle);
            Controls.Add(txtNote);
            Controls.Add(txtTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NoteTaker";
            Text = "Note Taker";
            Load += NoteTaker_Load;
            ((System.ComponentModel.ISupportInitialize)previousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtNote;
        private Label lblTitle;
        private Label lblNote;
        private DataGridView previousNotes;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnSave;
        private Button btnNewNote;
    }
}