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
            this.RadiusHeightGroupBox = new System.Windows.Forms.GroupBox();
            this.RadiusHeightLabel = new System.Windows.Forms.Label();
            this.RadiusHeightMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RadiusHeightGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadiusHeightGroupBox
            // 
            this.RadiusHeightGroupBox.Controls.Add(this.RadiusHeightLabel);
            this.RadiusHeightGroupBox.Controls.Add(this.RadiusHeightMaskedTextBox);
            this.RadiusHeightGroupBox.Location = new System.Drawing.Point(13, 15);
            this.RadiusHeightGroupBox.Name = "RadiusHeightGroupBox";
            this.RadiusHeightGroupBox.Size = new System.Drawing.Size(198, 53);
            this.RadiusHeightGroupBox.TabIndex = 2;
            this.RadiusHeightGroupBox.TabStop = false;
            this.RadiusHeightGroupBox.Text = "Parameters";
            // 
            // RadiusHeightLabel
            // 
            this.RadiusHeightLabel.AutoSize = true;
            this.RadiusHeightLabel.Location = new System.Drawing.Point(6, 21);
            this.RadiusHeightLabel.Name = "RadiusHeightLabel";
            this.RadiusHeightLabel.Size = new System.Drawing.Size(50, 17);
            this.RadiusHeightLabel.TabIndex = 8;
            this.RadiusHeightLabel.Text = "Radius:";
            // 
            // RadiusHeightMaskedTextBox
            // 
            this.RadiusHeightMaskedTextBox.Location = new System.Drawing.Point(132, 18);
            this.RadiusHeightMaskedTextBox.Name = "RadiusHeightMaskedTextBox";
            this.RadiusHeightMaskedTextBox.Size = new System.Drawing.Size(56, 25);
            this.RadiusHeightMaskedTextBox.TabIndex = 0;
            // 
            // SphereUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RadiusHeightGroupBox);
            this.Name = "SphereUserControl";
            this.Size = new System.Drawing.Size(343, 81);
            this.RadiusHeightGroupBox.ResumeLayout(false);
            this.RadiusHeightGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RadiusHeightGroupBox;
        private System.Windows.Forms.Label RadiusHeightLabel;
        private System.Windows.Forms.MaskedTextBox RadiusHeightMaskedTextBox;
    }
}
