namespace Like_Sherlock_Holmes
{
    partial class gameForm
    {
        public int a;
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameForm));
            startGameButton = new Button();
            detektywPictureBox = new PictureBox();
            policjantPictureBox = new PictureBox();
            policjantButton = new Button();
            detektywButton = new Button();
            pickCharacterGropuBox = new GroupBox();
            pickCharacterText = new Label();
            wstepGroupBox = new GroupBox();
            tekst4 = new Label();
            tekst3 = new Label();
            tekst2 = new Label();
            tekst1 = new Label();
            continuteButton = new Button();
            przesluchanieGroupBox = new GroupBox();
            kasiaLabel = new Label();
            albertLabel = new Label();
            karolLabel = new Label();
            hubertLabel = new Label();
            uniewinnijButton = new Button();
            miejsceZbrodniButton = new Button();
            wskazSprawceButton = new Button();
            podejrzany4 = new PictureBox();
            podejrzany3 = new PictureBox();
            podejrzany2 = new PictureBox();
            podejrzany1 = new PictureBox();
            podejrzaniButton = new Button();
            scenaZbrodniGroupBox = new GroupBox();
            poszlakaTextBox = new RichTextBox();
            dochodzenieButton = new Button();
            background = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            zmianaTuryGroupBox = new GroupBox();
            przejdzDalejButton = new Button();
            wynikLabel = new Label();
            winLoseLabel = new Label();
            timer3 = new System.Windows.Forms.Timer(components);
            menuGroupBox = new GroupBox();
            gameNameLabel = new Label();
            infoButton = new Button();
            infoGroupBox = new GroupBox();
            infoBackButton = new Button();
            infoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)detektywPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)policjantPictureBox).BeginInit();
            pickCharacterGropuBox.SuspendLayout();
            wstepGroupBox.SuspendLayout();
            przesluchanieGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)podejrzany4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)podejrzany3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)podejrzany2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)podejrzany1).BeginInit();
            scenaZbrodniGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)background).BeginInit();
            zmianaTuryGroupBox.SuspendLayout();
            menuGroupBox.SuspendLayout();
            infoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // startGameButton
            // 
            startGameButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            startGameButton.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            startGameButton.Location = new Point(434, 357);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(392, 165);
            startGameButton.TabIndex = 0;
            startGameButton.Text = "Start";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += startGameButton_Click;
            // 
            // detektywPictureBox
            // 
            detektywPictureBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            detektywPictureBox.Image = (Image)resources.GetObject("detektywPictureBox.Image");
            detektywPictureBox.Location = new Point(793, 559);
            detektywPictureBox.Name = "detektywPictureBox";
            detektywPictureBox.Size = new Size(427, 407);
            detektywPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            detektywPictureBox.TabIndex = 1;
            detektywPictureBox.TabStop = false;
            // 
            // policjantPictureBox
            // 
            policjantPictureBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            policjantPictureBox.BackColor = Color.Transparent;
            policjantPictureBox.BackgroundImageLayout = ImageLayout.None;
            policjantPictureBox.Image = (Image)resources.GetObject("policjantPictureBox.Image");
            policjantPictureBox.InitialImage = null;
            policjantPictureBox.Location = new Point(51, 557);
            policjantPictureBox.Name = "policjantPictureBox";
            policjantPictureBox.Size = new Size(427, 407);
            policjantPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            policjantPictureBox.TabIndex = 2;
            policjantPictureBox.TabStop = false;
            // 
            // policjantButton
            // 
            policjantButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            policjantButton.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            policjantButton.Location = new Point(836, 436);
            policjantButton.Name = "policjantButton";
            policjantButton.Size = new Size(296, 106);
            policjantButton.TabIndex = 3;
            policjantButton.Text = "Policjant";
            policjantButton.UseVisualStyleBackColor = true;
            policjantButton.Click += policjantButton_Click;
            // 
            // detektywButton
            // 
            detektywButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            detektywButton.AutoSize = true;
            detektywButton.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            detektywButton.Location = new Point(125, 432);
            detektywButton.Name = "detektywButton";
            detektywButton.Size = new Size(296, 106);
            detektywButton.TabIndex = 4;
            detektywButton.Text = "Detektyw";
            detektywButton.UseVisualStyleBackColor = true;
            detektywButton.Click += detektywButton_Click;
            // 
            // pickCharacterGropuBox
            // 
            pickCharacterGropuBox.Controls.Add(pickCharacterText);
            pickCharacterGropuBox.Controls.Add(detektywButton);
            pickCharacterGropuBox.Controls.Add(detektywPictureBox);
            pickCharacterGropuBox.Controls.Add(policjantButton);
            pickCharacterGropuBox.Controls.Add(policjantPictureBox);
            pickCharacterGropuBox.Location = new Point(0, -21);
            pickCharacterGropuBox.Name = "pickCharacterGropuBox";
            pickCharacterGropuBox.Size = new Size(1261, 957);
            pickCharacterGropuBox.TabIndex = 5;
            pickCharacterGropuBox.TabStop = false;
            pickCharacterGropuBox.Visible = false;
            // 
            // pickCharacterText
            // 
            pickCharacterText.Font = new Font("Bookman Old Style", 48F, FontStyle.Regular, GraphicsUnit.Point);
            pickCharacterText.Location = new Point(2, 126);
            pickCharacterText.Name = "pickCharacterText";
            pickCharacterText.Size = new Size(1263, 141);
            pickCharacterText.TabIndex = 5;
            pickCharacterText.Text = "Wybierz swoją postać";
            pickCharacterText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wstepGroupBox
            // 
            wstepGroupBox.BackColor = Color.White;
            wstepGroupBox.Controls.Add(tekst4);
            wstepGroupBox.Controls.Add(tekst3);
            wstepGroupBox.Controls.Add(tekst2);
            wstepGroupBox.Controls.Add(tekst1);
            wstepGroupBox.Controls.Add(continuteButton);
            wstepGroupBox.Location = new Point(-10, -13);
            wstepGroupBox.Name = "wstepGroupBox";
            wstepGroupBox.Size = new Size(1275, 962);
            wstepGroupBox.TabIndex = 6;
            wstepGroupBox.TabStop = false;
            wstepGroupBox.Visible = false;
            // 
            // tekst4
            // 
            tekst4.AutoSize = true;
            tekst4.BackColor = Color.Black;
            tekst4.Font = new Font("Corbel", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tekst4.ForeColor = Color.White;
            tekst4.Location = new Point(70, 724);
            tekst4.Name = "tekst4";
            tekst4.Size = new Size(915, 88);
            tekst4.TabIndex = 8;
            tekst4.Text = "Na miejscu zdarzenia nie znaleziono za wiele.\r\nŚledczy ustalili, że strzały musiały paść z większej odległości.";
            tekst4.Visible = false;
            // 
            // tekst3
            // 
            tekst3.AutoSize = true;
            tekst3.BackColor = Color.Black;
            tekst3.Font = new Font("Corbel", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tekst3.ForeColor = Color.White;
            tekst3.Location = new Point(70, 290);
            tekst3.Name = "tekst3";
            tekst3.Size = new Size(1177, 396);
            tekst3.TabIndex = 7;
            tekst3.Text = resources.GetString("tekst3.Text");
            tekst3.Visible = false;
            // 
            // tekst2
            // 
            tekst2.AutoSize = true;
            tekst2.BackColor = Color.Black;
            tekst2.Font = new Font("Corbel", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tekst2.ForeColor = Color.White;
            tekst2.Location = new Point(70, 171);
            tekst2.Name = "tekst2";
            tekst2.Size = new Size(926, 88);
            tekst2.TabIndex = 6;
            tekst2.Text = "Młoda kobieta - Ania została znaleziona martwa na chodniku.\r\nZostała postrzelona.";
            tekst2.Visible = false;
            // 
            // tekst1
            // 
            tekst1.AutoSize = true;
            tekst1.BackColor = Color.Black;
            tekst1.Font = new Font("Corbel", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tekst1.ForeColor = Color.White;
            tekst1.Location = new Point(70, 54);
            tekst1.Name = "tekst1";
            tekst1.Size = new Size(1097, 88);
            tekst1.TabIndex = 5;
            tekst1.Text = "Zostałem powiadomiony o zabójstwie, które odbyło się na ulicy Szkolnej.\r\nPojechałem zbadać sprawę.\r\n";
            tekst1.Visible = false;
            // 
            // continuteButton
            // 
            continuteButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            continuteButton.Location = new Point(448, 851);
            continuteButton.Name = "continuteButton";
            continuteButton.Size = new Size(305, 59);
            continuteButton.TabIndex = 4;
            continuteButton.Text = "Kontunuuj";
            continuteButton.UseVisualStyleBackColor = true;
            continuteButton.Visible = false;
            continuteButton.Click += continuteButton_Click;
            // 
            // przesluchanieGroupBox
            // 
            przesluchanieGroupBox.BackColor = Color.Black;
            przesluchanieGroupBox.Controls.Add(kasiaLabel);
            przesluchanieGroupBox.Controls.Add(albertLabel);
            przesluchanieGroupBox.Controls.Add(karolLabel);
            przesluchanieGroupBox.Controls.Add(hubertLabel);
            przesluchanieGroupBox.Controls.Add(uniewinnijButton);
            przesluchanieGroupBox.Controls.Add(miejsceZbrodniButton);
            przesluchanieGroupBox.Controls.Add(wskazSprawceButton);
            przesluchanieGroupBox.Controls.Add(podejrzany4);
            przesluchanieGroupBox.Controls.Add(podejrzany3);
            przesluchanieGroupBox.Controls.Add(podejrzany2);
            przesluchanieGroupBox.Controls.Add(podejrzany1);
            przesluchanieGroupBox.Location = new Point(-16, -13);
            przesluchanieGroupBox.Name = "przesluchanieGroupBox";
            przesluchanieGroupBox.Size = new Size(1288, 970);
            przesluchanieGroupBox.TabIndex = 6;
            przesluchanieGroupBox.TabStop = false;
            przesluchanieGroupBox.Visible = false;
            // 
            // kasiaLabel
            // 
            kasiaLabel.AutoSize = true;
            kasiaLabel.Font = new Font("Corbel", 18F, FontStyle.Regular, GraphicsUnit.Point);
            kasiaLabel.ForeColor = Color.White;
            kasiaLabel.Location = new Point(997, 424);
            kasiaLabel.Name = "kasiaLabel";
            kasiaLabel.Size = new Size(100, 44);
            kasiaLabel.TabIndex = 14;
            kasiaLabel.Text = "Kasia";
            // 
            // albertLabel
            // 
            albertLabel.AutoSize = true;
            albertLabel.Font = new Font("Corbel", 18F, FontStyle.Regular, GraphicsUnit.Point);
            albertLabel.ForeColor = Color.White;
            albertLabel.Location = new Point(415, 434);
            albertLabel.Name = "albertLabel";
            albertLabel.Size = new Size(112, 44);
            albertLabel.TabIndex = 12;
            albertLabel.Text = "Albert";
            // 
            // karolLabel
            // 
            karolLabel.AutoSize = true;
            karolLabel.Font = new Font("Corbel", 18F, FontStyle.Regular, GraphicsUnit.Point);
            karolLabel.ForeColor = Color.White;
            karolLabel.Location = new Point(725, 406);
            karolLabel.Name = "karolLabel";
            karolLabel.Size = new Size(98, 44);
            karolLabel.TabIndex = 13;
            karolLabel.Text = "Karol";
            // 
            // hubertLabel
            // 
            hubertLabel.AutoSize = true;
            hubertLabel.Font = new Font("Corbel", 18F, FontStyle.Regular, GraphicsUnit.Point);
            hubertLabel.ForeColor = Color.White;
            hubertLabel.Location = new Point(125, 389);
            hubertLabel.Name = "hubertLabel";
            hubertLabel.Size = new Size(124, 44);
            hubertLabel.TabIndex = 11;
            hubertLabel.Text = "Hubert";
            // 
            // uniewinnijButton
            // 
            uniewinnijButton.Location = new Point(654, 25);
            uniewinnijButton.Name = "uniewinnijButton";
            uniewinnijButton.Size = new Size(178, 85);
            uniewinnijButton.TabIndex = 6;
            uniewinnijButton.Text = "Uniewinnij";
            uniewinnijButton.UseVisualStyleBackColor = true;
            uniewinnijButton.Click += uniewinnijButton_Click;
            // 
            // miejsceZbrodniButton
            // 
            miejsceZbrodniButton.Location = new Point(28, 26);
            miejsceZbrodniButton.Name = "miejsceZbrodniButton";
            miejsceZbrodniButton.Size = new Size(173, 76);
            miejsceZbrodniButton.TabIndex = 6;
            miejsceZbrodniButton.Text = "Przejdź do miejsca zbrodni";
            miejsceZbrodniButton.UseVisualStyleBackColor = true;
            miejsceZbrodniButton.Click += miejsceZbrodniButton_Click;
            // 
            // wskazSprawceButton
            // 
            wskazSprawceButton.BackColor = Color.Transparent;
            wskazSprawceButton.Location = new Point(458, 25);
            wskazSprawceButton.Name = "wskazSprawceButton";
            wskazSprawceButton.Size = new Size(178, 86);
            wskazSprawceButton.TabIndex = 5;
            wskazSprawceButton.Text = "Wskaż sprawcę";
            wskazSprawceButton.UseVisualStyleBackColor = false;
            wskazSprawceButton.Click += wskazSprawceButton_Click;
            // 
            // podejrzany4
            // 
            podejrzany4.Image = (Image)resources.GetObject("podejrzany4.Image");
            podejrzany4.Location = new Point(951, 466);
            podejrzany4.Name = "podejrzany4";
            podejrzany4.Size = new Size(216, 470);
            podejrzany4.SizeMode = PictureBoxSizeMode.StretchImage;
            podejrzany4.TabIndex = 3;
            podejrzany4.TabStop = false;
            podejrzany4.Tag = "kasia";
            podejrzany4.Click += podejrzany4_Click;
            podejrzany4.MouseEnter += podejrzany_MouseEnter;
            podejrzany4.MouseLeave += podejrzany_MouseLeave;
            // 
            // podejrzany3
            // 
            podejrzany3.Image = (Image)resources.GetObject("podejrzany3.Image");
            podejrzany3.Location = new Point(654, 436);
            podejrzany3.Name = "podejrzany3";
            podejrzany3.Size = new Size(223, 487);
            podejrzany3.SizeMode = PictureBoxSizeMode.StretchImage;
            podejrzany3.TabIndex = 2;
            podejrzany3.TabStop = false;
            podejrzany3.Tag = "karol";
            podejrzany3.Click += podejrzany3_Click;
            podejrzany3.MouseEnter += podejrzany_MouseEnter;
            podejrzany3.MouseLeave += podejrzany_MouseLeave;
            // 
            // podejrzany2
            // 
            podejrzany2.Image = (Image)resources.GetObject("podejrzany2.Image");
            podejrzany2.Location = new Point(398, 481);
            podejrzany2.Name = "podejrzany2";
            podejrzany2.Size = new Size(139, 442);
            podejrzany2.SizeMode = PictureBoxSizeMode.StretchImage;
            podejrzany2.TabIndex = 1;
            podejrzany2.TabStop = false;
            podejrzany2.Tag = "albert";
            podejrzany2.Click += podejrzany2_Click;
            podejrzany2.MouseEnter += podejrzany_MouseEnter;
            podejrzany2.MouseLeave += podejrzany_MouseLeave;
            // 
            // podejrzany1
            // 
            podejrzany1.Image = (Image)resources.GetObject("podejrzany1.Image");
            podejrzany1.Location = new Point(113, 436);
            podejrzany1.Name = "podejrzany1";
            podejrzany1.Size = new Size(153, 487);
            podejrzany1.SizeMode = PictureBoxSizeMode.StretchImage;
            podejrzany1.TabIndex = 0;
            podejrzany1.TabStop = false;
            podejrzany1.Tag = "hubert";
            podejrzany1.Click += podejrzany1_Click;
            podejrzany1.MouseEnter += podejrzany_MouseEnter;
            podejrzany1.MouseLeave += podejrzany_MouseLeave;
            // 
            // podejrzaniButton
            // 
            podejrzaniButton.Location = new Point(12, 12);
            podejrzaniButton.Name = "podejrzaniButton";
            podejrzaniButton.Size = new Size(173, 76);
            podejrzaniButton.TabIndex = 4;
            podejrzaniButton.Text = "Przejdź do podejrzanych";
            podejrzaniButton.UseVisualStyleBackColor = true;
            podejrzaniButton.Click += podejrzaniButton_Click;
            // 
            // scenaZbrodniGroupBox
            // 
            scenaZbrodniGroupBox.Controls.Add(poszlakaTextBox);
            scenaZbrodniGroupBox.Controls.Add(podejrzaniButton);
            scenaZbrodniGroupBox.Controls.Add(dochodzenieButton);
            scenaZbrodniGroupBox.Controls.Add(background);
            scenaZbrodniGroupBox.Location = new Point(0, 0);
            scenaZbrodniGroupBox.Name = "scenaZbrodniGroupBox";
            scenaZbrodniGroupBox.Size = new Size(1272, 957);
            scenaZbrodniGroupBox.TabIndex = 6;
            scenaZbrodniGroupBox.TabStop = false;
            scenaZbrodniGroupBox.Visible = false;
            // 
            // poszlakaTextBox
            // 
            poszlakaTextBox.BackColor = Color.Black;
            poszlakaTextBox.BorderStyle = BorderStyle.FixedSingle;
            poszlakaTextBox.ForeColor = Color.White;
            poszlakaTextBox.Location = new Point(357, 12);
            poszlakaTextBox.Name = "poszlakaTextBox";
            poszlakaTextBox.ReadOnly = true;
            poszlakaTextBox.Size = new Size(527, 117);
            poszlakaTextBox.TabIndex = 6;
            poszlakaTextBox.Text = "";
            // 
            // dochodzenieButton
            // 
            dochodzenieButton.Location = new Point(1078, 12);
            dochodzenieButton.Name = "dochodzenieButton";
            dochodzenieButton.Size = new Size(173, 79);
            dochodzenieButton.TabIndex = 5;
            dochodzenieButton.Text = "Szukaj poszlak";
            dochodzenieButton.UseVisualStyleBackColor = true;
            dochodzenieButton.Click += dochodzenieButton_Click;
            // 
            // background
            // 
            background.Image = (Image)resources.GetObject("background.Image");
            background.Location = new Point(-10, 0);
            background.Name = "background";
            background.Size = new Size(1276, 936);
            background.SizeMode = PictureBoxSizeMode.StretchImage;
            background.TabIndex = 0;
            background.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // zmianaTuryGroupBox
            // 
            zmianaTuryGroupBox.BackColor = Color.Black;
            zmianaTuryGroupBox.Controls.Add(przejdzDalejButton);
            zmianaTuryGroupBox.Controls.Add(wynikLabel);
            zmianaTuryGroupBox.Controls.Add(winLoseLabel);
            zmianaTuryGroupBox.Location = new Point(-4, -13);
            zmianaTuryGroupBox.Name = "zmianaTuryGroupBox";
            zmianaTuryGroupBox.Size = new Size(1270, 956);
            zmianaTuryGroupBox.TabIndex = 11;
            zmianaTuryGroupBox.TabStop = false;
            zmianaTuryGroupBox.Visible = false;
            // 
            // przejdzDalejButton
            // 
            przejdzDalejButton.Location = new Point(515, 689);
            przejdzDalejButton.Name = "przejdzDalejButton";
            przejdzDalejButton.Size = new Size(239, 93);
            przejdzDalejButton.TabIndex = 1;
            przejdzDalejButton.Text = "Przejdz do menu";
            przejdzDalejButton.UseVisualStyleBackColor = true;
            przejdzDalejButton.Visible = false;
            przejdzDalejButton.Click += przejdzDalejButton_Click;
            // 
            // wynikLabel
            // 
            wynikLabel.Font = new Font("Corbel", 22F, FontStyle.Regular, GraphicsUnit.Point);
            wynikLabel.ForeColor = Color.White;
            wynikLabel.Location = new Point(0, 424);
            wynikLabel.Name = "wynikLabel";
            wynikLabel.Size = new Size(1263, 92);
            wynikLabel.TabIndex = 2;
            wynikLabel.Text = "... był winny";
            wynikLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // winLoseLabel
            // 
            winLoseLabel.Font = new Font("Corbel", 48F, FontStyle.Regular, GraphicsUnit.Point);
            winLoseLabel.ForeColor = Color.White;
            winLoseLabel.Location = new Point(0, 197);
            winLoseLabel.Name = "winLoseLabel";
            winLoseLabel.Size = new Size(1266, 155);
            winLoseLabel.TabIndex = 3;
            winLoseLabel.Text = "WYGRAŁEŚ";
            winLoseLabel.TextAlign = ContentAlignment.MiddleCenter;
            winLoseLabel.Visible = false;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;
            // 
            // menuGroupBox
            // 
            menuGroupBox.Controls.Add(gameNameLabel);
            menuGroupBox.Controls.Add(startGameButton);
            menuGroupBox.Controls.Add(infoButton);
            menuGroupBox.Location = new Point(-10, -13);
            menuGroupBox.Name = "menuGroupBox";
            menuGroupBox.Size = new Size(1282, 964);
            menuGroupBox.TabIndex = 3;
            menuGroupBox.TabStop = false;
            // 
            // gameNameLabel
            // 
            gameNameLabel.Font = new Font("Bookman Old Style", 48F, FontStyle.Italic, GraphicsUnit.Point);
            gameNameLabel.Location = new Point(6, 197);
            gameNameLabel.Name = "gameNameLabel";
            gameNameLabel.Size = new Size(1263, 108);
            gameNameLabel.TabIndex = 1;
            gameNameLabel.Text = "Like Sherlock Holmes";
            gameNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // infoButton
            // 
            infoButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            infoButton.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            infoButton.Location = new Point(434, 556);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(392, 165);
            infoButton.TabIndex = 2;
            infoButton.Text = "Pomoc";
            infoButton.UseVisualStyleBackColor = true;
            infoButton.Click += infoButton_Click;
            // 
            // infoGroupBox
            // 
            infoGroupBox.Controls.Add(infoBackButton);
            infoGroupBox.Controls.Add(infoLabel);
            infoGroupBox.Location = new Point(-10, -21);
            infoGroupBox.Name = "infoGroupBox";
            infoGroupBox.Size = new Size(1282, 964);
            infoGroupBox.TabIndex = 3;
            infoGroupBox.TabStop = false;
            // 
            // infoBackButton
            // 
            infoBackButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            infoBackButton.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            infoBackButton.Location = new Point(434, 766);
            infoBackButton.Name = "infoBackButton";
            infoBackButton.Size = new Size(392, 165);
            infoBackButton.TabIndex = 3;
            infoBackButton.Text = "Powrót";
            infoBackButton.UseVisualStyleBackColor = true;
            infoBackButton.Click += infoBackButton_Click;
            // 
            // infoLabel
            // 
            infoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            infoLabel.Location = new Point(70, 48);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(1124, 699);
            infoLabel.TabIndex = 0;
            infoLabel.Text = resources.GetString("infoLabel.Text");
            // 
            // gameForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1263, 935);
            Controls.Add(scenaZbrodniGroupBox);
            Controls.Add(przesluchanieGroupBox);
            Controls.Add(menuGroupBox);
            Controls.Add(infoGroupBox);
            Controls.Add(zmianaTuryGroupBox);
            Controls.Add(pickCharacterGropuBox);
            Controls.Add(wstepGroupBox);
            Name = "gameForm";
            Text = "Like Sherlock Holmes";
            Load += gameForm_load;
            ((System.ComponentModel.ISupportInitialize)detektywPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)policjantPictureBox).EndInit();
            pickCharacterGropuBox.ResumeLayout(false);
            pickCharacterGropuBox.PerformLayout();
            wstepGroupBox.ResumeLayout(false);
            wstepGroupBox.PerformLayout();
            przesluchanieGroupBox.ResumeLayout(false);
            przesluchanieGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)podejrzany4).EndInit();
            ((System.ComponentModel.ISupportInitialize)podejrzany3).EndInit();
            ((System.ComponentModel.ISupportInitialize)podejrzany2).EndInit();
            ((System.ComponentModel.ISupportInitialize)podejrzany1).EndInit();
            scenaZbrodniGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)background).EndInit();
            zmianaTuryGroupBox.ResumeLayout(false);
            menuGroupBox.ResumeLayout(false);
            infoGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public PictureBox detektywPictureBox;
        public PictureBox policjantPictureBox;
        public Button policjantButton;
        public Button detektywButton;
        public GroupBox pickCharacterGropuBox;
        public GroupBox przesluchanieGroupBox;
        public Button podejrzaniButton;
        public PictureBox podejrzany4;
        public PictureBox podejrzany3;
        public PictureBox podejrzany2;
        public PictureBox podejrzany1;
        public Button wskazSprawceButton;
        public Button uniewinnijButton;
        public GroupBox scenaZbrodniGroupBox;
        public PictureBox background;
        public Button miejsceZbrodniButton;
        public Button dochodzenieButton;
        public RichTextBox poszlakaTextBox;
        public GroupBox wstepGroupBox;
        public Button continuteButton;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
        public GroupBox zmianaTuryGroupBox;
        public Button startGameButton;
        public System.Windows.Forms.Timer timer3;
        public Button przejdzDalejButton;
        public Label tekst4;
        public Label tekst3;
        public Label tekst2;
        public Label tekst1;
        public Label kasiaLabel;
        public Label albertLabel;
        public Label karolLabel;
        public Label hubertLabel;
        public Label wynikLabel;
        public GroupBox menuGroupBox;
        public Label gameNameLabel;
        public Label pickCharacterText;
        public Label winLoseLabel;
        public Button infoButton;
        public GroupBox infoGroupBox;
        public Label infoLabel;
        public Button infoBackButton;
    }
}