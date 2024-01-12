using LearnEnglish.Context;
using LearnEnglish.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnEnglish
{
    public partial class Form1 : Form
    {

        private AppDbContext dbContext;

        public Form1()
        {
            InitializeComponent();
            dbContext = new AppDbContext();

        }



        //ListBox lstEklenenKelimeler = new ListBox();
        List<TurkishWord> _turkishWords;
        List<EnglishWord> _englishWords;
        List<EnglishWord> unkownEnglishWord;
        List<TurkishWord> unkownTurkishWord;


        private void Form1_Load(object sender, EventArgs e)
        {
            _turkishWords = new List<TurkishWord>();
            _englishWords = new List<EnglishWord>();
            unkownTurkishWord = new List<TurkishWord>();
            unkownEnglishWord = new List<EnglishWord>();

            _englishWords.AddRange(dbContext.EnglishWords);
            _turkishWords.AddRange(dbContext.TurkishWords);
            //kalanKelime = ingilizceKelimeler.Length;
            //lblRemainingWord.Text = kalanKelime.ToString();
            //lstEklenenKelimeler.Width = 0;
            //lblUnkownWords.Text = kelimeSayisi.ToString();

            //btnTurkishExampleSentence.Enabled = false;
            //btnEnglishExampleSentence.Enabled = false;
            //btnShowTurkishWord.Enabled = false;
            //btnPronunciation.Enabled = false;
            //btnShowUnkownWord.Enabled = false;
            //btnAddUnkown.Enabled = false;

            lblRemainingWord.Text = dbContext.EnglishWords.Count().ToString();
            lblUnkownWords.Text = "0";

            btnShowTurkishWord.Enabled = false;
            btnAddUnkown.Enabled = false;
            btnStartOver.Enabled = false;
            btnShowUnkownWord.Enabled = false;

        }

      

        int selectedWord = 0;
        Random random = new Random();

        EnglishWord englishWord;
        TurkishWord turkishWord;
        string englishSentence = "";
        string turkishSentence = "";
        string pronunciation = "";
        private void btnShowEnglishWord_Click(object sender, EventArgs e)
        {
            btnAddUnkown.Enabled = true;
            btnStartOver.Enabled = true;
            
      
                if (!DidItChange)
                {
                    selectedWord = random.Next(0, _englishWords.Count);
                    englishWord = _englishWords[selectedWord];
                    lblEnglish.Text = englishWord.Word;
                    englishSentence = englishWord.Sentence;
                    _englishWords.Remove(englishWord);

                    btnShowEnglishWord.Enabled = false;

                    if (_turkishWords.Count != 0)
                        btnShowTurkishWord.Enabled = true;

                    turkishWord = _turkishWords[selectedWord];
                    turkishSentence = turkishWord.Sentence;
                    pronunciation = turkishWord.Pronunciation;

                    lblRemainingWord.Text = _englishWords.Count.ToString();
                }
                else
                {
                    if (_turkishWords.Count != 0)
                        btnShowTurkishWord.Enabled = true;

                    lblEnglish.Text = englishWord.Word;
                    _englishWords.Remove(englishWord);

                }

            
       

            if (_englishWords.Count == 0)
            {
                btnShowEnglishWord.Enabled = false;

            }

        }

        // TURKCE KELİEMELERİ GÖSTER
        private void btnShowTurkishWord_Click(object sender, EventArgs e)
        {

            btnStartOver.Enabled = true;


            if (!showingUnkownWords)
            {
                if (DidItChange)
                {
                    selectedWord = random.Next(0, _turkishWords.Count);

                    turkishWord = _turkishWords[selectedWord];
                    lblTurkish.Text = turkishWord.Word;
                    turkishSentence = turkishWord.Sentence;
                    _turkishWords.Remove(turkishWord);

                    btnShowTurkishWord.Enabled = false;


                    if (_englishWords.Count != 0)
                        btnShowEnglishWord.Enabled = true;

                    englishWord = _englishWords[selectedWord];
                    englishSentence = englishWord.Sentence;

                    lblRemainingWord.Text = _turkishWords.Count.ToString();
                }
                else
                {
                    lblTurkish.Text = turkishWord.Word;
                    _turkishWords.Remove(turkishWord);

                    btnShowTurkishWord.Enabled = false;

                    if (_englishWords.Count != 0)
                        btnShowEnglishWord.Enabled = true;

                }


            }
            else
            {

                btnShowTurkishWord.Enabled = false;

                lblTurkish.Text = turkishWord.Word;
                unkownTurkishWord.Remove(turkishWord);

                btnShowTurkishWord.Enabled = false;

                if (unkownEnglishWord.Count != 0)
                    btnShowUnkownWord.Enabled = true;


            }



            if (_turkishWords.Count == 0)
            {
                btnShowTurkishWord.Enabled = false;
            }



        }

        private void btnTurkishExampleSentence_Click(object sender, EventArgs e)
        {

            lblTurkishSentence.Text = turkishSentence;

            if (_turkishWords.Count == 0 || _englishWords.Count == 0)
            {
                btnTurkishExampleSentence.Enabled = false;
            }
        }

        private void btnEnglishExampleSentence_Click(object sender, EventArgs e)
        {

            lblEnglishSentence.Text = englishSentence;

            if (_turkishWords.Count == 0 || _englishWords.Count == 0)
                btnEnglishExampleSentence.Enabled = false;
        }

        private void btnPronunciation_Click(object sender, EventArgs e)
        {

            lblPronunciation.Text = pronunciation;

            if (_turkishWords.Count == 0 || _englishWords.Count == 0)
            {
                btnPronunciation.Enabled = false;
            }
        }

        private void btnStartOver_Click(object sender, EventArgs e)
        {

            _turkishWords = new List<TurkishWord>();
            _englishWords = new List<EnglishWord>();
            unkownTurkishWord = new List<TurkishWord>();
            unkownEnglishWord = new List<EnglishWord>();

            _englishWords.AddRange(dbContext.EnglishWords);
            _turkishWords.AddRange(dbContext.TurkishWords);

          showingUnkownWords = false;



            if (!DidItChange)
            {
                btnShowEnglishWord.Enabled = true;
                btnShowTurkishWord.Enabled = false;
            }
            else
            {
                btnShowTurkishWord.Enabled = true;
            }


            foreach (Control item in this.Controls)
            {
                if (item is Label)
                {
                    item.Text = "";
                }
            }

            lblRemainingWord.Text = _englishWords.Count.ToString();

            lblUnkownWords.Text = "0";

            btnEnglishExampleSentence.Enabled = true;
            btnTurkishExampleSentence.Enabled = true;
            btnShowEnglishWord.Enabled = true;
            btnPronunciation.Enabled = true;
            btnAddUnkown.Enabled = true;
            btnShowUnkownWord.Enabled = false;



        }


        bool showingUnkownWords = false;
        private void btnAddUnkown_Click(object sender, EventArgs e)
        {

            unkownEnglishWord.Add(englishWord);
            unkownTurkishWord.Add(turkishWord);

            btnShowUnkownWord.Enabled = true;


            lblUnkownWords.Text = unkownEnglishWord.Count.ToString();

            if (_englishWords.Count == 0)
                btnAddUnkown.Enabled = false;

        }



        private void btnShowUnkownWord_Click(object sender, EventArgs e)
        {

            if (!showingUnkownWords)
            {
                foreach (Control item in this.Controls)
                {
                    if (item is Label)
                    {
                        item.Text = "";
                    }
                }
            }


            btnShowTurkishWord.Enabled = true;
            btnShowEnglishWord.Enabled = false;
            btnEnglishExampleSentence.Enabled = true;
            btnTurkishExampleSentence.Enabled = true;
            btnPronunciation.Enabled = true;
            btnAddUnkown.Enabled= false;
            lblRemainingWord.Text = "0";

            selectedWord = random.Next(0, unkownEnglishWord.Count);

            englishWord = unkownEnglishWord[selectedWord];
            lblIDontKnow.Text = englishWord.Word;
            englishSentence = englishWord.Sentence;
            unkownEnglishWord.Remove(englishWord);

            btnShowUnkownWord.Enabled = false;

            if (unkownTurkishWord.Count != 0)
                btnShowTurkishWord.Enabled = true;

            turkishWord = unkownTurkishWord[selectedWord];
            turkishSentence = turkishWord.Sentence;
            pronunciation = turkishWord.Pronunciation;

            lblUnkownWords.Text = unkownEnglishWord.Count.ToString();


           
            if (unkownEnglishWord.Count == 0)
            {
                showingUnkownWords = false;
                btnShowUnkownWord.Enabled = false;
            }
            showingUnkownWords = true;


        }

        private void btnAddNewWords_Click(object sender, EventArgs e)
        {
            NewWords newWords = new NewWords();
            newWords.ShowDialog();
        }



        bool DidItChange = false;
        private void btnChangeLanguage_Click(object sender, EventArgs e)
        {
            if (DidItChange)
            {
                DidItChange = true;
            }
            else
            {
                DidItChange = false;
            }

        }

    }
}


