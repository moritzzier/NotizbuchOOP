﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotizbuchOOP
{
    public partial class Form1 : Form
    {
        private List<Notizbuch.Notizbuch> notizenListe = new List<Notizbuch.Notizbuch>();
        private Notizbuch.Notizbuch currentNotizbuch;

        //0 = Notizen, 1 = Einkaufsliste, 2 = Hausaufgaben
        private int notizArt = 0;

        public Form1()
        {
            InitializeComponent();

            //Deklaration des ersten Notizbuches
            Notizbuch.Notizbuch notizen = new Notizbuch.Notizbuch(DateTime.Now, "Notizbuch");
            this.notizenListe.Add(notizen);

            //Data-Bindings
            cb_ListenAuswahl.DataSource = notizenListe;
            cb_ListenAuswahl.DisplayMember = "name";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void test(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void cb_ListenAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.currentNotizbuch = notizenListe[cb_ListenAuswahl.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.notizArt = 0;
            b_Notizen.Enabled = false;
            b_Einkauf.Enabled = true;
            b_Hausaufgaben.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.notizArt = 1;
            b_Notizen.Enabled = true;
            b_Einkauf.Enabled = false;
            b_Hausaufgaben.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.notizArt = 2;
            b_Notizen.Enabled = true;
            b_Einkauf.Enabled = true;
            b_Hausaufgaben.Enabled = false;
        }
    }
}
