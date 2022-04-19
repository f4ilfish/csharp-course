
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
            this.FigureGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoveFigureButton = new System.Windows.Forms.Button();
            this.AddFigureButton = new System.Windows.Forms.Button();
            this.FigureDataGridView = new System.Windows.Forms.DataGridView();
            this.FigureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FigureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FigureGroupBox
            // 
            this.FigureGroupBox.Controls.Add(this.RemoveFigureButton);
            this.FigureGroupBox.Controls.Add(this.AddFigureButton);
            this.FigureGroupBox.Controls.Add(this.FigureDataGridView);
            this.FigureGroupBox.Location = new System.Drawing.Point(12, 12);
            this.FigureGroupBox.Name = "FigureGroupBox";
            this.FigureGroupBox.Size = new System.Drawing.Size(518, 419);
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
            this.FigureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FigureDataGridView.Size = new System.Drawing.Size(479, 340);
            this.FigureDataGridView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.FigureGroupBox);
            this.Name = "MainForm";
            this.Text = "Volume calc";
            this.FigureGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FigureDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FigureGroupBox;
        private System.Windows.Forms.DataGridView FigureDataGridView;
        private System.Windows.Forms.Button RemoveFigureButton;
        private System.Windows.Forms.Button AddFigureButton;
    }
}

