namespace LearnEnglish
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowEnglishWord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblTurkish = new System.Windows.Forms.Label();
            this.btnShowTurkishWord = new System.Windows.Forms.Button();
            this.lblEnglishSentence = new System.Windows.Forms.Label();
            this.lblTurkishSentence = new System.Windows.Forms.Label();
            this.btnEnglishExampleSentence = new System.Windows.Forms.Button();
            this.btnTurkishExampleSentence = new System.Windows.Forms.Button();
            this.lblPronunciation = new System.Windows.Forms.Label();
            this.btnPronunciation = new System.Windows.Forms.Button();
            this.btnStartOver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRemainingWord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIDontKnow = new System.Windows.Forms.Label();
            this.btnShowUnkownWord = new System.Windows.Forms.Button();
            this.btnAddUnkown = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUnkownWords = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddNewWords = new System.Windows.Forms.Button();
            this.btnChangeLanguage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowEnglishWord
            // 
            this.btnShowEnglishWord.Location = new System.Drawing.Point(29, 98);
            this.btnShowEnglishWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowEnglishWord.Name = "btnShowEnglishWord";
            this.btnShowEnglishWord.Size = new System.Drawing.Size(211, 35);
            this.btnShowEnglishWord.TabIndex = 0;
            this.btnShowEnglishWord.Text = "Show Word";
            this.btnShowEnglishWord.UseVisualStyleBackColor = true;
            this.btnShowEnglishWord.Click += new System.EventHandler(this.btnShowEnglishWord_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "English Words";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turkish Words";
            // 
            // lblEnglish
            // 
            this.lblEnglish.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEnglish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnglish.Location = new System.Drawing.Point(29, 38);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(211, 55);
            this.lblEnglish.TabIndex = 1;
            this.lblEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTurkish
            // 
            this.lblTurkish.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTurkish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTurkish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTurkish.Location = new System.Drawing.Point(288, 38);
            this.lblTurkish.Name = "lblTurkish";
            this.lblTurkish.Size = new System.Drawing.Size(301, 55);
            this.lblTurkish.TabIndex = 1;
            this.lblTurkish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowTurkishWord
            // 
            this.btnShowTurkishWord.Location = new System.Drawing.Point(288, 98);
            this.btnShowTurkishWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowTurkishWord.Name = "btnShowTurkishWord";
            this.btnShowTurkishWord.Size = new System.Drawing.Size(301, 35);
            this.btnShowTurkishWord.TabIndex = 0;
            this.btnShowTurkishWord.Text = "Show Word";
            this.btnShowTurkishWord.UseVisualStyleBackColor = true;
            this.btnShowTurkishWord.Click += new System.EventHandler(this.btnShowTurkishWord_Click);
            // 
            // lblEnglishSentence
            // 
            this.lblEnglishSentence.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEnglishSentence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnglishSentence.Location = new System.Drawing.Point(29, 174);
            this.lblEnglishSentence.Name = "lblEnglishSentence";
            this.lblEnglishSentence.Size = new System.Drawing.Size(805, 68);
            this.lblEnglishSentence.TabIndex = 9;
            this.lblEnglishSentence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTurkishSentence
            // 
            this.lblTurkishSentence.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTurkishSentence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTurkishSentence.Location = new System.Drawing.Point(29, 323);
            this.lblTurkishSentence.Name = "lblTurkishSentence";
            this.lblTurkishSentence.Size = new System.Drawing.Size(805, 68);
            this.lblTurkishSentence.TabIndex = 9;
            this.lblTurkishSentence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnglishExampleSentence
            // 
            this.btnEnglishExampleSentence.Location = new System.Drawing.Point(29, 245);
            this.btnEnglishExampleSentence.Name = "btnEnglishExampleSentence";
            this.btnEnglishExampleSentence.Size = new System.Drawing.Size(275, 35);
            this.btnEnglishExampleSentence.TabIndex = 10;
            this.btnEnglishExampleSentence.Text = "English Example Sentence";
            this.btnEnglishExampleSentence.UseVisualStyleBackColor = true;
            this.btnEnglishExampleSentence.Click += new System.EventHandler(this.btnEnglishExampleSentence_Click);
            // 
            // btnTurkishExampleSentence
            // 
            this.btnTurkishExampleSentence.Location = new System.Drawing.Point(29, 394);
            this.btnTurkishExampleSentence.Name = "btnTurkishExampleSentence";
            this.btnTurkishExampleSentence.Size = new System.Drawing.Size(275, 35);
            this.btnTurkishExampleSentence.TabIndex = 10;
            this.btnTurkishExampleSentence.Text = "Turkish Example Sentence";
            this.btnTurkishExampleSentence.UseVisualStyleBackColor = true;
            this.btnTurkishExampleSentence.Click += new System.EventHandler(this.btnTurkishExampleSentence_Click);
            // 
            // lblPronunciation
            // 
            this.lblPronunciation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPronunciation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPronunciation.Location = new System.Drawing.Point(29, 460);
            this.lblPronunciation.Name = "lblPronunciation";
            this.lblPronunciation.Size = new System.Drawing.Size(211, 48);
            this.lblPronunciation.TabIndex = 11;
            this.lblPronunciation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPronunciation
            // 
            this.btnPronunciation.Location = new System.Drawing.Point(29, 513);
            this.btnPronunciation.Name = "btnPronunciation";
            this.btnPronunciation.Size = new System.Drawing.Size(211, 42);
            this.btnPronunciation.TabIndex = 12;
            this.btnPronunciation.Text = "Pronunciation";
            this.btnPronunciation.UseVisualStyleBackColor = true;
            this.btnPronunciation.Click += new System.EventHandler(this.btnPronunciation_Click);
            // 
            // btnStartOver
            // 
            this.btnStartOver.Location = new System.Drawing.Point(605, 522);
            this.btnStartOver.Name = "btnStartOver";
            this.btnStartOver.Size = new System.Drawing.Size(229, 34);
            this.btnStartOver.TabIndex = 13;
            this.btnStartOver.Text = "Start Over";
            this.btnStartOver.UseVisualStyleBackColor = true;
            this.btnStartOver.Click += new System.EventHandler(this.btnStartOver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 35);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Words I don\'t know";
            // 
            // lblRemainingWord
            // 
            this.lblRemainingWord.BackColor = System.Drawing.Color.White;
            this.lblRemainingWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRemainingWord.Location = new System.Drawing.Point(250, 52);
            this.lblRemainingWord.Name = "lblRemainingWord";
            this.lblRemainingWord.Size = new System.Drawing.Size(54, 22);
            this.lblRemainingWord.TabIndex = 15;
            this.lblRemainingWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(21, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Remaining Word Count  =";
            // 
            // lblIDontKnow
            // 
            this.lblIDontKnow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIDontKnow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIDontKnow.Location = new System.Drawing.Point(623, 32);
            this.lblIDontKnow.Name = "lblIDontKnow";
            this.lblIDontKnow.Size = new System.Drawing.Size(211, 55);
            this.lblIDontKnow.TabIndex = 15;
            this.lblIDontKnow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowUnkownWord
            // 
            this.btnShowUnkownWord.Location = new System.Drawing.Point(623, 98);
            this.btnShowUnkownWord.Name = "btnShowUnkownWord";
            this.btnShowUnkownWord.Size = new System.Drawing.Size(211, 35);
            this.btnShowUnkownWord.TabIndex = 16;
            this.btnShowUnkownWord.Text = "Show Word";
            this.btnShowUnkownWord.UseVisualStyleBackColor = true;
            this.btnShowUnkownWord.Click += new System.EventHandler(this.btnShowUnkownWord_Click);
            // 
            // btnAddUnkown
            // 
            this.btnAddUnkown.Location = new System.Drawing.Point(605, 481);
            this.btnAddUnkown.Name = "btnAddUnkown";
            this.btnAddUnkown.Size = new System.Drawing.Size(229, 34);
            this.btnAddUnkown.TabIndex = 17;
            this.btnAddUnkown.Text = "Add to unknown words";
            this.btnAddUnkown.UseVisualStyleBackColor = true;
            this.btnAddUnkown.Click += new System.EventHandler(this.btnAddUnkown_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(21, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Unkown Word Count      =";
            // 
            // lblUnkownWords
            // 
            this.lblUnkownWords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnkownWords.BackColor = System.Drawing.Color.White;
            this.lblUnkownWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnkownWords.Location = new System.Drawing.Point(250, 27);
            this.lblUnkownWords.Name = "lblUnkownWords";
            this.lblUnkownWords.Size = new System.Drawing.Size(54, 22);
            this.lblUnkownWords.TabIndex = 15;
            this.lblUnkownWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblRemainingWord);
            this.groupBox2.Controls.Add(this.lblUnkownWords);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(263, 460);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 95);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // btnAddNewWords
            // 
            this.btnAddNewWords.Location = new System.Drawing.Point(29, 582);
            this.btnAddNewWords.Name = "btnAddNewWords";
            this.btnAddNewWords.Size = new System.Drawing.Size(805, 35);
            this.btnAddNewWords.TabIndex = 18;
            this.btnAddNewWords.Text = "ADD NEW WORDS";
            this.btnAddNewWords.UseVisualStyleBackColor = true;
            this.btnAddNewWords.Click += new System.EventHandler(this.btnAddNewWords_Click);
            // 
            // btnChangeLanguage
            // 
            this.btnChangeLanguage.Location = new System.Drawing.Point(605, 440);
            this.btnChangeLanguage.Name = "btnChangeLanguage";
            this.btnChangeLanguage.Size = new System.Drawing.Size(229, 34);
            this.btnChangeLanguage.TabIndex = 19;
            this.btnChangeLanguage.Text = "Change ";
            this.btnChangeLanguage.UseVisualStyleBackColor = true;
            this.btnChangeLanguage.Click += new System.EventHandler(this.btnChangeLanguage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 643);
            this.Controls.Add(this.btnChangeLanguage);
            this.Controls.Add(this.btnAddNewWords);
            this.Controls.Add(this.btnAddUnkown);
            this.Controls.Add(this.btnShowUnkownWord);
            this.Controls.Add(this.lblIDontKnow);
            this.Controls.Add(this.btnStartOver);
            this.Controls.Add(this.btnPronunciation);
            this.Controls.Add(this.lblPronunciation);
            this.Controls.Add(this.btnTurkishExampleSentence);
            this.Controls.Add(this.btnEnglishExampleSentence);
            this.Controls.Add(this.lblTurkishSentence);
            this.Controls.Add(this.lblEnglishSentence);
            this.Controls.Add(this.lblTurkish);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.btnShowTurkishWord);
            this.Controls.Add(this.btnShowEnglishWord);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "LEARN ENGLISH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowEnglishWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblTurkish;
        private System.Windows.Forms.Button btnShowTurkishWord;
        private System.Windows.Forms.Label lblEnglishSentence;
        private System.Windows.Forms.Label lblTurkishSentence;
        private System.Windows.Forms.Button btnEnglishExampleSentence;
        private System.Windows.Forms.Button btnTurkishExampleSentence;
        private System.Windows.Forms.Label lblPronunciation;
        private System.Windows.Forms.Button btnPronunciation;
        private System.Windows.Forms.Button btnStartOver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRemainingWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIDontKnow;
        private System.Windows.Forms.Button btnShowUnkownWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddUnkown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUnkownWords;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddNewWords;
        private System.Windows.Forms.Button btnChangeLanguage;
    }
}

