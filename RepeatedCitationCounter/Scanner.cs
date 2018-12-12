using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedCitationCounter
{
    class Scanner
    {

        private String[] Text;

        public Scanner(String[] text)
        {
            Text = text;
        }

        public Perek[] BuildPerakim()
        {
            List<string> perakimList = new List<string>();
            StringBuilder sb = new StringBuilder();
            foreach (string word in Text)
            {
                sb.Append(word);
                if (word.Equals("הדרן"))
                {
                    string perekText = sb.ToString();
                    perakimList.Add(perekText);
                    sb.Clear();
                }
            }
            Perek[] perakimArray = new Perek[perakimList.Count];
            for (int perekNumber = 0; perekNumber < perakimList.Count; perekNumber++)
            {
                perakimArray[perekNumber] = new Perek(perakimList[perekNumber], this);
            }
            return perakimArray;
        }

        public Block[] BuildBlocks(string text)
        {
            List<string> blocksList = new List<string>();
            StringBuilder sb = new StringBuilder();
            String[] textArray = text.Split(' ');
            foreach (string word in textArray)
            {
                sb.Append(word);
                if (word.Equals("מתני׳") && sb.Length > 5)
                {
                    string blockText = sb.ToString();
                    blocksList.Add(blockText);
                    sb.Clear();
                }
            }
            Block[] blocksArray = new Block[blocksList.Count];
            for (int blockNumber = 0; blockNumber < blocksList.Count; blockNumber++)
            {
                blocksArray[blockNumber] = new Block(blocksList[blockNumber], this);
            }
            return blocksArray;
        }

        public string[] GetCitations(string[] text)
        {
            string firstCitation = "";
            string secondCitation = "";
            string placeholder = "";
            StringBuilder sb = new StringBuilder();
            bool EndCite = false;
            foreach (string word in text)
            {
                if (word[word.Length - 1].Equals(":")) EndCite = true;
                else EndCite = false;
                sb.Append(word);
                if (EndCite)
                {
                    placeholder = sb.ToString();
                    sb.Clear();
                    if (firstCitation.Equals(""))
                    {
                        firstCitation = placeholder;
                    }
                    else
                    {
                        if (!secondCitation.Equals(""))
                        {
                            firstCitation = secondCitation;
                        }
                        secondCitation = placeholder;
                    }
                }
            }
            string[] result = new string[] { firstCitation, secondCitation };
        }

        public int CompareCitations(string[] text, int limit)
        {
            string first = text[0];
            string second = text[1];

        }


    }
}
