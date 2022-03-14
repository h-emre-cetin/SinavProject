using Business.Abstract;
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
            throw new NotImplementedException();
        }

        public IResult Delete(Sinav sinav)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Sinav>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Sinav sinav)
        {
            throw new NotImplementedException();
        }
    }
}
