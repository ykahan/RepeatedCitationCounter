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
        public String[] TextWords { get { return textWords; } set { textWords = value; } }
        //private string cleanedText;
        //public string CleanedText { get { return cleanedText; } set { cleanedText = value; } }
        private string[] Perakim;
        private string chosenMasechta = "Bava Basra";
        public string ChosenMasechta { get { return chosenMasechta; } set { chosenMasechta = value; } }
        private GeneralResources GR;
        private Scanner scanner;

        public Masechta(string masechta)
        {
            GR = new GeneralResources();
            ChosenMasechta = masechta;
            FullText = System.IO.File.ReadAllText(GR.FilePaths[ChosenMasechta]);
            Perakim = GetPerakimTexts();

        }

        public string[] GetPerakimTexts()
        {
            TextWords = FullText.Split(' ');
            StringBuilder sb = new StringBuilder();
            List<string> PerakimTextsList = new List<string>();
            for (int word = 0; word < TextWords.Length; word++)
            {
                sb.Append(word);
                sb.Append(" ");
                if(IsEndOfPerek(word))
                {
                    string perek = sb.ToString();
                    for(int i = 0; i < perek.Length; i++)
                    {
                        sb.Append(perek[i]);
                    }
                    PerakimTextsList.Add(perek);
                    sb.Clear();
                }
            }
            string[] PerakimTextsArray = new string[PerakimTextsList.Count];
            return PerakimTextsArray;
        }

        private bool IsEndOfPerek(int word)
        {
            if(TextWords[word - 1].Equals("הדרן") && (TextWords[word].Equals("עלך") || TextWords[word].Equals("עליך")))
            {
                return true;
            }
            return false;
        }
    }
}
