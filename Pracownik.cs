using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Pracownik
    {

        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Plec {  get; set; }
        public string Pesel { get; set; }
        public string Stanowisko { get; set; }
        public double Wynagrodzenie { get; set; }
        public bool Aktywny {  get; set; }
        public Uri Zdjecie { get; set; }
        public string Email { get; set; }

    }
}
