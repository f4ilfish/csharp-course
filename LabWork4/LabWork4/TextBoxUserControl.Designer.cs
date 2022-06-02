namespace View
{
    partial class TextBoxUserControl
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
            this.components = new System.ComponentModel.Container();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.ValueErorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ValueErorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ValueTextBox.Location = new System.Drawing.Point(0, 0);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(60, 25);
            this.ValueTextBox.TabIndex = 0;
            this.ValueTextBox.TextChanged += new System.EventHandler(this.ValueTextBox_TextChanged);
            // 
            // ValueErorProvider
            // 
            this.ValueErorProvider.ContainerControl = this;
            // 
            // ValidatorTextBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ValueTextBox);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ValidatorTextBoxControl";
            this.Size = new System.Drawing.Size(200, 25);
            ((System.ComponentModel.ISupportInitialize)(this.ValueErorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.ErrorProvider ValueErorProvider;
    }
}
