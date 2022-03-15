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
    public  class SinavManager : ISinavService
    {

        private ISinavDal _sinavDal;

        public SinavManager(ISinavDal sinavDal)
        {
            _sinavDal = sinavDal;
        }

        public IResult Add(Sinav sinav)
        {
            IResult result = BusinessRules.Run(CheckTheLimit(sinav.SinavSüresi), CheckIfNameNull(sinav.SinavAdı), CheckNull(sinav.BasariPuani));
            if(result!= null)
            {
                return result;
            }
            _sinavDal.Add(sinav);
            return new SuccessResult();
        }

        public IResult Delete(int id)
        {
            _sinavDal.Delete(id);
            return new SuccessResult("Sınav Silindi");
        }

        public IDataResult<List<Sinav>> GetAll()
        {
            return new SuccessDataResult<List<Sinav>>(_sinavDal.GetList());
        }

        public IResult Update(Sinav sinav)
        {
            IResult result = BusinessRules.Run(CheckTheLimit(sinav.SinavSüresi), CheckIfNameNull(sinav.SinavAdı), CheckNull(sinav.BasariPuani));
            if (result != null)
            {
                return result;
            }
            _sinavDal.Update(sinav);
            return new SuccessResult("Sinav Güncellendi");
        }

        private IResult CheckTheLimit(int sinavSuresi)
        {
            if (sinavSuresi <3)
            {
                return new ErrorResult("Sınav Süresi 3 dakikadan az olamaz");
            }

            return new SuccessResult();
        }

        private IResult CheckIfNameNull(string sinavAdı)
        {
            if (string.IsNullOrEmpty(sinavAdı))
            {
                return new ErrorResult("Sınav adı boş kalamaz.");
            }

            return new SuccessResult();
        }

        private IResult CheckNull(int basariPuani)
        {
            if (basariPuani < 10)
            {
                return new ErrorResult("Başarı Puanı 10'dan az olamaz.");
            }

            return new SuccessResult();
        }
    }
}
