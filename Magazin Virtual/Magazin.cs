using Magazin_Virtual.OptiuniAdaugare;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin_Virtual
{
    public partial class Magazin : Form
    {
        public Magazin()
        {
            InitializeComponent();
        }

        private bool menuLock = false;

        private void Exit_Main_Menu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SchimbaControlInArieOperatiuni(Control e)
        {
            arieOperatiuni.Controls.Clear();
            e.Visible = true;
            arieOperatiuni.Controls.Add(e);
        }
        
        private void buttonAdaugareProdus_Click(object sender, EventArgs e)
        {
            AdaugareProdus adaugareProdus = new AdaugareProdus();
            adaugareProdus.Location = CalculatorPozitie.ColtStangaSus(arieOperatiuni, adaugareProdus);
            adaugareProdus.Visible = true;
            SchimbaControlInArieOperatiuni(adaugareProdus);
        }

        private void buttonAdaugareLocatie_Click(object sender, EventArgs e)
        {
            AdaugareLocatie adaugareLocatie = new AdaugareLocatie();
            adaugareLocatie.Location = CalculatorPozitie.ColtStangaSus(arieOperatiuni, adaugareLocatie);
            adaugareLocatie.Visible = true;
            SchimbaControlInArieOperatiuni(adaugareLocatie);
        }

        private void buttonAdaugareAngajat_Click(object sender, EventArgs e)
        {
            AdaugareAngajat adaugareAngajat = new AdaugareAngajat();
            adaugareAngajat.Location = CalculatorPozitie.ColtStangaSus(arieOperatiuni, adaugareAngajat);
            adaugareAngajat.Visible = true;
            SchimbaControlInArieOperatiuni(adaugareAngajat);
        }

        private void buttonAdaugareFacturi_Click(object sender, EventArgs e)
        {
            AdaugareFactura adaugareFactura = new AdaugareFactura();
            adaugareFactura.Location = CalculatorPozitie.ColtStangaSus(arieOperatiuni, adaugareFactura);
            adaugareFactura.Visible = true;
            SchimbaControlInArieOperatiuni(adaugareFactura);
        }

        private void buttonAdaugareAprovizionare_Click(object sender, EventArgs e)
        {
            AdaugareAprovizionare adaugareAprovizionare = new AdaugareAprovizionare();
            adaugareAprovizionare.Location = CalculatorPozitie.ColtStangaSus(arieOperatiuni, adaugareAprovizionare);
            adaugareAprovizionare.Visible = true;
            SchimbaControlInArieOperatiuni(adaugareAprovizionare);
        }

        private void buttonProduse_Click(object sender, EventArgs e)
        {
            TabelaProduse tabelaProduse = new TabelaProduse();
            tabelaProduse.Location = CalculatorPozitie.ColtStangaSus(arieOperatiuni, tabelaProduse);
            tabelaProduse.Visible = true;
            SchimbaControlInArieOperatiuni(tabelaProduse);
        }

        private void buttonAngajati_Click(object sender, EventArgs e)
        {
            TabelaAngajati tabelaAngajati = new TabelaAngajati();
            tabelaAngajati.Location = CalculatorPozitie.ColtStangaSus(arieOperatiuni, tabelaAngajati);
            tabelaAngajati.Visible = true;
            SchimbaControlInArieOperatiuni(tabelaAngajati);
        }

        private void buttonLocatii_Click(object sender, EventArgs e)
        {
            TabelaLocatii tabelaLocatii = new TabelaLocatii();
            tabelaLocatii.Location = CalculatorPozitie.ColtStangaSus(arieOperatiuni, tabelaLocatii);
            tabelaLocatii.Visible = true;
            SchimbaControlInArieOperatiuni(tabelaLocatii);
        }

        private void buttonFacturi_Click(object sender, EventArgs e)
        {
            TabelaFacturi tabelaFacturi = new TabelaFacturi();
            tabelaFacturi.Location = CalculatorPozitie.ColtStangaSus(arieOperatiuni, tabelaFacturi);
            tabelaFacturi.Visible = true;
            SchimbaControlInArieOperatiuni(tabelaFacturi);
        }

        private void buttonAprovizionari_Click(object sender, EventArgs e)
        {
            TabelaAprovizionari tabelaAprovizionari = new TabelaAprovizionari();
            tabelaAprovizionari.Location = CalculatorPozitie.ColtStangaSus(arieOperatiuni, tabelaAprovizionari);
            tabelaAprovizionari.Visible = true;
            SchimbaControlInArieOperatiuni(tabelaAprovizionari);
        }

        private void buttonStoc_Click(object sender, EventArgs e)
        {
            TabelaStoc tabelaStoc = new TabelaStoc();
            tabelaStoc.Location = CalculatorPozitie.ColtStangaSus(arieOperatiuni, tabelaStoc);
            tabelaStoc.Visible = true;
            SchimbaControlInArieOperatiuni(tabelaStoc);
        }

        private void buttonRapoarte_Click(object sender, EventArgs e)
        {
            Rapoarte rapoarte = new Rapoarte();
            rapoarte.Location = CalculatorPozitie.ColtStangaSus(arieOperatiuni, rapoarte);
            rapoarte.Visible = true;
            SchimbaControlInArieOperatiuni(rapoarte);
        }
    }
}
