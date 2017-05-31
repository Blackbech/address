using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace telefonbuch
{
    public partial class Form1 : Form
    {
        int telnr_kategorie = 0; //Kat 0 = Alle Nummern, Kat 1 = Servicenummern, Kat 2 = Privatnummern
        string[] zeile;
        string[] info_teile;
        string[] person;
        string[] telnr; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            telnr_laden();
        }

        private void telnr_laden()
        {
            //Listview leeren:
            listView1.Items.Clear();

            //Alle Felder leeren:
            suchtextTB.Text = String.Empty;
            nameTB.Text = String.Empty;
            telnrTB.Text = String.Empty;

            switch (telnr_kategorie)
            {
                case 0:
                    zeile = File.ReadAllLines("telnr_alle.csv");
                    Array.Sort(zeile);

                    infos_splitten_eintragen();
                    break; //Jede Case-Anweisung endet mit einem break!

                case 1:
                    zeile = File.ReadAllLines("telnr_service.csv");
                    Array.Sort(zeile);

                    infos_splitten_eintragen();
                    break;

                case 2:
                    zeile = File.ReadAllLines("telnr_privat.csv");
                    Array.Sort(zeile);

                    infos_splitten_eintragen();
                    break;
            }
        }

        private void infos_splitten_eintragen()
        {
            int i;
            ListViewItem lvi;

            person = new string[zeile.Length];
            telnr = new string[zeile.Length];

            for (i = 0; i < zeile.Length; i++)
            {
                //Einträge werden in info_teile hintereinander durch Semikolons gesplittet und aneinandergereiht, anschließend aufgeteilt auf Personen und TelNr, bevor der Eintrag in info_teile im Zug der nächsten Schleife überschrieben werden.
                info_teile = zeile[i].Split(';');
                person[i] = info_teile[0];
                telnr[i] = info_teile[1];

                //Informationen werden ins ListView eingetragen:
                lvi = new ListViewItem(person[i]);
                lvi.SubItems.Add(telnr[i]);
                listView1.Items.Add(lvi);
            }
        }

        private void alleBtn_Click(object sender, EventArgs e)
        {
            telnr_kategorie = 0;
            telnr_laden();
        }

        private void serviceBtn_Click(object sender, EventArgs e)
        {
            telnr_kategorie = 1;
            telnr_laden();
        }

        private void privatBtn_Click(object sender, EventArgs e)
        {
            telnr_kategorie = 2;
            telnr_laden();
        }

        private void suchenBtn_Click(object sender, EventArgs e)
        {
            int i;
            string suchtext, anfangsbuchstaben, wortanfang;
            ListViewItem lvi;

            //ListView-Einträge löschen:
            listView1.Items.Clear();

            suchtext = suchtextTB.Text;

            for (i = 0; i < person.Length; i++)
            {
                if (person[i].ToUpper() == suchtext.ToUpper())
                {
                    //Information in ListView eintragen:
                    lvi = new ListViewItem(person[i]);
                    lvi.SubItems.Add(telnr[i]);
                    listView1.Items.Add(lvi);
                    return; //Bricht die Methode ab um nur 1 (präzises) Ergebnis darzustellen.
                }
            }

            //Suche nach Anfangsbuchstaben:

            anfangsbuchstaben = suchtextTB.Text;

            for (i = 0; i < person.Length; i++)
            {
                if (person[i].Length < anfangsbuchstaben.Length) //Dient dazu Begriffe die kürzer sind als der Suchbegriff im Vorhinein auszuschließen.
                {
                    continue; //Überspringt den restlichen Vorgang der Schleife und beginnt wieder bei i++
                }

                wortanfang = person[i].Substring(0, anfangsbuchstaben.Length); //Setzt den Wortanfang auf die gleiche Länge wie den Suchwert.

                if (wortanfang.ToUpper() == anfangsbuchstaben.ToUpper()) //Entspricht der Wortanfang dem Suchbegriff wird der Eintrag aufgelistet.
                {
                    lvi = new ListViewItem(person[i]);
                    lvi.SubItems.Add(telnr[i]);
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void neuBtn_Click(object sender, EventArgs e)
        {
            string pers, nr;
            pers = nameTB.Text;
            nr = telnrTB.Text;

            switch (telnr_kategorie)
            {
                case 0:
                    MessageBox.Show("Das Anlegen von neuen Kontakten ist nur in Privat oder Geschäftlich möglich.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 1:
                    StreamWriter swa = new StreamWriter("telnr_alle.csv", true);
                    StreamWriter swas = new StreamWriter("telnr_service.csv", true);
                    swa.WriteLine(pers + ";" + nr);
                    swas.WriteLine(pers + ";" + nr);
                    swa.Close();
                    swas.Close();
                    //Array.Clear(zeile, 0, zeile.Length - 1);
                    telnr_laden();
                    break;

                case 2:
                    StreamWriter swb = new StreamWriter("telnr_alle.csv", true);
                    StreamWriter swbp = new StreamWriter("telnr_privat.csv", true);
                    swb.WriteLine(pers + ";" + nr);
                    swbp.WriteLine(pers + ";" + nr);
                    swb.Close();
                    swbp.Close();
                    //Array.Clear(zeile, 0, zeile.Length - 1);
                    telnr_laden();
                    break;
            }
        }

        private void loeschenBtn_Click(object sender, EventArgs e)
        {
            int auswahl, i;
            string zeilen;

            //Gewählten Kontakt erkennen + Exception-Handling.
            try
            {
                auswahl = listView1.SelectedIndices[0];
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Wählen Sie zuerst einen Eintrag aus.");
                return;
            }
            
            //Datensatz wird nur gelöscht, wenn er Eindeutig auf Privat oder Service zuordenbar ist, um Mehraufwand zu verhindern.
            if (telnr_kategorie == 0)
            {
                MessageBox.Show("Kontakte können nur in den Kategorien Service und Privat gelöscht werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Gewählten Kontakt aus dem Array löschen.
            person[auswahl] = String.Empty;
            telnr[auswahl] = String.Empty;

            if (telnr_kategorie == 1)
            {
                StreamWriter sw = new StreamWriter("telnr_service.csv", false);

                for (i = 0; i < person.Length; i++)
                {
                    if (person[i] == "")
                    {
                        continue; //Zum nächsten Schleifendurchlauf hüpfen.
                    }
                    zeilen = person[i] + ";" + telnr[i];
                    sw.WriteLine(zeilen);
                }
                sw.Close();

                //Überschreiben der Inhalte in der Datei "telnr_alle.csv".
                Array.Clear(zeile, 0, zeile.Length - 1);
                zeile = File.ReadAllLines("telnr_service.csv");
                StreamWriter sw1 = new StreamWriter("telnr_alle.csv", false);

                for (i = 0; i < zeile.Length; i++)
                {
                    sw1.WriteLine(zeile[i]);
                }
                sw1.Close();

                //Hinzufügen der Inhalte aus den Privatkontakten:
                Array.Clear(zeile, 0, zeile.Length - 1);
                zeile = File.ReadAllLines("telnr_privat.csv");
                StreamWriter sw2 = new StreamWriter("telnr_alle.csv", true);

                for (i = 0; i < zeile.Length; i++)
                {
                    sw2.WriteLine(zeile[i]);
                }
                sw2.Close();
            }

            if (telnr_kategorie == 2)
            {
                StreamWriter sw3 = new StreamWriter("telnr_privat", false);

                for (i = 0; i < person.Length; i++)
                {
                    if (person[i] == "")
                    {
                        continue;
                    }
                    zeilen = person[i] + ";" + telnr[i];
                    sw3.WriteLine(zeilen);
                }
                sw3.Close();

                Array.Clear(zeile, 0, zeile.Length - 1);
                zeile = File.ReadAllLines("telnr_privat.csv");
                StreamWriter sw4 = new StreamWriter("telnr_alle.csv", false);

                for (i = 0; i < zeile.Length; i++)
                {
                    sw4.WriteLine(zeile[i]);
                }
                sw4.Close();

                Array.Clear(zeile, 0, zeile.Length - 1);
                zeile = File.ReadAllLines("telnr_service.csv");
                StreamWriter sw5 = new StreamWriter("telnr_alle.csv", true);

                for (i = 0; i < zeile.Length; i++)
                {
                    sw5.WriteLine(zeile[i]);
                }
                sw5.Close();
            }

            telnr_laden();
        }
    }
}
