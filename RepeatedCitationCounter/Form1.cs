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
        private string ChosenMasechta = "Bava Basra";
        private Scanner Scanner;
        private int characterLimit = 50;
        public int CharacterLimit { get { return characterLimit; } set { characterLimit = value; } }
        private int levenshtein = 0;
        public int Levenshtein { get { return levenshtein;  } set { levenshtein = value; } }

        public Form1()
        {
            InitializeComponent();
        }

        private void MasechtaChoice_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ChosenMasechta = MasechtaChoice.Text;
            ResultsText.Text = $"Your chosen Masechta is now {ChosenMasechta}";
        }

        private void CharsLimitNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            CharacterLimit = (int)CharsLimitNumUpDown.Value;
            ResultsText.Text = $"The app will now allow citations of up to {CharacterLimit} characters";
        }

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            Masechta masechta = new Masechta(ChosenMasechta);
            Scanner = new Scanner();
            string[] Blocks = Scanner.GetBlocks(masechta.FullText);
            string[] shortBlocks = Scanner.ShortBlocks(Blocks, CharacterLimit);
            shortBlocks = Scanner.CleanStringArrayOfEtc(shortBlocks);
            string[] repetitionsFound = Scanner.GetRepeatedCites(shortBlocks, Levenshtein);
            ResultsText.Text = $"Masechta {ChosenMasechta} has {repetitionsFound.Length / 2} repeated citations.";
            DisplayBlocks.Text = $"Here are the repetitions discovered in {ChosenMasechta}.";
            DisplayBlocks.Text = "\n";
            for (int repetition = 0; repetition < repetitionsFound.Length; repetition++)
            {
                DisplayBlocks.Text += repetitionsFound[repetition];
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            Masechta masechta = new Masechta(ChosenMasechta);
            Scanner = new Scanner();
            string[] Blocks = Scanner.GetBlocks(masechta.FullText);
            Blocks = Scanner.CleanStringArrayOfEtc(Blocks);
            for(int block = 0; block < Blocks.Length; block++)
            {
                DisplayBlocks.Text += Blocks[block];
            }
        }

        private void LevenshteinUpDown_ValueChanged(object sender, EventArgs e)
        {
            Levenshtein = (int)LevenshteinUpDown.Value;
            ResultsText.Text = $"The maximum permitted Levenshtein distance is now {Levenshtein}.";
        }

        private void ShortBlocksBttn_Click(object sender, EventArgs e)
        {
            Masechta masechta = new Masechta(ChosenMasechta);
            Scanner = new Scanner();
            string[] Blocks = Scanner.GetBlocks(masechta.FullText);
            string[] shortBlocks = Scanner.ShortBlocks(Blocks, CharacterLimit);
            shortBlocks = Scanner.CleanStringArrayOfEtc(shortBlocks);
            for (int block = 0; block < shortBlocks.Length; block++)
            {
                DisplayBlocks.Text += shortBlocks[block];
            }
        }
    }
}
