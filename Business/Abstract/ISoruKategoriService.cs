using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public  interface ISoruKategoriService
    {

        List<SoruKategori> GetAll();
        void Add(SoruKategori soruKategori);

        void Update(SoruKategori soruKategori);

        void Delete(SoruKategori soruKategori);

    }
}
