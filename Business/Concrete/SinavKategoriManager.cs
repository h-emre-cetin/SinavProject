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
    public class SinavKategoriManager : ISinavKategoriService
    {

        private ISinavKategoriDal _sinavKategoriDal;

        public SinavKategoriManager(ISinavKategoriDal sinavKategoriDal)
        {
            _sinavKategoriDal = sinavKategoriDal;
        }

        public void Add(SinavKategori sinavKategori)
        {
            _sinavKategoriDal.Add(sinavKategori);
        }

        public void Delete(SinavKategori sinavKategori)
        {
            _sinavKategoriDal.Delete(sinavKategori);
        }

        public List<SinavKategori> GetAll()
        {
            return _sinavKategoriDal.GetList();
        }

        public void Update(SinavKategori sinavKategori)
        {
            _sinavKategoriDal.Update(sinavKategori);
        }
    }
}
