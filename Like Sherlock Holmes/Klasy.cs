using Like_Sherlock_Holmes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Like_Sherlock_Holmes
{
    class Przesluchiwany
    {
        public String imie { get; }
        public bool winny { get; }
        public bool wskazany = false;
        String sciezkaDoGrafiki;
        PictureBox pictureBox;
        Label imieLabel;
        public Przesluchiwany(String imie, String sciezka, bool winny,
            PictureBox pictureBox, Label imieLabel)
        {
            this.imie = imie;
            this.sciezkaDoGrafiki = sciezka;
            this.winny = winny;
            this.pictureBox = pictureBox;
            this.imieLabel = imieLabel;
            pictureBox.ImageLocation = sciezka;
        }
        public String getImageLocation()
        {
            return sciezkaDoGrafiki;
        }
        public Przesluchiwany wskaz()
        {
            pictureBox.Hide();
            imieLabel.Hide();
            wskazany = true;
            return this;
        }
    }

    class MiejsceZbrodni
    {
        public MiejsceZbrodni(String nazwa, String sciezkaDoGrafiki)
        {
            this.nazwa = nazwa;
            this.sciezkaDoGrafiki = sciezkaDoGrafiki;
        }
        public String getImageLocation()
        {
            return sciezkaDoGrafiki;
        }
        String nazwa;
        String sciezkaDoGrafiki;
    }

    class Poszlaka
    {
        public String opis;
        public bool czyZnana;
        public Poszlaka(String opis)
        {
            this.opis = opis;
            this.czyZnana = false;
        }
    }
    class Dowod : Poszlaka
    {
        public Dowod(bool czyZnana, List<String> imiona) : base("")
        {
            int nrOsoby = Random.Shared.Next(0, 3);
            if(imiona[nrOsoby] == "Kasia")
                opis = "Znalazłem ważny dowód " + imiona[nrOsoby] + " jest niewinna";
            else
                opis = "Znalazłem ważny dowód " + imiona[nrOsoby] + " jest niewinny";
        }
    }
    interface ISledczy
    {
        Poszlaka znalezionaPoszlaka { get; set; } //ostatnia znaleziona poszlaka
        public int szukanePoszlakiWTurze { get; set; } //ilosc szukanych do tej pory poszlak w tej turze
        public bool czyMoznaSzukac(Context ctx);
        void przeprowadzSledztwo(Context ctx);
        Poszlaka szukajPoszlak();
    }
    class SledczyPolicji : ISledczy
    {
        Poszlaka szukanaPoszlaka;
        public bool czySzukanoPoszlak = false;
        public int maxPoszlakWTurze = 1;
        int szukanePoszlaki;
        List<Poszlaka> poszlaki = new List<Poszlaka>() //poszlaki ktore pokazuja sie w crime scene
        {
            new Poszlaka("W noc zabójstwa, Ania odprowadziła Huberta do domu."),
            new Poszlaka("Dowiedziałem się, że Karol ma problemy psychiczne"),
            new Dowod(false, new List<String> { "Albert", "Hubert", "Kasia" })
        };
        public Poszlaka znalezionaPoszlaka
        {
            get { return szukanaPoszlaka; }
            set { szukanaPoszlaka = value; }
        }
        public int szukanePoszlakiWTurze
        {
            get { return szukanePoszlaki; }
            set { szukanePoszlaki = value; }
        }
        public bool czyMoznaSzukac(Context ctx)
        {
            if (szukanePoszlaki == maxPoszlakWTurze)
                return false;
            return true;
        }
        public void przeprowadzSledztwo(Context ctx)
        {
            szukanaPoszlaka = szukajPoszlak();

            ctx.gra.poszlakaTextBox.Text = "";
            ctx.gra.dochodzenieButton.Enabled = false;
            ctx.gra.timer2.Interval = 100;
            ctx.gra.timer2.Start();
            szukanePoszlaki++;
        }
        public Poszlaka szukajPoszlak()
        {
            int nrPoszlaki = Random.Shared.Next(0, 3);
            while (poszlaki[nrPoszlaki].czyZnana == true) //losuj dopoki znajdziemy niepokazana poszlake
            {
                nrPoszlaki = Random.Shared.Next(0, 3);
            }
            poszlaki[nrPoszlaki].czyZnana = true;

            return poszlaki[nrPoszlaki];
        }
    }

    class DetektywPrywatny : ISledczy
    {
        Poszlaka szukanaPoszlaka = null;
        public int maxPoszlakWTurze = 2;
        int szukanePoszlaki;
        int szukanePoszlakiSuma = 0;
        List<Poszlaka> poszlaki = new List<Poszlaka>() //poszlaki ktore pokazuja sie w crime scene
        {
            new Poszlaka("Dowiedziałem się, że kasia nie była szcześliwa w byłm związku."),
            new Poszlaka("Wszystko wskazuje na to, że po rozwodzie Albert stał się bezdomny."),
            new Poszlaka("W noc zabójstwa, Ania odprowadziła Huberta do domu."),
            new Poszlaka("Tego dnia Ania zrobiła imprezę u siebie w domu. Karol wielokrotnie ich upominał."),
            new Poszlaka("Dowiedziałem się, że Karol ma problemy psychiczne.")
        };
        public int szukanePoszlakiWTurze
        {
            get { return szukanePoszlaki; }
            set { szukanePoszlaki = value; }
        }
        public bool czyMoznaSzukac(Context ctx)
        {
            if (szukanePoszlakiSuma == 5 && ctx.tura == 3)
                maxPoszlakWTurze = 1;

            if (szukanePoszlakiSuma == 4)
            {
                if(ctx.tura == 3)
                    maxPoszlakWTurze = 2;
                else
                    maxPoszlakWTurze = 1;
            }
            if (szukanePoszlaki >= maxPoszlakWTurze)
                return false;
            else 
            {
                return true;
            }   
        }
        public Poszlaka znalezionaPoszlaka
        {
            get { return szukanaPoszlaka; }
            set { szukanaPoszlaka = value; }
        }
        public void przeprowadzSledztwo(Context ctx)
        {
            szukanaPoszlaka = szukajPoszlak();

            ctx.gra.poszlakaTextBox.Text = "";
            ctx.gra.dochodzenieButton.Enabled = false;
            ctx.gra.timer2.Interval = 100;
            ctx.gra.timer2.Start();
            szukanePoszlaki++;
            szukanePoszlakiSuma++;
        }
        public Poszlaka szukajPoszlak() //daje nam 1 niewylosowana wczesniej poszlake
        {
            int nrPoszlaki = Random.Shared.Next(0, 5);
            while (poszlaki[nrPoszlaki].czyZnana == true) //losuj dopoki znajdziemy niepokazana poszlake
            {
                nrPoszlaki = Random.Shared.Next(0, 5);
            }
            poszlaki[nrPoszlaki].czyZnana = true;

            return poszlaki[nrPoszlaki];
        }
    }
    interface IStanGry
    {
        void Handle(Context context);
    }
    class Context
    {
        public gameForm gra { get; }
        public IStanGry stan { get; set; }
        public ISledczy sledczy { get; set; }

        public Przesluchiwany kolega, bylyMaz, sasiad, exPartnera;
        public Przesluchiwany ktoOdpadl;    
        String imgSciezka = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\img\\";
        MiejsceZbrodni miejsceZbrodni;

        //0 - brak wybierania, 1 - wybieranie sprawcy, 2 - wybieranie niewinnego
        public int stanWybierania = 0;
        public int tura = 1;
        public int endAnimationcolor = 0;

        public int introBgColor = 255;
        public int introAnimationState = 0;
        public int introTextColor = 0;
        public Context(IStanGry initialState, gameForm gra)
        {
            this.gra = gra;
            stan = initialState;

            kolega = new Przesluchiwany("Hubert", imgSciezka + "suspects\\garnitur.png", false, gra.podejrzany1, gra.hubertLabel);
            bylyMaz = new Przesluchiwany("Albert", imgSciezka + "suspects\\ziutek.png", false, gra.podejrzany2, gra.albertLabel);
            sasiad = new Przesluchiwany("Karol", imgSciezka + "suspects\\czerwony_swetr.png", true, gra.podejrzany3, gra.karolLabel);
            exPartnera = new Przesluchiwany("Kasia", imgSciezka + "suspects\\kobieta.png", false, gra.podejrzany4, gra.kasiaLabel);
            miejsceZbrodni = new MiejsceZbrodni("Ulica", imgSciezka + "scenes\\ulica.jpg");
            gra.background.ImageLocation = miejsceZbrodni.getImageLocation();
        }
        public void zmienStan(IStanGry nowyStan)
        {
            stan = nowyStan;
            stan.Handle(this);
        }
        public void wybierzPostac(ISledczy sledczy)
        {
            this.sledczy = sledczy;
        }
        public void resetujWartosciWszystkie()
        {
            resetujWartosciWskazWinnego();

            introAnimationState = 0; //animacja poczatkowa
            introBgColor = 255;
            introTextColor = 0;
            gra.wstepGroupBox.BackColor = Color.White; 
            gra.tekst1.Visible = false;
            gra.tekst2.Visible = false;
            gra.tekst3.Visible = false;
            gra.tekst4.Visible = false;

            gra.podejrzany1.Show(); //postacie
            gra.podejrzany2.Show();
            gra.podejrzany3.Show();
            gra.podejrzany4.Show();
            gra.albertLabel.Show();
            gra.hubertLabel.Show();
            gra.karolLabel.Show();
            gra.kasiaLabel.Show();

            gra.winLoseLabel.Hide(); //koniec gry
            gra.continuteButton.Hide();
            tura = 1;
        }

        public void resetujWartosciWskazWinnego()
        {
            gra.dochodzenieButton.Enabled = true;
            gra.poszlakaTextBox.Text = "";
            gra.wskazSprawceButton.BackColor = Color.White;
            gra.uniewinnijButton.BackColor = Color.White;

            stanWybierania = 0;
            sledczy.szukanePoszlakiWTurze = 0;
            endAnimationcolor = 0;
        }
    }
    class MenuStan : IStanGry
    {
        public void Handle(Context ctx)
        {
            ctx.gra.menuGroupBox.Show();
            ctx.gra.infoGroupBox.Hide();
        }
    }
    class WybierzPostacStan : IStanGry
    {
        public void Handle(Context ctx)
        {
            ctx.gra.pickCharacterGropuBox.Show();
            ctx.gra.menuGroupBox.Hide();
            ctx.gra.infoGroupBox.Hide();
        }
    }
    class FabulaStan : IStanGry
    {
        public void Handle(Context ctx)
        {
            ctx.gra.pickCharacterGropuBox.Hide();
            ctx.gra.wstepGroupBox.Show();

            ctx.gra.timer1.Interval = 15;
            ctx.gra.timer1.Start();    
        }
    }
    class WskazWinnegoStan : IStanGry
    {
        public void Handle(Context ctx)
        {
            ctx.gra.przesluchanieGroupBox.Show();
            ctx.gra.scenaZbrodniGroupBox.Hide();
            ctx.gra.wstepGroupBox.Hide();
            ctx.gra.zmianaTuryGroupBox.Hide();   
        }
    }
    class MiejsceZbrodniStan : IStanGry
    {
        public void Handle(Context ctx)
        {
            ctx.gra.scenaZbrodniGroupBox.Show();
            ctx.gra.przesluchanieGroupBox.Hide();

            if (ctx.sledczy.znalezionaPoszlaka != null)
                ctx.gra.poszlakaTextBox.Text = ctx.sledczy.znalezionaPoszlaka.opis;

            if (!ctx.sledczy.czyMoznaSzukac(ctx))
                ctx.gra.dochodzenieButton.Enabled = false;
        }
    }
    class PoWskazaniuStan : IStanGry
    {
        void gameOverScreen(Context ctx)
        {
            ctx.gra.przejdzDalejButton.Text = "Przejdź do menu";

            if (ctx.ktoOdpadl.imie == "Kasia") //zeby sie poprawnie wyswietlalo przy kasi
            {
                if (ctx.ktoOdpadl.winny == true) //jesli dobrze wytypowales
                {
                    ctx.gra.wynikLabel.Text = "Kasia była winna";
                    ctx.gra.winLoseLabel.Text = "WYGRAŁEŚ";
                }
                else //jesli zle wytypowales
                {
                    ctx.gra.wynikLabel.Text = "Kasia była niewinna";
                    ctx.gra.winLoseLabel.Text = "PRZEGRAŁEŚ";
                }
            }
            else //nie kasia
            {
                if (ctx.ktoOdpadl.winny == true) //jesli dobrze wytypowales
                {
                    ctx.gra.wynikLabel.Text = ctx.ktoOdpadl.imie + " był winny";
                    ctx.gra.winLoseLabel.Text = "WYGRAŁEŚ";
                }
                else //jesli zle wytypowales
                {
                    ctx.gra.wynikLabel.Text = ctx.ktoOdpadl.imie + " był niewinny";
                    ctx.gra.winLoseLabel.Text = "PRZEGRAŁEŚ";
                }
            }

        }
        void uniewinnienieScreen(Context ctx)
        {
            ctx.gra.przejdzDalejButton.Text = "Kontynuuj";

            if (ctx.ktoOdpadl.imie == "Kasia")
                ctx.gra.wynikLabel.Text = "Kasia została uniewinniona";
            else
                ctx.gra.wynikLabel.Text = ctx.ktoOdpadl.imie + " został uniewinniony";
        }
        public void Handle(Context ctx)
        {
            ctx.gra.zmianaTuryGroupBox.Show();
            ctx.gra.przesluchanieGroupBox.Hide();
            ctx.gra.wynikLabel.ForeColor = Color.Black;

            if (ctx.stanWybierania == 1)
                gameOverScreen(ctx);
            else if (ctx.stanWybierania == 2)
            {
                if (ctx.tura < 3)
                    uniewinnienieScreen(ctx);
                else //jesli zostaly sie 2 osoby i wskazesz niewinnego
                     //to automatycznie wskazuje sie winny i konczy gre
                {
                    if (ctx.kolega.wskazany == false)
                        ctx.ktoOdpadl = ctx.kolega;
                    else if (ctx.bylyMaz.wskazany == false)
                        ctx.ktoOdpadl = ctx.bylyMaz;
                    else if (ctx.sasiad.wskazany == false)
                        ctx.ktoOdpadl = ctx.sasiad;
                    else if (ctx.exPartnera.wskazany == false)
                        ctx.ktoOdpadl = ctx.exPartnera;

                    ctx.stanWybierania = 1;
                    gameOverScreen(ctx);
                }
            }

            ctx.tura++;
            ctx.gra.timer3.Interval = 15;
            ctx.gra.timer3.Start();
        }
    }
    class PomocStan : IStanGry
    {
        public void Handle(Context ctx)
        {
            ctx.gra.infoGroupBox.Show();
            ctx.gra.menuGroupBox.Hide();
        }
    }
}
