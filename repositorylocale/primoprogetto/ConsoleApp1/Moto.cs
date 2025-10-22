using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Moto
    {
        private Veicolo veicoli;
        private string marca;
        private string modello;
        private string colore;
        public Moto(string marca, string modello, string colore)
        {
            this.marca = marca;
            this.modello = modello;
            this.colore = colore;
        }
    }
}
