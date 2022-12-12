using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Datumoraimunka12._12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mentes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(szoveg.Text))
            {
                MessageBox.Show("Nem adott meg nevet!");
                return;
            }
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Nem adott meg szöveget!");
                return;
            }
            saveFileDialog1.Filter = "Szöveg fájl|*.txt| Vesszővel tagolt szövegfájl (*.csv) |*.csv|minden fájl|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string szovegg = string.Join(";", szoveg.Text, richTextBox1.Text, dateTimePicker1.Value);
                string kivFile = saveFileDialog1.FileName;
                File.WriteAllText(kivFile, szovegg);
                MessageBox.Show("A kiválasztott fájl:" + kivFile);
                szoveg.Text = "";
                richTextBox1.Text = "";

            }
            else
            {
                MessageBox.Show("Nincs kiválasztva!");
            }
        }

        private void Megnyit_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string kivFile = openFileDialog1.FileName;
                string beolvasottSzoveg = File.ReadAllText(kivFile);
                string[] adatok = beolvasottSzoveg.Split(';');
                szoveg.Text = adatok[0];
                richTextBox1.Text = adatok[1];
                dateTimePicker1.Text = adatok[2];
            }
        }
    }
}
