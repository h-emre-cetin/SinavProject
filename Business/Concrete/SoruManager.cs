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
    public class SoruManager : ISoruService
    {

        private ISoruDal _soruDal;

        public SoruManager(ISoruDal soruDal)
        {
            _soruDal = soruDal;
        }

        public IResult Add(Soru soru)
        {
            IResult result = BusinessRules.Run(CheckIfNameNull(soru.Sorular));
            if (result!= null)
            {
                return result;
            }
            _soruDal.Add(soru);

            return new SuccessResult();
        }

        public IResult Delete(int id)
        {
            _soruDal.Delete(id);
            return new SuccessResult();
        }

        public IDataResult<List<Soru>> GetAll()
        {
            return new SuccessDataResult<List<Soru>>(_soruDal.GetList());
        }

        public IResult Update(Soru soru)
        {
            IResult result = BusinessRules.Run(CheckIfNameNull(soru.Sorular));
            if (result != null)
            {
                return result;
            }
            _soruDal.Update(soru);

            return new SuccessResult();
        }

        private IResult CheckIfNameNull(string sorular)
        {
            if (string.IsNullOrEmpty(sorular))
            {
                return new ErrorResult("Soru boş kalamaz.");
            }

            return new SuccessResult();
        }
    }
}
