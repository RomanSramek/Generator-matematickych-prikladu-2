using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
// TEST GIT 2.4.2023


namespace Generáto_matematických_příkladů_2
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
            // nastavení standardní hodnoty
            celkovýPočetPříkladů = 10;
            // otevření souboru historie
            try
            {
                using (var sr = new StreamReader("../Uložené_výsledky_matematika_2.txt"))
                {
                    textBoxHistorie.Text = (sr.ReadToEnd());
                }
            }
            catch
            {
                //MessageBox.Show("Uložené_výsledky_matematika_2.txt(Soubor nenalezen)");
                //Raději txt znovu vytoříme jinak to padne
                using (var zapisovac = File.CreateText("../Uložené_výsledky_matematika_2.txt"))
                {
                    zapisovac.Write("");
                }
            }
        }

        // velikost okna, fontu a posunu v proměnné
        int velikostOknaY, velikostOknaX, velikostFontu, poziceZnaménko, poziceČ2, poziceRovnáSe, pozicePoleVýsledek,
            poziceTlačítko, poziceZnámka, pozicePoleHistorie, početSprávnýchVýsledků, početŠpatnýchVýsledku,
            celkovýPočetPříkladů, celkovýPočetProgress;
        
        double procentuálníÚspěšnost, celkovýPočetPříkladůProProcenta, SprávnéPříklady;

        private void checkBoxMínus_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBoxPlus.Checked == false && checkBoxNásobit.Checked == false && checkBoxDělit.Checked == false)
            {
                checkBoxPlus.Checked = true;
            }    
        }

        private void checkBoxNásobit_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlus.Checked == false && checkBoxMínus.Checked == false && checkBoxDělit.Checked == false)
            {
                checkBoxDělit.Checked = true;
            }
        }

        private void checkBoxDělit_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlus.Checked == false && checkBoxMínus.Checked == false && checkBoxNásobit.Checked == false)
            {
                checkBoxNásobit.Checked = true;
            }
        }

        private void checkBoxZobrazitOstatní_CheckedChanged(object sender, EventArgs e)
        {
            // zobrazení ostatních údajů
            if(checkBoxZobrazitOstatní.Checked == true)
            {
                LPočet.Visible = true;
                LPočetT.Visible = true;
                LZbývající.Visible = true;
                LZbývajícíT.Visible = true;
                LSprávné.Visible = true;
                LSprávnéT.Visible = true;
                LŠpatně.Visible = true;
                LŠpatněT.Visible = true;
                LÚspěšnost.Visible = true;
                LVýsledekT.Visible = true;
            }
            else
            {
                LPočet.Visible = false;
                LPočetT.Visible = false;
                LZbývající.Visible = false;
                LZbývajícíT.Visible = false;
                LSprávné.Visible = false;
                LSprávnéT.Visible = false;
                LŠpatně.Visible = false;
                LŠpatněT.Visible = false;
                LÚspěšnost.Visible = false;
                LVýsledekT.Visible = false;
            }
        }

        private void smazatHistoriiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // přepsání veškerého textu v historii
            using (var zapisovac = File.CreateText("../Uložené_výsledky_matematika_2.txt"))
            {
                zapisovac.Write("");
            }
            // otevření txt souboru
            using (var sr = new StreamReader("../Uložené_výsledky_matematika_2.txt"))
            {
                textBoxHistorie.Text = (sr.ReadToEnd());
            }

            historie = null;
            historieProŠpatnýVýsledek = null;
            špatnýVýsledekDoHistorie = null;

            if (checkBoxZvuky.Checked == true)
            {
                // Přehrání zvuku pokud se požaduje
                SoundPlayer melodie = new SoundPlayer(Properties.Resources.smazaniHistorie);
                melodie.Play();
            }
        }

        private void textBoxZadejJméno_Click(object sender, EventArgs e)
        {
            textBoxZadejJméno.Text = null;
        }

        private void textBoxČ1od_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Pokud je zádané číslo 1od větší jak číslo 1do  
                int čísloOD1 = Convert.ToInt32(textBoxČ1od.Text);
                int čísloDO1 = Convert.ToInt32(textBoxČ1do.Text);

                if (čísloOD1 > čísloDO1)
                {
                    čísloDO1 = čísloOD1 + 1;
                    textBoxČ1do.Text = Convert.ToString(čísloDO1);
                }
            }
            catch
            {

            }
        }

        private void textBoxČ2od_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Pokud je zádané číslo 2od větší jak číslo 2do  
                int čísloOD2 = Convert.ToInt32(textBoxČ2od.Text);
                int čísloDO2 = Convert.ToInt32(textBoxČ2do.Text);

                if (čísloOD2 > čísloDO2)
                {
                    čísloDO2 = čísloOD2 + 1;
                    textBoxČ2do.Text = Convert.ToString(čísloDO2);
                }
            }
            catch
            {

            }
        }

        // Stopky
        DateTime start;
        TimeSpan ts;
        private void stopky_Tick(object sender, EventArgs e)
        {
            // stopky
            ts = DateTime.Now - start;
            LstopkyT.Text = String.Format("{0:hh\\:mm\\:ss}", ts);
        }

        private void checkBoxPlus_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNásobit.Checked == false && checkBoxMínus.Checked == false && checkBoxDělit.Checked == false)
            {
                checkBoxMínus.Checked = true;
            }
        }

        private void timerČervená_Tick(object sender, EventArgs e)
        {
            textBoxVýsledek.BackColor = Color.White;
            timerČervená.Enabled = false;
        }

        private void labelZnámka_Click(object sender, EventArgs e)
        {
            // easter egg v podobě textu podle úspěšnosti
            
            double skóre = procentuálníÚspěšnost / 10;
            switch (skóre)
            {
                case 0:
                    if (checkBoxZvuky.Checked == true)
                    {
                        // Přehrání zvuku pokud se požaduje
                        SoundPlayer melodie = new SoundPlayer(Properties.Resources._5);
                        melodie.Play();
                    }
                    MessageBox.Show("S tím už nic neuděláš");
                    break;
                case 1:
                    if (checkBoxZvuky.Checked == true)
                    {
                        // Přehrání zvuku pokud se požaduje
                        SoundPlayer melodie = new SoundPlayer(Properties.Resources._5);
                        melodie.Play();
                    }
                    MessageBox.Show("Tohle je na pováženou!");
                    break;
                case 2:
                    if (checkBoxZvuky.Checked == true)
                    {
                        // Přehrání zvuku pokud se požaduje
                        SoundPlayer melodie = new SoundPlayer(Properties.Resources._4);
                        melodie.Play();
                    }
                    MessageBox.Show("Tohle bylo o fous");
                    break;
                case 3:
                    if (checkBoxZvuky.Checked == true)
                    {
                        // Přehrání zvuku pokud se požaduje
                        SoundPlayer melodie = new SoundPlayer(Properties.Resources._4);
                        melodie.Play();
                    }
                    MessageBox.Show("No... dá se to");
                    break;
                case 4:
                    if (checkBoxZvuky.Checked == true)
                    {
                        // Přehrání zvuku pokud se požaduje
                        SoundPlayer melodie = new SoundPlayer(Properties.Resources._3);
                        melodie.Play();
                    }
                    MessageBox.Show("Pořád se dá co zlepšovat");
                    break;
                case 5:
                    if (checkBoxZvuky.Checked == true)
                    {
                        // Přehrání zvuku pokud se požaduje
                        SoundPlayer melodie = new SoundPlayer(Properties.Resources._3);
                        melodie.Play();
                    }
                    MessageBox.Show("No šlo by to lépe");
                    break;
                case 6:
                    if (checkBoxZvuky.Checked == true)
                    {
                        // Přehrání zvuku pokud se požaduje
                        SoundPlayer melodie = new SoundPlayer(Properties.Resources._2);
                        melodie.Play();
                    }
                    MessageBox.Show("Pořád se dá trénovat");
                    break;
                case 7:
                    if (checkBoxZvuky.Checked == true)
                    {
                        // Přehrání zvuku pokud se požaduje
                        SoundPlayer melodie = new SoundPlayer(Properties.Resources._2);
                        melodie.Play();
                    }
                    MessageBox.Show("Dobrý výsledek");
                    break;
                case 8:
                    if (checkBoxZvuky.Checked == true)
                    {
                        // Přehrání zvuku pokud se požaduje
                        SoundPlayer melodie = new SoundPlayer(Properties.Resources._1);
                        melodie.Play();
                    }
                    MessageBox.Show("To ujde");
                    break;
                case 9:
                    if (checkBoxZvuky.Checked == true)
                    {
                        // Přehrání zvuku pokud se požaduje
                        SoundPlayer melodie = new SoundPlayer(Properties.Resources._1);
                        melodie.Play();
                    }
                    MessageBox.Show("Jen kousek ti chyběl k nejlepšímu výsledku");
                    break;
                case 10:
                    if (checkBoxZvuky.Checked == true)
                    {
                        // Přehrání zvuku pokud se požaduje
                        SoundPlayer melodie = new SoundPlayer(Properties.Resources._1);
                        melodie.Play();
                    }
                    MessageBox.Show("Skvěle! Lépe už to nejde!!!");
                    break;

                default:
                    MessageBox.Show("Neplatné skóre!Tohle není to tvá chyba.");
                    break;
            }
        }

        private void checkBoxStopky_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxStopky.Checked == true)
            {
                LStopky.Visible = true;
                LstopkyT.Visible = true;
            }
            else
            {
                LStopky.Visible = false;
                LstopkyT.Visible = false;
            }
        }

        private void textBoxPočetPříkladů_TextChanged(object sender, EventArgs e)
        {
            try
            {
                celkovýPočetPříkladů = Convert.ToInt32(textBoxPočetPříkladů.Text);
                LZbývajícíT.Text = Convert.ToString(celkovýPočetPříkladů);
                
                if( celkovýPočetPříkladů <= 0)
                {
                    celkovýPočetPříkladů = 1;
                    textBoxPočetPříkladů.Text = Convert.ToString(celkovýPočetPříkladů);
                }
            }
            catch
            {

            }
        }

        private void zastavPočítáníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // vymazání proměnné pro historii
            špatnýVýsledekDoHistorie = null;

            // resetování do původních hodnot
            LZbývajícíT.Text = Convert.ToString(celkovýPočetPříkladů);
            procentuálníÚspěšnost = 0;
            progressBar.Value = 0;
            celkovýPočetPříkladůProProcenta = 0;
            SprávnéPříklady = 0;
            početSprávnýchVýsledků = 0;
            labelZnámka.Visible = false;

            // Stopky STOP
            stopky.Enabled = false;
            ts = DateTime.Now - start;
            LstopkyT.Text = String.Format("{0:hh\\:mm\\:ss}", ts);

            //Vynulování STOPEK
            ts = DateTime.Now - start;
            LstopkyT.Text = String.Format("00:00:00");

            LSprávnéT.Text = "0";
            LZbývajícíT.Text = "0";
            LSprávnéT.Text = "0";
            LŠpatněT.Text = "0";
            LVýsledekT.Text = "0";

            // změna viditelnosti prvků
            smazatHistoriiToolStripMenuItem.Enabled = true;
            labelPříkladČ1.Visible = false;
            labelZnaménko.Visible = false;
            labelPříkladČ2.Visible = false;
            labelRovnáSe.Visible = false;
            textBoxVýsledek.Visible = false;
            buttonZkontroluj.Visible = false;
            buttonStart.Visible = true;

            // ukrytí tlačítka konec 
            labelKonec.Visible = false;
        }

        private void textBoxZadejJméno_TextChanged(object sender, EventArgs e)
        {
            labelJménoHráče.Text = ("Nyní počítá: " + textBoxZadejJméno.Text);
        }

        private void zobrazHistoriiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxHistorie.Visible = !textBoxHistorie.Visible;

            if (textBoxHistorie.Visible == true)
            {
                zobrazHistoriiToolStripMenuItem.Text = "Skryj historii";
            }
            else
            {
                zobrazHistoriiToolStripMenuItem.Text = "Zobraz historii";
            }
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUložNastavení_Click(object sender, EventArgs e)
        {
            gBnastavení.Visible = false;
            if (gBnastavení.Visible == true)
            {
                checkBoxMínusVýsledek.Visible = true;
                checkBoxZvuky.Visible = true;
                checkBoxStopky.Visible = true;
                checkBoxZobrazitOstatní.Visible = true;
                textBoxZadejJméno.Visible = true;
                textBoxČ1od.Visible = true;
                textBoxČ1do.Visible = true;
                checkBoxPlus.Visible = true;
                checkBoxMínus.Visible = true;
                checkBoxNásobit.Visible = true;
                checkBoxDělit.Visible = true;
                textBoxČ2od.Visible = true;
                textBoxČ2do.Visible = true;
                labelPočetPříkladů.Visible = true;
                textBoxPočetPříkladů.Visible = true;
                buttonUložNastavení.Visible = true;
                labelJménoHráče.Visible = false;
            }
            else
            {
                checkBoxMínusVýsledek.Visible = false;
                checkBoxStopky.Visible = false;
                checkBoxZobrazitOstatní.Visible = false;
                textBoxZadejJméno.Visible = false;
                textBoxČ1od.Visible = false;
                textBoxČ1do.Visible = false;
                checkBoxPlus.Visible = false;
                checkBoxMínus.Visible = false;
                checkBoxNásobit.Visible = false;
                checkBoxDělit.Visible = false;
                textBoxČ2od.Visible = false;
                textBoxČ2do.Visible = false;
                labelPočetPříkladů.Visible = false;
                textBoxPočetPříkladů.Visible = false;
                buttonUložNastavení.Visible = false;
                labelJménoHráče.Visible = true;
            }

            // resetování do původních hodnot
            celkovýPočetPříkladů = Convert.ToInt32(textBoxPočetPříkladů.Text);
            LZbývajícíT.Text = Convert.ToString(celkovýPočetPříkladů);
            
            procentuálníÚspěšnost = 0;
            progressBar.Value = 0;

            celkovýPočetPříkladůProProcenta = 0;
            SprávnéPříklady = 0;
            početSprávnýchVýsledků = 0;

            if (číslo1Od > číslo1Do)
            {
                číslo1Do = číslo1Od + 1;
                textBoxČ1do.Text = Convert.ToString(číslo1Do);
            }
            if (číslo2Od > číslo2Do)
            {
                číslo2Do = číslo2Od + 1;
                textBoxČ2do.Text = Convert.ToString(číslo2Do);
            }

            LSprávnéT.Text = "0";
            LZbývajícíT.Text = textBoxPočetPříkladů.Text;
            LSprávnéT.Text = "0";
            LŠpatněT.Text = "0";
            LVýsledekT.Text = "0";

            // změna viditelnosti prvků
            labelPříkladČ1.Visible = false;
            labelZnaménko.Visible = false;
            labelPříkladČ2.Visible = false;
            labelRovnáSe.Visible = false;
            textBoxVýsledek.Visible = false;
            buttonZkontroluj.Visible = false;
            buttonStart.Visible = true;

            //vypsání počtu zbývajících příkladů
            LPočetT.Text = Convert.ToString(celkovýPočetPříkladů);
        }

        private void nastaveníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // vymazání proměnné pro historii
            špatnýVýsledekDoHistorie = null;

            // Stopky STOP
            stopky.Enabled = false;
            ts = DateTime.Now - start;
            LstopkyT.Text = String.Format("{0:hh\\:mm\\:ss}", ts);

            //Vynulování STOPEK
            ts = DateTime.Now - start;
            LstopkyT.Text = String.Format("00:00:00");

            celkovýPočetPříkladů = Convert.ToInt32(textBoxPočetPříkladů.Text);
            LZbývajícíT.Text = Convert.ToString(celkovýPočetPříkladů);
            
            // zobrazení nastavení
            gBnastavení.Visible = !gBnastavení.Visible;

            smazatHistoriiToolStripMenuItem.Enabled = true;
            if (gBnastavení.Visible == true)
            {
                checkBoxMínusVýsledek.Visible = true;
                checkBoxZvuky.Visible = true;
                checkBoxStopky.Visible = true;
                checkBoxZobrazitOstatní.Visible = true;
                textBoxZadejJméno.Visible = true;
                textBoxČ1od.Visible = true;
                textBoxČ1do.Visible = true;
                checkBoxPlus.Visible = true;
                checkBoxMínus.Visible = true;
                checkBoxNásobit.Visible = true;
                checkBoxDělit.Visible = true;
                textBoxČ2od.Visible = true;
                textBoxČ2do.Visible = true;
                labelPočetPříkladů.Visible = true;
                textBoxPočetPříkladů.Visible = true;
                buttonUložNastavení.Visible = true;
                labelJménoHráče.Visible = false;
            }
            else
            {
                checkBoxMínusVýsledek.Visible = false;
                checkBoxStopky.Visible = false;
                checkBoxZobrazitOstatní.Visible = false;
                textBoxZadejJméno.Visible = false;
                textBoxČ1od.Visible = false;
                textBoxČ1do.Visible = false;
                checkBoxPlus.Visible = false;
                checkBoxMínus.Visible = false;
                checkBoxNásobit.Visible = false;
                checkBoxDělit.Visible = false;
                textBoxČ2od.Visible = false;
                textBoxČ2do.Visible = false;
                labelPočetPříkladů.Visible = false;
                textBoxPočetPříkladů.Visible = false;
                buttonUložNastavení.Visible = false;
                labelJménoHráče.Visible = true;
            }

            // resetování do původních hodnot
            celkovýPočetPříkladů = Convert.ToInt32(textBoxPočetPříkladů.Text);
            LZbývajícíT.Text = Convert.ToString(celkovýPočetPříkladů);
            procentuálníÚspěšnost = 0;
            progressBar.Value = 0;
            početŠpatnýchVýsledku = 0;
            celkovýPočetPříkladůProProcenta = 0;
            SprávnéPříklady = 0;
            početSprávnýchVýsledků = 0;

            labelKonec.Visible = false;

            LSprávnéT.Text = "0";
            LZbývajícíT.Text = textBoxPočetPříkladů.Text;
            LSprávnéT.Text = "0";
            LŠpatněT.Text = "0";
            LVýsledekT.Text = "0";

            // změna viditelnosti prvků
            labelPříkladČ1.Visible = false;
            labelZnaménko.Visible = false;
            labelPříkladČ2.Visible = false;
            labelRovnáSe.Visible = false;
            textBoxVýsledek.Visible = false;
            buttonZkontroluj.Visible = false;
            buttonStart.Visible = true;

            //vypsání počtu zbývajících příkladů
            LPočetT.Text = Convert.ToString(celkovýPočetPříkladů);

            // schování známky 
            labelZnámka.Visible = false;
        }

        private void buttonZkontroluj_Click(object sender, EventArgs e)
        {
            try
            {
                // načtení napsaného výsledku

                zadanýVýsledek = Convert.ToInt32(textBoxVýsledek.Text);

                // kontrola výsledku
                if (VÝSLEDEK == zadanýVýsledek)
                {
                    // (pro zobrazení) MessageBox.Show("správně");

                    // uložení správné odpovědi
                    početSprávnýchVýsledků +=1;
                    // vypsání správné odpovědi
                    LSprávnéT.Text = Convert.ToString(početSprávnýchVýsledků);

                    // odečet celkového počtu příkladů
                    celkovýPočetPříkladů -= 1;

                    //vypsání počtu zbývajících příkladů
                    LZbývajícíT.Text = Convert.ToString(celkovýPočetPříkladů);

                    if (checkBoxZvuky.Checked == true)
                    {
                        // Přehrání zvuku pokud se požaduje
                        SoundPlayer melodie = new SoundPlayer(Properties.Resources.SpravnaOdpoved);
                        melodie.Play();
                    }
                    // zezelenání pole do kterého se píše výsledek
                    timerČervená.Enabled = true;
                    textBoxVýsledek.BackColor = Color.Green;
                }
                else
                {
                    //Uložení špatně spočítaného příkladu do promměné
                    špatnýVýsledekDoHistorie += labelPříkladČ1.Text + labelZnaménko.Text + labelPříkladČ2.Text + " ≠ " + zadanýVýsledek + " || = " + VÝSLEDEK + "   ";

                    // (pro zobrazení) MessageBox.Show("špatně");
                    //uložení špatné odpovědi
                    početŠpatnýchVýsledku += 1;
                    // vypsání špatné odpovědi
                    LŠpatněT.Text = Convert.ToString(početŠpatnýchVýsledku);

                    // odečet celkového počtu příkladů
                    celkovýPočetPříkladů -= 1;

                    //vypsání počtu zbývajících příkladů
                    LZbývajícíT.Text = Convert.ToString(celkovýPočetPříkladů);

                    // zčervenání pole do kterého se píše výsledek
                    timerČervená.Enabled = true;
                    textBoxVýsledek.BackColor = Color.Red;

                    if (checkBoxZvuky.Checked == true)
                    {
                        // Přehrání zvuku pokud se požaduje
                        SoundPlayer melodie = new SoundPlayer(Properties.Resources.SpatnaOdpoved);
                        melodie.Play();
                    }

                    //Historie
                    if (početŠpatnýchVýsledku > 0)
                    {
                        sChybou = ("   Špatné výsledky: ");
                    }

                    // smazání historie
                    using (var zapisovac = File.CreateText("../Uložené_výsledky_matematika_2.txt"))
                    {
                        zapisovac.Write("");
                    }

                    // zapsání informace
                    using (var zapisovac = File.AppendText("../Uložené_výsledky_matematika_2.txt"))
                    {
                        zapisovac.WriteLine(historieProŠpatnýVýsledek + sChybou + špatnýVýsledekDoHistorie);
                        // zapsání původních hodnot aby byl nový text vždy nahoře
                        zapisovac.WriteLine(historie);

                        //zapisovac.Flush();
                    }
                    // znovu otevření souboru historie
                    using (var sr = new StreamReader("../Uložené_výsledky_matematika_2.txt"))
                    {
                        textBoxHistorie.Text = (sr.ReadToEnd());
                    }
                }

                textBoxVýsledek.Text = null;

                // vygenerování prvního a druhého čísla
                ČÍSLO1 = náhodnéČíslo.Next(číslo1Od, číslo1Do+1);
                ČÍSLO2 = náhodnéČíslo.Next(číslo2Od, číslo2Do+1);

                // změna hodnoty progresbaru 
                progressBar.Value = (100 / celkovýPočetProgress) * (celkovýPočetProgress - celkovýPočetPříkladů);

                // výpočet procentuální úspěšnosti 

                celkovýPočetPříkladůProProcenta = Convert.ToDouble(textBoxPočetPříkladů.Text);
                SprávnéPříklady = Convert.ToDouble(početSprávnýchVýsledků);
                procentuálníÚspěšnost = (100 / celkovýPočetPříkladůProProcenta) * SprávnéPříklady;
                LVýsledekT.Text = Convert.ToString(procentuálníÚspěšnost);

                // náhodné generování znamének podle výběru uživatele
                // číslo 1 je + , 2 je - , 3 je x , 4 je : 
                // výpočet je proveden po vygenerování znaménka
                // rozhodl jsem se pro metodu if i když bych mohl použít switch...
                do
                {
                    náhodnéZnaménko = náhodnéČíslo.Next(1, 4+1);

                    // 1 +
                    if (checkBoxPlus.Checked == true && náhodnéZnaménko == 1)
                    {
                        //Výpočet výsledku do proměnné
                        VÝSLEDEK = ČÍSLO1 + ČÍSLO2;

                        //zobrazení čísel a znaménka pro uživatele
                        labelPříkladČ1.Text = Convert.ToString(ČÍSLO1);
                        labelPříkladČ2.Text = Convert.ToString(ČÍSLO2);
                        labelZnaménko.Text =("+");

                        //labelVýsledek.Text = Convert.ToString(VÝSLEDEK);
                        break;
                    }

                    // 2 -
                    if (checkBoxMínus.Checked == true && náhodnéZnaménko == 2)
                    {
                        VÝSLEDEK = ČÍSLO1 - ČÍSLO2;

                        if (checkBoxMínusVýsledek.Checked == true && VÝSLEDEK > 0)
                        {
                            //Výpočet výsledku do proměnné
                            VÝSLEDEK = ČÍSLO1 - ČÍSLO2;
                            //zobrazení čísel a znaménka pro uživatele
                            labelPříkladČ1.Text = Convert.ToString(ČÍSLO1);
                            labelPříkladČ2.Text = Convert.ToString(ČÍSLO2);
                            labelZnaménko.Text =("-");

                            //labelVýsledek.Text = Convert.ToString(VÝSLEDEK);
                        }
                        else
                        {
                            //opět výpočet výsledku do proměnné
                            VÝSLEDEK = ČÍSLO2 - ČÍSLO1;

                            //prohození a opětovné zobrazení čísel a znaménka pro uživatele
                            labelPříkladČ1.Text = Convert.ToString(ČÍSLO2);
                            labelPříkladČ2.Text = Convert.ToString(ČÍSLO1);
                            labelZnaménko.Text =("-");
                            //labelVýsledek.Text = Convert.ToString(VÝSLEDEK);
                        }
                        break;
                    }


                    // 3 x
                    if (checkBoxNásobit.Checked == true && náhodnéZnaménko == 3)
                    {
                        //Výpočet výsledku do proměnné
                        VÝSLEDEK = ČÍSLO1 * ČÍSLO2;

                        //zobrazení čísel a znaménka pro uživatele
                        labelPříkladČ1.Text = Convert.ToString(ČÍSLO1);
                        labelPříkladČ2.Text = Convert.ToString(ČÍSLO2);
                        labelZnaménko.Text =("×");

                        //labelVýsledek.Text = Convert.ToString(VÝSLEDEK);

                        break;
                    }

                    // 4 :
                    if (checkBoxDělit.Checked == true && náhodnéZnaménko == 4)
                    {
                        // pokud by na jednom čísla byla 0
                        if (ČÍSLO1 == 0 || ČÍSLO2 == 0)
                        {
                            // změna čísel OD na 1
                            číslo1Od = +1;
                            číslo2Od = +1;

                            // opětovné vygenerování prvního a druhého čísla
                            ČÍSLO1 = náhodnéČíslo.Next(číslo1Od, číslo1Do+1);
                            ČÍSLO2 = náhodnéČíslo.Next(číslo2Od, číslo2Do+1);

                            //opětovné zobrazení čísel a znaménka pro uživatele
                            labelPříkladČ1.Text = Convert.ToString(ČÍSLO3);
                            labelPříkladČ2.Text = Convert.ToString(ČÍSLO1);
                            labelZnaménko.Text =(":");

                            // výpočet výsledku
                            ČÍSLO3 = ČÍSLO1 * ČÍSLO2;
                            VÝSLEDEK = ČÍSLO3 / ČÍSLO1;

                            //labelVýsledek.Text = Convert.ToString(VÝSLEDEK);
                        }
                        else // pokud by na jednom čísle není 0 pokračuje se dál
                        {
                            ČÍSLO3 = ČÍSLO1 * ČÍSLO2;
                            VÝSLEDEK = ČÍSLO3 / ČÍSLO1;

                            //labelVýsledek.Text = Convert.ToString(VÝSLEDEK);
                        }

                        //zobrazení čísel a znaménka pro uživatele
                        labelPříkladČ1.Text = Convert.ToString(ČÍSLO3);
                        labelPříkladČ2.Text = Convert.ToString(ČÍSLO1);
                        labelZnaménko.Text =(":");

                        break;
                    }
                } while (true);

                // UKONČENÍ POČÍTÁNÍ
                if (celkovýPočetPříkladů == 0)
                {
                    // Stopky STOP
                    stopky.Enabled = false;
                    ts = DateTime.Now - start;
                    LstopkyT.Text = String.Format("{0:hh\\:mm\\:ss}", ts);

                    // uložení času do proměnné
                    stopkyH = LstopkyT.Text;


                    // improvizace při řešení ,,nepřesného progressBar"
                    progressBar.Value = 100;

                    // zapnutí možnosti smazat historii
                    smazatHistoriiToolStripMenuItem.Enabled = true;

                    if (checkBoxZvuky.Checked == true)
                    {
                        // Přehrání zvuku pokud se požaduje
                        SoundPlayer melodie = new SoundPlayer(Properties.Resources.tada);
                        melodie.Play();
                    }

                    double skóre = procentuálníÚspěšnost / 10;

                    switch (skóre)
                    {
                        case 0:
                            // Comic Sans pro grafiky :) 
                            labelZnámka.Font = new Font("Comic Sans MS", velikostFontu * 3, FontStyle.Bold);
                            labelKonec.Font = new Font("Comic Sans MS", velikostFontu, FontStyle.Bold);
                            labelZnámka.ForeColor = Color.Red;
                            labelZnámka.Text = "5";

                            break;
                        case 1:
                            labelZnámka.Font = new Font("Comic Sans MS", velikostFontu * 3, FontStyle.Bold);
                            labelKonec.Font = new Font("Comic Sans MS", velikostFontu, FontStyle.Bold);
                            labelZnámka.ForeColor = Color.Red;
                            labelZnámka.Text = "5";

                            break;
                        case 2:
                            labelZnámka.ForeColor = Color.OrangeRed;
                            labelZnámka.Text = "4-";

                            break;
                        case 3:
                            labelZnámka.ForeColor = Color.Orange;
                            labelZnámka.Text = "4";

                            break;
                        case 4:
                            labelZnámka.ForeColor = Color.Orange;
                            labelZnámka.Text = "3-";

                            break;
                        case 5:
                            labelZnámka.ForeColor = Color.Yellow;
                            labelZnámka.Text = "3";

                            break;
                        case 6:
                            labelZnámka.ForeColor = Color.YellowGreen;
                            labelZnámka.Text = "2-";

                            break;
                        case 7:
                            labelZnámka.ForeColor = Color.GreenYellow;
                            labelZnámka.Text = "2";

                            break;
                        case 8:
                            labelZnámka.ForeColor = Color.Green;
                            labelZnámka.Text = "1-";

                            break;
                        case 9:
                            labelZnámka.ForeColor = Color.Green;
                            labelZnámka.Text = "1";

                            break;
                        case 10:
                            labelZnámka.ForeColor = Color.Gold;
                            labelZnámka.Text = "1*";

                            break;

                        default:
                            break;
                    }
                    // zobrazení známky
                    labelZnámka.Visible = true;
                    // skyrytí tlačítek a příkladu
                    buttonZkontroluj.Visible = false;
                    labelPříkladČ1.Visible = false;
                    labelPříkladČ2.Visible = false;
                    labelZnaménko.Visible = false;
                    labelRovnáSe.Visible = false;
                    textBoxVýsledek.Visible = false;
                    // zobrazení tlačítka start a textu konec
                    buttonStart.Visible = true;
                    labelKonec.Visible = true;

                    //Historie
                    // smazání historie
                    using (var zapisovac = File.CreateText("../Uložené_výsledky_matematika_2.txt"))
                    {
                        zapisovac.Write("");
                    }

                    // zapsání informace
                    using (var zapisovac = File.AppendText("../Uložené_výsledky_matematika_2.txt"))
                    {
                        zapisovac.WriteLine(historieProŠpatnýVýsledek + sChybou + špatnýVýsledekDoHistorie + "  Dokončeno:" + " ZNÁMKA "+ labelZnámka.Text +"  Stopky: " + stopkyH);
                        // zapsání původních hodnot aby byl nový text vždy nahoře
                        zapisovac.WriteLine(historie);
                        //zapisovac.Flush();
                    }
                    // znovu otevření souboru historie
                    using (var sr = new StreamReader("../Uložené_výsledky_matematika_2.txt"))
                    {
                        textBoxHistorie.Text = (sr.ReadToEnd());
                    }
                }
            }
            catch
            {
                textBoxVýsledek.Focus();
            }  
        }

        private void oknoProgramu_ResizeBegin(object sender, EventArgs e)
        {
            // Uložení velikosti okna do proměnné při změně velikosti
            velikostOknaX = Size.Width;
            velikostOknaY = Size.Height;

            //změna velikosti tlačítek podle velikosti okna
            buttonStart.Width = velikostOknaX / 8;
            buttonStart.Height = velikostOknaX / 15;
            buttonZkontroluj.Width = velikostOknaX / 8;
            buttonZkontroluj.Height = velikostOknaX / 15;
            
            //Změna pozice prvků podle velikosti okna
            poziceZnaménko = (velikostFontu*2) + 60;
            labelZnaménko.Location = new Point(poziceZnaménko, 120);
            // label KONEC podle znaménka
            labelKonec.Location = new Point(poziceZnaménko, 120);

            poziceČ2 = (velikostFontu*4) + 40;
            labelPříkladČ2.Location = new Point(poziceČ2, 120);

            poziceRovnáSe = (velikostFontu*6) + 50;
            labelRovnáSe.Location = new Point(poziceRovnáSe, 120);

            pozicePoleVýsledek = (velikostFontu*8) + 40;
            textBoxVýsledek.Location = new Point(pozicePoleVýsledek, 120);

            poziceTlačítko = (velikostFontu*10) + 100;
            buttonStart.Location = new Point(poziceTlačítko, 120);
            buttonZkontroluj.Location = new Point(poziceTlačítko, 120);

            poziceZnámka = (velikostFontu * 13) + 215;
            labelZnámka.Location = new Point(poziceZnámka, 50);

            pozicePoleHistorie = (velikostFontu * 6) +60;
            textBoxHistorie.Location = new Point(12, pozicePoleHistorie);

            // stopky a podrobnější prvky
            
            LStopky.Location = new Point(12, pozicePoleHistorie - 20);
            LstopkyT.Location = new Point(40, pozicePoleHistorie - 22);
            LPočet.Location = new Point(145, pozicePoleHistorie - 20);
            LPočetT.Location = new Point(235, pozicePoleHistorie - 24);
            LZbývající.Location = new Point(275, pozicePoleHistorie - 20);
            LZbývajícíT.Location = new Point(335, pozicePoleHistorie - 24);
            LSprávné.Location = new Point(485, pozicePoleHistorie - 20);
            LSprávnéT.Location = new Point(535, pozicePoleHistorie - 24);
            LŠpatně.Location = new Point(575, pozicePoleHistorie - 20);
            LŠpatněT.Location = new Point(620, pozicePoleHistorie - 24);
            LÚspěšnost.Location = new Point(660, pozicePoleHistorie - 20);
            LVýsledekT.Location = new Point(733, pozicePoleHistorie - 24);

            // zobrazení velikosti okna
            //label1.Text = Convert.ToString(velikostOknaX);
            //label2.Text = Convert.ToString(velikostOknaY);

            // zobrazení velikosti tlačítka
            //label4.Text = Convert.ToString(velikostOknaX/20);
            //label3.Text = Convert.ToString(velikostOknaY/4);

            // změna fontu tlačítek podle velikosti
            velikostFontu = velikostOknaX / 26;
            // tlačítka
            buttonStart.Font = new Font("Consolas", velikostFontu/2, FontStyle.Bold);
            buttonZkontroluj.Font = new Font("Consolas", velikostFontu, FontStyle.Bold);
            // texty
            labelJménoHráče.Font = new Font("Consolas", velikostFontu/2, FontStyle.Bold);
            labelPříkladČ1.Font = new Font("Consolas", velikostFontu, FontStyle.Bold);
            labelZnaménko.Font = new Font("Consolas", velikostFontu, FontStyle.Bold);
            labelPříkladČ2.Font = new Font("Consolas", velikostFontu, FontStyle.Bold);
            labelRovnáSe.Font = new Font("Consolas", velikostFontu, FontStyle.Bold);
            labelZnámka.Font = new Font("Freehand521 BT", velikostFontu * 3, FontStyle.Bold);

            // velikost labelKONEC podle znaménka
            labelKonec.Font = new Font("Consolas", velikostFontu, FontStyle.Bold);

            textBoxVýsledek.Font = new Font("Consolas", velikostFontu, FontStyle.Bold);

            // změna délky progresbar 
            progressBar.Width = velikostOknaX - 16;
            // a textového pole historie
            textBoxHistorie.Width = velikostOknaX -40 ;
            // ještě aby textové pole bylo vždy až na spod okna
            textBoxHistorie.Height = velikostOknaY - pozicePoleHistorie - 50;

            // změna velikosti GB podle okna
            gBnastavení.Width = velikostOknaX - 16;
            gBnastavení.Height = velikostOknaY / 100 * 46;
        }

        //proměnná náhody
        Random náhodnéČíslo = new Random();
        int číslo1Od, číslo1Do, číslo2Od, číslo2Do, ČÍSLO1, ČÍSLO2, ČÍSLO3,
            náhodnéZnaménko, VÝSLEDEK, zadanýVýsledek;

        string historie, historieProŠpatnýVýsledek, špatnýVýsledekDoHistorie, znaménkoHistorie, sChybou,
                stopkyH;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //přepsání proměnné 
            sChybou = ("   Bez chyby! :-) ");

            //vymazání proměnných
            historieProŠpatnýVýsledek = null;
            špatnýVýsledekDoHistorie = null;
            početŠpatnýchVýsledku = 0;
            procentuálníÚspěšnost = 0;
            progressBar.Value = 0;
            celkovýPočetPříkladůProProcenta = 0;
            SprávnéPříklady = 0;
            početSprávnýchVýsledků = 0;
            znaménkoHistorie = null;

            // načtení zadání rozsahu náhodných čísel
            try
            {
                číslo1Od = Convert.ToInt32(textBoxČ1od.Text);
            }
            catch
            {
                číslo1Od = 0;
                textBoxČ1od.Text = ("0");
            }
            try
            {
                číslo1Do = Convert.ToInt32(textBoxČ1do.Text);
            }
            catch
            {
                číslo1Do = 10;
                textBoxČ1do.Text = ("10");
            }
            try
            {
                číslo2Od = Convert.ToInt32(textBoxČ2od.Text);
            }
            catch
            {
                číslo2Od = 0;
                textBoxČ2od.Text = ("0");
            }
            try
            {
                číslo2Do = Convert.ToInt32(textBoxČ2do.Text);
            }
            catch
            {
                číslo2Do = 10;
                textBoxČ2do.Text = ("10");
            }

            //ochrana pokud jsou čísla DO menší než čísla OD
            if(číslo1Do < číslo1Od)
            {
                číslo1Do = číslo1Od + 1;
                textBoxČ1do.Text = Convert.ToString(číslo1Do);
            }

            if(číslo2Do < číslo2Od)
            {
                číslo2Do = číslo2Od + 1;
                textBoxČ2do.Text = Convert.ToString(číslo2Do);
            }

            // uložení celkového počtu příkladů
            celkovýPočetPříkladů = Convert.ToInt32(textBoxPočetPříkladů.Text);

            //zobrazení ,,vypsání" znamének do historie
            if (checkBoxPlus.Checked == true)
            {
                znaménkoHistorie += "+,";
            }
            else
            {
                znaménkoHistorie +="";
            }
            if (checkBoxMínus.Checked == true)
            {
                znaménkoHistorie += "-,";
            }
            else
            {
                znaménkoHistorie +="";
            }
            if (checkBoxNásobit.Checked == true)
            {
                znaménkoHistorie += "x,";
            }
            else
            {
                znaménkoHistorie +="";
            }
            if (checkBoxDělit.Checked == true)
            {
                znaménkoHistorie += ":,";
            }
            else
            {
                znaménkoHistorie +="";
            }

            try
            {
                if (checkBoxZvuky.Checked == true)
                {
                    // Přehrání zvuku pokud se požaduje
                    SoundPlayer melodie = new SoundPlayer(Properties.Resources.Start);
                    melodie.Play();
                }

                //Vynulování STOPEK
                ts = DateTime.Now - start;
                LstopkyT.Text = String.Format("00:00:00");

                // zapnutí stopek
                stopky.Enabled = true;
                start = DateTime.Now;
                LstopkyT.Text = "00:00:00";

                // Reset zobrazení 
                labelZnámka.Font = new Font("Freehand521 BT", velikostFontu * 3, FontStyle.Bold);
                labelKonec.Font = new Font("Consolas", velikostFontu, FontStyle.Bold);
                LZbývajícíT.Text = Convert.ToString(celkovýPočetPříkladů);
                labelKonec.Visible = false;
                labelZnámka.Visible = false;
                labelZnámka.Visible = false;
                LSprávnéT.Text = "0";
                LZbývajícíT.Text = textBoxPočetPříkladů.Text;
                LSprávnéT.Text = "0";
                LŠpatněT.Text = "0";
                LVýsledekT.Text = "0";

                // změna viditelnosti prvků
                labelPříkladČ1.Visible = false;
                labelZnaménko.Visible = false;
                labelPříkladČ2.Visible = false;
                labelRovnáSe.Visible = false;
                textBoxVýsledek.Visible = false;
                buttonZkontroluj.Visible = false;
                buttonStart.Visible = true;
                smazatHistoriiToolStripMenuItem.Enabled = false;

                LPočetT.Text = Convert.ToString(celkovýPočetPříkladů);
                // ukrytí tlačítka konec 
                labelKonec.Visible = false;

                //zobrazení a skrytí tlačítek
                buttonZkontroluj.Visible = true;
                buttonStart.Visible = false;

                // zobrazení prvků
                labelPříkladČ1.Visible = true;
                labelPříkladČ2.Visible = true;
                labelZnaménko.Visible = true;
                labelRovnáSe.Visible = true;
                textBoxVýsledek.Visible = true;

                //vypsání počtu zbývajících příkladů
                LPočetT.Text = Convert.ToString(celkovýPočetPříkladů);

                // Proměnná pro progressbar
                celkovýPočetProgress = celkovýPočetPříkladů;

                // vygenerování prvního a druhého čísla
                ČÍSLO1 = náhodnéČíslo.Next(číslo1Od, číslo1Do+1);
                ČÍSLO2 = náhodnéČíslo.Next(číslo2Od, číslo2Do+1);

                // přepnutí do textového pole!!!!!!!!!!!!!!!!!!!!
                textBoxVýsledek.Focus();

                // náhodné generování znamének podle výběru uživatele
                // číslo 1 je + , 2 je - , 3 je x , 4 je : 
                // výpočet je proveden po vygenerování znaménka
                do
                {
                    náhodnéZnaménko = náhodnéČíslo.Next(1, 4+1);

                    // 1 +
                    if (checkBoxPlus.Checked == true && náhodnéZnaménko == 1)
                    {
                        //Výpočet výsledku do proměnné
                        VÝSLEDEK = ČÍSLO1 + ČÍSLO2;
                        //zobrazení čísel a znaménka pro uživatele
                        labelPříkladČ1.Text = Convert.ToString(ČÍSLO1);
                        labelPříkladČ2.Text = Convert.ToString(ČÍSLO2);
                        labelZnaménko.Text =("+");

                        //labelVýsledek.Text = Convert.ToString(VÝSLEDEK);
                        break;
                    }

                    // 2 -
                    if (checkBoxMínus.Checked == true && náhodnéZnaménko == 2)
                    {
                        VÝSLEDEK = ČÍSLO1 - ČÍSLO2;

                        if (checkBoxMínusVýsledek.Checked == true && VÝSLEDEK > 0)
                        {
                            //Výpočet výsledku do proměnné
                            VÝSLEDEK = ČÍSLO1 - ČÍSLO2;
                            //zobrazení čísel a znaménka pro uživatele
                            labelPříkladČ1.Text = Convert.ToString(ČÍSLO1);
                            labelPříkladČ2.Text = Convert.ToString(ČÍSLO2);
                            labelZnaménko.Text =("-");

                            //labelVýsledek.Text = Convert.ToString(VÝSLEDEK);
                        }
                        else
                        {
                            //opět výpočet výsledku do proměnné
                            VÝSLEDEK = ČÍSLO2 - ČÍSLO1;

                            //prohození a opětovné zobrazení čísel a znaménka pro uživatele
                            labelPříkladČ1.Text = Convert.ToString(ČÍSLO2);
                            labelPříkladČ2.Text = Convert.ToString(ČÍSLO1);
                            labelZnaménko.Text =("-");
                            //labelVýsledek.Text = Convert.ToString(VÝSLEDEK);
                        }
                        break;
                    }

                    // 3 x
                    if (checkBoxNásobit.Checked == true && náhodnéZnaménko == 3)
                    {
                        //Výpočet výsledku do proměnné
                        VÝSLEDEK = ČÍSLO1 * ČÍSLO2;

                        //zobrazení čísel a znaménka pro uživatele
                        labelPříkladČ1.Text = Convert.ToString(ČÍSLO1);
                        labelPříkladČ2.Text = Convert.ToString(ČÍSLO2);
                        labelZnaménko.Text =("x");
                        //labelVýsledek.Text = Convert.ToString(VÝSLEDEK);

                        break;
                    }

                    // 4 :
                    if (checkBoxDělit.Checked == true && náhodnéZnaménko == 4)
                    {
                        if (ČÍSLO1 == 0 || ČÍSLO2 == 0)// pokud by na jedno z náhodných čísel byla 0
                        {
                            // opětovné vygenerování prvního a druhého čísla. 
                            ČÍSLO1 = náhodnéČíslo.Next(číslo1Od+1, číslo1Do);
                            ČÍSLO2 = náhodnéČíslo.Next(číslo2Od+1, číslo2Do);

                            //opětovné zobrazení čísel a znaménka pro uživatele
                            labelPříkladČ1.Text = Convert.ToString(ČÍSLO3);
                            labelPříkladČ2.Text = Convert.ToString(ČÍSLO1);
                            labelZnaménko.Text =(":");

                            // výpočet výsledku
                            ČÍSLO3 = ČÍSLO1 * ČÍSLO2;
                            VÝSLEDEK = ČÍSLO3 / ČÍSLO1;

                            //labelVýsledek.Text = Convert.ToString(VÝSLEDEK);
                        }
                        else // pokud ani jedno číslo není 0 pokračuje se dál
                        {
                            ČÍSLO3 = ČÍSLO1 * ČÍSLO2;
                            VÝSLEDEK = ČÍSLO3 / ČÍSLO1;

                            //labelVýsledek.Text = Convert.ToString(VÝSLEDEK);
                        }

                        //zobrazení čísel a znaménka pro uživatele
                        labelPříkladČ1.Text = Convert.ToString(ČÍSLO3);
                        labelPříkladČ2.Text = Convert.ToString(ČÍSLO1);
                        labelZnaménko.Text =(":");

                        break;
                    }
                } while (true);
            }
            catch
            {
                MessageBox.Show("Nebyla zadána číselná hodnota\nZadejte pouze číslice\nBez mezer");
            }
            //Historie
            // Načtení historie do proměnné
            using (var sr = new StreamReader("../Uložené_výsledky_matematika_2.txt"))
            {
                // uložení původních hodnot do proměnné
                historie = (sr.ReadToEnd());
            }
            // smazání historie
            using (var zapisovac = File.CreateText("../Uložené_výsledky_matematika_2.txt"))
            {
                zapisovac.Write("");
            }
            // zapsání informace
            using (var zapisovac = File.AppendText("../Uložené_výsledky_matematika_2.txt"))
            {
                // Vytvoření proměné času
                string datumAčas = DateTime.Now.ToString("dd.MM.yyyy - HH:mm:ss");

                zapisovac.WriteLine("Datum: "+ datumAčas + " - Jméno: " +textBoxZadejJméno.Text + "  Čísla " + číslo1Od + " až " + číslo1Do + " " + znaménkoHistorie + " "+ číslo2Od + " až " + číslo2Do + "   Počet příkladů: " + celkovýPočetPříkladů);
                // vytvoření proměnné ke které se budou přidávat špatné výsledky na jednom řádku
                historieProŠpatnýVýsledek = "Datum: "+ datumAčas + " - Jméno: " +textBoxZadejJméno.Text + "  Čísla " + číslo1Od + " až " + číslo1Do + " " + znaménkoHistorie + " "+ číslo2Od + " až " + číslo2Do + "   Počet příkladů: " + celkovýPočetPříkladů;

                // zapsání původních hodnot aby byl nový text vždy nahoře
                zapisovac.WriteLine(historie);

                zapisovac.Flush();
            }
            // znovu otevření souboru historie
            using (var sr = new StreamReader("../Uložené_výsledky_matematika_2.txt"))
            {
                textBoxHistorie.Text = (sr.ReadToEnd());
            }
        }
    }
}
