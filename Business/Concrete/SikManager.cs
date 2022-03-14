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
    public class SikManager : ISikService
    {
        private ISikDal _sikDal;

        public SikManager(ISikDal sikDal)
        {
            _sikDal = sikDal;
        }


        public IResult Add(Sik sik)
        {
            IResult result = BusinessRules.Run(CheckIfNull(sik.SikText));

            if (result != null)
            {
                return result;
            }

            _sikDal.Add(sik);
            return new SuccessResult("Şık eklendi.");

        }

        public IResult Delete(int id)
        {
            _sikDal.Delete(id);
            return new SuccessResult("Şık silindi.");
        }

        public IDataResult<List<Sik>> GetAll()
        {
            return new SuccessDataResult<List<Sik>>(_sikDal.GetList());
        }

        public IResult Update(Sik sik)
        {
            IResult result = BusinessRules.Run(CheckIfNull(sik.SikText));

            if (result != null)
            {
                return result;
            }

            _sikDal.Update(sik);
            return new SuccessResult("Şık güncellendi.");
        }

        private IResult CheckIfNull(string soruText)
        {

            if (string.IsNullOrEmpty(soruText))
            {
                return new ErrorResult("Şık boş olamaz. ");
            }


            return new SuccessResult();
        }
    }
}
