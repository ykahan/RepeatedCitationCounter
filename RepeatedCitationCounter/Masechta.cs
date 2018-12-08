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
        private string CleanedText { get; }
        private Block[][] Perakim;
        private Char[] AcceptableCharacters;
        private string chosenMasechta = "Bava Basra";
        public string ChosenMasechta { get { return chosenMasechta; } set { chosenMasechta = value; } }
        private GeneralResources GR;

        public Masechta()
        {
            GR = new GeneralResources();
            FullText = System.IO.File.ReadAllText(GR.FilePaths[ChosenMasechta]);
            Char[] TextChars = FullText.ToCharArray();

            StringBuilder sb = new StringBuilder();
            foreach (Char c in TextChars)
            {
                if (GR.AcceptableCharacters.Contains(c)) sb.Append(c);
            }
            string CleanedText = sb.ToString();
           

        }

    }
}
