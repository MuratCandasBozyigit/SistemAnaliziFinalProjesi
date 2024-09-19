using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemAnalizleriFinalProjesi.Models.Models
{
    public class Okul
    {
        public int OkulId { get; set; }
        public string OkulAdi { get; set; }

        //bu ikisi için şehir classı oluştur o listeden select yaparak bilgileri buraya çek seç gonder 
        public string BulunduguSehir { get; set; }
        public string Semt { get; set; }

    }
}
