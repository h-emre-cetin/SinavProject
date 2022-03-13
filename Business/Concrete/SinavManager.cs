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
    public  class SinavManager : ISinavService
    {

        private ISinavDal _sinavDal;

        public SinavManager(ISinavDal sinavDal)
        {
            _sinavDal = sinavDal;
        }

        public void Add(Sinav sinav)
        {
            _sinavDal.Add(sinav);
        }

        public void Delete(Sinav sinav)
        {
            _sinavDal.Delete(sinav);
        }

        public List<Sinav> GetAll()
        {
            return _sinavDal.GetList();
        }

        public void Update(Sinav sinav)
        {
            _sinavDal.Update(sinav);

        }
    }
}
