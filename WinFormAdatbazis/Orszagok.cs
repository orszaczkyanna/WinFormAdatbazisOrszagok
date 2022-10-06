using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAdatbazis
{
    class Orszagok
    {
        readonly int id;
        string orszag;
        string fovaros;
        decimal terulet;
        string allamforma;

        public int Id => id;

        public string Orszag { get => orszag; set => orszag = value; }
        public string Fovaros { get => fovaros; set => fovaros = value; }
        public decimal Terulet { get => terulet; set => terulet = value; }
        public string Allamforma { get => allamforma; set => allamforma = value; }

        public Orszagok(int id, string orszag, string fovaros, decimal terulet, string allamforma)
        {
            this.id = id;
            Orszag = orszag;
            Fovaros = fovaros;
            Terulet = terulet;
            Allamforma = allamforma;
        }

        public override string ToString()
        {
            return orszag;
        }

    }
}
