using System;
using System.Collections.Generic;

namespace OsztalyDia1
{
    public class Felhasznalo : Szemely
    {
        public string _szokasok;
        public int _szokasszam;
        public string _edz;
        
        public Felhasznalo(int id, string nev, string szokasok, int szokasszam, string edz) : base(id, nev)
        {

            this._szokasok = szokasok;
            this._szokasszam = szokasszam;
            this._edz = edz;

        }


        public override void Nev()
        {

            Console.WriteLine(string.Format("ID: {0}", this._id));
            Console.WriteLine(string.Format("Név: {0}", this._nev));
            Console.WriteLine(string.Format("Szokások: {0}", this._szokasok));
            Console.WriteLine(string.Format("Szokás szám: {0}", this._szokasszam));
            Console.WriteLine(string.Format("Edző: {0}", this._edz));


        }

    }
}
