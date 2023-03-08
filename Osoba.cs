using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spremanje_u_csvDatoteku
{
    internal class Osoba
    {
        string ime, prezime, email;
        int godRod;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public int GodRod { get => godRod; set => godRod = value; }

        public Osoba(string ime, string prezime, string email, int godRod)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.godRod = godRod;
        }

        public override string ToString()
        {
            string ispis = "Ime: " + this.ime + " Prezime: " + this.prezime + " Godina rođenja: " + this.godRod + " Email: " + this.email;
            return ispis;
        }
    }
}
