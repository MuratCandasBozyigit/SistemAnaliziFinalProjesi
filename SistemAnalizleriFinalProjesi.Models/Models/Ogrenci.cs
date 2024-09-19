
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemAnalizleriFinalProjesi.Models.Models
{
    public class Ogrenci:BaseModel
    {
        public int OgrenciTcNo {  get; set; }
        public int OgrenciNo {  get; set; }
        public string AlınanDersler { get; set; }
        
        public int OkulId {  get; set; }
        public virtual Okul Okul { get; set; }

       

        public ICollection<Notlar> Notlar { get; set; }
        public ICollection<Ders> Dersler { get; set; }
        public ICollection<Veli> veliler { get; set; }
    }
}
