using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class BankFelhasznalo
    {
        private int felhasznaloszam;
        private int osszeg;

        public BankFelhasznalo(int felhasznaloszam, int osszeg)
        {
            this.felhasznaloszam = felhasznaloszam;
            this.osszeg = osszeg;
        }
        public virtual void Nev()
        {
            Console.WriteLine(string.Format("Felhasználó Szám: {0}"), this.felhasznaloszam);
            Console.WriteLine(string.Format("Felhasználó összege: {0}"), this.osszeg);
        }
        public static void Osszegvissza()
        {

        }
        public static void Osszegfrissit()
        {

        }
    }
}
