using Microsoft.VisualBasic.Devices;
using System.Drawing;
using System;
using System.IO;


namespace Like_Sherlock_Holmes
{
    public partial class gameForm : Form
    {
        Context context; //wspolne dla wszystkich stanow
        public gameForm()
        {
            InitializeComponent();
        }
        private void gameForm_load(object sender, EventArgs e)
        {
            context = new Context(new MenuStan(), this);
        }
        private void startGameButton_Click(object sender, EventArgs e)
        {
            context.zmienStan(new WybierzPostacStan());
        }
        private void detektywButton_Click(object sender, EventArgs e)
        {
            context.wybierzPostac(new DetektywPrywatny());
            context.zmienStan(new FabulaStan());
        }
        private void policjantButton_Click(object sender, EventArgs e)
        {
            context.wybierzPostac(new SledczyPolicji());
            context.zmienStan(new FabulaStan());
        }
        private void podejrzaniButton_Click(object sender, EventArgs e)
        {
            context.zmienStan(new WskazWinnegoStan());
        }
        private void miejsceZbrodniButton_Click(object sender, EventArgs e)
        {
            context.zmienStan(new MiejsceZbrodniStan());
        }
        private void continuteButton_Click(object sender, EventArgs e) //przejscie z intra do gry
        {
            context.zmienStan(new WskazWinnegoStan());
        }
        private void dochodzenieButton_Click(object sender, EventArgs e)
        {
            context.sledczy.przeprowadzSledztwo(context);
        }
        private void infoBackButton_Click(object sender, EventArgs e)
        {
            context.zmienStan(new MenuStan());
        }
        private void infoButton_Click(object sender, EventArgs e)
        {
            context.zmienStan(new PomocStan());
        }
        private void wskazSprawceButton_Click(object sender, EventArgs e)
        {
            if (context.stanWybierania == 1) //wlaczanie i wylaczanie funkcji wybierania sprawcy
            {
                wskazSprawceButton.BackColor = Color.Transparent;
                uniewinnijButton.BackColor = Color.Transparent;
                context.stanWybierania = 0;
            }
            else
            {
                wskazSprawceButton.BackColor = Color.DimGray;
                uniewinnijButton.BackColor = Color.Transparent;
                context.stanWybierania = 1;
            }
        }

        private void uniewinnijButton_Click(object sender, EventArgs e)
        {
            if (context.stanWybierania == 2) //wlaczanie i wylaczanie funkcji uniwinniania
            {
                uniewinnijButton.BackColor = Color.Transparent;
                wskazSprawceButton.BackColor = Color.Transparent;
                context.stanWybierania = 0;
            }
            else
            {
                uniewinnijButton.BackColor = Color.DimGray;
                wskazSprawceButton.BackColor = Color.Transparent;
                context.stanWybierania = 2;
            }

        }
        private void podejrzany1_Click(object sender, EventArgs e) //hubert
        {
            if (context.stanWybierania != 0)
            {
                context.ktoOdpadl = context.kolega.wskaz();
                context.zmienStan(new PoWskazaniuStan());
            }
        }

        private void podejrzany2_Click(object sender, EventArgs e) //albert
        {
            if (context.stanWybierania != 0)
            {
                context.ktoOdpadl = context.bylyMaz.wskaz();
                context.zmienStan(new PoWskazaniuStan());
            }
        }

        private void podejrzany3_Click(object sender, EventArgs e) //karol
        {
            if (context.stanWybierania != 0)
            {
                context.ktoOdpadl = context.sasiad.wskaz();
                context.zmienStan(new PoWskazaniuStan());
            }
        }

        private void podejrzany4_Click(object sender, EventArgs e) //kasia
        {
            if (context.stanWybierania != 0)
            {
                context.ktoOdpadl = context.exPartnera.wskaz();
                context.zmienStan(new PoWskazaniuStan());
            }
        }

