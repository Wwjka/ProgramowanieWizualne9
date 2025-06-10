using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormularzDanych
{
    public partial class Formularz : Form
    {
        DatabaseManager bazaDanych = new DatabaseManager();

        public Formularz()
        {
            InitializeComponent();
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            bazaDanych.ZapiszDane(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,
                textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text,
                textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text);
        }

        private void buttonWczytaj_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bazaDanych.WczytajDane();
        }
    }
}
