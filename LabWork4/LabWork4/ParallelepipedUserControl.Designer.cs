namespace View
{
    partial class ParallelepipedUserControl
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
            this.ParallelepipedGroupBox = new System.Windows.Forms.GroupBox();
            this.ParallelepipedTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AngleOfSidesTextBox = new View.TextBoxUserControl();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.SecondSideTextBox = new View.TextBoxUserControl();
            this.FirstSideLabel = new System.Windows.Forms.Label();
            this.FirstSideTextBox = new View.TextBoxUserControl();
            this.SecondSideLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new View.TextBoxUserControl();
            this.AngleOfSidesLabel = new System.Windows.Forms.Label();
            this.ParallelepipedGroupBox.SuspendLayout();
            this.ParallelepipedTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParallelepipedGroupBox
            // 
            this.ParallelepipedGroupBox.Controls.Add(this.ParallelepipedTableLayout);
            this.ParallelepipedGroupBox.Location = new System.Drawing.Point(15, 15);
            this.ParallelepipedGroupBox.Name = "ParallelepipedGroupBox";
            this.ParallelepipedGroupBox.Size = new System.Drawing.Size(405, 180);
            this.ParallelepipedGroupBox.TabIndex = 0;
            this.ParallelepipedGroupBox.TabStop = false;
            this.ParallelepipedGroupBox.Text = "Parameters:";
            // 
            // ParallelepipedTableLayout
            // 
            this.ParallelepipedTableLayout.ColumnCount = 2;
            this.ParallelepipedTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ParallelepipedTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.ParallelepipedTableLayout.Controls.Add(this.AngleOfSidesTextBox, 1, 3);
            this.ParallelepipedTableLayout.Controls.Add(this.HeightLabel, 0, 0);
            this.ParallelepipedTableLayout.Controls.Add(this.SecondSideTextBox, 1, 2);
            this.ParallelepipedTableLayout.Controls.Add(this.FirstSideLabel, 0, 1);
            this.ParallelepipedTableLayout.Controls.Add(this.FirstSideTextBox, 1, 1);
            this.ParallelepipedTableLayout.Controls.Add(this.SecondSideLabel, 0, 2);
            this.ParallelepipedTableLayout.Controls.Add(this.HeightTextBox, 1, 0);
            this.ParallelepipedTableLayout.Controls.Add(this.AngleOfSidesLabel, 0, 3);
            this.ParallelepipedTableLayout.Location = new System.Drawing.Point(25, 24);
            this.ParallelepipedTableLayout.Name = "ParallelepipedTableLayout";
            this.ParallelepipedTableLayout.RowCount = 4;
            this.ParallelepipedTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ParallelepipedTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ParallelepipedTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ParallelepipedTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ParallelepipedTableLayout.Size = new System.Drawing.Size(350, 140);
            this.ParallelepipedTableLayout.TabIndex = 0;
            // 
            // AngleOfSidesTextBox
            // 
            this.AngleOfSidesTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AngleOfSidesTextBox.Location = new System.Drawing.Point(150, 108);
            this.AngleOfSidesTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.AngleOfSidesTextBox.Name = "AngleOfSidesTextBox";
            this.AngleOfSidesTextBox.Size = new System.Drawing.Size(200, 28);
            this.AngleOfSidesTextBox.TabIndex = 7;
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
            // SecondSideTextBox
            // 
            this.SecondSideTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SecondSideTextBox.Location = new System.Drawing.Point(150, 73);
            this.SecondSideTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.SecondSideTextBox.Name = "SecondSideTextBox";
            this.SecondSideTextBox.Size = new System.Drawing.Size(200, 28);
            this.SecondSideTextBox.TabIndex = 6;
            // 
            // FirstSideLabel
            // 
            this.FirstSideLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FirstSideLabel.AutoSize = true;
            this.FirstSideLabel.Location = new System.Drawing.Point(3, 44);
            this.FirstSideLabel.Name = "FirstSideLabel";
            this.FirstSideLabel.Size = new System.Drawing.Size(112, 17);
            this.FirstSideLabel.TabIndex = 1;
            this.FirstSideLabel.Text = "First side\'s length:";
            // 
            // FirstSideTextBox
            // 
            this.FirstSideTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FirstSideTextBox.Location = new System.Drawing.Point(150, 38);
            this.FirstSideTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.FirstSideTextBox.Name = "FirstSideTextBox";
            this.FirstSideTextBox.Size = new System.Drawing.Size(200, 28);
            this.FirstSideTextBox.TabIndex = 5;
            // 
            // SecondSideLabel
            // 
            this.SecondSideLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SecondSideLabel.AutoSize = true;
            this.SecondSideLabel.Location = new System.Drawing.Point(3, 79);
            this.SecondSideLabel.Name = "SecondSideLabel";
            this.SecondSideLabel.Size = new System.Drawing.Size(131, 17);
            this.SecondSideLabel.TabIndex = 2;
            this.SecondSideLabel.Text = "Second side\'s length:";
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
            // AngleOfSidesLabel
            // 
            this.AngleOfSidesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AngleOfSidesLabel.AutoSize = true;
            this.AngleOfSidesLabel.Location = new System.Drawing.Point(3, 114);
            this.AngleOfSidesLabel.Name = "AngleOfSidesLabel";
            this.AngleOfSidesLabel.Size = new System.Drawing.Size(94, 17);
            this.AngleOfSidesLabel.TabIndex = 3;
            this.AngleOfSidesLabel.Text = "Angle of sides:";
            // 
            // ParallelepipedUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParallelepipedGroupBox);
            this.Name = "ParallelepipedUserControl";
            this.Size = new System.Drawing.Size(435, 220);
            this.ParallelepipedGroupBox.ResumeLayout(false);
            this.ParallelepipedTableLayout.ResumeLayout(false);
            this.ParallelepipedTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ParallelepipedGroupBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label SecondSideLabel;
        private System.Windows.Forms.Label FirstSideLabel;
        private System.Windows.Forms.Label AngleOfSidesLabel;
        private TextBoxUserControl FirstSideTextBox;
        private TextBoxUserControl HeightTextBox;
        private TextBoxUserControl AngleOfSidesTextBox;
        private TextBoxUserControl SecondSideTextBox;
        private System.Windows.Forms.TableLayoutPanel ParallelepipedTableLayout;
    }
}
