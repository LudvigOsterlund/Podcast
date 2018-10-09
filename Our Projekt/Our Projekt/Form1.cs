
using HamtaData;
using Logik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Our_Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kategoriLista = logikLager.SkickavidareUppdateringAvXML();
            fyllComboBoxVidStart();       

            timer1 = new Timer();
            timer1.Tick += new EventHandler(Uppdatera_Tick);
            timer1.Interval = 60 * 1000 * 60;
            timer1.Start();

            VisaTid = new Timer();
            VisaTid.Tick += new EventHandler(VisaTid_Tick);
            VisaTid.Interval = 1000;
            VisaTid.Start();
        }

        GetLogik logikLager = new GetLogik();
        List<PodcastsInfo> podcastLista;
        List<Category> kategoriLista;

        private int kollaOmInfolistaSkaClearas = 0;
        private string hallaURLtillPrenumeration;
        int kollaIndexTillBeskrivning;
        int kollaComboIndex;
        bool kollaOmHover = false;
        int visaTimerForUppdatering = 60 * 60;
        int hallKollPaTidsintervall;
        int hallKollPaPrenumIndexForHover;
        bool t = false;

        private void button1_Click(object sender, EventArgs e)
        {   
            if (t)
            {
                podcastLista.Clear();
            }

            try
            {
                if (Validering.kollaTextruta(textBoxURL.Text))
                {

                    if (Validering.testaURL(textBoxURL.Text) && kollaOmInfolistaSkaClearas > 0)
                    {
                        podcastLista.Clear();
                    }

                    podcastLista = logikLager.returneraXML(textBoxURL.Text);
                    listBox1.Items.Clear();
                    foreach (var podcast in podcastLista)
                        {
                            listBox1.Items.Add(podcast);
                        }
                        hallaURLtillPrenumeration = textBoxURL.Text;
                    
                        textBoxURL.Clear();
                        kollaOmInfolistaSkaClearas++;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is something wrong with the url you entered, try again!");
            }
        }

        private void PrenumereraKnapp_Click(object sender, EventArgs e)
        {
            try
            {

                if (Validering.kollaTextruta(textBox2.Text))
                {
                    if (listBox1.Items.Count > 0)
                    {
                        string namn = textBox2.Text;
                        int comboBoxIndex = comboBox2.SelectedIndex;

                        if (comboBoxIndex >= 0)
                        {
                            kategoriLista = logikLager.skickaVidareLaggTillPrenumIKategorilista(namn, hallaURLtillPrenumeration, comboBoxIndex);
                            string kategoriname = kategoriLista[comboBoxIndex].kategoriNamn;
                            textBox2.Clear();
                            logikLager.LaggTillXML();
                            comboBoxIndex = -1;
                            MessageBox.Show("The podcast " + namn + " has been added to your list under catagory " + kategoriname);
                        }
                        else
                        {
                            MessageBox.Show("Välj en kategori att lägga podcasten i");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You need to fill the list with a url to able to subscribe");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("");
            }
        }

        private void VisaPrenumPod_Click(object sender, EventArgs e)
        {
            try
            {
                int comboIndex = comboBox1.SelectedIndex;
                kollaComboIndex = comboIndex;
                int podFeedIndex = listBox2.SelectedIndex;

                hallKollPaPrenumIndexForHover = podFeedIndex;
                PodFeed podFeedObjekt = new PodFeed();

                podFeedObjekt = kategoriLista[comboIndex].listOverPodFeed[podFeedIndex];

                listBox3.Items.Clear();
                listBox3.DrawMode = DrawMode.OwnerDrawVariable;
                foreach (var avsnitt in podFeedObjekt.podcastsLista)
                {
                    listBox3.Items.Add(avsnitt);
                }
                kollaOmHover = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("You need to select a podcast in your prenum list to show the episodes");
            }
        }

        private void AvPrenumereraKnapp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to unsubscribe to this podcast?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int comboIndex = comboBox1.SelectedIndex;
                    int index = listBox2.SelectedIndex;

                    kategoriLista[comboIndex].listOverPodFeed.RemoveAt(index);

                    logikLager.LaggTillXML();

                    listBox2.Items.Clear();

                    foreach (var prenumLista in kategoriLista[comboIndex].listOverPodFeed)
                    {
                        listBox2.Items.Add(prenumLista);
                    }
                    kollaOmHover = false;
                    toolTip1.RemoveAll();
                    MessageBox.Show("You have successfully unsubscribed to this podcast!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("You must select a podcast to unsubscribe to");
                }
            }
            else
            {
                MessageBox.Show("Your subscription was not canceled");
            }
        }

        private void UppdateringsintervallKnapp_Click(object sender, EventArgs e)
        {
            if (Validering.kollaTextruta(textBox1.Text))
            {
                if (Validering.testaParseInt(textBox1.Text))
                {
                    int intervall = int.Parse(textBox1.Text);
                    if (intervall >= 1 && intervall <= 60)
                    {
                        visaTimerForUppdatering = intervall * 60;
                        hallKollPaTidsintervall = visaTimerForUppdatering;

                        if (timer1.Enabled == true)
                        {
                            timer1.Stop();
                        }
                        timer1.Tick += new EventHandler(Uppdatera_Tick);
                        timer1.Interval = intervall * 1000 * 60;
                        timer1.Start();
                        textBox1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Ange ett heltal mellan 1 - 60 (i minuter)");
                    }
                }
            }
        }

        private void LaggTillKategoriKnapp_Click(object sender, EventArgs e)
        {
            if (Validering.kollaTextruta(textBox3.Text))
            {
                string namn = textBox3.Text;
                kategoriLista = logikLager.skickaVidareKategoriLista(namn);

                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                foreach (var kategori in kategoriLista)
                {
                    comboBox1.Items.Add(kategori);
                    comboBox2.Items.Add(kategori);
                }
                textBox3.Clear();
            }
        }

        private void TaBortKategoriKnapp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this category? The podcasts that the category holds will be removed in the process.", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int comboIndex = comboBox1.SelectedIndex;

                    kategoriLista.RemoveAt(comboIndex);

                    logikLager.LaggTillXML();

                    listBox2.Items.Clear();
                    listBox3.Items.Clear();
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();

                    fyllComboBoxVidStart();
                    comboBox1.Text = "";
                    MessageBox.Show("You have successfully removed the category!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("You must select a category to remove.");
                }
            }
            else
            {
                MessageBox.Show("Your subscription was not canceled");
            }
        }

        private void AndraNamnPaKategoriKnapp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validering.kollaTextruta(textBox4.ToString()))
                {
                    string nyttKategoriNamn = textBox4.Text;
                    int comboIndex = comboBox1.SelectedIndex;

                    kategoriLista[comboIndex].kategoriNamn = nyttKategoriNamn;
                    logikLager.LaggTillXML();

                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    listBox2.Items.Clear();
                    listBox3.Items.Clear();
                    textBox4.Clear();

                    fyllComboBoxVidStart();
                    kollaOmHover = false;
                    toolTip1.RemoveAll();
                    
                    MessageBox.Show("The category has been changed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a category that you would like to change.");
            }
        }

        private void SpelaUppAvsnittKnapp(ListBox listbox, int comboIndex)
        {

            try
            {
                string downloadURL;

                int index = listbox.SelectedIndex;
                if (listbox == listBox3)
                {
                    int prenumIndex = listBox2.SelectedIndex;
                    string darTitelAr = kategoriLista[comboIndex].listOverPodFeed[prenumIndex].podcastsLista[index].title.ToString();
                    
                    var dlURL = kategoriLista[comboIndex].listOverPodFeed[prenumIndex].podcastsLista.Single(podtitle => darTitelAr == podtitle.title.ToString());
                    downloadURL = dlURL.url.ToString();
                    dlURL.uppspelad = true;

                    logikLager.LaggTillXML();
                }
                else
                {
                    downloadURL = podcastLista[index].url.ToString();
                }

                Process.Start(downloadURL);
            }
            catch (Exception ex)
            {
                MessageBox.Show("We could not find the podcast you were looking for");
            }
        }


        private void SpelaUppAvsnitt_Click(object sender, EventArgs e)
        {
            SpelaUppAvsnittKnapp(listBox1, 0);
        }

        private void SpelaUppPrenumPod_Click(object sender, EventArgs e)
        {
            int comboIndex = comboBox1.SelectedIndex;
            SpelaUppAvsnittKnapp(listBox3, comboIndex);
        }

        public void fyllComboBoxVidStart()
        {
            foreach (var kategori in kategoriLista)
            {
                comboBox2.Items.Add(kategori);
                comboBox1.Items.Add(kategori);
            }
        }

        private void VisaBeskrivning(int index, ListBox listbox, int comboIndex, int prenumlistaIndex)
        {
            string indexForListboxForBeskrivning;
            try
            {
                if (index >= 0)
                {
                    if (kollaIndexTillBeskrivning == index)
                    {
                        return;
                    }

                    kollaIndexTillBeskrivning = index;
                    if (listbox == listBox3)
                    {
                        indexForListboxForBeskrivning = kategoriLista[comboIndex].listOverPodFeed[prenumlistaIndex].podcastsLista[index].description.ToString();
                    }
                    else
                    {
                        indexForListboxForBeskrivning = podcastLista[index].description.ToString();
                    }
                    string beskrivningAttVisa = listbox.Items[index].ToString();

                    if (toolTip1.GetToolTip(listbox) != beskrivningAttVisa)
                        toolTip1.SetToolTip(listbox, indexForListboxForBeskrivning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("vad hände nu???");
            }
        }

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int index = listBox1.IndexFromPoint(e.Location);
            VisaBeskrivning(index, listBox1, 0, 0);
        }

        private void listBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (kollaOmHover)
            {
                int index = listBox3.IndexFromPoint(e.Location);
                int comboIndex = comboBox1.SelectedIndex;
                int prenumIndex = listBox2.SelectedIndex;

                VisaBeskrivning(index, listBox3, kollaComboIndex, hallKollPaPrenumIndexForHover);
            }
        }

        private void listBox3_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush pensel;
            Graphics g = e.Graphics;

            int comboIndex = comboBox1.SelectedIndex;
            int kollaIndex = listBox2.SelectedIndex;

            if (kategoriLista[comboIndex].listOverPodFeed[kollaIndex].podcastsLista[e.Index].uppspelad)
            {
                pensel = Brushes.Red;
            }
            else
            {
                pensel = Brushes.Black;
            }
            g.DrawString(kategoriLista[comboIndex].listOverPodFeed[kollaIndex].podcastsLista[e.Index].ToString(), e.Font, pensel, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        public void UppdateraPrenumeration()
        {
            List<PodcastsInfo> uppdateraLista = new List<PodcastsInfo>();

            foreach (var kategori in kategoriLista)
            {
                foreach (var podcast in kategori.listOverPodFeed)
                {
                    uppdateraLista = logikLager.returneraXML(podcast.uppdateringsURL);
                    if (uppdateraLista.Count > podcast.podcastsLista.Count)
                    {
                        int omFleraAvsnitt = 0;
                        
                        for (int i = podcast.podcastsLista.Count; i < uppdateraLista.Count; i++)
                        {
                            podcast.podcastsLista.Insert(omFleraAvsnitt, uppdateraLista[omFleraAvsnitt]);
                            omFleraAvsnitt++;
                        }
                        logikLager.LaggTillXML();
                    }
                    uppdateraLista.Clear();
                }
            }
        }

        private void Uppdatera_Tick(object sender, EventArgs e)
        {
            UppdateraPrenumeration();
        }

        private void VisaTid_Tick(object sender, EventArgs e)
        {
            if (visaTimerForUppdatering / 60 >= 0 && ((visaTimerForUppdatering - 1) % 60) >= 0)
            {
                visaTimerForUppdatering--;
                label4.Text = visaTimerForUppdatering / 60 + ":" + ((visaTimerForUppdatering % 60) >= 10 ? (visaTimerForUppdatering % 60).ToString() : "0" + visaTimerForUppdatering % 60);
            }
            else
            {
                visaTimerForUppdatering = hallKollPaTidsintervall;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int comboBoxIndex = comboBox1.SelectedIndex;
            int podFeedListaLangd = kategoriLista[comboBoxIndex].listOverPodFeed.Count();

            listBox2.Items.Clear();
            for (int i = 0; i < podFeedListaLangd; i++)
            {
                listBox2.Items.Add(kategoriLista[comboBoxIndex].listOverPodFeed[i]);
            }
        }
    }
}