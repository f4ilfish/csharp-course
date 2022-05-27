
namespace View
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FigureGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoveFigureButton = new System.Windows.Forms.Button();
            this.AddFigureButton = new System.Windows.Forms.Button();
            this.FigureDataGridView = new System.Windows.Forms.DataGridView();
            this.FileMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterButton = new System.Windows.Forms.Button();
            this.FigureTypeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.FigureTypeLabel = new System.Windows.Forms.Label();
            this.FigureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FigureDataGridView)).BeginInit();
            this.FileMenuStrip.SuspendLayout();
            this.FilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FigureGroupBox
            // 
            this.FigureGroupBox.Controls.Add(this.RemoveFigureButton);
            this.FigureGroupBox.Controls.Add(this.AddFigureButton);
            this.FigureGroupBox.Controls.Add(this.FigureDataGridView);
            this.FigureGroupBox.Location = new System.Drawing.Point(12, 29);
            this.FigureGroupBox.Name = "FigureGroupBox";
            this.FigureGroupBox.Size = new System.Drawing.Size(518, 424);
            this.FigureGroupBox.TabIndex = 0;
            this.FigureGroupBox.TabStop = false;
            this.FigureGroupBox.Text = "Figures";
            // 
            // RemoveFigureButton
            // 
            this.RemoveFigureButton.Location = new System.Drawing.Point(131, 380);
            this.RemoveFigureButton.Name = "RemoveFigureButton";
            this.RemoveFigureButton.Size = new System.Drawing.Size(108, 27);
            this.RemoveFigureButton.TabIndex = 2;
            this.RemoveFigureButton.Text = "Remove figure";
            this.RemoveFigureButton.UseVisualStyleBackColor = true;
            this.RemoveFigureButton.Click += new System.EventHandler(this.RemoveFigureButton_Click);
            // 
            // AddFigureButton
            // 
            this.AddFigureButton.Location = new System.Drawing.Point(17, 380);
            this.AddFigureButton.Name = "AddFigureButton";
            this.AddFigureButton.Size = new System.Drawing.Size(108, 27);
            this.AddFigureButton.TabIndex = 1;
            this.AddFigureButton.Text = "Add figure";
            this.AddFigureButton.UseVisualStyleBackColor = true;
            this.AddFigureButton.Click += new System.EventHandler(this.AddFigureButton_Click);
            // 
            // FigureDataGridView
            // 
            this.FigureDataGridView.AllowUserToAddRows = false;
            this.FigureDataGridView.AllowUserToDeleteRows = false;
            this.FigureDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.FigureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FigureDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.FigureDataGridView.Location = new System.Drawing.Point(17, 32);
            this.FigureDataGridView.Name = "FigureDataGridView";
            this.FigureDataGridView.ReadOnly = true;
            this.FigureDataGridView.RowHeadersWidth = 45;
            this.FigureDataGridView.RowTemplate.Height = 27;
            this.FigureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.FigureDataGridView.Size = new System.Drawing.Size(479, 340);
            this.FigureDataGridView.TabIndex = 0;
            // 
            // FileMenuStrip
            // 
            this.FileMenuStrip.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.FileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.FileMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.FileMenuStrip.Name = "FileMenuStrip";
            this.FileMenuStrip.Size = new System.Drawing.Size(831, 25);
            this.FileMenuStrip.TabIndex = 1;
            this.FileMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.LoadToolStripMenuItem.Text = "Load";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(31, 250);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(108, 27);
            this.FilterButton.TabIndex = 3;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // FigureTypeCheckedListBox
            // 
            this.FigureTypeCheckedListBox.FormattingEnabled = true;
            this.FigureTypeCheckedListBox.Location = new System.Drawing.Point(31, 52);
            this.FigureTypeCheckedListBox.Name = "FigureTypeCheckedListBox";
            this.FigureTypeCheckedListBox.ScrollAlwaysVisible = true;
            this.FigureTypeCheckedListBox.Size = new System.Drawing.Size(222, 84);
            this.FigureTypeCheckedListBox.TabIndex = 4;
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.Controls.Add(this.ToTextBox);
            this.FilterGroupBox.Controls.Add(this.FromTextBox);
            this.FilterGroupBox.Controls.Add(this.ResetButton);
            this.FilterGroupBox.Controls.Add(this.ToLabel);
            this.FilterGroupBox.Controls.Add(this.FromLabel);
            this.FilterGroupBox.Controls.Add(this.VolumeLabel);
            this.FilterGroupBox.Controls.Add(this.FigureTypeLabel);
            this.FilterGroupBox.Controls.Add(this.FigureTypeCheckedListBox);
            this.FilterGroupBox.Controls.Add(this.FilterButton);
            this.FilterGroupBox.Location = new System.Drawing.Point(551, 29);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Size = new System.Drawing.Size(268, 292);
            this.FilterGroupBox.TabIndex = 5;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "Filter";
            // 
            // ToTextBox
            // 
            this.ToTextBox.Location = new System.Drawing.Point(85, 212);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(168, 25);
            this.ToTextBox.TabIndex = 13;
            this.ToTextBox.Text = "0";
            // 
            // FromTextBox
            // 
            this.FromTextBox.Location = new System.Drawing.Point(84, 175);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(169, 25);
            this.FromTextBox.TabIndex = 12;
            this.FromTextBox.Text = "0";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(145, 250);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(108, 27);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(47, 216);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(25, 17);
            this.ToLabel.TabIndex = 9;
            this.ToLabel.Text = "To:";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(31, 179);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(41, 17);
            this.FromLabel.TabIndex = 8;
            this.FromLabel.Text = "From:";
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(6, 148);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(92, 17);
            this.VolumeLabel.TabIndex = 7;
            this.VolumeLabel.Text = "Volume range:";
            // 
            // FigureTypeLabel
            // 
            this.FigureTypeLabel.AutoSize = true;
            this.FigureTypeLabel.Location = new System.Drawing.Point(6, 23);
            this.FigureTypeLabel.Name = "FigureTypeLabel";
            this.FigureTypeLabel.Size = new System.Drawing.Size(76, 17);
            this.FigureTypeLabel.TabIndex = 6;
            this.FigureTypeLabel.Text = "Figure type:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 463);
            this.Controls.Add(this.FilterGroupBox);
            this.Controls.Add(this.FigureGroupBox);
            this.Controls.Add(this.FileMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Figure\'s Volume Calculator";
            this.FigureGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FigureDataGridView)).EndInit();
            this.FileMenuStrip.ResumeLayout(false);
            this.FileMenuStrip.PerformLayout();
            this.FilterGroupBox.ResumeLayout(false);
            this.FilterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FigureGroupBox;
        private System.Windows.Forms.DataGridView FigureDataGridView;
        private System.Windows.Forms.Button RemoveFigureButton;
        private System.Windows.Forms.Button AddFigureButton;
        private System.Windows.Forms.MenuStrip FileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.CheckedListBox FigureTypeCheckedListBox;
        private System.Windows.Forms.GroupBox FilterGroupBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Label FigureTypeLabel;
        private System.Windows.Forms.TextBox ToTextBox;
        private System.Windows.Forms.TextBox FromTextBox;
    }
}

