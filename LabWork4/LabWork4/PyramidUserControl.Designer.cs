namespace View
{
    partial class PyramidUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.PyramidTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SideLengthLabel = new System.Windows.Forms.Label();
            this.NumberOfAnglesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NumberOfAnglesLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new View.TextBoxUserControl();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.SideTextBox = new View.TextBoxUserControl();
            this.ParametersGroupBox.SuspendLayout();
            this.PyramidTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfAnglesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ParametersGroupBox
            // 
            this.ParametersGroupBox.Controls.Add(this.PyramidTableLayout);
            this.ParametersGroupBox.Location = new System.Drawing.Point(15, 15);
            this.ParametersGroupBox.Name = "ParametersGroupBox";
            this.ParametersGroupBox.Size = new System.Drawing.Size(405, 150);
            this.ParametersGroupBox.TabIndex = 0;
            this.ParametersGroupBox.TabStop = false;
            this.ParametersGroupBox.Text = "Parameters:";
            // 
            // PyramidTableLayout
            // 
            this.PyramidTableLayout.ColumnCount = 2;
            this.PyramidTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.PyramidTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.PyramidTableLayout.Controls.Add(this.SideLengthLabel, 0, 2);
            this.PyramidTableLayout.Controls.Add(this.NumberOfAnglesNumericUpDown, 1, 1);
            this.PyramidTableLayout.Controls.Add(this.NumberOfAnglesLabel, 0, 1);
            this.PyramidTableLayout.Controls.Add(this.HeightTextBox, 1, 0);
            this.PyramidTableLayout.Controls.Add(this.HeightLabel, 0, 0);
            this.PyramidTableLayout.Controls.Add(this.SideTextBox, 1, 2);
            this.PyramidTableLayout.Location = new System.Drawing.Point(25, 25);
            this.PyramidTableLayout.Name = "PyramidTableLayout";
            this.PyramidTableLayout.RowCount = 3;
            this.PyramidTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PyramidTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PyramidTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.PyramidTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PyramidTableLayout.Size = new System.Drawing.Size(350, 105);
            this.PyramidTableLayout.TabIndex = 1;
            // 
            // SideLengthLabel
            // 
            this.SideLengthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SideLengthLabel.AutoSize = true;
            this.SideLengthLabel.Location = new System.Drawing.Point(3, 79);
            this.SideLengthLabel.Name = "SideLengthLabel";
            this.SideLengthLabel.Size = new System.Drawing.Size(85, 17);
            this.SideLengthLabel.TabIndex = 4;
            this.SideLengthLabel.Text = "Side\'s length:";
            // 
            // NumberOfAnglesNumericUpDown
            // 
            this.NumberOfAnglesNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumberOfAnglesNumericUpDown.Location = new System.Drawing.Point(153, 40);
            this.NumberOfAnglesNumericUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumberOfAnglesNumericUpDown.Name = "NumberOfAnglesNumericUpDown";
            this.NumberOfAnglesNumericUpDown.Size = new System.Drawing.Size(56, 25);
            this.NumberOfAnglesNumericUpDown.TabIndex = 3;
            this.NumberOfAnglesNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // NumberOfAnglesLabel
            // 
            this.NumberOfAnglesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NumberOfAnglesLabel.AutoSize = true;
            this.NumberOfAnglesLabel.Location = new System.Drawing.Point(3, 44);
            this.NumberOfAnglesLabel.Name = "NumberOfAnglesLabel";
            this.NumberOfAnglesLabel.Size = new System.Drawing.Size(117, 17);
            this.NumberOfAnglesLabel.TabIndex = 2;
            this.NumberOfAnglesLabel.Text = "Number of angles:";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HeightTextBox.Location = new System.Drawing.Point(150, 3);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(200, 28);
            this.HeightTextBox.TabIndex = 4;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(3, 9);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(49, 17);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "Height:";
            // 
            // SideTextBox
            // 
            this.SideTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SideTextBox.Location = new System.Drawing.Point(150, 73);
            this.SideTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.SideTextBox.Name = "SideTextBox";
            this.SideTextBox.Size = new System.Drawing.Size(200, 28);
            this.SideTextBox.TabIndex = 5;
            // 
            // PyramidUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 144);
            this.Controls.Add(this.ParametersGroupBox);
            this.Name = "PyramidUserControl";
            this.ParametersGroupBox.ResumeLayout(false);
            this.PyramidTableLayout.ResumeLayout(false);
            this.PyramidTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfAnglesNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ParametersGroupBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label NumberOfAnglesLabel;
        private System.Windows.Forms.NumericUpDown NumberOfAnglesNumericUpDown;
        private System.Windows.Forms.Label SideLengthLabel;
        private System.Windows.Forms.TableLayoutPanel PyramidTableLayout;
        private TextBoxUserControl HeightTextBox;
        private TextBoxUserControl SideTextBox;
    }
}
