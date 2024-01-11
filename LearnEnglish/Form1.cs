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

                ,"any"
                ,"anybody"
                ,"anyone"
                ,"anything"
                ,"anyway"
                ,"anywhere"
                ,"appear"
                ,"appetite"
                ,"apple"
                ,"application"
                ,"apply"
                ,"appointment"
                ,"appropriate"
                ,"apricot"
                ,"april"
                ,"are"
                ,"argue"
                ,"argument"
                ,"arm"
                ,"armchair"
                ,"army"
                ,"around"
                ,"as / as... as"
                ,"ashtray"
                ,"ask"
                ,"aspirin"
                ,"assume"
                ,"astronaut"
                ,"at"
                ,"ate"
                ,"athlete"
                ,"atlas"
                ,"attention"
                ,"attitude"
                ,"August"
                ,"aunt"
                ,"authority"
                ,"automobile"
                ,"autumn"
                ,"available"
                ,"average"
                ,"awake"
                ,"away"
                ,"axe"
                

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
                ,"Hiç"
                ,"Kimse , Biri , Hiç kimse"
                ,"Kimse , Biri , Hiç kimse"
                ,"(Hiç)Bir şey"
                ,"Neyse ,Yine de"
                ,"(Hiç)Bir yere, (Hiç)Bir yerde"
                ,"Gibi görünmek / ortaya çıkmak, görünmek"
                ,"İştah"
                ,"Elma"
                ,"Başvuru"
                ,"Başvurmak"
                ,"Randevu"
                ,"Uygun"
                ,"Kayısı"
                ,"Nisan"
                ,"-sin , -iz , -siniz, -dirler"
                ,"Tartışmak"
                ,"Tartışma"
                ,"Kol"
                ,"Koltuk"
                ,"Ordu"
                ,"Etrafında, Çevresinde , Çevresine"
                ,"-iken, -ken, -ince / olarak / -dığı için, çünkü / Kadar "
                ,"Kül tablası"
                ,"Sormak / Rica etmek , istemek"
                ,"Aspirin"
                ,"Sanmak"
                ,"Astronot"
                ,"-de , -da"
                ,"eat(geçmiş zaman) / yedi"
                ,"Atlet"
                ,"Atlas"
                ,"Dikkat, İlgi"
                ,"Tutum"
                ,"Ağustos"
                ,"Hala, Teyze, Yenge"
                ,"Otorite"
                ,"Otomobil, Araba"
                ,"Sonbahar, Güz"
                ,"Mevcut, Hazır, Elde edilebilir, Musait"
                ,"Ortalama"
                ,"Uyanık"
                ,"Uzağa, uzakta / Başka yerde, yok"
                ,"Balta"
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


                ,"Have you any apples?"
                ,"Is there anybody at home?"
                ,"Has anyyone seen my book?"
                ,"I don't want anything"
                ,"He doesn't like that place, but he will go there anyway"
                ,"I can't see my jacket anywhere"
                ,"She appeared to be happy / The monkey appeared on the stage suddenly"
                ,"I haven't any appetite"
                ,"I ate two apples"
                ,"His application for the job was not accepted"
                ,"He wanted to apply for the job"
                ,"I have an appointment at the hospital"
                ,"His words were not appropriate for the meeting"
                ,"He bought a kilo of apricots"
                ,"They are thirty days in April"
                ,"You are very kind"
                ,"You shouldn't argue with your friends"
                ,"They had an argument"
                ,"She broke her arm."
                ,"This armchair is very comfortable."
                ,"This lorry belongs to the army"
                ,"There were 6 chairs around the table"
                ,"The play started as I got there / She is perfect as a teacher / As it was geting late, I took a taxi / I run as fast as he does"
                ,"He put the chewing gum in the ashtray."
                ,"She asked me my age / I'll ask him to help me."
                ,"Have you any aspirin"
                ,"I assumed that she was wrong"
                ,"The astronaut is walking to the spaceship"
                ,"He is at school"
                ,"The man ate all the melon."
                ,"The Turkish athlete won a gold medal"
                ,"There are maps of all the countries in the atlas"
                ,"He listened to the teacher with attention."
                ,"Her attitude toward work is not so good."
                ,"August is the eight month of the year"
                ,"My mother's sister is my aunt"
                ,"Who is the authority here?"
                ,"There are too many automobiles in this city."
                ,"Autumn is the season after summer."
                ,"No one is available at the moment."
                ,"His marks are below the average"
                ,"Are all the children awake?"
                ,"My house is 6 kilometres away. / She was away yesterday"
                ,"He cut the tree with an axe"

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
                ,"Hiç elman var mı?"
                ,"Evde kimse var mı?"
                ,"Kimse kitabımı gördü mü?"
                ,"Hiçbir şey istemiyorum"
                ,"Orayı sevmiyor, ama yine de oraya gidecek."
                ,"Ceketimi hiçbir yerde göremiyorum."
                ,"Mutlu görünüyordu. / Birdenbire sahneye maymun çıktı."
                ,"Hiç iştahım yok."
                ,"İki elma yedim."
                ,"İş başvurusu kabul edilmedi."
                ,"İşe başvurmak istiyordu."
                ,"Hastanede randevum var."
                ,"Sözleri toplantı için uygun değildi."
                ,"Bir kilo kayısı aldı."
                ,"Nisanda otuz gün vardır."
                ,"Çok naziksiniz."

                ,"Arkadaşlarınla tartışmamalısın."
                ,"Tartışma yaptılar."
                ,"Kolunu kırdı."
                ,"Bu koltuk çok rahat"
                ,"Bu kamyon orduya aittir."
                ,"Masanın etrafında 6 sandalye vardı."
                ,"Oyun, ben oraya varınca başladı. / Öğretmen olarak mükemmeldir. / Geç olduğu için taksi tuttum / Ben onun kadar hızlı koşarım."
                ,"Sakızı kül tablasına koydu"
                ,"Bana yaşımı sordu / Bana yardım etmesini rica edeceğim."
                ,"Hiç aspirinin var mı ?"
                ,"Onun yanıldığını sanıyordum"
                ,"Astronot uzaygemisine doğru yürüyor."
                ,"O okulda"
                ,"Adam bütün kavunu yedi"
                ,"Türk atleti altın madalya kazandı"
                ,"Atlasta bütün ülkelerin haritaları vardır."
                ,"Öğretmeni dikkatle dinledi."
                ,"İşe karşı tutumu çok iyi değil"
                ,"Ağustos yılın sekinci ayıdır."
                ,"Annemin kız kardeşi benim teyzemdir."
                ,"Burada yetkili kim?"
                ,"Bu şehirde çok fazla araba var"
                ,"Sonbahar yazdan sonraki mevsimdir."
                ,"Şu anda musait kimse yok"
               ,"Onun notları ortalamanın altındadır."
                ,"Bütün çocuklar uyanık mı ?"
                ,"Benim evim 6 kilometre uzaktadır. / O dün yoktu"
                ,"Ağacı bir balta ile kesti."
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
                ,"eni"
                ,"enibadi"
                ,"eniwın"
                ,"eniting"
                ,"enivey"
                ,"enivear"
                ,"epir"
                ,"epitayt"
                ,"epıl"
                ,"aplikayşın"
                  ,"Aplı"
                ,"Appoyntmınt"
                ,"Approprııt"
                ,"Eyprıkıt"
                ,"Eyprıl"
                ,"Ar"
                ,"Argü"
                ,"Argüment"
                ,"Arm"
                ,"Armçer"
                ,"Armı"
                ,"Arand"
                ,"As"
                ,"Eyştrey"
                ,"Esk"
                ,"Aspîrin"
                ,"Esyum"
                ,"Esronot"
                ,"At"
                ,"Eyt"
                ,"Ettlit"
                ,"Etlas"
                ,"ıtenşın"
                ,"etityud"
                ,"o:gıst"
                ,"a:nt"
                ,"o:'toriti"
                ,"o:tımıbi:l"
                ,"o:tım"
                ,"ı'veylıbıl"
                ,"evric"
                ,"ı'weyk"
                ,"ı'wey"
                ,"eks"


        };


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


