
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
            this.components = new System.ComponentModel.Container();
            this.SelectFigureGroupBox = new System.Windows.Forms.GroupBox();
            this.PyramidRadioButton = new System.Windows.Forms.RadioButton();
            this.ParallelepipedRadioButton = new System.Windows.Forms.RadioButton();
            this.SphereRadioButton = new System.Windows.Forms.RadioButton();
            this.RadiusHeightGroupBox = new System.Windows.Forms.GroupBox();
            this.RadiusHeightLabel = new System.Windows.Forms.Label();
            this.RadiusHeightMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SecondSideMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SecondSideLabel = new System.Windows.Forms.Label();
            this.FirstSideMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SideFirstSideLabel = new System.Windows.Forms.Label();
            this.SidesAngleMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SidesAngleLabel = new System.Windows.Forms.Label();
            this.NumberOfSidesLabel = new System.Windows.Forms.Label();
            this.BaseGroupBox = new System.Windows.Forms.GroupBox();
            this.NumberOfSidesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OkInputButton = new System.Windows.Forms.Button();
            this.CancelInputButton = new System.Windows.Forms.Button();
            this.RadiusHeightErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SidesAngleErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FirstSideErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SecondSideErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SelectFigureGroupBox.SuspendLayout();
            this.RadiusHeightGroupBox.SuspendLayout();
            this.BaseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfSidesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusHeightErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SidesAngleErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstSideErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondSideErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectFigureGroupBox
            // 
            this.SelectFigureGroupBox.Controls.Add(this.PyramidRadioButton);
            this.SelectFigureGroupBox.Controls.Add(this.ParallelepipedRadioButton);
            this.SelectFigureGroupBox.Controls.Add(this.SphereRadioButton);
            this.SelectFigureGroupBox.Location = new System.Drawing.Point(12, 12);
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
            this.PyramidRadioButton.CheckedChanged += new System.EventHandler(this.PyramidRadioButton_CheckedChanged);
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
            this.ParallelepipedRadioButton.CheckedChanged += new System.EventHandler(this.ParallelepipedRadioButton_CheckedChanged);
            // 
            // SphereRadioButton
            // 
            this.SphereRadioButton.AutoSize = true;
            this.SphereRadioButton.Location = new System.Drawing.Point(6, 24);
            this.SphereRadioButton.Name = "SphereRadioButton";
            this.SphereRadioButton.Size = new System.Drawing.Size(67, 21);
            this.SphereRadioButton.TabIndex = 0;
            this.SphereRadioButton.TabStop = true;
            this.SphereRadioButton.Text = "Sphere";
            this.SphereRadioButton.UseVisualStyleBackColor = true;
            this.SphereRadioButton.CheckedChanged += new System.EventHandler(this.SphereRadioButton_CheckedChanged);
            // 
            // RadiusHeightGroupBox
            // 
            this.RadiusHeightGroupBox.Controls.Add(this.RadiusHeightLabel);
            this.RadiusHeightGroupBox.Controls.Add(this.RadiusHeightMaskedTextBox);
            this.RadiusHeightGroupBox.Location = new System.Drawing.Point(212, 12);
            this.RadiusHeightGroupBox.Name = "RadiusHeightGroupBox";
            this.RadiusHeightGroupBox.Size = new System.Drawing.Size(211, 53);
            this.RadiusHeightGroupBox.TabIndex = 1;
            this.RadiusHeightGroupBox.TabStop = false;
            this.RadiusHeightGroupBox.Text = "Radius / Height";
            // 
            // RadiusHeightLabel
            // 
            this.RadiusHeightLabel.AutoSize = true;
            this.RadiusHeightLabel.Location = new System.Drawing.Point(6, 21);
            this.RadiusHeightLabel.Name = "RadiusHeightLabel";
            this.RadiusHeightLabel.Size = new System.Drawing.Size(88, 17);
            this.RadiusHeightLabel.TabIndex = 8;
            this.RadiusHeightLabel.Text = "RadiusHeight:";
            // 
            // RadiusHeightMaskedTextBox
            // 
            this.RadiusHeightMaskedTextBox.Location = new System.Drawing.Point(121, 18);
            this.RadiusHeightMaskedTextBox.Name = "RadiusHeightMaskedTextBox";
            this.RadiusHeightMaskedTextBox.Size = new System.Drawing.Size(56, 25);
            this.RadiusHeightMaskedTextBox.TabIndex = 0;
            this.RadiusHeightMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.RadiusMaskedTextBox_Validating);
            this.RadiusHeightMaskedTextBox.Validated += new System.EventHandler(this.RadiusHeightMaskedTextBox_Validated);
            // 
            // SecondSideMaskedTextBox
            // 
            this.SecondSideMaskedTextBox.Location = new System.Drawing.Point(121, 111);
            this.SecondSideMaskedTextBox.Name = "SecondSideMaskedTextBox";
            this.SecondSideMaskedTextBox.Size = new System.Drawing.Size(56, 25);
            this.SecondSideMaskedTextBox.TabIndex = 7;
            this.SecondSideMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.SecondSideMaskedTextBox_Validating);
            this.SecondSideMaskedTextBox.Validated += new System.EventHandler(this.SecondSideMaskedTextBox_Validated);
            // 
            // SecondSideLabel
            // 
            this.SecondSideLabel.AutoSize = true;
            this.SecondSideLabel.Location = new System.Drawing.Point(6, 114);
            this.SecondSideLabel.Name = "SecondSideLabel";
            this.SecondSideLabel.Size = new System.Drawing.Size(82, 17);
            this.SecondSideLabel.TabIndex = 6;
            this.SecondSideLabel.Text = "Second side:";
            // 
            // FirstSideMaskedTextBox
            // 
            this.FirstSideMaskedTextBox.Location = new System.Drawing.Point(121, 80);
            this.FirstSideMaskedTextBox.Name = "FirstSideMaskedTextBox";
            this.FirstSideMaskedTextBox.Size = new System.Drawing.Size(56, 25);
            this.FirstSideMaskedTextBox.TabIndex = 5;
            this.FirstSideMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.FirstSideMaskedTextBox_Validating);
            this.FirstSideMaskedTextBox.Validated += new System.EventHandler(this.FirstSideMaskedTextBox_Validated);
            // 
            // SideFirstSideLabel
            // 
            this.SideFirstSideLabel.AutoSize = true;
            this.SideFirstSideLabel.Location = new System.Drawing.Point(6, 83);
            this.SideFirstSideLabel.Name = "SideFirstSideLabel";
            this.SideFirstSideLabel.Size = new System.Drawing.Size(88, 17);
            this.SideFirstSideLabel.TabIndex = 4;
            this.SideFirstSideLabel.Text = "SideFirst side:";
            // 
            // SidesAngleMaskedTextBox
            // 
            this.SidesAngleMaskedTextBox.Location = new System.Drawing.Point(121, 49);
            this.SidesAngleMaskedTextBox.Name = "SidesAngleMaskedTextBox";
            this.SidesAngleMaskedTextBox.Size = new System.Drawing.Size(56, 25);
            this.SidesAngleMaskedTextBox.TabIndex = 3;
            this.SidesAngleMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.SidesAngleMaskedTextBox_Validating);
            this.SidesAngleMaskedTextBox.Validated += new System.EventHandler(this.SidesAngleMaskedTextBox_Validated);
            // 
            // SidesAngleLabel
            // 
            this.SidesAngleLabel.AutoSize = true;
            this.SidesAngleLabel.Location = new System.Drawing.Point(6, 52);
            this.SidesAngleLabel.Name = "SidesAngleLabel";
            this.SidesAngleLabel.Size = new System.Drawing.Size(78, 17);
            this.SidesAngleLabel.TabIndex = 2;
            this.SidesAngleLabel.Text = "Sides angle:";
            // 
            // NumberOfSidesLabel
            // 
            this.NumberOfSidesLabel.AutoSize = true;
            this.NumberOfSidesLabel.Location = new System.Drawing.Point(6, 21);
            this.NumberOfSidesLabel.Name = "NumberOfSidesLabel";
            this.NumberOfSidesLabel.Size = new System.Drawing.Size(109, 17);
            this.NumberOfSidesLabel.TabIndex = 0;
            this.NumberOfSidesLabel.Text = "Number of sides:";
            // 
            // BaseGroupBox
            // 
            this.BaseGroupBox.Controls.Add(this.NumberOfSidesNumericUpDown);
            this.BaseGroupBox.Controls.Add(this.NumberOfSidesLabel);
            this.BaseGroupBox.Controls.Add(this.SidesAngleMaskedTextBox);
            this.BaseGroupBox.Controls.Add(this.SideFirstSideLabel);
            this.BaseGroupBox.Controls.Add(this.SecondSideMaskedTextBox);
            this.BaseGroupBox.Controls.Add(this.SidesAngleLabel);
            this.BaseGroupBox.Controls.Add(this.FirstSideMaskedTextBox);
            this.BaseGroupBox.Controls.Add(this.SecondSideLabel);
            this.BaseGroupBox.Location = new System.Drawing.Point(212, 71);
            this.BaseGroupBox.Name = "BaseGroupBox";
            this.BaseGroupBox.Size = new System.Drawing.Size(211, 149);
            this.BaseGroupBox.TabIndex = 8;
            this.BaseGroupBox.TabStop = false;
            this.BaseGroupBox.Text = "Base:";
            // 
            // NumberOfSidesNumericUpDown
            // 
            this.NumberOfSidesNumericUpDown.Location = new System.Drawing.Point(121, 15);
            this.NumberOfSidesNumericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NumberOfSidesNumericUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumberOfSidesNumericUpDown.Name = "NumberOfSidesNumericUpDown";
            this.NumberOfSidesNumericUpDown.Size = new System.Drawing.Size(56, 25);
            this.NumberOfSidesNumericUpDown.TabIndex = 11;
            this.NumberOfSidesNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // OkInputButton
            // 
            this.OkInputButton.Location = new System.Drawing.Point(18, 226);
            this.OkInputButton.Name = "OkInputButton";
            this.OkInputButton.Size = new System.Drawing.Size(188, 33);
            this.OkInputButton.TabIndex = 9;
            this.OkInputButton.Text = "OK";
            this.OkInputButton.UseVisualStyleBackColor = true;
            // 
            // CancelInputButton
            // 
            this.CancelInputButton.Location = new System.Drawing.Point(212, 226);
            this.CancelInputButton.Name = "CancelInputButton";
            this.CancelInputButton.Size = new System.Drawing.Size(188, 33);
            this.CancelInputButton.TabIndex = 10;
            this.CancelInputButton.Text = "Cancel";
            this.CancelInputButton.UseVisualStyleBackColor = true;
            // 
            // RadiusHeightErrorProvider
            // 
            this.RadiusHeightErrorProvider.ContainerControl = this;
            // 
            // SidesAngleErrorProvider
            // 
            this.SidesAngleErrorProvider.ContainerControl = this;
            // 
            // FirstSideErrorProvider
            // 
            this.FirstSideErrorProvider.ContainerControl = this;
            // 
            // SecondSideErrorProvider
            // 
            this.SecondSideErrorProvider.ContainerControl = this;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelInputButton);
            this.Controls.Add(this.OkInputButton);
            this.Controls.Add(this.BaseGroupBox);
            this.Controls.Add(this.RadiusHeightGroupBox);
            this.Controls.Add(this.SelectFigureGroupBox);
            this.Name = "InputForm";
            this.Text = "Input figure";
            this.SelectFigureGroupBox.ResumeLayout(false);
            this.SelectFigureGroupBox.PerformLayout();
            this.RadiusHeightGroupBox.ResumeLayout(false);
            this.RadiusHeightGroupBox.PerformLayout();
            this.BaseGroupBox.ResumeLayout(false);
            this.BaseGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfSidesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusHeightErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SidesAngleErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstSideErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondSideErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SelectFigureGroupBox;
        private System.Windows.Forms.RadioButton PyramidRadioButton;
        private System.Windows.Forms.RadioButton ParallelepipedRadioButton;
        private System.Windows.Forms.RadioButton SphereRadioButton;
        private System.Windows.Forms.GroupBox RadiusHeightGroupBox;
        private System.Windows.Forms.MaskedTextBox RadiusHeightMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox SidesAngleMaskedTextBox;
        private System.Windows.Forms.Label SidesAngleLabel;
        private System.Windows.Forms.Label NumberOfSidesLabel;
        private System.Windows.Forms.MaskedTextBox SecondSideMaskedTextBox;
        private System.Windows.Forms.Label SecondSideLabel;
        private System.Windows.Forms.MaskedTextBox FirstSideMaskedTextBox;
        private System.Windows.Forms.Label SideFirstSideLabel;
        private System.Windows.Forms.Label RadiusHeightLabel;
        private System.Windows.Forms.GroupBox BaseGroupBox;
        private System.Windows.Forms.Button OkInputButton;
        private System.Windows.Forms.Button CancelInputButton;
        private System.Windows.Forms.ErrorProvider RadiusHeightErrorProvider;
        private System.Windows.Forms.NumericUpDown NumberOfSidesNumericUpDown;
        private System.Windows.Forms.ErrorProvider SidesAngleErrorProvider;
        private System.Windows.Forms.ErrorProvider FirstSideErrorProvider;
        private System.Windows.Forms.ErrorProvider SecondSideErrorProvider;
    }
}