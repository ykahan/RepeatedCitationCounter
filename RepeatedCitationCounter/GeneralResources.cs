using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedCitationCounter
{
    class GeneralResources
    {
        public Dictionary<string, string> FilePaths;
        public Char[] AcceptableCharacters;
        public GeneralResources()
        {
            AcceptableCharacters = new Char[]
{
                'א', 'ב', 'ג', 'ד', 'ה', 'ו', 'ז', 'ח', 'ט', 'י', 'כ', 'ך', 'ל', 'מ', 'ם', 'נ', 'ן', 'ס', 'ע', 'פ', 'ף', 'צ', 'ץ', 'ק', 'ר', 'ש', 'ת', '1', '2', '3', '4',
                '5', '6', '7', '8', '9', '0', 'a', 'b', ':', '\'', '<', '>', 'i', 'g', 's', 't', 'r', 'o', 'n', 'g', '/', '[', ']', '׳'
};
            FilePaths = new Dictionary<string, string>();
            FilePaths.Add("Bava Basra", @"C:\Users\USER\Documents\Yehoshua\Programming\Text Resources\RepeatedCitationCounter\BavaBasra.txt");
            FilePaths.Add("Testing Text", @"C:\Users\USER\Documents\Yehoshua\Programming\Text Resources\RepeatedCitationCounter\TestingText.txt");

        }
    }
}
