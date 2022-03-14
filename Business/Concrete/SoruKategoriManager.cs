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
    public class SoruKategoriManager : ISoruKategoriService
    {
        private ISoruKategoriDal _soruKategoriDal;

        public SoruKategoriManager(ISoruKategoriDal soruKategoriDal)
        {
            _soruKategoriDal = soruKategoriDal;
        }

        public IResult Add(SoruKategori soruKategori)
        {
            IResult result = BusinessRules.Run(CheckLenght(soruKategori.SoruKategoriAdi));
            if(result != null)
            {
                return result;
            }
            _soruKategoriDal.Add(soruKategori);
            return new SuccessResult();
        }

        public IResult Delete(int id)
        {
            _soruKategoriDal.Delete(id);
            return new SuccessResult();
        }

        public IDataResult<List<SoruKategori>> GetAll()
        {
            return new SuccessDataResult<List<SoruKategori>>(_soruKategoriDal.GetList());
        }

        public IResult Update(SoruKategori soruKategori)
        {
            IResult result = BusinessRules.Run(CheckLenght(soruKategori.SoruKategoriAdi));
            if (result != null)
            {
                return result;
            }
            _soruKategoriDal.Update(soruKategori);
            return new SuccessResult("Soru Kategorisi Güncellendi");
        }

        private IResult CheckLenght(string soruKategoriAdi)
        {

            var result = soruKategoriAdi.Length;

            if (result <= 1)
            {
                return new ErrorResult("Kategori adı bir harften fazla olmalıdır.");
            }
            return new SuccessResult();
        }
    }
}
