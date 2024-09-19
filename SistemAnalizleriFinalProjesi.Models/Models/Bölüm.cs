using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemAnalizleriFinalProjesi.Models.Models
{
    public class Bölüm
    {
        public int BölümId { get; set; }
        public string BölümAdı { get; set; }
        public string BölümAcıklaması { get; set; }

        public ICollection<Ders> Dersler { get; set; }
    }
}
