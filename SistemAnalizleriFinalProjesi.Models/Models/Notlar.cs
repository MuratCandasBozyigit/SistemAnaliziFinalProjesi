using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemAnalizleriFinalProjesi.Models.Models
{
    public class Notlar:Ders 
    {


        public int İlkSınavNotu { get; set; }
        public int İkinciSınavNotu { get; set; }

        public ICollection<Ders>Ders { get; set; }

        //Doğrulugunu kontrol et 
        private int dersNot;
        public void Ortalama(int ortalama)
        {
            foreach (var item in Ders)
            {
                dersNot = İlkSınavNotu + İkinciSınavNotu;
                ortalama = dersNot / 2;
            }

        }

        public void GenelOrt(int genelOrtalama)
        {

        }
    }
}
