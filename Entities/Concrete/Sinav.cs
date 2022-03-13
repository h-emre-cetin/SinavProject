using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Sinav: IEntity
    {
        public int Id { get; set; }
        public int SinavKategoriId { get; set; }

        public SinavKategori SinavKategori { get; set; }
        public string SinavAdı { get; set; }

        public int SinavSüresi { get; set; }

        public string SınavAciklamasi { get; set; }

        public int BasariPuani { get; set; }
    }
}
