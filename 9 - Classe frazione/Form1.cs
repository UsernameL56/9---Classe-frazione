using System;
using classeFrazioni;
namespace _9___Classe_frazione
{
    public partial class Form1 : Form
    {
        public int numeratore, denominatore;
        Frazione frazione;
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
            listView1.Items.Add(numeratore + " " + denominatore);
        }
    }
}