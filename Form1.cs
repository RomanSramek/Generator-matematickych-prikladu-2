﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Generáto_matematických_příkladů_2
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
            // nastavení standardní hodnoty
            celkovýPočetPříkladů = 10;
            celkovýPočetPříkladůProgres = 10;
        }


        // velikost okna, fontu a posunu v proměnné
        int velikostOknaY, velikostOknaX, velikostFontu, poziceZnaménko, poziceČ2, poziceRovnáSe, pozicePoleVýsledek,
            poziceTlačítko, poziceZnámka, pozicePoleHistorie, početSprávnýchVýsledků, početŠpatnýchVýsledku,
            celkovýPočetPříkladů, celkovýPočetPříkladůProgres;
        double procentuálníÚspěšnost;

        private void labelZnámka_Click(object sender, EventArgs e)
        {
            // easter egg v podobě textu podle úspěšnosti
            
            double skóre = procentuálníÚspěšnost / 10;
            switch (skóre)
            {
                case 0:
                    MessageBox.Show("S tím už nic neuděláš");
                    break;
                case 1:
                    MessageBox.Show("Tohle je na pováženou!");
                    break;
                case 2:
                    MessageBox.Show("Tohle bylo o fous");
                    break;
                case 3:
                    MessageBox.Show("No... dá se to");
                    break;
                case 4:
                    MessageBox.Show("Pořád se dá co zlepšovat");
                    break;
                case 5:
                    MessageBox.Show("No šlo by to lépe");
                    break;
                case 6:
                    MessageBox.Show("Pořád se dá trénovat");
                    break;
                case 7:
                    MessageBox.Show("Dobrý výsledek");
                    break;
                case 8:
                    MessageBox.Show("To ujde");
                    break;
                case 9:
                    MessageBox.Show("Jen kousek ti chyběl k nejlepšímu výsledku");
                    break;
                case 10:
                    MessageBox.Show("Skvěle! Lépe už to nejde!!!");
                    break;

                default:
                    MessageBox.Show("Neplatné skóre!");
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
                celkovýPočetPříkladůProgres = celkovýPočetPříkladů;
            }
            catch
            {

            }
        }

        private void zastavPočítáníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // resetování do původních hodnot
            celkovýPočetPříkladů = Convert.ToInt32(textBoxPočetPříkladů.Text);
            LZbývajícíT.Text = Convert.ToString(celkovýPočetPříkladů);
            celkovýPočetPříkladůProgres = celkovýPočetPříkladů;
            progressBar.Value = 0;


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

            // načtení zadání rozsahu náhodných čísel
            číslo1Od = Convert.ToInt32(textBoxČ1od.Text);
            číslo1Do = Convert.ToInt32(textBoxČ1do.Text);
            číslo2Od = Convert.ToInt32(textBoxČ2od.Text);
            číslo2Do = Convert.ToInt32(textBoxČ2do.Text);

            LPočetT.Text = Convert.ToString(celkovýPočetPříkladů);




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
                labelJménoHráče.Visible = true;
            }
            else
            {
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
                labelJménoHráče.Visible = false;
            }

        }

        private void nastaveníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // vypnutí počítání a vrácení do původních hodnot


            
            
            // zobrazení nastavení
            gBnastavení.Visible = !gBnastavení.Visible;

            if (gBnastavení.Visible == true)
            {
                
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
                labelJménoHráče.Visible = true;
            }
            else
            {
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
                labelJménoHráče.Visible = false;
            }
            

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

                }
                else
                {
                    // (pro zobrazení) MessageBox.Show("špatně");
                    //uložení špatné odpovědi
                    početŠpatnýchVýsledku += 1;
                    // vypsání špatné odpovědi
                    LŠpatněT.Text = Convert.ToString(početŠpatnýchVýsledku);

                    // odečet celkového počtu příkladů
                    celkovýPočetPříkladů -= 1;

                    //vypsání počtu zbývajících příkladů
                    LZbývajícíT.Text = Convert.ToString(celkovýPočetPříkladů);
                }

                textBoxVýsledek.Text = null;

                // vygenerování prvního a druhého čísla
                ČÍSLO1 = náhodnéČíslo.Next(číslo1Od, číslo1Do+1);
                ČÍSLO2 = náhodnéČíslo.Next(číslo2Od, číslo2Do+1);


                // změna hodnoty progresbaru 
                progressBar.Value = (celkovýPočetPříkladůProgres - celkovýPočetPříkladů)*10;

                // výpočet procentuální úspěšnosti 

                double celkovýPočetPříkladůProProcenta = Convert.ToDouble(textBoxPočetPříkladů.Text);
                double SprávnéPříklady = Convert.ToDouble(početSprávnýchVýsledků);
                procentuálníÚspěšnost = (100 / celkovýPočetPříkladůProProcenta) * SprávnéPříklady;
                LVýsledekT.Text = Convert.ToString(procentuálníÚspěšnost);

                // náhodné generování znamének podle výběru uživatele
                // číslo 1 je + , 2 je - , 3 je x , 4 je : 
                // výpočet je proveden po vygenerování znaménka
                // rozhodl jsem se pro metodu if i když bych mohl použít switch


                // UKONČENÍ POČÍTÁNÍ
                if (celkovýPočetPříkladů == 0)
                {
                    MessageBox.Show("KONEC");
                }


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

                        labelVýsledek.Text = Convert.ToString(VÝSLEDEK);
                        break;
                    }

                    // 2 -
                    if (checkBoxMínus.Checked == true && náhodnéZnaménko == 2)
                    {
                        //Výpočet výsledku do proměnné
                        VÝSLEDEK = ČÍSLO1 - ČÍSLO2;

                        //zobrazení čísel a znaménka pro uživatele
                        labelPříkladČ1.Text = Convert.ToString(ČÍSLO1);
                        labelPříkladČ2.Text = Convert.ToString(ČÍSLO2);
                        labelZnaménko.Text =("-");

                        labelVýsledek.Text = Convert.ToString(VÝSLEDEK);

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

                        labelVýsledek.Text = Convert.ToString(VÝSLEDEK);

                        break;
                    }


                    // 4 :
                    if (checkBoxDělit.Checked == true && náhodnéZnaménko == 4)
                    {
                        // pokud by na jednom čísla byla 0
                        if (ČÍSLO1 == 0 || ČÍSLO2 == 0)
                        {
                            // změna čísel OD na 1
                            číslo1Od += 1;
                            číslo2Od += 1;

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

                            labelVýsledek.Text = Convert.ToString(VÝSLEDEK);
                        }
                        else // pokud by na jednom čísle není 0 pokračuje se dál
                        {
                            ČÍSLO3 = ČÍSLO1 * ČÍSLO2;
                            VÝSLEDEK = ČÍSLO3 / ČÍSLO1;

                            labelVýsledek.Text = Convert.ToString(VÝSLEDEK);
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
            buttonZkontroluj.Font = new Font("Consolas", velikostFontu/2, FontStyle.Bold);
            // texty
            labelJménoHráče.Font = new Font("Consolas", velikostFontu/2, FontStyle.Bold);
            labelPříkladČ1.Font = new Font("Consolas", velikostFontu, FontStyle.Bold);
            labelZnaménko.Font = new Font("Consolas", velikostFontu, FontStyle.Bold);
            labelPříkladČ2.Font = new Font("Consolas", velikostFontu, FontStyle.Bold);
            labelRovnáSe.Font = new Font("Consolas", velikostFontu, FontStyle.Bold);
            labelZnámka.Font = new Font("Times New Roman", velikostFontu * 3, FontStyle.Bold);

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

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                
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

                // načtení zadání rozsahu náhodných čísel
                číslo1Od = Convert.ToInt32(textBoxČ1od.Text);
                číslo1Do = Convert.ToInt32(textBoxČ1do.Text);
                číslo2Od = Convert.ToInt32(textBoxČ2od.Text);
                číslo2Do = Convert.ToInt32(textBoxČ2do.Text);

                // vygenerování prvního a druhého čísla
                ČÍSLO1 = náhodnéČíslo.Next(číslo1Od, číslo1Do+1);
                ČÍSLO2 = náhodnéČíslo.Next(číslo2Od, číslo2Do+1);


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

                        labelVýsledek.Text = Convert.ToString(VÝSLEDEK);
                        break;
                    }

                    // 2 -
                    if (checkBoxMínus.Checked == true && náhodnéZnaménko == 2)
                    {
                        //Výpočet výsledku do proměnné
                        VÝSLEDEK = ČÍSLO1 - ČÍSLO2;

                        //zobrazení čísel a znaménka pro uživatele
                        labelPříkladČ1.Text = Convert.ToString(ČÍSLO1);
                        labelPříkladČ2.Text = Convert.ToString(ČÍSLO2);
                        labelZnaménko.Text =("-");

                        labelVýsledek.Text = Convert.ToString(VÝSLEDEK);

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

                        labelVýsledek.Text = Convert.ToString(VÝSLEDEK);

                        break;
                    }


                    // 4 :
                    if (checkBoxDělit.Checked == true && náhodnéZnaménko == 4)
                    {
                        if (ČÍSLO1 == 0 || ČÍSLO2 == 0)// pokud by na jedno z náhodných čísel byla 0
                        {
                            // změna čísel OD na 1
                            číslo1Od += 1;
                            číslo2Od += 1;

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

                            labelVýsledek.Text = Convert.ToString(VÝSLEDEK);
                        }
                        else // pokud ani jedno číslo není 0 pokračuje se dál
                        {
                            ČÍSLO3 = ČÍSLO1 * ČÍSLO2;
                            VÝSLEDEK = ČÍSLO3 / ČÍSLO1;

                            labelVýsledek.Text = Convert.ToString(VÝSLEDEK);
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

        }
    }
}