using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.Results;
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

        public IResult Add(SinavKategori sinavKategori)
        {
            IResult result = BusinessRules.Run(CheckLenght(sinavKategori.KategoriAdi));
            if (result!= null)
            {
                return result;
            }
            _sinavKategoriDal.Add(sinavKategori);
            return new SuccessResult("Kategori Eklendi");
        }

        public IResult Delete(int id)
        {
            _sinavKategoriDal.Delete(id);
            return new SuccessResult("Sinav Kategorisi Silindi.");
        }

        public IDataResult<List<SinavKategori>> GetAll()
        {

            return new SuccessDataResult<List<SinavKategori>>(_sinavKategoriDal.GetList());
        }

        public IResult Update(SinavKategori sinavKategori)
        {

            IResult result = BusinessRules.Run(CheckLenght(sinavKategori.KategoriAdi));
            if (result != null)
            {
                return result;
            }
            _sinavKategoriDal.Update(sinavKategori);
            return new SuccessResult("Kategori Güncellendi");
        }

        private IResult CheckLenght(string kategoriAdi)
        {

            var result = kategoriAdi.Length;

            if (result<=1)
            {
                return new ErrorResult("Kategori adı bir harften fazla olmalıdır.");
            }
            return new SuccessResult();
        }

    }
}
