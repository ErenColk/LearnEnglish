using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Entities
{
    public class TurkishWord
    {

        public int Id { get; set; }
        public string Word { get; set; }
        public string Sentence { get; set; }
        public string Pronunciation { get; set; }

        //NAV
        public int EnglishWordId { get; set; }
        public EnglishWord EnglishWord { get; set; }

    }
}
