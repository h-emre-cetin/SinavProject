using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SoruKategoriManager : ISoruKategoriService
    {
        private ISoruKategoriDal _soruKategoriDal;

        public SoruKategoriManager(ISoruKategoriDal soruKategoriDal)
        {
            _soruKategoriDal = soruKategoriDal;
        }

        public void Add(SoruKategori soruKategori)
        {
            _soruKategoriDal.Add(soruKategori);
        }

        public void Delete(SoruKategori soruKategori)
        {
            _soruKategoriDal.Delete(soruKategori);
        }

        public List<SoruKategori> GetAll()
        {
            return _soruKategoriDal.GetList();
        }

        public void Update(SoruKategori soruKategori)
        {
            _soruKategoriDal.Update(soruKategori);
        }
    }
}
