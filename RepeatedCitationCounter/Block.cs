using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedCitationCounter
{
    class Block
    {
        private string Mishna;
        private Gemara Gemara;
        private string fullText;
        public string FullText { get { return fullText; } set { fullText = value; } }
        private Scanner scanner;

        public Block(string text, Scanner scanner)
        {
            FullText = text;
            this.scanner = scanner;
        }

    

    }
}
