﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepeatedCitationCounter
{
    public partial class Form1 : Form
    {
        private string ChosenMasechta;
        private Scanner Scanner;
        private int characterLimit = 50;
        public int CharacterLimit { set { characterLimit = value; } }

        public Form1()
        {
            InitializeComponent();
        }

        private void MasechtaChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChosenMasechta = MasechtaChoice.Text;
        }

        private void CharsLimitNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            CharacterLimit = (int)CharsLimitNumUpDown.Value;
        }

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            Masechta masechta = new Masechta(ChosenMasechta);
            Scanner scanner = new Scanner(masechta.TextWords);
        }
    }
}
