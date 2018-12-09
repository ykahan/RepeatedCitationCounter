using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedCitationCounter
{
    class Perek
    {
        Block[] FullPerek;
        private string text;
        public string Text { get { return text; } set { text = value; } }
        Scanner scanner;

        public Perek(string text, Scanner scanner)
        {
            Text = text;
            this.scanner = scanner;
            FullPerek = scanner.BuildBlocks(Text);
        }
    }
}
