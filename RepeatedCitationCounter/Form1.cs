using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RepeatedCitationCounter
{
    public partial class Form1 : Form
    {
        private string ChosenMasechta = "Bava Basra";
        private Scanner Scanner;
        private int characterLimit = 50;
        public int CharacterLimit { get { return characterLimit; } set { characterLimit = value; } }
        private int levenshtein = 0;
        public int Levenshtein { get { return levenshtein; } set { levenshtein = value; } }

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
            if (SaveOption.Checked) SaveTextFile(repetitionsFound);

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            Masechta masechta = new Masechta(ChosenMasechta);
            Scanner = new Scanner();
            string[] Blocks = Scanner.GetBlocks(masechta.FullText);
            Blocks = Scanner.CleanStringArrayOfEtc(Blocks);
            DisplayBlocks.Text = "Blocks In Chosen Text:\n\n";
            for (int block = 0; block < Blocks.Length; block++)
            {
                DisplayBlocks.Text += "\n" + Blocks[block];
            }
        }

        private void SaveTextFile(string[] text)
        {

            string path = BuildPath();
            WriteFile(path, text);
            
        }

        private void WriteFile(string path, string[] text)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine($"Analyzing {ChosenMasechta}");
            sw.WriteLine($"Character limit set to {CharacterLimit}");
            sw.WriteLine($"Maximum allowable Levenshtein distance of {Levenshtein}");
            sw.WriteLine($"Found {text.Length / 2} repetitions.");
            sw.WriteLine("Now printing both halves of each repetition.");
            sw.WriteLine();

            int longestString = LongestString(text);
            longestString *= 3;

            for (int str = 0; str < text.Length; str += 2)
            {
                sw.WriteLine("\n" + text[str]);
                sw.WriteLine(text[str + 1]);
                if (text.Length - 2 > str)
                {
                    for (int dash = 0; dash < longestString; dash++) sw.Write("-");
                    sw.WriteLine();
                }
            }
            sw.Close();
        }

        private string BuildPath()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"C:\Users\USER\source\repos\RepeatedCitationCounter\");
            sb.Append("\\");
            sb.Append(ChosenMasechta);
            sb.Append(" ");
            sb.Append(LevenshteinUpDown.Value);
            sb.Append(".txt");
            return sb.ToString();
        }

        private int LongestString(string[] text)
        {
            int result = 0;
            for(int str = 0; str < text.Length; str++)
            {
                if (result < text[str].Length) result = text[str].Length;
            }
            return result;
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

        private void SaveOption_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveOption.Checked) ResultsText.Text = "Will save analysis to text file.";
            else ResultsText.Text = "Will not save analysis to text file.";
        }
    }
}
