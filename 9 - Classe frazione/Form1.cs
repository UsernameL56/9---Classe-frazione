using System;
using classeFrazioni;
namespace _9___Classe_frazione
{
    public partial class Form1 : Form
    {
        public int numeratore, denominatore;
        Frazione frazione, frazione2;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void semplifica_Click(object sender, EventArgs e)
        {
            frazione = new Frazione(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            var t = frazione.semplificaFrazione();
            numeratore = t.Item1;
            denominatore = t.Item2;

            listView1.Clear();
            listView1.Items.Add(numeratore + "\n" + denominatore);
        }

        private void somma_Click(object sender, EventArgs e)
        {

            frazione = new Frazione(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            frazione2 = new Frazione(int.Parse(textBox3.Text), int.Parse(textBox4.Text));


            var risultato = frazione.sommaFrazione(frazione2);
            numeratore = risultato.Item1;
            denominatore = risultato.Item2;

            listView1.Clear();
            listView1.Items.Add(numeratore + "\n" + denominatore);
        }

        private void sottrazione_Click(object sender, EventArgs e)
        {
            frazione = new Frazione(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            frazione2 = new Frazione(int.Parse(textBox3.Text), int.Parse(textBox4.Text));


            var risultato = frazione.sottrazioneFrazione(frazione2);
            numeratore = risultato.Item1;
            denominatore = risultato.Item2;

            listView1.Clear();
            listView1.Items.Add(numeratore + "\n" + denominatore);
        }
    }
}