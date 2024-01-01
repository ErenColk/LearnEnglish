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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        ListBox lstEklenenKelimeler = new ListBox();

        private void Form1_Load(object sender, EventArgs e)
        {

            btnBilgisayarTurkce.Hide();
            btnBilgisayarİng.Hide();
            kalanKelime = ingilizceKelimeler.Length;
            lblkalanKelime.Text = kalanKelime.ToString();
            lstEklenenKelimeler.Width = 0;
            lblBilinmeyenKelime.Text = kelimeSayisi.ToString();

            btnTurkceCumle.Enabled = false;
            btnIngilizceCumle.Enabled = false;
            btnTurkceKelime.Enabled = false;
            btnOkunusu.Enabled = false;
            btnBilinmeyen.Enabled = false;
            btnBilinmeyenEkle.Enabled = false;


        }

        string[] ingilizceBilgisayarTerimleri =
      { "assign","scan","required","ship via","freight","functions",

"ıdentity"        ,
"specification"   ,
"row"             ,
"completion"      ,
"result"          ,
"scale"           ,
"precision"       ,
"northwind"       ,
"Available"       ,
"hiredate"        ,
"costumer"        ,
"intellisense"    ,
"percent"         ,
"order"           ,
"store",
"main",
"expensive",
"today",
"cheap",
"plate",
"instance",
"bool"            ,
"catch"           ,
"else"            ,
"source"          ,
"overflow"        ,
"over"            ,
"ternary"         ,
"return"          ,
"insert"          ,
"replace"         ,
"split"           ,
"substring"       ,
"endsWith"        ,
"contains"        ,
"date"            ,
"args"            ,
"assigned"        ,
"internal"        ,
"default"         ,
"digit"           ,
"temp"            ,
"comment"         ,
"compair"         ,
"count"           ,
"changed"         ,
"regular"         ,
"attribute"       ,
"enum"            ,
"Struct"          ,
"ınterface"       ,
"abstract"        ,
"sealed"          ,
"polymorphism"    ,
"ınheritance"     ,
"encapsulation"   ,
"constant"        ,
"return"          ,
"sur name"        ,
"formatter"       ,
"cross"           ,
"readonly"        ,
"guid"            ,
"datetime"        ,
"access"          ,
"file"            ,
"stream"          ,
"solution"        ,
"surname"         ,
"only"            ,
"dictionary"      ,
"extension"       ,
"fromfile"        ,
"concrete"        ,
"enabled"         ,
"disabled"        ,
"management"      ,
"Authentication"  ,
"third"           ,
"primary"         ,
"unique"          ,
"company"         ,
"contact"         ,
"title"           ,
"owner"           ,
"order"           ,
"suppliers"       ,
"products"        ,
"details"         ,
"restore"         ,
"attach"          ,
"shrink"         ,
"incremental"     ,
"initial size"    ,
 "autogrowth"      ,
"column"          ,
"label"           ,
"try "            ,
"parse"           ,
"catch"           ,
"casting"         ,
"choose"          ,
"Initialize"      ,
"unassigned"      ,
"condition"       ,
"difficult",
            "conversion"




    };
        string[] turkceBilgisayarTerimleri =
        {
            "atamak","tara/tarama yapmak","gerekli","nakliye","taşıma ücreti/navlun","fonksiyon/işlev",
"kimlik"        ,
"belirtme"   ,
"sıra/dizi"             ,
"bitirme"      ,
"sonuç"          ,
"genişlet/ölçek"           ,
"hassasiyet/kesinlik"       ,
"kuzeyden esen rüzgar"       ,
"boşta/eldeki/mevcut/musait"       ,
"işe alma tarihi"        ,
"müşteri"        ,
"iyileştirmek"    ,
"yüzde"         ,
"sipariş/emir"           ,
"mağaza/depo",
"ana/baş",
"pahalı/masraflı",
"bugün",
"ucuz",
"tabak",
"misal/örnek",
"mantıksal"            ,
"tutma/yakalama"           ,
"değilse/başka"            ,
"kaynak/köken"          ,
"taşma/fazlalık"        ,
"üzerinden/üstüne/"            ,
"üç terimli/üçlü"         ,
"dönüş/iade"          ,
"sokmak/arasına sokmak"          ,
"yer değiştirmek / yenisiyle değiştirmek"         ,
"yarmak / bölmek "           ,
"alt dizi"       ,
"son harfi"        ,
"içeriği / içerdiği"        ,
"tarih"            ,
"args"            ,
"atanmış"        ,
"dahili / iç"        ,
"varsayılan"         ,
"hane/rakam/sayı"           ,
"sıcaklık"            ,
"yorum / yorumlamak"         ,
"karşılaştırma"         ,
"saymak / sayı"           ,
"değiştirilmiş"         ,
"düzenli / normal / olağan "         ,
"dayandırmak / nitelik / öznitelik"       ,
"Sıralama"            ,
"yapı"          ,
"arayüz"       ,
"soyut / soyutlamak"        ,
"mühürlü"          ,
"çok biçimlilik"    ,
"miras"     ,
"kapsülleme"   ,
"sabit / değişmez / devamlı"        ,
"dönüş / iade"          ,
"Soyadı"        ,
"Metin formatlayıcı"       ,
"çapraz / kesişen "           ,
"sadece oku"        ,
"küresel benzersiz tanımlayıcı"            ,
"tarih saat"        ,
"erişim / erişme / ulaşma"          ,
"dosya"            ,
"aktarım"          ,
"çözüm / çözelti"        ,
"soyadı"         ,
"sadece"            ,
"sözlük"      ,
"uzatma / genişletme / eklenti"       ,
"dosyadan"        ,
"beton / somut"        ,
"etkinleştirilmiş"         ,
"devredışı"        ,
"yönetim / yönetmek"      ,
"belgeleme / kimlik doğrulama "  ,
"üçüncü / üçte bir"           ,
"öncelik / ana / birincil"         ,
"benzersiz"          ,
"şirket / firma"         ,
"bağlantı / temas etmek"         ,
"unvan / başlık"           ,
"mal sahibi"           ,
"sipariş / emir"           ,
"tedarikçiler / üreticiler"       ,
"ürünler"        ,
"detaylar / ayrıntılar"         ,
"yenileştirmek"         ,
"eklemek / yapıştırmak"          ,
"küçülmek / büzülmek"         ,
"artımlı / artan"     ,
"başlangıç ​​boyutu"    ,
 "otomatik büyüme"      ,
"kolon"          ,
"etiket"           ,
"denemek "            ,
"ayrıştırmak"           ,
"yakalamak"           ,
"rol dağıtımı / dökme / döküm"         ,
"seçmek "          ,
"başlatmak"      ,
"atanmamış"      ,
"koşul"       ,
"zor / zorlu"
        };
        string[] ingilizceKelimeler = {
             "a/an"
            ,"ability"
            ,"able / be able to "
            ,"about"
            ,"absolutely"
            ,"accept"
            ,"accident / by accident"
                ,"achieve"
                ,"across"
                ,"act"
                ,"action"
                ,"activity"
                ,"actually"
                ,"add"
                ,"address"
                ,"adjective"
                ,"advantage"
                ,"aerial"
                ,"aeroplane"
                ,"affect"
                ,"afraid"
                ,"after"
                ,"afternoon"
                ,"again"
                ,"against"
                ,"age"
                ,"ago"
                ,"agree"
                ,"agreement"
                ,"air"
                ,"air-conditioner"
                ,"airhostess"
                ,"airline"
                ,"airplane"
                ,"alike"
                ,"alive"
                ,"all"
                ,"all right"
                ,"allow"
                ,"almost"
                ,"alone"
                ,"along"
                ,"aloud"
                ,"alphabet"
                ,"already"
                ,"also"
                ,"although"
                ,"always"
                ,"a.m."
                ,"am"
                ,"amateur"
                ,"among"
                ,"amount"
                ,"an"
                ,"and"
                ,"angry"
                ,"animal"
                ,"another"
                ,"answer"
                ,"ant"
    //            , "the", "be", "to", "of", "and", "a", "in", "that", "have", "I", "it", "for", "not", "on", "with", "he", "as", "you", "do", "at",
    //"this", "but", "his", "by", "from", "they", "we", "say", "her", "she", "or", "an", "will", "my", "one", "all", "would", "there",
    //"their", "what", "so", "up", "out", "if", "about", "who", "get", "which", "go", "me", "when", "make", "can", "like", "time",
    //"no", "just", "him", "know", "take", "people", "into", "year", "your", "good", "some", "could", "them", "see", "other", "than",
    //"then", "now", "look", "only", "come", "its", "over", "think", "also", "back", "after", "use", "two", "how", "our", "work",
    //"first", "well", "way", "even", "new", "want", "because", "any", "these", "give", "day", "most", "us"
    };
        string[] turkceKelimeler = {
             "(sıfat)/bir"
            ,"Yetenek"
            ,"güçlü,yetenekli/ (fiil) -ebilmek, - abilmek"
            ,"Hakkında / Aşağ Yukarı-Yaklaşık"
            ,"Tümüyle;Kesinlikle"
            ,"Kabul etmek"
            ,"Kaza / tesadüfen-kazara"
                ,"Başarmak,yapmak"
                ,"Bir yanından öteki yanına / karşısında"
                ,"Hareket etmek,davranmak / (rol) oynamak"
                ,"Hareket,iş(eylem)"
                ,"Etkinlik"
                ,"Gerçekten,aslında"
                ,"İlave etmek,eklemek / toplamak"
                ,"Adres"
                ,"Sıfat"
                ,"Avantaj, yarar"
                ,"Anten"
                ,"Uçak"
                ,"Etkilemek"
                ,"Korkmak"
                ,"-den sonra"
                ,"Öğleden sonra"
                ,"Tekrar,yine"
                ,"Karşı"
                ,"Yaş / çağ"
                ,"Önce"
                ,"Aynı fikirde olmak, katılmak"
                ,"Sözleşme, anlaşma"
                ,"Hava"
                ,"Klima"
                ,"Hostes"
                ,"Havayolu"
                ,"Uçak"
                ,"Aynı , benzer"
                ,"Canlı, hareketli"
                ,"Bütün, tüm, hepsi"
                ,"Bir şey olmamış, iyi"
                ,"İzin vermek"
                ,"Hemen hemen, neredeyse"
                ,"Tek başına, yalnız"
                ,"Boyunca"
                ,"Yüksek sesle"
                ,"Alfabe"
                ,"Şimdiden, çoktan, zaten"
                ,"de, da, bir de, ayrıca"
                ,"-dığı halde, -e karşın"
                ,"Daima, hep"
                ,"Geceyarısından öğlene kadar olan zaman"
                ,"-ım,-im"
                ,"Amatör"
                ,"Aralarında, arasında"
                ,"Miktar"
                ,"Bir(herhangi)"
                ,"Ve"
                ,"Kızgın"
               ,"Hayvan"
                ,"Başka bir, başka / Bir... daha"
                ,"Cevap vermek, yanıtlamak / Cevap, yanıt"
                ,"Karınca"
    //            , "o", "olmak", "e, -e, -a", "nin, -ın, -in", "ve", "bir", "içinde", "şu, o", "sahip olmak", "ben", "o", "için", "değil",
    //"üzerinde", "ile", "o (erkek)", "olarak", "sen", "yapmak", "at", "bu", "fakat", "onun", "tarafından", "dan, den",
    //"onlar", "biz", "söylemek", "onun", "o (kadın)", "veya", "bir", "olacak", "benim", "bir", "tüm", "olurdu", "orada",
    //"onların", "ne", "bu yüzden", "yukarı", "dışarı", "eğer", "hakkında", "kim", "elde etmek", "hangi", "gitmek", "beni",
    //"ne zaman", "yapmak", "yapabilir", "gibi", "zaman", "hayır", "sadece", "onu", "bilmek", "almak", "insanlar", "içine",
    //"yıl", "sizin", "iyi", "bazı", "olabilir", "onları", "görmek", "diğer", "ondan, ondan daha", "o zaman", "şimdi", "bakmak",
    //"sadece", "gelmek", "onun", "üzerinde", "düşünmek", "ayrıca", "geri", "sonra", "kullanmak", "iki", "nasıl", "bizim",
    //"çalışmak", "ilk", "iyi", "yol", "bile", "yeni", "istemek", "çünkü", "herhangi", "bunlar", "vermek", "gün", "en çok",
    //"bize, bizi"

        };
        string[] ingilizceCumle = {
            "This is a table / This is an apple."
            ,"He has the ability to do this job."
            ,"Are you able to lift this heavy suitcase?"
            ,"This book is about Turkey / The holiday cost about 500 dolars."
            , "You are absolutely wrong."
            ,"I accepted the wedding invitation."
            ,"The car accident was very bad./ He broke the window by accident."
                ,"What do you want to achieve in your work?"
                ,"She walked across the park. / The post office is across the road."
                ,"He is acting very strangely. / He acted as the King in the play."
                ,"You are responsible for your actions."
                ,"He enjoys all the activities in school."
                ,"Actually, he is more stupid than others ."
                ,"She added salt to the soup / If you add 3 to 4 and you get 7."
                ,"What is your address?."
                ,"'Beautiful' is an adjective."
                ,"Speaking English is an advantage."
                ,"There are 10 TV aerials on the roof."
                ,"This aeroplane flies to Australia."
                ,"Smoking affects health."
                ,"He is afraid of snakes."
                ,"After dinner they went to the cinema."
                ,"He went out in the morning and came home in the afternoon."
                ,"Can you play that song again."
                ,"He threw the ball against the wall."
                ,"Do you know my age?"
                ,"Two years ago I met him on the street."
                ,"He doesn't agree with me."
                ,"There is no agreement between the two sides."
                ,"He threw the ball into the air."
                ,"This car has an automatic air-conditioner."
                ,"My cousin is an airhostess."
                ,"Cem always travels by Turkish Airlines"
                ,"Turkey has bought a lot of airplanes from France"
                ,"Those two bicycles look alike."
                ,"Hey! This fish is still alive"
                ,"She put all her money in the bank."
                ,"He was all right after the accident."
                ,"Smoking is not allowed here."
                ,"He almost died in the car crash"
                ,"He lives alone"
                ,"He walked along the road for three kilometres."
                ,"She read the book aloud."
                ,"There are 26 letters in the English alphabet."
                ,"I have already had breakfast"
                ,"She sings beautifully and also plays the piano."
                ,"They are happy although they are poor."
                ,"He is always late for school."
                ,"9 a.m. is 9 o'clock in the morning."
                ,"I am a student."
               ,"He is only an amateur footballer"
                ,"There was an apple among the oranges"
                ,"There is small amount of water in the cup"
                ,"Can you give me an orange please?"
                ,"We sang and danced"
                ,"The teacher was angry with the noisy students"
                ,"Cats,dogs,horses,cows and sheep are animals"
                ,"Have you got another book ? / Do you want another drink ?"
                ,"He answered the question / He didn't know the answer"
                ,"Ants live in large groups"

        };
        string[] turkceCumle = {
            "Bu bir masadır / Bu bir elmadır."
            ,"O bu işi yapacak yeteneğe sahiptir."
            ,"Bu ağır bavulu kaldırabilir misin?"
            ,"Bu kitap Türkiye hakkında / Tatil aşağı yukarı 500 dolara mal oldu."
            ,"Kesinlikle yanılıyorsun."
            ,"Düğün davetini kabul ettim."
            ,"Araba kazası çok kötüydü / Camı kazara kırdı."
                ,"İşinde neyi başarmak istiyorsun?"
                ,"Parkın bir yanından öteki yanına yürüdü / Postane yolun karşısındadır."
                ,"Çok tuhaf davranıyor / Oyunda Kral rolünü oynadı."
                ,"Hareketlerinden sorumlusun."
                ,"Okuldaki bütün etkinliklerden hoşlanır."
                ,"Aslında o diğerlerinden daha aptaldır."
                ,"Çorbaya baya tuz ilave etti. / 4 ile 3'ü toplarsan 7 eder."
                ,"Adresiniz nedir?"
                ,"'Güzel' bir sıfattır."
                , "İngilizce konuşmak bir avantajdır."
                ,"Çatıda 10 tane televizyon anteni var."
                ,"Bu uçak Avustralya'ya uçar."
                ,"Sigara içmek sağlığı etkiler"
                ,"O yılanlardan korkar."
                ,"Akşam yemeğinden sonra sinemaya gittiler."
                ,"Sabahleyin dışarı çıktı ve öğleden sonra eve geldi."
                ,"O şarkıyı tekrar oynatabilir(çalabilir) misin?"
                ,"Topu duvara karşı fırlattı."
                ,"Benim yaşımı biliyor musun?"
                ,"İki yıl önce onunla sokakta karşılaştım."
                ,"Benimle aynı fikirde değil."
                ,"İki taraf arasında anlaşma yok."
                ,"Topu havaya fırlattı."
                ,"Bu arabanın otomatik bir kliması var."
                ,"Kuzenim hostestir."
                ,"Cem hep Türk Havayolları ile seyahat eder."
                ,"Türkiye Fransa'dan çok uçak satın aldı."
                ,"Şu iki bisiklet benze görünüyorlar."
                ,"Hey! Bu balık hala canlı!"
                ,"Bütün parasını bankaya koydu."
                ,"Kazadan sonra iyiydi."
                ,"Burada sigara içmeye izin verilmiyor."
                ,"Araba kazasında az kalsın ölüyordu."
                ,"O tek başına yaşar."
                ,"Yol boyunca üç kilometre yürüdü."
                ,"Kitabı yüksek sesle okudu."
                ,"İngiliz alfabesinde 26 harf vardır."
                ,"Çoktan kahvaltı yaptım."
                ,"Güzel şarkı söyler ve piyano da çalar."
                ,"Yoksul oldukları halde mutlular."
                ,"O okula hep geç kalır."
                ,"9 a.m., sabah saat dokuz demektir."
                ,"Ben bir öğrenciyim."
               ,"O sadece amatör bir futbolcu"
                ,"Portakalların arasında bir elma vardı"
                ,"Fincada az biktarda su var"
                ,"Lütfen bana bir portakal verebilir misin ?"
                ,"Şarkı söyledik ve dans ettik."
                ,"Öğretmen gürültücü öğrencilere kızgındı"
                ,"Kediler, köpekler, atlar, inekler ve koyunlar hayvanlardır"
                ,"Başka kitabın var mı ? / Bir içki daha ister misin ?"
                ,"Soruyu yanıtladı / Yanıtı bilmiyordu."
                ,"Karıncalar büyük gruplar halinde yaşarlar."

        };
        string[] okunusu = {
            "ei/en"
            ,"ı'bilıti"
            ,"eybıl"
            ,"ı'baut"
            ,"ebsılu:tli"
            ,"ık'sept"
                ,"eksidınt"
                ,"ı'çi:v"
                ,"ı'kros"
                ,"ekt"
                ,"ekşın"
                ,"ek'tiviti"
                ,"ekçuıli"
                ,"ed"
                ,"ı'dres"
                ,"eciktiv"
                ,"ıd'va:ntic"
                ,"eırıl"
                ,"eırıpleyn"
                ,"ı'fekt"
                ,"ı'freyd"
                ,"a:ftı"
                ,"a:ftı'nu:n"
                ,"ı'gen "
                ,"ı'genst"
                ,"eyc"
                ,"ı'gou"
                ,"ı'gri"
                ,"ı'gri:mınt"
                ,"eı"
                ,"eıkındişını"
                ,"eıhoustis"
                ,"eılayn"
                ,"eıpleyn"
                ,"ı'Layk"
                ,"ı'Layv"
                ,"o:L"
                ,"o:L'rayt"
                ,"ı'Lau"
                ,"o:Lmoust"
                ,"ı'Loun"
                ,"ı'Long"
                ,"ı'Laud"
                ,"elfıbet"
                ,"o:L'redi"
                ,"o:Lsou"
                ,"o:L'dou"
                ,"o:Lweyz"
                ,"ey'em"
                ,"em"
                ,"'emıtı"
                ,"ı'mang"
               ,"ı'maunt"
                ,"ın,en"
                ,"ınd,end"
               ,"engri"
                ,"enimıl"
                ,"ı'nadı"
                ,"a:nsı"
                ,"ent"





        };


        Random rnd = new Random();

        int i;
        int j;
        int sayac;
        int kalanKelime;

        // İNGİLİZCE KELİME GÖSTER

        private void btnİngilizceKelime_Click(object sender, EventArgs e)
        {

            btnBilinmeyenEkle.Enabled = true;
            bilinmeyenBilinen = false;
            btnTurkceCumle.Enabled = true;
            btnIngilizceCumle.Enabled = true;
            btnTurkceKelime.Enabled = true;
            btnOkunusu.Enabled = true;

            if (sayac != ingilizceKelimeler.Length)
            {
                for (j = 0; j < 1;)
                {

                    i = rnd.Next(0, ingilizceKelimeler.Length);

                    if (!lstEklenenKelimeler.Items.Contains(ingilizceKelimeler[i]))
                    {


                        lstEklenenKelimeler.Items.Add(ingilizceKelimeler[i]);
                        lblİngilizce.Text = ingilizceKelimeler[i];
                        sayac++;
                        j++;
                        int kalanKelime = ingilizceKelimeler.Length - sayac;
                        lblkalanKelime.Text = kalanKelime.ToString();

                    }

                }

            }

            else
            {


                btnİngilizceKelime.Enabled = false;
                DialogResult dr = MessageBox.Show("İngilizce Kelime Tükendi! Tekrar Başlamak İçin Evet yada Hayır Seçeneğini Kullanın.", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    sayac = 0;
                    btnİngilizceKelime.Enabled = true;
                    lblkalanKelime.Text = kalanKelime.ToString();
                    lstEklenenKelimeler.Items.Clear();

                }
                else
                {

                    MessageBox.Show("Bilmediğiniz Kelimeler var ise devam ediniz!");


                }

            }
        }


        // TURKCE KELİEMELERİ GÖSTER

        private void btnTurkceKelime_Click(object sender, EventArgs e)
        {

            if (bilinmeyenBilinen == true)
            {
                lblTurkce.Text = turkceEkle[ekleRastgele];
            }
            else
            {
                lblTurkce.Text = turkceKelimeler[i];
            }
        }

        private void btnTurkceCumle_Click(object sender, EventArgs e)
        {
            lblTurkceCumle.Text = turkceCumle[i];
        }

        private void btnIngilizceCumle_Click(object sender, EventArgs e)
        {
            lblİngilizceCumle.Text = ingilizceCumle[i];

        }

        private void btnOkunusu_Click(object sender, EventArgs e)
        {
            lblOkunusu.Text = okunusu[i];
        }




        // BAŞTAN BAŞLAA


        private void btnbastanBasla_Click(object sender, EventArgs e)
        {

            sayac = 0;
            btnBilinmeyen.Enabled = true;
            btnBilinmeyenEkle.Enabled = true;
            kelimeSayisi = 0;
            sayac1 = 0;
            lblBilinmeyenKelime.Text = kelimeSayisi.ToString();
            btnTurkceCumle.Enabled = false;
            btnIngilizceCumle.Enabled = false;
            btnTurkceKelime.Enabled = false;
            btnOkunusu.Enabled = false;
            btnBilinmeyen.Enabled = false;

            foreach (Control item in this.Controls)
            {
                if (item is Label)
                {
                    Label lbl = (Label)item;
                    lbl.Text = "";
                    lblkalanKelime.Text = kalanKelime.ToString();

                }


            }


        }

        // İNGİLİZCE BİLİNMEYENLERİ EKLE

        ListBox BilinmeyenKelilemer = new ListBox();
        string[] ingilizceEkle = new string[1000];
        int kelimeSayisi = 0;
        string[] turkceEkle = new string[1000];


        private void btnBilinmeyenEkle_Click(object sender, EventArgs e)
        {
            turkceEkle[kelimeSayisi] = turkceKelimeler[i];
            ingilizceEkle[kelimeSayisi] = ingilizceKelimeler[i];
            btnBilinmeyen.Enabled = true;

            kelimeSayisi++;
            lblBilinmeyenKelime.Text = kelimeSayisi.ToString();
            btnBilinmeyenEkle.Enabled = false;


        }






        // İNGİLİZCE BİLİNMEYEN KELİMELERİ GÖSTER

        int ekleRastgele;
        int sayac1 = 0;
        int kalanKelimeSayisi;
        bool bilinmeyenBilinen;

        private void btnBilinmeyen_Click(object sender, EventArgs e)
        {
         
            kalanKelimeSayisi = kelimeSayisi - sayac1;
            lblBilinmeyenKelime.Text = kalanKelimeSayisi.ToString();
            bilinmeyenBilinen = true;

            if (sayac1 != kelimeSayisi)
            {


                for (int i = 0; i < 1;)
                {
                    ekleRastgele = rnd.Next(0, kelimeSayisi);

                    if (!BilinmeyenKelilemer.Items.Contains(ingilizceEkle[ekleRastgele]))

                    {

                        lblBilmediklerim.Text = ingilizceEkle[ekleRastgele];

                        BilinmeyenKelilemer.Items.Add(ingilizceEkle[ekleRastgele]);
                        i++;
                        sayac1++;

                    }

                }



            }
            else
            {

                MessageBox.Show("Bilinmeyen kelimeleri bitirdiniz. TEBRİKLER!");
                btnBilinmeyen.Enabled = false;
                sayac1 = 0;
                kelimeSayisi = 0;


            }


        }













        private void lblBilinmeyenKelime_Click(object sender, EventArgs e)
        {

        }

        private void lblkalanKelime_Click(object sender, EventArgs e)
        {

        }

        private void btnBilgisayarİng_Click(object sender, EventArgs e)
        {
            btnBilinmeyenEkle.Enabled = true;
            bilinmeyenBilinen = false;
            btnTurkceCumle.Enabled = true;
            btnIngilizceCumle.Enabled = true;
            btnTurkceKelime.Enabled = true;
            btnOkunusu.Enabled = true;




            if (sayac != ingilizceBilgisayarTerimleri.Length)
            {
                for (j = 0; j < 1;)
                {

                    i = rnd.Next(0, ingilizceBilgisayarTerimleri.Length);

                    if (!lstEklenenKelimeler.Items.Contains(ingilizceBilgisayarTerimleri[i]))
                    {


                        lstEklenenKelimeler.Items.Add(ingilizceBilgisayarTerimleri[i]);
                        lblİngilizce.Text = ingilizceBilgisayarTerimleri[i];
                        sayac++;
                        j++;
                        int kalanKelime = ingilizceBilgisayarTerimleri.Length - sayac;
                        lblkalanKelime.Text = kalanKelime.ToString();

                    }

                }

            }

            else
            {


                btnİngilizceKelime.Enabled = false;
                DialogResult dr = MessageBox.Show("İngilizce Kelime Tükendi! Tekrar Başlamak İçin Evet yada Hayır Seçeneğini Kullanın.", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    sayac = 0;
                    btnİngilizceKelime.Enabled = true;
                    lblkalanKelime.Text = kalanKelime.ToString();
                    lstEklenenKelimeler.Items.Clear();

                }
                else
                {

                    MessageBox.Show("Bilmediğiniz Kelimeler var ise devam ediniz!");


                }

            }
        }

        private void btnBilgisayarTurkce_Click(object sender, EventArgs e)
        {

            if (bilinmeyenBilinen == true)
            {
                lblTurkce.Text = turkceEkle[ekleRastgele];
            }
            else
            {
                lblTurkce.Text = turkceBilgisayarTerimleri[i];
            }
        }
    }
}


