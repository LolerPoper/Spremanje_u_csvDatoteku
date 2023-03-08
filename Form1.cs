using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spremanje_u_csvDatoteku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            List<Osoba> listaOsoba = new List<Osoba>();
            try
            {
                Osoba osoba = new Osoba(txtIme.Text, txtPrezime.Text, txtEmail.Text, Convert.ToInt16(txtGodRod.Text));
                txtIme.Clear();
                txtPrezime.Clear();
                txtEmail.Clear();
                txtGodRod.Clear();

                DialogResult upit = MessageBox.Show("Želite li unesti još podataka?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (upit)
                {
                    case DialogResult.Yes:
                        {
                            listaOsoba.Add(osoba);
                            break;
                        }
                    case DialogResult.No:
                        {
                            listaOsoba.Add(osoba);
                            // Upis podataka u datoteku
                            using (var writer = new StreamWriter("Osobe.csv"))
                            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                            {
                                csv.WriteRecords(listaOsoba);
                            }
                            break;
                        }
                }
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message, "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
