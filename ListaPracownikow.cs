using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2;

namespace WpfApp2
{
    class ListaPracownikow : ObservableCollection<Pracownik>
    {

        public ListaPracownikow()
        {

            Add(new Pracownik
            {
                Imie = "dfasfda",
                Nazwisko = "sdfgawfeaw",
                Plec = "Mezczyzna",
                Pesel = "22222222222",
                Stanowisko = "Prezes",
                Wynagrodzenie = 1.2,
                Aktywny = true,
                Zdjecie = new Uri("pack://application:,,,/Zdjecia/pacman.png"),
                Email = "ddd@eee.fff",
            });

            Add(new Pracownik
            {
                Imie = "wert",
                Nazwisko = "ssdewert",
                Plec = "Kobieta",
                Pesel = "11111111111",
                Stanowisko = "robol",
                Wynagrodzenie = 0.1,
                Aktywny = false,
                Zdjecie = new Uri("pack://application:,,,/Zdjecia/list.png"),
                Email = "aaa@bbb.ccc",
            });
        }

    }
}
