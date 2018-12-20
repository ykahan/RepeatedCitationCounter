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
            this.DisplayBlocks = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LevenshteinUpDown = new System.Windows.Forms.NumericUpDown();
            this.ShortBlocksBttn = new System.Windows.Forms.Button();
            this.SaveOption = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.CharsLimitNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevenshteinUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Masechta";
            // 
            // AnalyzeButton
            // 
            this.AnalyzeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AnalyzeButton.Location = new System.Drawing.Point(12, 213);
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
            this.ResultsText.Location = new System.Drawing.Point(41, 239);
            this.ResultsText.Name = "ResultsText";
            this.ResultsText.Size = new System.Drawing.Size(210, 13);
            this.ResultsText.TabIndex = 4;
            this.ResultsText.Text = "You have not yet analyzed any masechtos.";
            this.ResultsText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CharsLimitNumUpDown
            // 
            this.CharsLimitNumUpDown.Location = new System.Drawing.Point(180, 106);
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
            "Pesachim",
            "Kesuvos",
            "Gittin (Bavli)",
            "Yevamos",
            "Bava Metzia",
            "Bava Basra",
            "Testing Text",
            "Bava Basra 69a"});
            this.MasechtaChoice.Location = new System.Drawing.Point(180, 182);
            this.MasechtaChoice.Name = "MasechtaChoice";
            this.MasechtaChoice.Size = new System.Drawing.Size(121, 21);
            this.MasechtaChoice.TabIndex = 7;
            this.MasechtaChoice.Text = "Bava Basra";
            this.MasechtaChoice.SelectedIndexChanged += new System.EventHandler(this.MasechtaChoice_SelectedIndexChanged_1);
            // 
            // DisplayBlocks
            // 
            this.DisplayBlocks.AutoSize = true;
            this.DisplayBlocks.Location = new System.Drawing.Point(408, 13);
            this.DisplayBlocks.Name = "DisplayBlocks";
            this.DisplayBlocks.Size = new System.Drawing.Size(0, 13);
            this.DisplayBlocks.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Max Levenshtein Dist";
            // 
            // LevenshteinUpDown
            // 
            this.LevenshteinUpDown.Location = new System.Drawing.Point(180, 146);
            this.LevenshteinUpDown.Name = "LevenshteinUpDown";
            this.LevenshteinUpDown.Size = new System.Drawing.Size(50, 20);
            this.LevenshteinUpDown.TabIndex = 11;
            this.LevenshteinUpDown.ValueChanged += new System.EventHandler(this.LevenshteinUpDown_ValueChanged);
            // 
            // ShortBlocksBttn
            // 
            this.ShortBlocksBttn.Location = new System.Drawing.Point(12, 276);
            this.ShortBlocksBttn.Name = "ShortBlocksBttn";
            this.ShortBlocksBttn.Size = new System.Drawing.Size(75, 23);
            this.ShortBlocksBttn.TabIndex = 12;
            this.ShortBlocksBttn.Text = "Short Blocks";
            this.ShortBlocksBttn.UseVisualStyleBackColor = true;
            this.ShortBlocksBttn.Click += new System.EventHandler(this.ShortBlocksBttn_Click);
            // 
            // SaveOption
            // 
            this.SaveOption.AutoSize = true;
            this.SaveOption.Location = new System.Drawing.Point(152, 280);
            this.SaveOption.Name = "SaveOption";
            this.SaveOption.Size = new System.Drawing.Size(148, 17);
            this.SaveOption.TabIndex = 13;
            this.SaveOption.Text = "Save Results To Text File";
            this.SaveOption.UseVisualStyleBackColor = true;
            this.SaveOption.CheckedChanged += new System.EventHandler(this.SaveOption_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 314);
            this.Controls.Add(this.SaveOption);
            this.Controls.Add(this.ShortBlocksBttn);
            this.Controls.Add(this.LevenshteinUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DisplayBlocks);
            this.Controls.Add(this.MasechtaChoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CharsLimitNumUpDown);
            this.Controls.Add(this.ResultsText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnalyzeButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cite Find by Yehoshua Kahan";
            ((System.ComponentModel.ISupportInitialize)(this.CharsLimitNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevenshteinUpDown)).EndInit();
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
        private System.Windows.Forms.Label DisplayBlocks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown LevenshteinUpDown;
        private System.Windows.Forms.Button ShortBlocksBttn;
        private System.Windows.Forms.CheckBox SaveOption;
    }
}

