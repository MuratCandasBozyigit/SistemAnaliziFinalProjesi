using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemAnalizleriFinalProjesi.Models.Models
{
    public class Veli:BaseModel
    {
        public int TelefonNo { get; set; }

        public int OgrenciTcNo { get; set; }
        //ogrenci adını tcnodan getirirsin ekrana 
        public virtual Ogrenci Ogrenci {  get; set; } 

    }
}
