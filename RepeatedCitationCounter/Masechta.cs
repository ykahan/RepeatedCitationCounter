using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedCitationCounter
{
    class Masechta
    {
        private string FullText;
        private String[] textWords;
        public String[] TextWords { get { return textWords; } set { textWords = value; } };
        private string cleanedText;
        public string CleanedText { get {return cleanedText; } set { cleanedText = value; } }
        private List<Perek> Perakim;
        private string chosenMasechta = "Bava Basra";
        public string ChosenMasechta { get { return chosenMasechta; } set { chosenMasechta = value; } }
        private GeneralResources GR;
        private Scanner scanner;

        public Masechta()
        {
            GR = new GeneralResources();
            FullText = System.IO.File.ReadAllText(GR.FilePaths[ChosenMasechta]);
            TextWords = FullText.Split(' ');
            //Char[] TextChars = FullText.ToCharArray();

            //StringBuilder sb = new StringBuilder();
            //foreach (Char c in TextChars)
            //{
            //    if (GR.AcceptableCharacters.Contains(c)) sb.Append(c);
            //}
            //string CleanedText = sb.ToString();
           

        }

    }
}
