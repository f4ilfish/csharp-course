
namespace View
{
    partial class InputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.SelectFigureGroupBox = new System.Windows.Forms.GroupBox();
            this.PyramidRadioButton = new System.Windows.Forms.RadioButton();
            this.ParallelepipedRadioButton = new System.Windows.Forms.RadioButton();
            this.SphereRadioButton = new System.Windows.Forms.RadioButton();
            this.OkInputButton = new System.Windows.Forms.Button();
            this.CancelInputButton = new System.Windows.Forms.Button();
            this.SphereUserControl = new View.SphereUserControl();
            this.PyramidUserControl = new View.PyramidUserControl();
            this.ParallelepipedUserControl = new View.ParallelepipedUserControl();
            this.SelectFigureGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectFigureGroupBox
            // 
            this.SelectFigureGroupBox.Controls.Add(this.PyramidRadioButton);
            this.SelectFigureGroupBox.Controls.Add(this.ParallelepipedRadioButton);
            this.SelectFigureGroupBox.Controls.Add(this.SphereRadioButton);
            this.SelectFigureGroupBox.Location = new System.Drawing.Point(20, 25);
            this.SelectFigureGroupBox.Name = "SelectFigureGroupBox";
            this.SelectFigureGroupBox.Size = new System.Drawing.Size(188, 116);
            this.SelectFigureGroupBox.TabIndex = 0;
            this.SelectFigureGroupBox.TabStop = false;
            this.SelectFigureGroupBox.Text = "Select figure";
            // 
            // PyramidRadioButton
            // 
            this.PyramidRadioButton.AutoSize = true;
            this.PyramidRadioButton.Location = new System.Drawing.Point(6, 51);
            this.PyramidRadioButton.Name = "PyramidRadioButton";
            this.PyramidRadioButton.Size = new System.Drawing.Size(73, 21);
            this.PyramidRadioButton.TabIndex = 2;
            this.PyramidRadioButton.TabStop = true;
            this.PyramidRadioButton.Text = "Pyramid";
            this.PyramidRadioButton.UseVisualStyleBackColor = true;
            // 
            // ParallelepipedRadioButton
            // 
            this.ParallelepipedRadioButton.AutoSize = true;
            this.ParallelepipedRadioButton.Location = new System.Drawing.Point(6, 78);
            this.ParallelepipedRadioButton.Name = "ParallelepipedRadioButton";
            this.ParallelepipedRadioButton.Size = new System.Drawing.Size(109, 21);
            this.ParallelepipedRadioButton.TabIndex = 1;
            this.ParallelepipedRadioButton.TabStop = true;
            this.ParallelepipedRadioButton.Text = "Parallelepiped";
            this.ParallelepipedRadioButton.UseVisualStyleBackColor = true;
            // 
            // SphereRadioButton
            // 
            this.SphereRadioButton.AutoSize = true;
            this.SphereRadioButton.Location = new System.Drawing.Point(6, 24);
            this.SphereRadioButton.Name = "SphereRadioButton";
            this.SphereRadioButton.Size = new System.Drawing.Size(67, 21);
            this.SphereRadioButton.TabIndex = 0;
            this.SphereRadioButton.TabStop = true;
            this.SphereRadioButton.Tag = "";
            this.SphereRadioButton.Text = "Sphere";
            this.SphereRadioButton.UseVisualStyleBackColor = true;
            // 
            // OkInputButton
            // 
            this.OkInputButton.Location = new System.Drawing.Point(20, 223);
            this.OkInputButton.Name = "OkInputButton";
            this.OkInputButton.Size = new System.Drawing.Size(188, 33);
            this.OkInputButton.TabIndex = 9;
            this.OkInputButton.Text = "OK";
            this.OkInputButton.UseVisualStyleBackColor = true;
            this.OkInputButton.Click += new System.EventHandler(this.OkInputButton_Click);
            // 
            // CancelInputButton
            // 
            this.CancelInputButton.Location = new System.Drawing.Point(224, 223);
            this.CancelInputButton.Name = "CancelInputButton";
            this.CancelInputButton.Size = new System.Drawing.Size(188, 33);
            this.CancelInputButton.TabIndex = 10;
            this.CancelInputButton.Text = "Cancel";
            this.CancelInputButton.UseVisualStyleBackColor = true;
            this.CancelInputButton.Click += new System.EventHandler(this.CancelInputButton_Click);
            // 
            // SphereUserControl
            // 
            this.SphereUserControl.Location = new System.Drawing.Point(210, 10);
            this.SphereUserControl.Name = "SphereUserControl";
            this.SphereUserControl.Size = new System.Drawing.Size(443, 116);
            this.SphereUserControl.TabIndex = 11;
            // 
            // PyramidUserControl
            // 
            this.PyramidUserControl.Location = new System.Drawing.Point(210, 10);
            this.PyramidUserControl.Name = "PyramidUserControl";
            this.PyramidUserControl.Size = new System.Drawing.Size(437, 180);
            this.PyramidUserControl.TabIndex = 12;
            // 
            // ParallelepipedUserControl
            // 
            this.ParallelepipedUserControl.Location = new System.Drawing.Point(210, 10);
            this.ParallelepipedUserControl.Name = "ParallelepipedUserControl";
            this.ParallelepipedUserControl.Size = new System.Drawing.Size(437, 210);
            this.ParallelepipedUserControl.TabIndex = 13;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 284);
            this.ControlBox = false;
            this.Controls.Add(this.ParallelepipedUserControl);
            this.Controls.Add(this.PyramidUserControl);
            this.Controls.Add(this.SphereUserControl);
            this.Controls.Add(this.CancelInputButton);
            this.Controls.Add(this.OkInputButton);
            this.Controls.Add(this.SelectFigureGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input figure";
            this.SelectFigureGroupBox.ResumeLayout(false);
            this.SelectFigureGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SelectFigureGroupBox;
        private System.Windows.Forms.RadioButton PyramidRadioButton;
        private System.Windows.Forms.RadioButton ParallelepipedRadioButton;
        private System.Windows.Forms.RadioButton SphereRadioButton;
        private System.Windows.Forms.Button OkInputButton;
        private System.Windows.Forms.Button CancelInputButton;
        private ParallelepipedUserControl ParallelepipedUserControl;
        private PyramidUserControl PyramidUserControl;
        private SphereUserControl SphereUserControl;
    }
}