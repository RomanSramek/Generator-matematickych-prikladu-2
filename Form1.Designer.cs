namespace Generáto_matematických_příkladů_2
{
    partial class oknoProgramu
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oknoProgramu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zastavPočítáníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastaveníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zobrazHistoriiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smazatHistoriiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxVýsledek = new System.Windows.Forms.TextBox();
            this.labelPříkladČ1 = new System.Windows.Forms.Label();
            this.labelZnaménko = new System.Windows.Forms.Label();
            this.labelPříkladČ2 = new System.Windows.Forms.Label();
            this.labelRovnáSe = new System.Windows.Forms.Label();
            this.labelZnámka = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textBoxHistorie = new System.Windows.Forms.TextBox();
            this.LstopkyT = new System.Windows.Forms.Label();
            this.LStopky = new System.Windows.Forms.Label();
            this.LVýsledekT = new System.Windows.Forms.Label();
            this.LŠpatněT = new System.Windows.Forms.Label();
            this.LSprávnéT = new System.Windows.Forms.Label();
            this.LZbývajícíT = new System.Windows.Forms.Label();
            this.LPočetT = new System.Windows.Forms.Label();
            this.LŠpatně = new System.Windows.Forms.Label();
            this.LSprávné = new System.Windows.Forms.Label();
            this.LZbývající = new System.Windows.Forms.Label();
            this.LPočet = new System.Windows.Forms.Label();
            this.LÚspěšnost = new System.Windows.Forms.Label();
            this.labelJménoHráče = new System.Windows.Forms.Label();
            this.checkBoxPlus = new System.Windows.Forms.CheckBox();
            this.checkBoxMínus = new System.Windows.Forms.CheckBox();
            this.checkBoxNásobit = new System.Windows.Forms.CheckBox();
            this.checkBoxDělit = new System.Windows.Forms.CheckBox();
            this.textBoxČ1od = new System.Windows.Forms.TextBox();
            this.textBoxČ1do = new System.Windows.Forms.TextBox();
            this.textBoxČ2od = new System.Windows.Forms.TextBox();
            this.textBoxČ2do = new System.Windows.Forms.TextBox();
            this.labelVýsledek = new System.Windows.Forms.Label();
            this.textBoxPočetPříkladů = new System.Windows.Forms.TextBox();
            this.buttonZkontroluj = new System.Windows.Forms.Button();
            this.textBoxZadejJméno = new System.Windows.Forms.TextBox();
            this.labelPočetPříkladů = new System.Windows.Forms.Label();
            this.buttonUložNastavení = new System.Windows.Forms.Button();
            this.checkBoxStopky = new System.Windows.Forms.CheckBox();
            this.checkBoxZobrazitOstatní = new System.Windows.Forms.CheckBox();
            this.gBnastavení = new System.Windows.Forms.GroupBox();
            this.checkBoxMínusVýsledek = new System.Windows.Forms.CheckBox();
            this.labelJméno = new System.Windows.Forms.Label();
            this.checkBoxZvuky = new System.Windows.Forms.CheckBox();
            this.labelKonec = new System.Windows.Forms.Label();
            this.stopky = new System.Windows.Forms.Timer(this.components);
            this.timerČervená = new System.Windows.Forms.Timer(this.components);
            this.bŠedá = new System.Windows.Forms.Button();
            this.bBílá = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gBnastavení.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.nastaveníToolStripMenuItem,
            this.historieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zastavPočítáníToolStripMenuItem,
            this.konecToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // zastavPočítáníToolStripMenuItem
            // 
            this.zastavPočítáníToolStripMenuItem.Name = "zastavPočítáníToolStripMenuItem";
            this.zastavPočítáníToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.zastavPočítáníToolStripMenuItem.Text = "Znovu";
            this.zastavPočítáníToolStripMenuItem.Click += new System.EventHandler(this.zastavPočítáníToolStripMenuItem_Click);
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.konecToolStripMenuItem.Text = "Konec";
            this.konecToolStripMenuItem.Click += new System.EventHandler(this.konecToolStripMenuItem_Click);
            // 
            // nastaveníToolStripMenuItem
            // 
            this.nastaveníToolStripMenuItem.Name = "nastaveníToolStripMenuItem";
            this.nastaveníToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.nastaveníToolStripMenuItem.Text = "Nastavení";
            this.nastaveníToolStripMenuItem.Click += new System.EventHandler(this.nastaveníToolStripMenuItem_Click);
            // 
            // historieToolStripMenuItem
            // 
            this.historieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zobrazHistoriiToolStripMenuItem,
            this.smazatHistoriiToolStripMenuItem});
            this.historieToolStripMenuItem.Name = "historieToolStripMenuItem";
            this.historieToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.historieToolStripMenuItem.Text = "Historie";
            // 
            // zobrazHistoriiToolStripMenuItem
            // 
            this.zobrazHistoriiToolStripMenuItem.Name = "zobrazHistoriiToolStripMenuItem";
            this.zobrazHistoriiToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.zobrazHistoriiToolStripMenuItem.Text = "Zobraz historii";
            this.zobrazHistoriiToolStripMenuItem.Click += new System.EventHandler(this.zobrazHistoriiToolStripMenuItem_Click);
            // 
            // smazatHistoriiToolStripMenuItem
            // 
            this.smazatHistoriiToolStripMenuItem.Name = "smazatHistoriiToolStripMenuItem";
            this.smazatHistoriiToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.smazatHistoriiToolStripMenuItem.Text = "Smazat historii";
            this.smazatHistoriiToolStripMenuItem.Click += new System.EventHandler(this.smazatHistoriiToolStripMenuItem_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Consolas", 13.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.Location = new System.Drawing.Point(400, 128);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 50);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxVýsledek
            // 
            this.textBoxVýsledek.BackColor = System.Drawing.Color.White;
            this.textBoxVýsledek.Font = new System.Drawing.Font("Consolas", 26.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVýsledek.Location = new System.Drawing.Point(280, 100);
            this.textBoxVýsledek.MaxLength = 4;
            this.textBoxVýsledek.Name = "textBoxVýsledek";
            this.textBoxVýsledek.Size = new System.Drawing.Size(120, 49);
            this.textBoxVýsledek.TabIndex = 6;
            this.textBoxVýsledek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVýsledek.Visible = false;
            // 
            // labelPříkladČ1
            // 
            this.labelPříkladČ1.AutoSize = true;
            this.labelPříkladČ1.BackColor = System.Drawing.Color.Transparent;
            this.labelPříkladČ1.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPříkladČ1.Location = new System.Drawing.Point(50, 120);
            this.labelPříkladČ1.Name = "labelPříkladČ1";
            this.labelPříkladČ1.Size = new System.Drawing.Size(64, 47);
            this.labelPříkladČ1.TabIndex = 7;
            this.labelPříkladČ1.Text = "10";
            this.labelPříkladČ1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPříkladČ1.Visible = false;
            // 
            // labelZnaménko
            // 
            this.labelZnaménko.AutoSize = true;
            this.labelZnaménko.BackColor = System.Drawing.Color.Transparent;
            this.labelZnaménko.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZnaménko.Location = new System.Drawing.Point(114, 100);
            this.labelZnaménko.Name = "labelZnaménko";
            this.labelZnaménko.Size = new System.Drawing.Size(42, 47);
            this.labelZnaménko.TabIndex = 8;
            this.labelZnaménko.Text = "+";
            this.labelZnaménko.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelZnaménko.Visible = false;
            // 
            // labelPříkladČ2
            // 
            this.labelPříkladČ2.AutoSize = true;
            this.labelPříkladČ2.BackColor = System.Drawing.Color.Transparent;
            this.labelPříkladČ2.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPříkladČ2.Location = new System.Drawing.Point(160, 100);
            this.labelPříkladČ2.Name = "labelPříkladČ2";
            this.labelPříkladČ2.Size = new System.Drawing.Size(64, 47);
            this.labelPříkladČ2.TabIndex = 9;
            this.labelPříkladČ2.Text = "20";
            this.labelPříkladČ2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPříkladČ2.Visible = false;
            // 
            // labelRovnáSe
            // 
            this.labelRovnáSe.AutoSize = true;
            this.labelRovnáSe.BackColor = System.Drawing.Color.Transparent;
            this.labelRovnáSe.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRovnáSe.Location = new System.Drawing.Point(230, 100);
            this.labelRovnáSe.Name = "labelRovnáSe";
            this.labelRovnáSe.Size = new System.Drawing.Size(42, 47);
            this.labelRovnáSe.TabIndex = 10;
            this.labelRovnáSe.Text = "=";
            this.labelRovnáSe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRovnáSe.Visible = false;
            // 
            // labelZnámka
            // 
            this.labelZnámka.AutoSize = true;
            this.labelZnámka.BackColor = System.Drawing.Color.Transparent;
            this.labelZnámka.Font = new System.Drawing.Font("Freehand521 BT", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZnámka.Location = new System.Drawing.Point(575, 50);
            this.labelZnámka.Name = "labelZnámka";
            this.labelZnámka.Size = new System.Drawing.Size(178, 162);
            this.labelZnámka.TabIndex = 11;
            this.labelZnámka.Text = "1*";
            this.labelZnámka.Visible = false;
            this.labelZnámka.Click += new System.EventHandler(this.labelZnámka_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 24);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(784, 25);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 12;
            // 
            // textBoxHistorie
            // 
            this.textBoxHistorie.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxHistorie.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHistorie.Location = new System.Drawing.Point(12, 240);
            this.textBoxHistorie.Multiline = true;
            this.textBoxHistorie.Name = "textBoxHistorie";
            this.textBoxHistorie.ReadOnly = true;
            this.textBoxHistorie.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHistorie.Size = new System.Drawing.Size(760, 109);
            this.textBoxHistorie.TabIndex = 13;
            this.textBoxHistorie.TabStop = false;
            this.textBoxHistorie.Visible = false;
            // 
            // LstopkyT
            // 
            this.LstopkyT.AutoSize = true;
            this.LstopkyT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LstopkyT.Location = new System.Drawing.Point(40, 215);
            this.LstopkyT.Name = "LstopkyT";
            this.LstopkyT.Size = new System.Drawing.Size(64, 17);
            this.LstopkyT.TabIndex = 14;
            this.LstopkyT.Text = "00:00:00";
            // 
            // LStopky
            // 
            this.LStopky.AutoSize = true;
            this.LStopky.Location = new System.Drawing.Point(12, 220);
            this.LStopky.Name = "LStopky";
            this.LStopky.Size = new System.Drawing.Size(28, 13);
            this.LStopky.TabIndex = 15;
            this.LStopky.Text = "Čas:";
            // 
            // LVýsledekT
            // 
            this.LVýsledekT.AutoSize = true;
            this.LVýsledekT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LVýsledekT.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LVýsledekT.Location = new System.Drawing.Point(733, 215);
            this.LVýsledekT.Name = "LVýsledekT";
            this.LVýsledekT.Size = new System.Drawing.Size(19, 20);
            this.LVýsledekT.TabIndex = 10;
            this.LVýsledekT.Text = "0";
            // 
            // LŠpatněT
            // 
            this.LŠpatněT.AutoSize = true;
            this.LŠpatněT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LŠpatněT.ForeColor = System.Drawing.Color.Red;
            this.LŠpatněT.Location = new System.Drawing.Point(620, 215);
            this.LŠpatněT.Name = "LŠpatněT";
            this.LŠpatněT.Size = new System.Drawing.Size(19, 20);
            this.LŠpatněT.TabIndex = 8;
            this.LŠpatněT.Text = "0";
            // 
            // LSprávnéT
            // 
            this.LSprávnéT.AutoSize = true;
            this.LSprávnéT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LSprávnéT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LSprávnéT.Location = new System.Drawing.Point(535, 215);
            this.LSprávnéT.Name = "LSprávnéT";
            this.LSprávnéT.Size = new System.Drawing.Size(19, 20);
            this.LSprávnéT.TabIndex = 7;
            this.LSprávnéT.Text = "0";
            // 
            // LZbývajícíT
            // 
            this.LZbývajícíT.AutoSize = true;
            this.LZbývajícíT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LZbývajícíT.Location = new System.Drawing.Point(335, 215);
            this.LZbývajícíT.Name = "LZbývajícíT";
            this.LZbývajícíT.Size = new System.Drawing.Size(29, 20);
            this.LZbývajícíT.TabIndex = 6;
            this.LZbývajícíT.Text = "10";
            // 
            // LPočetT
            // 
            this.LPočetT.AutoSize = true;
            this.LPočetT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LPočetT.Location = new System.Drawing.Point(235, 215);
            this.LPočetT.Name = "LPočetT";
            this.LPočetT.Size = new System.Drawing.Size(29, 20);
            this.LPočetT.TabIndex = 5;
            this.LPočetT.Text = "10";
            // 
            // LŠpatně
            // 
            this.LŠpatně.AutoSize = true;
            this.LŠpatně.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LŠpatně.Location = new System.Drawing.Point(575, 220);
            this.LŠpatně.Name = "LŠpatně";
            this.LŠpatně.Size = new System.Drawing.Size(49, 13);
            this.LŠpatně.TabIndex = 4;
            this.LŠpatně.Text = "Špatně:";
            // 
            // LSprávné
            // 
            this.LSprávné.AutoSize = true;
            this.LSprávné.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LSprávné.Location = new System.Drawing.Point(485, 220);
            this.LSprávné.Name = "LSprávné";
            this.LSprávné.Size = new System.Drawing.Size(55, 13);
            this.LSprávné.TabIndex = 3;
            this.LSprávné.Text = "Správné:";
            // 
            // LZbývající
            // 
            this.LZbývající.AutoSize = true;
            this.LZbývající.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LZbývající.Location = new System.Drawing.Point(275, 220);
            this.LZbývající.Name = "LZbývající";
            this.LZbývající.Size = new System.Drawing.Size(67, 13);
            this.LZbývající.TabIndex = 2;
            this.LZbývající.Text = "Zbývající:";
            // 
            // LPočet
            // 
            this.LPočet.AutoSize = true;
            this.LPočet.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LPočet.Location = new System.Drawing.Point(145, 220);
            this.LPočet.Name = "LPočet";
            this.LPočet.Size = new System.Drawing.Size(91, 13);
            this.LPočet.TabIndex = 1;
            this.LPočet.Text = "Celkový počet:";
            // 
            // LÚspěšnost
            // 
            this.LÚspěšnost.AutoSize = true;
            this.LÚspěšnost.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LÚspěšnost.Location = new System.Drawing.Point(660, 220);
            this.LÚspěšnost.Name = "LÚspěšnost";
            this.LÚspěšnost.Size = new System.Drawing.Size(79, 13);
            this.LÚspěšnost.TabIndex = 9;
            this.LÚspěšnost.Text = "Úspěšnost %:";
            // 
            // labelJménoHráče
            // 
            this.labelJménoHráče.AutoSize = true;
            this.labelJménoHráče.BackColor = System.Drawing.Color.White;
            this.labelJménoHráče.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelJménoHráče.Location = new System.Drawing.Point(19, 52);
            this.labelJménoHráče.Name = "labelJménoHráče";
            this.labelJménoHráče.Size = new System.Drawing.Size(0, 23);
            this.labelJménoHráče.TabIndex = 16;
            this.labelJménoHráče.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxPlus
            // 
            this.checkBoxPlus.AutoSize = true;
            this.checkBoxPlus.Checked = true;
            this.checkBoxPlus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPlus.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPlus.Location = new System.Drawing.Point(122, 74);
            this.checkBoxPlus.Name = "checkBoxPlus";
            this.checkBoxPlus.Size = new System.Drawing.Size(82, 23);
            this.checkBoxPlus.TabIndex = 17;
            this.checkBoxPlus.Text = "Sčítat";
            this.checkBoxPlus.UseVisualStyleBackColor = true;
            this.checkBoxPlus.Visible = false;
            this.checkBoxPlus.CheckedChanged += new System.EventHandler(this.checkBoxPlus_CheckedChanged);
            // 
            // checkBoxMínus
            // 
            this.checkBoxMínus.AutoSize = true;
            this.checkBoxMínus.Checked = true;
            this.checkBoxMínus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMínus.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxMínus.Location = new System.Drawing.Point(122, 94);
            this.checkBoxMínus.Name = "checkBoxMínus";
            this.checkBoxMínus.Size = new System.Drawing.Size(100, 23);
            this.checkBoxMínus.TabIndex = 18;
            this.checkBoxMínus.Text = "Odečítat";
            this.checkBoxMínus.UseVisualStyleBackColor = true;
            this.checkBoxMínus.Visible = false;
            this.checkBoxMínus.CheckedChanged += new System.EventHandler(this.checkBoxMínus_CheckedChanged);
            // 
            // checkBoxNásobit
            // 
            this.checkBoxNásobit.AutoSize = true;
            this.checkBoxNásobit.Checked = true;
            this.checkBoxNásobit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNásobit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxNásobit.Location = new System.Drawing.Point(122, 119);
            this.checkBoxNásobit.Name = "checkBoxNásobit";
            this.checkBoxNásobit.Size = new System.Drawing.Size(91, 23);
            this.checkBoxNásobit.TabIndex = 19;
            this.checkBoxNásobit.Text = "Násobit";
            this.checkBoxNásobit.UseVisualStyleBackColor = true;
            this.checkBoxNásobit.Visible = false;
            this.checkBoxNásobit.CheckedChanged += new System.EventHandler(this.checkBoxNásobit_CheckedChanged);
            // 
            // checkBoxDělit
            // 
            this.checkBoxDělit.AutoSize = true;
            this.checkBoxDělit.Checked = true;
            this.checkBoxDělit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDělit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxDělit.Location = new System.Drawing.Point(122, 141);
            this.checkBoxDělit.Name = "checkBoxDělit";
            this.checkBoxDělit.Size = new System.Drawing.Size(73, 23);
            this.checkBoxDělit.TabIndex = 20;
            this.checkBoxDělit.Text = "Dělit";
            this.checkBoxDělit.UseVisualStyleBackColor = true;
            this.checkBoxDělit.Visible = false;
            this.checkBoxDělit.CheckedChanged += new System.EventHandler(this.checkBoxDělit_CheckedChanged);
            // 
            // textBoxČ1od
            // 
            this.textBoxČ1od.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxČ1od.Location = new System.Drawing.Point(28, 100);
            this.textBoxČ1od.MaxLength = 2;
            this.textBoxČ1od.Name = "textBoxČ1od";
            this.textBoxČ1od.Size = new System.Drawing.Size(40, 36);
            this.textBoxČ1od.TabIndex = 21;
            this.textBoxČ1od.Text = "0";
            this.textBoxČ1od.Visible = false;
            this.textBoxČ1od.TextChanged += new System.EventHandler(this.textBoxČ1od_TextChanged);
            // 
            // textBoxČ1do
            // 
            this.textBoxČ1do.Font = new System.Drawing.Font("Consolas", 18F);
            this.textBoxČ1do.Location = new System.Drawing.Point(74, 100);
            this.textBoxČ1do.MaxLength = 2;
            this.textBoxČ1do.Name = "textBoxČ1do";
            this.textBoxČ1do.Size = new System.Drawing.Size(40, 36);
            this.textBoxČ1do.TabIndex = 22;
            this.textBoxČ1do.Text = "10";
            this.textBoxČ1do.Visible = false;
            // 
            // textBoxČ2od
            // 
            this.textBoxČ2od.Font = new System.Drawing.Font("Consolas", 18F);
            this.textBoxČ2od.Location = new System.Drawing.Point(228, 100);
            this.textBoxČ2od.MaxLength = 2;
            this.textBoxČ2od.Name = "textBoxČ2od";
            this.textBoxČ2od.Size = new System.Drawing.Size(40, 36);
            this.textBoxČ2od.TabIndex = 23;
            this.textBoxČ2od.Text = "0";
            this.textBoxČ2od.Visible = false;
            this.textBoxČ2od.TextChanged += new System.EventHandler(this.textBoxČ2od_TextChanged);
            // 
            // textBoxČ2do
            // 
            this.textBoxČ2do.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxČ2do.Location = new System.Drawing.Point(275, 100);
            this.textBoxČ2do.MaxLength = 2;
            this.textBoxČ2do.Name = "textBoxČ2do";
            this.textBoxČ2do.Size = new System.Drawing.Size(40, 36);
            this.textBoxČ2do.TabIndex = 24;
            this.textBoxČ2do.Text = "10";
            this.textBoxČ2do.Visible = false;
            // 
            // labelVýsledek
            // 
            this.labelVýsledek.AutoSize = true;
            this.labelVýsledek.BackColor = System.Drawing.Color.Transparent;
            this.labelVýsledek.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVýsledek.Location = new System.Drawing.Point(469, 252);
            this.labelVýsledek.Name = "labelVýsledek";
            this.labelVýsledek.Size = new System.Drawing.Size(98, 23);
            this.labelVýsledek.TabIndex = 25;
            this.labelVýsledek.Text = "Výsledek";
            this.labelVýsledek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVýsledek.Visible = false;
            // 
            // textBoxPočetPříkladů
            // 
            this.textBoxPočetPříkladů.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPočetPříkladů.Location = new System.Drawing.Point(546, 76);
            this.textBoxPočetPříkladů.MaxLength = 2;
            this.textBoxPočetPříkladů.Name = "textBoxPočetPříkladů";
            this.textBoxPočetPříkladů.Size = new System.Drawing.Size(40, 36);
            this.textBoxPočetPříkladů.TabIndex = 26;
            this.textBoxPočetPříkladů.Text = "10";
            this.textBoxPočetPříkladů.Visible = false;
            this.textBoxPočetPříkladů.TextChanged += new System.EventHandler(this.textBoxPočetPříkladů_TextChanged);
            // 
            // buttonZkontroluj
            // 
            this.buttonZkontroluj.Font = new System.Drawing.Font("Consolas", 13.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZkontroluj.Location = new System.Drawing.Point(400, 100);
            this.buttonZkontroluj.Name = "buttonZkontroluj";
            this.buttonZkontroluj.Size = new System.Drawing.Size(100, 50);
            this.buttonZkontroluj.TabIndex = 27;
            this.buttonZkontroluj.Text = "✔";
            this.buttonZkontroluj.UseVisualStyleBackColor = true;
            this.buttonZkontroluj.Click += new System.EventHandler(this.buttonZkontroluj_Click);
            // 
            // textBoxZadejJméno
            // 
            this.textBoxZadejJméno.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxZadejJméno.Location = new System.Drawing.Point(229, 13);
            this.textBoxZadejJméno.Name = "textBoxZadejJméno";
            this.textBoxZadejJméno.Size = new System.Drawing.Size(287, 32);
            this.textBoxZadejJméno.TabIndex = 28;
            this.textBoxZadejJméno.Text = "---";
            this.textBoxZadejJméno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxZadejJméno.Visible = false;
            this.textBoxZadejJméno.Click += new System.EventHandler(this.textBoxZadejJméno_Click);
            this.textBoxZadejJméno.TextChanged += new System.EventHandler(this.textBoxZadejJméno_TextChanged);
            // 
            // labelPočetPříkladů
            // 
            this.labelPočetPříkladů.AutoSize = true;
            this.labelPočetPříkladů.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPočetPříkladů.Location = new System.Drawing.Point(346, 79);
            this.labelPočetPříkladů.Name = "labelPočetPříkladů";
            this.labelPočetPříkladů.Size = new System.Drawing.Size(194, 28);
            this.labelPočetPříkladů.TabIndex = 29;
            this.labelPočetPříkladů.Text = "Počet příkladů";
            this.labelPočetPříkladů.Visible = false;
            // 
            // buttonUložNastavení
            // 
            this.buttonUložNastavení.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUložNastavení.Location = new System.Drawing.Point(624, 139);
            this.buttonUložNastavení.Name = "buttonUložNastavení";
            this.buttonUložNastavení.Size = new System.Drawing.Size(133, 32);
            this.buttonUložNastavení.TabIndex = 30;
            this.buttonUložNastavení.Text = "Ulož nastavení";
            this.buttonUložNastavení.UseVisualStyleBackColor = true;
            this.buttonUložNastavení.Visible = false;
            this.buttonUložNastavení.Click += new System.EventHandler(this.buttonUložNastavení_Click);
            // 
            // checkBoxStopky
            // 
            this.checkBoxStopky.AutoSize = true;
            this.checkBoxStopky.Checked = true;
            this.checkBoxStopky.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStopky.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxStopky.Location = new System.Drawing.Point(28, 148);
            this.checkBoxStopky.Name = "checkBoxStopky";
            this.checkBoxStopky.Size = new System.Drawing.Size(163, 23);
            this.checkBoxStopky.TabIndex = 31;
            this.checkBoxStopky.Text = "Zobrazit stopky";
            this.checkBoxStopky.UseVisualStyleBackColor = true;
            this.checkBoxStopky.Visible = false;
            this.checkBoxStopky.CheckedChanged += new System.EventHandler(this.checkBoxStopky_CheckedChanged);
            // 
            // checkBoxZobrazitOstatní
            // 
            this.checkBoxZobrazitOstatní.AutoSize = true;
            this.checkBoxZobrazitOstatní.Checked = true;
            this.checkBoxZobrazitOstatní.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxZobrazitOstatní.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxZobrazitOstatní.Location = new System.Drawing.Point(197, 148);
            this.checkBoxZobrazitOstatní.Name = "checkBoxZobrazitOstatní";
            this.checkBoxZobrazitOstatní.Size = new System.Drawing.Size(226, 23);
            this.checkBoxZobrazitOstatní.TabIndex = 32;
            this.checkBoxZobrazitOstatní.Text = "Zobrazit ostatní údaje";
            this.checkBoxZobrazitOstatní.UseVisualStyleBackColor = true;
            this.checkBoxZobrazitOstatní.Visible = false;
            this.checkBoxZobrazitOstatní.CheckedChanged += new System.EventHandler(this.checkBoxZobrazitOstatní_CheckedChanged);
            // 
            // gBnastavení
            // 
            this.gBnastavení.Controls.Add(this.bBílá);
            this.gBnastavení.Controls.Add(this.bŠedá);
            this.gBnastavení.Controls.Add(this.checkBoxMínusVýsledek);
            this.gBnastavení.Controls.Add(this.labelJméno);
            this.gBnastavení.Controls.Add(this.checkBoxZvuky);
            this.gBnastavení.Controls.Add(this.textBoxZadejJméno);
            this.gBnastavení.Controls.Add(this.checkBoxZobrazitOstatní);
            this.gBnastavení.Controls.Add(this.labelPočetPříkladů);
            this.gBnastavení.Controls.Add(this.checkBoxStopky);
            this.gBnastavení.Controls.Add(this.textBoxPočetPříkladů);
            this.gBnastavení.Controls.Add(this.buttonUložNastavení);
            this.gBnastavení.Location = new System.Drawing.Point(0, 24);
            this.gBnastavení.Name = "gBnastavení";
            this.gBnastavení.Size = new System.Drawing.Size(296, 188);
            this.gBnastavení.TabIndex = 33;
            this.gBnastavení.TabStop = false;
            this.gBnastavení.Text = "Nastavení";
            this.gBnastavení.Visible = false;
            // 
            // checkBoxMínusVýsledek
            // 
            this.checkBoxMínusVýsledek.AutoSize = true;
            this.checkBoxMínusVýsledek.Checked = true;
            this.checkBoxMínusVýsledek.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMínusVýsledek.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxMínusVýsledek.Location = new System.Drawing.Point(228, 50);
            this.checkBoxMínusVýsledek.Name = "checkBoxMínusVýsledek";
            this.checkBoxMínusVýsledek.Size = new System.Drawing.Size(334, 23);
            this.checkBoxMínusVýsledek.TabIndex = 35;
            this.checkBoxMínusVýsledek.Text = "Odečítat pouze s kladným výsledkem";
            this.checkBoxMínusVýsledek.UseVisualStyleBackColor = true;
            this.checkBoxMínusVýsledek.Visible = false;
            // 
            // labelJméno
            // 
            this.labelJméno.AutoSize = true;
            this.labelJméno.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelJméno.Location = new System.Drawing.Point(69, 16);
            this.labelJméno.Name = "labelJméno";
            this.labelJméno.Size = new System.Drawing.Size(155, 28);
            this.labelJméno.TabIndex = 34;
            this.labelJméno.Text = "Zadej jméno";
            this.labelJméno.Visible = false;
            // 
            // checkBoxZvuky
            // 
            this.checkBoxZvuky.AutoSize = true;
            this.checkBoxZvuky.Checked = true;
            this.checkBoxZvuky.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxZvuky.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxZvuky.Location = new System.Drawing.Point(429, 148);
            this.checkBoxZvuky.Name = "checkBoxZvuky";
            this.checkBoxZvuky.Size = new System.Drawing.Size(73, 23);
            this.checkBoxZvuky.TabIndex = 33;
            this.checkBoxZvuky.Text = "Zvuky";
            this.checkBoxZvuky.UseVisualStyleBackColor = true;
            this.checkBoxZvuky.Visible = false;
            // 
            // labelKonec
            // 
            this.labelKonec.AutoSize = true;
            this.labelKonec.BackColor = System.Drawing.Color.Transparent;
            this.labelKonec.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKonec.Location = new System.Drawing.Point(120, 151);
            this.labelKonec.Name = "labelKonec";
            this.labelKonec.Size = new System.Drawing.Size(130, 47);
            this.labelKonec.TabIndex = 34;
            this.labelKonec.Text = "KONEC";
            this.labelKonec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelKonec.Visible = false;
            // 
            // stopky
            // 
            this.stopky.Tick += new System.EventHandler(this.stopky_Tick);
            // 
            // timerČervená
            // 
            this.timerČervená.Interval = 300;
            this.timerČervená.Tick += new System.EventHandler(this.timerČervená_Tick);
            // 
            // bŠedá
            // 
            this.bŠedá.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bŠedá.Location = new System.Drawing.Point(624, 97);
            this.bŠedá.Name = "bŠedá";
            this.bŠedá.Size = new System.Drawing.Size(75, 23);
            this.bŠedá.TabIndex = 36;
            this.bŠedá.Text = "Šedá";
            this.bŠedá.UseVisualStyleBackColor = false;
            this.bŠedá.Click += new System.EventHandler(this.bŠedá_Click);
            // 
            // bBílá
            // 
            this.bBílá.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bBílá.Location = new System.Drawing.Point(624, 68);
            this.bBílá.Name = "bBílá";
            this.bBílá.Size = new System.Drawing.Size(75, 23);
            this.bBílá.TabIndex = 37;
            this.bBílá.Text = "Bílá";
            this.bBílá.UseVisualStyleBackColor = false;
            this.bBílá.Click += new System.EventHandler(this.bBílá_Click);
            // 
            // oknoProgramu
            // 
            this.AcceptButton = this.buttonZkontroluj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.labelKonec);
            this.Controls.Add(this.textBoxČ2od);
            this.Controls.Add(this.labelVýsledek);
            this.Controls.Add(this.textBoxČ2do);
            this.Controls.Add(this.textBoxČ1do);
            this.Controls.Add(this.textBoxČ1od);
            this.Controls.Add(this.checkBoxDělit);
            this.Controls.Add(this.checkBoxNásobit);
            this.Controls.Add(this.checkBoxMínus);
            this.Controls.Add(this.checkBoxPlus);
            this.Controls.Add(this.LStopky);
            this.Controls.Add(this.LVýsledekT);
            this.Controls.Add(this.LstopkyT);
            this.Controls.Add(this.LÚspěšnost);
            this.Controls.Add(this.textBoxHistorie);
            this.Controls.Add(this.LŠpatněT);
            this.Controls.Add(this.LŠpatně);
            this.Controls.Add(this.LSprávnéT);
            this.Controls.Add(this.LZbývajícíT);
            this.Controls.Add(this.LSprávné);
            this.Controls.Add(this.LPočetT);
            this.Controls.Add(this.LZbývající);
            this.Controls.Add(this.LPočet);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gBnastavení);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonZkontroluj);
            this.Controls.Add(this.textBoxVýsledek);
            this.Controls.Add(this.labelPříkladČ1);
            this.Controls.Add(this.labelRovnáSe);
            this.Controls.Add(this.labelPříkladČ2);
            this.Controls.Add(this.labelZnaménko);
            this.Controls.Add(this.labelZnámka);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelJménoHráče);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "oknoProgramu";
            this.Text = "Generátor matematických příkladů 2";
            this.RightToLeftLayoutChanged += new System.EventHandler(this.oknoProgramu_ResizeBegin);
            this.Shown += new System.EventHandler(this.oknoProgramu_ResizeBegin);
            this.ResizeBegin += new System.EventHandler(this.oknoProgramu_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.oknoProgramu_ResizeBegin);
            this.EnabledChanged += new System.EventHandler(this.oknoProgramu_ResizeBegin);
            this.RightToLeftChanged += new System.EventHandler(this.oknoProgramu_ResizeBegin);
            this.SizeChanged += new System.EventHandler(this.oknoProgramu_ResizeBegin);
            this.Move += new System.EventHandler(this.oknoProgramu_ResizeBegin);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gBnastavení.ResumeLayout(false);
            this.gBnastavení.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastaveníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zobrazHistoriiToolStripMenuItem;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxVýsledek;
        private System.Windows.Forms.Label labelPříkladČ1;
        private System.Windows.Forms.Label labelZnaménko;
        private System.Windows.Forms.Label labelPříkladČ2;
        private System.Windows.Forms.Label labelRovnáSe;
        private System.Windows.Forms.Label labelZnámka;
        private System.Windows.Forms.ToolStripMenuItem zastavPočítáníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smazatHistoriiToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textBoxHistorie;
        private System.Windows.Forms.Label LstopkyT;
        private System.Windows.Forms.Label LStopky;
        private System.Windows.Forms.Label LVýsledekT;
        private System.Windows.Forms.Label LŠpatněT;
        private System.Windows.Forms.Label LSprávnéT;
        private System.Windows.Forms.Label LZbývajícíT;
        private System.Windows.Forms.Label LPočetT;
        private System.Windows.Forms.Label LŠpatně;
        private System.Windows.Forms.Label LSprávné;
        private System.Windows.Forms.Label LZbývající;
        private System.Windows.Forms.Label LPočet;
        private System.Windows.Forms.Label LÚspěšnost;
        private System.Windows.Forms.Label labelJménoHráče;
        private System.Windows.Forms.CheckBox checkBoxPlus;
        private System.Windows.Forms.CheckBox checkBoxMínus;
        private System.Windows.Forms.CheckBox checkBoxNásobit;
        private System.Windows.Forms.CheckBox checkBoxDělit;
        private System.Windows.Forms.TextBox textBoxČ1od;
        private System.Windows.Forms.TextBox textBoxČ1do;
        private System.Windows.Forms.TextBox textBoxČ2od;
        private System.Windows.Forms.TextBox textBoxČ2do;
        private System.Windows.Forms.Label labelVýsledek;
        private System.Windows.Forms.TextBox textBoxPočetPříkladů;
        private System.Windows.Forms.Button buttonZkontroluj;
        private System.Windows.Forms.TextBox textBoxZadejJméno;
        private System.Windows.Forms.Label labelPočetPříkladů;
        private System.Windows.Forms.Button buttonUložNastavení;
        private System.Windows.Forms.CheckBox checkBoxStopky;
        private System.Windows.Forms.CheckBox checkBoxZobrazitOstatní;
        private System.Windows.Forms.GroupBox gBnastavení;
        private System.Windows.Forms.CheckBox checkBoxZvuky;
        private System.Windows.Forms.Label labelKonec;
        private System.Windows.Forms.Timer stopky;
        private System.Windows.Forms.Label labelJméno;
        private System.Windows.Forms.CheckBox checkBoxMínusVýsledek;
        private System.Windows.Forms.Timer timerČervená;
        private System.Windows.Forms.Button bŠedá;
        private System.Windows.Forms.Button bBílá;
    }
}

