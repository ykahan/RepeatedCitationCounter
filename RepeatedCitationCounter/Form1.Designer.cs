namespace RepeatedCitationCounter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.AnalyzeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultsText = new System.Windows.Forms.Label();
            this.CharsLimitNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.MasechtaChoice = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CharsLimitNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Masechta";
            // 
            // AnalyzeButton
            // 
            this.AnalyzeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AnalyzeButton.Location = new System.Drawing.Point(12, 171);
            this.AnalyzeButton.Name = "AnalyzeButton";
            this.AnalyzeButton.Size = new System.Drawing.Size(288, 23);
            this.AnalyzeButton.TabIndex = 2;
            this.AnalyzeButton.Text = "Analyze!";
            this.AnalyzeButton.UseVisualStyleBackColor = true;
            this.AnalyzeButton.Click += new System.EventHandler(this.AnalyzeButton_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(41, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 90);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // ResultsText
            // 
            this.ResultsText.AutoSize = true;
            this.ResultsText.Location = new System.Drawing.Point(41, 208);
            this.ResultsText.Name = "ResultsText";
            this.ResultsText.Size = new System.Drawing.Size(210, 13);
            this.ResultsText.TabIndex = 4;
            this.ResultsText.Text = "You have not yet analyzed any masechtos.";
            this.ResultsText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CharsLimitNumUpDown
            // 
            this.CharsLimitNumUpDown.Location = new System.Drawing.Point(154, 106);
            this.CharsLimitNumUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.CharsLimitNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CharsLimitNumUpDown.Name = "CharsLimitNumUpDown";
            this.CharsLimitNumUpDown.Size = new System.Drawing.Size(50, 20);
            this.CharsLimitNumUpDown.TabIndex = 5;
            this.CharsLimitNumUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CharsLimitNumUpDown.ValueChanged += new System.EventHandler(this.CharsLimitNumUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Character Limit";
            // 
            // MasechtaChoice
            // 
            this.MasechtaChoice.FormattingEnabled = true;
            this.MasechtaChoice.Items.AddRange(new object[] {
            "Bava Basra"});
            this.MasechtaChoice.Location = new System.Drawing.Point(154, 138);
            this.MasechtaChoice.Name = "MasechtaChoice";
            this.MasechtaChoice.Size = new System.Drawing.Size(121, 21);
            this.MasechtaChoice.TabIndex = 7;
            this.MasechtaChoice.Text = "Bava Basra";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 261);
            this.Controls.Add(this.MasechtaChoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CharsLimitNumUpDown);
            this.Controls.Add(this.ResultsText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnalyzeButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Cite Find by Yehoshua Kahan";
            ((System.ComponentModel.ISupportInitialize)(this.CharsLimitNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AnalyzeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ResultsText;
        private System.Windows.Forms.NumericUpDown CharsLimitNumUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MasechtaChoice;
    }
}

