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
        GeneralResources gr;

        public Scanner()
        {
            gr = new GeneralResources();
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
            return result;
        }

        public int CompareCitations(string[] text, int limit)
        {
            string first = text[0];
            string second = text[1];
            return 0;
        }

        public string[] GetBlocks(string text)
        {
            string[] result = text.Split(':');
            return result;
        }

        public string[] CleanBlocks(string[] blocks)
        {
            if (blocks.Length > 0)
            {
                StringBuilder sb = new StringBuilder();
                
                for (int text = 0; text < blocks.Length; text++)
                {
                    sb.Append('\n');
                    foreach (char character in blocks[text])
                    {
                        if (gr.AcceptableCharacters.Contains(character)) sb.Append(character);
                        //if (CharNotSpace(character)) sb.Append(character);
                    }
                    int etc = EndsWithEtc(sb);
                    if (etc > 0) sb = ClearEtc(sb, etc);
                    //sb.Append('\n');
                    blocks[text] = sb.ToString();
                    sb.Clear();
                }
            }
            return blocks;
        }

        //private bool CharNotSpace(char c)
        //{
        //    if (c.Equals(' ')) return false;
        //    return true;
        //}

        private int EndsWithEtc(StringBuilder sb)
        {
            //if (sb.ToString().EndsWith("וכו׳") || sb.ToString().EndsWith("וכו'") || sb.ToString().EndsWith("וגו'") || sb.ToString().EndsWith("וגו׳")) return 4;
            if (sb.ToString().EndsWith("וכו") || sb.ToString().EndsWith("וגו")) return 3;
            if (sb.ToString().EndsWith("וכוליה") || sb.ToString().EndsWith("וכולי'") || sb.ToString().EndsWith("וכולי׳")) return 6;
            if (sb.ToString().EndsWith("וגומר")) return 5;
            return -1;
        }

        private StringBuilder ClearEtc(StringBuilder sb, int etc)
        {
            sb.Remove(sb.Length - etc, etc);
            return sb;
        }

        public string[] GetRepeatedCites(string[] blocks, int MaxLevDistance)
        {
            List<string> resultsList = new List<string>();
            int counter = 0;
            for (int block = 1; block < blocks.Length; block++)
            {
                bool closeEnough = true;
                if (Levenshtein(blocks[block], blocks[block - 1]) > MaxLevDistance) closeEnough = false;
                if (closeEnough == true)
                {
                    counter++;
                    resultsList.Add(blocks[block - 1]);
                    resultsList.Add(blocks[block]);
                }
            }
            string[] resultsArray = resultsList.ToArray();
            return resultsArray;
        }

        public string[] ShortBlocks(string[] blocks, int limit)
        {
            List<String> blocksList = new List<String>();
            for (int block = 0; block < blocks.Length; block++)
            {
                if (blocks[block].Length <= limit)
                {
                    blocksList.Add(blocks[block]);
                }
            }
            string[] result = blocksList.ToArray();
            return result;
        }

        private int Levenshtein(string a, string b)
        {
            // taken from Wikibooks

            if (string.IsNullOrEmpty(a))
            {
                if (!string.IsNullOrEmpty(b))
                {
                    return b.Length;
                }
                return 0;
            }

            if (string.IsNullOrEmpty(b))
            {
                if (!string.IsNullOrEmpty(a))
                {
                    return a.Length;
                }
                return 0;
            }

            int cost;
            int[,] d = new int[a.Length + 1, b.Length + 1];
            int min1;
            int min2;
            int min3;

            for (int i = 0; i <= d.GetUpperBound(0); i += 1)
            {
                d[i, 0] = i;
            }

            for (int i = 0; i <= d.GetUpperBound(1); i += 1)
            {
                d[0, i] = i;
            }

            for (int i = 1; i <= d.GetUpperBound(0); i += 1)
            {
                for (int j = 1; j <= d.GetUpperBound(1); j += 1)
                {
                    cost = (a[i - 1] != b[j - 1]) ? 1 : 0;

                    min1 = d[i - 1, j] + 1;
                    min2 = d[i, j - 1] + 1;
                    min3 = d[i - 1, j - 1] + cost;
                    d[i, j] = Math.Min(Math.Min(min1, min2), min3);
                }
            }

            return d[d.GetUpperBound(0), d.GetUpperBound(1)];

        }
    }
}
