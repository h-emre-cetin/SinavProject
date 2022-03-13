using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public  class Sik: IEntity
    {
        public int Id { get; set; }
        public string SikText { get; set; }

        public int SoruId { get; set; }

        public Soru Soru { get; set; }
        public bool DogruMu { get; set; }

    }
}