        private void przejdzDalejButton_Click(object sender, EventArgs e) //przycisk po uniewinnieniu/wskazaniu postaci
        {
            if (context.stanWybierania == 1)
            {
                context.zmienStan(new MenuStan());
                context.resetujWartosciWszystkie();
            }
            else if (context.stanWybierania == 2)
            {
                context.zmienStan(new WskazWinnegoStan());
                context.resetujWartosciWskazWinnego();

            }

            zmianaTuryGroupBox.Hide();
            przejdzDalejButton.Hide();
        }
        private void podejrzany_MouseEnter(object sender, EventArgs e) //najechanie na podejrzanego
        {
            var postac = sender as PictureBox;
            if (postac != null && context.stanWybierania != 0)
            {
                Color kolorTekstu = Color.White;
                if (context.stanWybierania == 1)
                    kolorTekstu = Color.Red;
                else if (context.stanWybierania == 2)
                    kolorTekstu = Color.Green;

                postac.Cursor = System.Windows.Forms.Cursors.Hand;
                switch (postac.Tag)
                {
                    case "hubert":
                        hubertLabel.ForeColor = kolorTekstu;
                        break;

                    case "albert":
                        albertLabel.ForeColor = kolorTekstu;
                        break;

                    case "karol":
                        karolLabel.ForeColor = kolorTekstu;
                        break;

                    case "kasia":
                        kasiaLabel.ForeColor = kolorTekstu;
                        break;
                }
            }
        }
        private void podejrzany_MouseLeave(object sender, EventArgs e) //wyjechanie z podejrzanego
        {
            var postac = sender as PictureBox;
            if (postac != null && context.stanWybierania != 0)
            {
                switch (postac.Tag)
                {
                    case "hubert":
                        hubertLabel.ForeColor = Color.White;
                        break;

                    case "albert":
                        albertLabel.ForeColor = Color.White;
                        break;

                    case "karol":
                        karolLabel.ForeColor = Color.White;
                        break;

                    case "kasia":
                        kasiaLabel.ForeColor = Color.White;
                        break;
                }
            }
        }
        void timer1_Tick(object sender, EventArgs e) //animacje tekstu na poczatku
        {
            switch (context.introAnimationState)
            {
                case 0:
                    wstepGroupBox.BackColor = Color.FromArgb(context.introBgColor, context.introBgColor, context.introBgColor);
                    context.introBgColor -= 1;
                    if (context.introBgColor <= 0)
                        context.introAnimationState = 1;
                    break;
                case 1:
                    tekst1.Visible = true;
                    tekst1.ForeColor = Color.FromArgb(context.introTextColor, context.introTextColor, context.introTextColor);
                    context.introTextColor += 1;
                    if (context.introTextColor >= 255)
                    {
                        context.introAnimationState = 2;
                        context.introTextColor = 0;
                    }
                    break;
                case 2:
                    tekst2.Visible = true;
                    tekst2.ForeColor = Color.FromArgb(context.introTextColor, context.introTextColor, context.introTextColor);
                    context.introTextColor += 1;
                    if (context.introTextColor >= 255)
                    {
                        context.introAnimationState = 3;
                        context.introTextColor = 0;
                    }
                    break;
                case 3:
                    tekst3.Visible = true;
                    tekst3.ForeColor = Color.FromArgb(context.introTextColor, context.introTextColor, context.introTextColor);
                    context.introTextColor += 1;
                    if (context.introTextColor >= 255)
                    {
                        context.introAnimationState = 4;
                        context.introTextColor = 0;
                    }
                    break;
                case 4:
                    tekst4.Visible = true;
                    tekst4.ForeColor = Color.FromArgb(context.introTextColor, context.introTextColor, context.introTextColor);
                    context.introTextColor += 5;
                    if (context.introTextColor >= 255)
                    {
                        context.introAnimationState = 5;
                        context.introTextColor = 0;
                    }
                    break;
                case 5:
                    context.introTextColor += 5;
                    if (context.introTextColor >= 255)
                    {
                        continuteButton.Show();
                        timer1.Stop();
                    }
                    break;
            }
        }
        int i = 0;
        void timer2_Tick(object sender, EventArgs e)
        {
            if (context.sledczy.znalezionaPoszlaka.opis.Length <= i) //koniec wypisywania
            {
                timer2.Stop();
                i = 0;

                if (context.sledczy.czyMoznaSzukac(context))
                    dochodzenieButton.Enabled = true;
            }
            else //wypisywanie
            {
                poszlakaTextBox.Text += context.sledczy.znalezionaPoszlaka.opis[i];
                i++;
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (context.stanWybierania == 1) //jesli w stanie wybierania winnego
            {
                if (context.ktoOdpadl.winny == true)
                    wynikLabel.ForeColor = Color.FromArgb(0, context.endAnimationcolor, 0); //zielony kolor animacja
                else
                    wynikLabel.ForeColor = Color.FromArgb(context.endAnimationcolor, 0, 0); //czerwony kolor animacja
            }
            else //jesli w stanie unniewiniania
                wynikLabel.ForeColor = Color.FromArgb(context.endAnimationcolor, //bialy kolor animacja
                    context.endAnimationcolor, context.endAnimationcolor);

            context.endAnimationcolor++;
            if (context.endAnimationcolor == 255)
            {
                timer3.Stop();
                context.endAnimationcolor = 0;

                przejdzDalejButton.Show();
                if (context.stanWybierania == 1)
                    winLoseLabel.Show();
            }
        }
    }
}