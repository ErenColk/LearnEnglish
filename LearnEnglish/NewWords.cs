using LearnEnglish.Context;
using LearnEnglish.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnEnglish
{
    public partial class NewWords : Form
    {
        public NewWords( )
        {
            InitializeComponent();
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            AppDbContext dbContext = new AppDbContext();

            EnglishWord english = new EnglishWord();
            english.Word = txtEnglishWord.Text;
            english.Sentence = txtEnglishSentence.Text;
            dbContext.EnglishWords.Add(english);
            dbContext.SaveChanges();

            TurkishWord turkish = new TurkishWord();
            turkish.Word = txtTurkishWord.Text;
            turkish.Sentence = txtTurkishSentence.Text;
            turkish.Pronunciation = txtPronunciation.Text;
            turkish.EnglishWordId = english.Id;
            
            dbContext.TurkishWords.Add(turkish);
            dbContext.SaveChanges();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewWords_Load(object sender, EventArgs e)
        {

        }
    }
}
