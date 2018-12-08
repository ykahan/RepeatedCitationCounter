using System;
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
        Masechta CurrentMasechta;
        Scanner Scanner;
        public Form1()
        {
            InitializeComponent();
            CurrentMasechta = new Masechta();
            Scanner = new Scanner();
        }

        private void MasechtaChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentMasechta.ChosenMasechta = MasechtaChoice.Text;
        }

        private void CharsLimitNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            Scanner.CharacterLimit = (int) CharsLimitNumUpDown.Value;
        }
    }
}
