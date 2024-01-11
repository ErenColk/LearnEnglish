using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Entities
{
    public class EnglishWord
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public string Sentence { get; set; }


        //NAV
        public TurkishWord TurkishWord { get; set; }

    }
}
