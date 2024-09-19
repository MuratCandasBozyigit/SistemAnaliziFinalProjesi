using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemAnalizleriFinalProjesi.Models.Models
{
    public class Ders
    {
        public int DersId { get; set; }
        public string DersAdı { get; set; }
        public int DersSaati { get; set; }
        public ICollection<Bölüm> Bölümler { get; set; }
    }
}
