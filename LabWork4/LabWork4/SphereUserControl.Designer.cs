namespace View
{
    partial class SphereUserControl
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
            this.SphereGroupBox = new System.Windows.Forms.GroupBox();
            this.SphereTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.RadiusTextBox = new View.TextBoxUserControl();
            this.SphereRadiusLabel = new System.Windows.Forms.Label();
            this.SphereGroupBox.SuspendLayout();
            this.SphereTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // SphereGroupBox
            // 
            this.SphereGroupBox.Controls.Add(this.SphereTableLayout);
            this.SphereGroupBox.Location = new System.Drawing.Point(15, 15);
            this.SphereGroupBox.Name = "SphereGroupBox";
            this.SphereGroupBox.Size = new System.Drawing.Size(405, 75);
            this.SphereGroupBox.TabIndex = 0;
            this.SphereGroupBox.TabStop = false;
            this.SphereGroupBox.Text = "Parameters:";
            // 
            // SphereTableLayout
            // 
            this.SphereTableLayout.ColumnCount = 2;
            this.SphereTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.SphereTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.SphereTableLayout.Controls.Add(this.RadiusTextBox, 1, 0);
            this.SphereTableLayout.Controls.Add(this.SphereRadiusLabel, 0, 0);
            this.SphereTableLayout.Location = new System.Drawing.Point(25, 24);
            this.SphereTableLayout.Name = "SphereTableLayout";
            this.SphereTableLayout.RowCount = 1;
            this.SphereTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.SphereTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.SphereTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.SphereTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.SphereTableLayout.Size = new System.Drawing.Size(350, 35);
            this.SphereTableLayout.TabIndex = 2;
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RadiusTextBox.Location = new System.Drawing.Point(150, 3);
            this.RadiusTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(200, 28);
            this.RadiusTextBox.TabIndex = 4;
            // 
            // SphereRadiusLabel
            // 
            this.SphereRadiusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SphereRadiusLabel.AutoSize = true;
            this.SphereRadiusLabel.Location = new System.Drawing.Point(3, 9);
            this.SphereRadiusLabel.Name = "SphereRadiusLabel";
            this.SphereRadiusLabel.Size = new System.Drawing.Size(50, 17);
            this.SphereRadiusLabel.TabIndex = 1;
            this.SphereRadiusLabel.Text = "Radius:";
            // 
            // SphereUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SphereGroupBox);
            this.Name = "SphereUserControl";
            this.Size = new System.Drawing.Size(435, 115);
            this.SphereGroupBox.ResumeLayout(false);
            this.SphereTableLayout.ResumeLayout(false);
            this.SphereTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SphereGroupBox;
        private System.Windows.Forms.Label SphereRadiusLabel;
        private System.Windows.Forms.TableLayoutPanel SphereTableLayout;
        private TextBoxUserControl RadiusTextBox;
    }
}
