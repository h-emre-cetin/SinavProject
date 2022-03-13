using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Soru: IEntity
    {
        public int Id { get; set; }

        public string Sorular { get; set; }
        public int SoruKategoriId { get; set; }
        public SoruKategori SoruKategori { get; set; }
        public int SoruTipi { get; set; }
    }
}
